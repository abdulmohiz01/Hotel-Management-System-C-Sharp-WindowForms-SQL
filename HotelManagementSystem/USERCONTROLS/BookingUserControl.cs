using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.USERCONTROLS
{
    public partial class BookingUserControl : UserControl
    {
        private BookingDataContext books;
        private RoomsDataContext roms;
        private GuestRegisterDataContext gr;
        private PaymentsDataContext payments;
        
        public PaymentsDataContext PaymentsDataContext
        {
            get { return payments; }
            set
            { 
                payments = value; 
            } 
        }
        public GuestRegisterDataContext GuestRegisterData
        {
            get { return gr; }
            set
            {
                gr = value;
                LoadGuestsData();
            }
        }
        public RoomsDataContext RoomsDataContext
        {
            get { return roms; }
            set 
            { 
                roms = value;
                LoadRoomsData();
            }
        }

        public BookingDataContext BookingDataContext {
            get { return books; }
            set
            {
                books = value;
                LoadBookingData();
            }
        }
        public BookingUserControl()
        {
            InitializeComponent();
        }

        public  void LoadGuestsData()
        {
            if (gr != null)
            {
                guestlist.DataSource = gr.Guests.ToList();
            }

        }
        public void LoadRoomsData()
        {
            if (roms != null)
            {
                roomlist.DataSource = roms.Rooms.Where(r => r.Status == "Available").ToList();
            }
        }
        public void LoadBookingData()
        {
            if (books != null)
            {
                bookinglist.DataSource = books.Bookings.ToList();
                
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadBookingData();
                LoadRoomsData();
                LoadGuestsData();
            }
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            LoadBookingData();
            LoadRoomsData();
            LoadGuestsData(); 
        }

        private void book_Click(object sender, EventArgs e)
        {
            int price = int.Parse(daystext.Text) * 9000;
            pricetext.Text = price.ToString();

            if (string.IsNullOrWhiteSpace(guestidtext.Text))
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            int roomId;
            if (!int.TryParse(roomnumbertext.Text, out roomId))
            {
                MessageBox.Show("Please enter a valid room number.");
                return;
            }

            var room = roms.Rooms.SingleOrDefault(r => r.RoomNumber == roomId);
            if (room == null || room.Status == "Booked")
            {
                MessageBox.Show("The selected room is not available. Please choose another room.");
                return;
            }

            int maxBookingId = books.Bookings.Any() ? books.Bookings.Max(b => b.BookingId) : 0;
           // MessageBox.Show(maxBookingId.ToString()); //output is 1000

            if (BookingDataContext != null)
            {
                var newBooking = new Booking
                {
                    BookingId = maxBookingId + 1,
                    GuestId = int.Parse(guestidtext.Text),
                    RoomNumber = int.Parse(roomnumbertext.Text),
                    CheckinDate = DateTime.Parse(checkintext.Text),
                    CheckoutDate = DateTime.Parse(checkouttext.Text),
                    TotalPrice = decimal.Parse(pricetext.Text)
                };
                books.Bookings.InsertOnSubmit(newBooking);
            }

            books.SubmitChanges();

            room.Status = "Booked";
            roms.SubmitChanges();
            int maxPaymentId = payments.Payments.Any() ? payments.Payments.Max(b => b.PaymentId) : 0;
            var newPayment = new Payment
            {
                PaymentId = maxPaymentId +1,
                BookingId = int.Parse(bookingidtext.Text),
                Amount = decimal.Parse(pricetext.Text),
                PaymentDate = DateTime.MinValue,
                PaymentMethod = "None"
            };

            payments.Payments.InsertOnSubmit(newPayment);
            payments.SubmitChanges();

            LoadBookingData();
            LoadRoomsData();
            MessageBox.Show("Booking completed successfully!");

        }

        private void guestlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guestlist.Rows[e.RowIndex].Cells["GuestId"].Value != null)
            {
                guestidtext.Text = guestlist.Rows[e.RowIndex].Cells["GuestId"].Value.ToString();
            }
        }
    }
}
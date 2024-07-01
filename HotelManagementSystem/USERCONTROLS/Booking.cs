using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.USERCONTROLS
{
    public partial class Booking : UserControl
    {
        private BookingClassDataContext bk;
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

        public BookingClassDataContext BookingClassDataContext {
            get { return bk; }
            set
            {
                bk = value;
                LoadBookingData();
            }
        }
        public Booking()
        {
            InitializeComponent();
        }

        private void LoadGuestsData()
        {
            if (gr != null)
            {
                guestlist.DataSource = gr.Guests.ToList();
            }

        }
        private void LoadRoomsData()
        {
            if (roms != null)
            {
                roomlist.DataSource = roms.Rooms.Where(r => r.Status == "Available").ToList();
            }
        }
        private void LoadBookingData()
        {
            if (payments != null)
            {
                bookinglist.DataSource = bk.Bookings.ToList();
                
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
            if (string.IsNullOrWhiteSpace(guestid.Text))
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            int roomId;
            if (!int.TryParse(roomnumber.Text, out roomId))
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

            int maxBookingId = bk.Bookings.Any() ? bk.Bookings.Max(b => b.BookingId) : 0;
            MessageBox.Show(maxBookingId.ToString()); //output is 1000

          /*  var nBooking = new Booking
            {
                BookingId = maxBookingId + 1,
                GuestId = int.Parse(guestid.Text),
                RoomNumber = roomId,
                CheckInDate = DateTime.Parse(checkin.Text),
                CheckOutDate = DateTime.Parse(checkout.Text),
                Price = decimal.Parse(price.Text)

            };*/
            /*var newBooking = new Booking
            {
                BookingIds = maxBookingId + 1,
                GuestIds = int.Parse(guestid.Text),
                RoomNumbers = roomId,
                CheckInDates = DateTime.Parse(checkin.Text),   // Ensure to parse correctly
                CheckOutDate = DateTime.Parse(checkout.Text), // Ensure to parse correctly
                Price = decimal.Parse(price.Text)             // Ensure to parse correctly
            };


            bl.Bookings.InsertOnSubmit(newBooking);
            bl.SubmitChanges();

            room.Status = "Booked";
            roms.SubmitChanges();

            var newPayment = new Payment
            {
                BookingId = newBooking.BookingId,
                PaymentDate = DateTime.MinValue,
                PaymentMethod = "None"
            };

            payments.Payments.InsertOnSubmit(newPayment);
            payments.SubmitChanges();

            LoadBookingData();
            LoadRoomsData();
            MessageBox.Show("Booking completed successfully!");
            */
        }


        private void deletebooking_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void guestlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guestlist.Rows[e.RowIndex].Cells["GuestId"].Value != null)
            {
                guestid.Text = guestlist.Rows[e.RowIndex].Cells["GuestId"].Value.ToString();
            }
        }
    }
}
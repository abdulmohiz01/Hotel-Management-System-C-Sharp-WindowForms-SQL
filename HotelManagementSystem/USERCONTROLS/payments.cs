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
    public partial class payments : UserControl
    {
        PaymentsDataContext payment;
        BookingDataContext booking;
        RoomsDataContext rooms;
        public RoomsDataContext room
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
                loadPaymentData();
            }
        }
        public BookingDataContext Booking
        {
            get
            {
                return booking;
            }
            set
            {
                this.booking = value;
                
            }
        }

        public PaymentsDataContext Payment
        {
            get { return payment; }
            set
            {
                payment = value;
                loadPaymentData();
            }
        }
        public payments()
        {
            InitializeComponent();
        }

        private void payments_Load(object sender, EventArgs e)
        {

        }


        private void dropdown(object sender, EventArgs e)
        {
            paymentmethods.Items.Clear();
            paymentmethods.Items.Add("CASH");
            paymentmethods.Items.Add("CARD");
            paymentmethods.Items.Add("ONLINE");
        }

        public void loadPaymentData()
        {
            if (payment != null)
            {
                paymentlist.DataSource = payment.Payments.ToList();
            }
            /*
            if(rooms !=null) {
                paymentlist.DataSource = rooms.Rooms.ToList();
            }
            if (booking != null)
               {
                   paymentlist.DataSource = booking.Bookings.ToList();

               }*/
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (payment != null && paymentlist.SelectedRows.Count > 0)
            {
                // Get the selected row's PaymentId
                int paymentId = (int)paymentlist.SelectedRows[0].Cells["PaymentId"].Value;

                // Find the payment record in the database
                var paymentRecord = payment.Payments.SingleOrDefault(p => p.PaymentId == paymentId);

                if (paymentRecord != null)
                {
                    // Update the payment method
                    paymentRecord.PaymentDate = DateTime.Now.Date;
                    paymentRecord.PaymentMethod = paymentmethods.SelectedItem.ToString(); 
                    // Save changes to the database
                    payment.SubmitChanges(); 
                    // Reload the payment data to reflect changes
                    loadPaymentData(); 
                   //  MessageBox.Show("Payment method updated successfully!");
                    var bookingRecord = booking.Bookings.FirstOrDefault(b =>  b.TotalPrice == paymentRecord.Amount); //b.BookingId == paymentRecord.BookingId &&
                   // MessageBox.Show(bookingRecord.BookingId.ToString() + bookingRecord.TotalPrice.ToString());
                    if (bookingRecord != null)
                    {
                        //Fetching Room Record
                        var roomRecord = rooms.Rooms.FirstOrDefault(b => b.RoomNumber == bookingRecord.RoomNumber);
                        if (roomRecord != null)
                        {
                            roomRecord.Status = "Available";
                            rooms.SubmitChanges();
                        }
                        //MessageBox.Show("Room updated");
                        booking.Bookings.DeleteOnSubmit(bookingRecord);
                        booking.SubmitChanges();
                        //MessageBox.Show("Booking Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No Booking Found");
                    }
                }
                else
                {
                    MessageBox.Show("Payment record not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a payment record to update.");
            }
        }
    }
}



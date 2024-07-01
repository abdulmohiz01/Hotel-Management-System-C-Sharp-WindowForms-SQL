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

        private void loadPaymentData()
        {
            if (payment != null)
            {
                paymentlist.DataSource = payment.Payments.ToList();
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (payment != null && paymentlist.SelectedRows.Count > 0)
            {
                // Get the selected row's PaymentId
                int paymentId = (int)paymentlist.SelectedRows[0].Cells["PaymentId"].Value;
                /*string da= paymentlist.SelectedRows[0].Cells["PaymentDate"].Value.ToString();*/

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

                    MessageBox.Show("Payment method updated successfully!");
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



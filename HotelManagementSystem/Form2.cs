﻿using HotelManagementSystem.USERCONTROLS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class dashboard : Form
    {
        private int staffId;
        private RoomsDataContext roomsDataContext;
       
        private GuestRegisterDataContext gr;
       
        private PaymentsDataContext payments;

        public dashboard(int sId)
        {
            InitializeComponent();
            this.staffId = sId;

            // Initialize the AllDataContext here
            roomsDataContext = new RoomsDataContext();
            gr = new GuestRegisterDataContext();
          /*  bkk = new BookingClassDataContext();*/
            payments = new PaymentsDataContext();
            // Passing RoomsDataContext to the AddRoom user control
            //For Add Room User Control
            addRoom2.RoomsDataContext = roomsDataContext;
            //For Add Guest User Control
            guests1.GuestRegisterDataContext = gr;
            //For Booking User Control
          /*  booking1.BookingClassDataContext = bkk;*/
            booking1.RoomsDataContext = roomsDataContext;
            booking1.GuestRegisterData = gr;
            booking1.PaymentsDataContext = payments;

            // For Payment User Control
            payments1.Payment = payments;


        }

        private void dashboard_Load(object sender, System.EventArgs e)
        {
            managestaff.Visible = true;

            using (StaffDashboardDataContext data = new StaffDashboardDataContext())
            {
                try
                {
                    var staff = data.StaffCs.SingleOrDefault(s => s.StaffId == staffId);

                    if (staff != null)
                    {
                        staffidlabel.Text = $"ID: {staff.StaffId}";
                        namelabel.Text = $"Name: {staff.FirstName} {staff.LastName}";
                        staffpositionlabel.Text = $"Position: {staff.Position}";
                        staffsalarylabel.Text = $"Salary: {staff.Salary}"; 
                        staffphonelabel.Text = $"Phone: {staff.Phone}";
                        staffemaillabel.Text = $"Email: {staff.Email}";
                    }
                    else
                    {
                        MessageBox.Show("Staff not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    if (data.Connection.State != System.Data.ConnectionState.Closed)
                    {
                        data.Connection.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            addRoom2.Visible = true;
            addRoom2.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            booking1.Visible = true;
            booking1.BringToFront();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            guests1.Visible = true;
            guests1.BringToFront();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            payments1.Visible = true;
            payments1.BringToFront();
        }
    }
}

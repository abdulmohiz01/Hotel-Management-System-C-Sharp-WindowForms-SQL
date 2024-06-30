using HotelManagementSystem.USERCONTROLS;
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

        public dashboard(int sId)
        {
            InitializeComponent();
            this.staffId = sId;

            // Initialize the RoomsDataContext here
            roomsDataContext = new RoomsDataContext();
            gr = new GuestRegisterDataContext();


            // Pass the RoomsDataContext to the AddRoom user control
            addRoom2.RoomsDataContext = roomsDataContext;
            guests1.GuestRegisterDataContext = gr;
            
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

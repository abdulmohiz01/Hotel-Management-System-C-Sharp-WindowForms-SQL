using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem.USERCONTROLS
{
    public partial class guests : UserControl
    {
        private GuestRegisterDataContext gr;
        public GuestRegisterDataContext GuestRegisterDataContext
        {
            get { return gr; }
            set
            {
                gr = value;
                LoadGuestsData();
            }
        }

        public guests()
        {
            InitializeComponent();
        }

        public void LoadGuestsData()
        {
            if (gr != null)
            {
                guestlist.DataSource = gr.Guests.ToList();
         
            }
        }

        private void guests_Load(object sender, EventArgs e)
        {
            // Load data if not already loaded
            LoadGuestsData();
        }

        private void addguest_Click(object sender, EventArgs e)
        {
            if (gr != null)
            {
                // Find the maximum GuestId in the current guests
                int maxGuestId = gr.Guests.Any() ? gr.Guests.Max(g => g.GuestId) : 0;

                // Create a new guest with incremented GuestId
                var newGuest = new Guest
                {
                    GuestId = maxGuestId + 1,
                    FirstName = guestfirstname.Text,
                    LastName = guestlastname.Text,
                    Address = guestaddress.Text,
                    Phone = guestphone.Text,
                    Email = guestemail.Text
                };

                // Add the new guest to DataContext
                gr.Guests.InsertOnSubmit(newGuest);
                gr.SubmitChanges();
                LoadGuestsData();
                MessageBox.Show($"Guest with ID {newGuest.GuestId} added successfully!");
            }
            clearInputs();
        }
        


        private void updateguest_Click(object sender, EventArgs e)
        {
            if (gr != null && guestlist.SelectedRows.Count > 0)
            {
                int guestId = (int)guestlist.SelectedRows[0].Cells["GuestId"].Value;
                var guest = gr.Guests.SingleOrDefault(g => g.GuestId == guestId);

                if (guest != null)
                {
                    guest.FirstName = guestfirstname.Text;
                    guest.LastName = guestlastname.Text;
                    guest.Address = guestaddress.Text;
                    guest.Phone = guestphone.Text;
                    guest.Email = guestemail.Text;
                   
                    gr.SubmitChanges();
                    LoadGuestsData();
                    MessageBox.Show("Guest updated successfully!");
                }
                else
                {
                    MessageBox.Show("Guest not found.");
                }
            }
        }

        private void removeguest_Click(object sender, EventArgs e)
        {
            if (gr != null && guestlist.SelectedRows.Count > 0)
            {
                int guestId = (int)guestlist.SelectedRows[0].Cells["GuestId"].Value;
                var guest = gr.Guests.SingleOrDefault(g => g.GuestId == guestId);

                if (guest != null)
                {
                    gr.Guests.DeleteOnSubmit(guest);
                    gr.SubmitChanges();
                    LoadGuestsData();
                    MessageBox.Show("Guest removed successfully!");
                }
                else
                {
                    MessageBox.Show("Guest not found.");
                }
            }
        }

        private void clearInputs()
        {
            guestid.Text= string.Empty;
            guestfirstname.Text= string.Empty;
            guestlastname.Text= string.Empty;
            guestaddress.Text= string.Empty;
            guestphone.Text= string.Empty;
            guestemail.Text= string.Empty;

        }

        

        private void guestlist_SelectionChanged(object sender, EventArgs e)
        {
            if (guestlist.SelectedRows.Count > 0)
            {
                var selectedRow = guestlist.SelectedRows[0];
                guestid.Text = selectedRow.Cells["GuestId"].Value.ToString();
                guestfirstname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                guestlastname.Text = selectedRow.Cells["LastName"].Value.ToString();
                guestaddress.Text = selectedRow.Cells["Address"].Value.ToString();
                guestphone.Text = selectedRow.Cells["Phone"].Value.ToString();
                guestemail.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }
    }
}

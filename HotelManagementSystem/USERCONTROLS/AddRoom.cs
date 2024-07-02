using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem.USERCONTROLS
{
    public partial class AddRoom : UserControl
    {
        private RoomsDataContext roomsDataContext;

        public RoomsDataContext RoomsDataContext
        {
            get { return roomsDataContext; }
            set
            {
                roomsDataContext = value;
                LoadRoomsData();
            }
        }

        public AddRoom()
        {
            InitializeComponent();
        }

        public void LoadRoomsData()
        {
            if (roomsDataContext != null)
            {
                roomslistview.DataSource = roomsDataContext.Rooms.ToList();
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // Load data if not already loaded
            LoadRoomsData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (roomsDataContext != null)
            {
                // Find the maximum RoomId in the current rooms
                int maxRoomId = roomsDataContext.Rooms.Max(r => r.RoomNumber);

                // Create a new room with incremented RoomId
                var newRoom = new Room
                {
                    RoomNumber = maxRoomId + 1,
                    HotelId = 1,
                    Status = "Available"
                };

                // Add the new room to DataContext
                roomsDataContext.Rooms.InsertOnSubmit(newRoom);
                roomsDataContext.SubmitChanges();
                LoadRoomsData();
                MessageBox.Show($"Room with ID {newRoom.RoomNumber} added successfully!");
            }
        }


        private void status_Click(object sender, EventArgs e)
        {
            if (roomsDataContext != null && roomslistview.SelectedRows.Count > 0)
            {
                int roomId = (int)roomslistview.SelectedRows[0].Cells["RoomNumber"].Value;
                var room = roomsDataContext.Rooms.SingleOrDefault(r => r.RoomNumber == roomId);

                if (room != null)
                {
                    room.Status = room.Status == "Available" ? "Booked" : "Available";
                    roomsDataContext.SubmitChanges();
                    LoadRoomsData();
                    MessageBox.Show($"Room status updated to {room.Status}!");
                }
                else
                {
                    MessageBox.Show("Room not found.");
                }
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadRoomsData();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (roomsDataContext != null && roomslistview.SelectedRows.Count > 0)
            {
                int roomId = (int)roomslistview.SelectedRows[0].Cells["RoomNumber"].Value;
                var room = roomsDataContext.Rooms.SingleOrDefault(r => r.RoomNumber == roomId);

                if (room != null)
                {
                    roomsDataContext.Rooms.DeleteOnSubmit(room);
                    roomsDataContext.SubmitChanges();
                    LoadRoomsData();
                    MessageBox.Show("Room removed successfully!");
                }
                else
                {
                    MessageBox.Show("Room not found.");
                }
            }
        }
    }
}

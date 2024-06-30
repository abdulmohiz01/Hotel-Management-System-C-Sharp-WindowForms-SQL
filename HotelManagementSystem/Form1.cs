using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{

    public partial class loginpage : Form
    {
        string strCon;
        SqlConnection conn;
        int index = 0;

        public loginpage()
        {
            InitializeComponent();
            strCon = Properties.Settings.Default.HotelDatabase;
            conn = new SqlConnection(strCon);

        }

        private void loginpage_Load(object sender, EventArgs e)
        {
     

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Staff";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                bool check = false;
                
                for (int i = 0; i < 10; i++)
                {
                    DataRow row = table.Rows[i];
                    if (idinput.Text == row["StaffId"].ToString() && passwordinput.Text == row["Password"].ToString())
                    { 
                        // Move to the next page
                        this.Hide();
                        check = true; // Set check to true if a match is found
                        dashboard d = new dashboard(int.Parse(idinput.Text));
                        d.Show();


                        if (creds.Visible == true)
                        {
                            creds.Visible = false;

                        }
                        break; // Exit the loop once a match is found
                    }
                }

                if (!check) // If no match was found after checking all rows
                {
                   // MessageBox.Show("No such record found. Please verify your entered details.");
                    creds.Visible = true;
                    idinput.Text = "";
                    passwordinput.Text = "";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }


        }

        private void adminLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

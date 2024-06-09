using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                        MessageBox.Show("Success");
                        check = true; // Set check to true if a match is found
                        break; // Exit the loop once a match is found
                    }
                }

                if (!check) // If no match was found after checking all rows
                {
                    MessageBox.Show("No such record found. Please verify your entered details.");
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
    }
}

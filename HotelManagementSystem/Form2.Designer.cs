namespace HotelManagementSystem
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.managestaff = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.staffidlabel = new System.Windows.Forms.Label();
            this.staffpositionlabel = new System.Windows.Forms.Label();
            this.staffsalarylabel = new System.Windows.Forms.Label();
            this.staffphonelabel = new System.Windows.Forms.Label();
            this.staffemaillabel = new System.Windows.Forms.Label();
            this.payments1 = new HotelManagementSystem.USERCONTROLS.payments();
            this.guests1 = new HotelManagementSystem.USERCONTROLS.guests();
            this.booking1 = new HotelManagementSystem.USERCONTROLS.Booking();
            this.addRoom2 = new HotelManagementSystem.USERCONTROLS.AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.managestaff);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(31, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 855);
            this.panel1.TabIndex = 0;
            // 
            // managestaff
            // 
            this.managestaff.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.managestaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managestaff.Location = new System.Drawing.Point(37, 681);
            this.managestaff.Name = "managestaff";
            this.managestaff.Size = new System.Drawing.Size(156, 85);
            this.managestaff.TabIndex = 6;
            this.managestaff.Text = "Manage Staff";
            this.managestaff.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(37, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 85);
            this.button5.TabIndex = 4;
            this.button5.Text = "Manage Payment";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(37, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage Guests";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(37, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Bookings";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(37, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Rooms";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.payments1);
            this.panel2.Controls.Add(this.guests1);
            this.panel2.Controls.Add(this.booking1);
            this.panel2.Controls.Add(this.addRoom2);
            this.panel2.Location = new System.Drawing.Point(309, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1603, 855);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 43);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Logout";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(348, 12);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(64, 28);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "Name";
            // 
            // staffidlabel
            // 
            this.staffidlabel.AutoSize = true;
            this.staffidlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffidlabel.Location = new System.Drawing.Point(146, 12);
            this.staffidlabel.Name = "staffidlabel";
            this.staffidlabel.Size = new System.Drawing.Size(93, 28);
            this.staffidlabel.TabIndex = 3;
            this.staffidlabel.Text = "Staff Id";
            // 
            // staffpositionlabel
            // 
            this.staffpositionlabel.AutoSize = true;
            this.staffpositionlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpositionlabel.Location = new System.Drawing.Point(669, 12);
            this.staffpositionlabel.Name = "staffpositionlabel";
            this.staffpositionlabel.Size = new System.Drawing.Size(84, 28);
            this.staffpositionlabel.TabIndex = 4;
            this.staffpositionlabel.Text = "Position";
            // 
            // staffsalarylabel
            // 
            this.staffsalarylabel.AutoSize = true;
            this.staffsalarylabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsalarylabel.Location = new System.Drawing.Point(998, 12);
            this.staffsalarylabel.Name = "staffsalarylabel";
            this.staffsalarylabel.Size = new System.Drawing.Size(71, 28);
            this.staffsalarylabel.TabIndex = 5;
            this.staffsalarylabel.Text = "Salary";
            // 
            // staffphonelabel
            // 
            this.staffphonelabel.AutoSize = true;
            this.staffphonelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffphonelabel.Location = new System.Drawing.Point(1243, 12);
            this.staffphonelabel.Name = "staffphonelabel";
            this.staffphonelabel.Size = new System.Drawing.Size(66, 28);
            this.staffphonelabel.TabIndex = 6;
            this.staffphonelabel.Text = "Phone";
            // 
            // staffemaillabel
            // 
            this.staffemaillabel.AutoSize = true;
            this.staffemaillabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffemaillabel.Location = new System.Drawing.Point(1566, 12);
            this.staffemaillabel.Name = "staffemaillabel";
            this.staffemaillabel.Size = new System.Drawing.Size(60, 28);
            this.staffemaillabel.TabIndex = 5;
            this.staffemaillabel.Text = "Email";
            // 
            // payments1
            // 
            this.payments1.Location = new System.Drawing.Point(2, 3);
            this.payments1.Name = "payments1";
            this.payments1.Size = new System.Drawing.Size(1598, 849);
            this.payments1.TabIndex = 3;
            this.payments1.Visible = false;
            // 
            // guests1
            // 
            this.guests1.GuestRegisterDataContext = null;
            this.guests1.Location = new System.Drawing.Point(3, 0);
            this.guests1.Name = "guests1";
            this.guests1.Size = new System.Drawing.Size(1600, 855);
            this.guests1.TabIndex = 2;
            this.guests1.Visible = false;
            // 
            // booking1
            // 
            this.booking1.BookingsDataContext = null;
            this.booking1.GuestRegisterData = null;
            this.booking1.Location = new System.Drawing.Point(3, 3);
            this.booking1.Name = "booking1";
            this.booking1.PaymentsDataContext = null;
            this.booking1.RoomsDataContext = null;
            this.booking1.Size = new System.Drawing.Size(1597, 852);
            this.booking1.TabIndex = 1;
            this.booking1.Visible = false;
            // 
            // addRoom2
            // 
            this.addRoom2.Location = new System.Drawing.Point(0, 0);
            this.addRoom2.Name = "addRoom2";
            this.addRoom2.RoomsDataContext = null;
            this.addRoom2.Size = new System.Drawing.Size(1603, 855);
            this.addRoom2.TabIndex = 0;
            this.addRoom2.Visible = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 945);
            this.Controls.Add(this.staffemaillabel);
            this.Controls.Add(this.staffphonelabel);
            this.Controls.Add(this.staffsalarylabel);
            this.Controls.Add(this.staffpositionlabel);
            this.Controls.Add(this.staffidlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private USERCONTROLS.AddRoom addRoom1;
        private System.Windows.Forms.Button managestaff;
        private USERCONTROLS.AddRoom addRoom2;
        private USERCONTROLS.Booking booking1;
        private USERCONTROLS.guests guests1;
        private USERCONTROLS.payments payments1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label staffidlabel;
        private System.Windows.Forms.Label staffpositionlabel;
        private System.Windows.Forms.Label staffsalarylabel;
        private System.Windows.Forms.Label staffphonelabel;
        private System.Windows.Forms.Label staffemaillabel;
    }
}
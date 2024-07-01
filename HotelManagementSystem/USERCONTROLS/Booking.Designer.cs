namespace HotelManagementSystem.USERCONTROLS
{
    partial class Booking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guestlist = new System.Windows.Forms.DataGridView();
            this.roomlist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookinglist = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.bookingid = new System.Windows.Forms.TextBox();
            this.guestid = new System.Windows.Forms.TextBox();
            this.roomnumber = new System.Windows.Forms.TextBox();
            this.checkin = new System.Windows.Forms.TextBox();
            this.checkout = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.deletebooking = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guestlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglist)).BeginInit();
            this.SuspendLayout();
            // 
            // guestlist
            // 
            this.guestlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestlist.Location = new System.Drawing.Point(26, 446);
            this.guestlist.Name = "guestlist";
            this.guestlist.RowHeadersWidth = 51;
            this.guestlist.RowTemplate.Height = 24;
            this.guestlist.Size = new System.Drawing.Size(1078, 401);
            this.guestlist.TabIndex = 1;
            this.guestlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestlist_CellContentClick);
            // 
            // roomlist
            // 
            this.roomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomlist.Location = new System.Drawing.Point(1110, 446);
            this.roomlist.Name = "roomlist";
            this.roomlist.RowHeadersWidth = 51;
            this.roomlist.RowTemplate.Height = 24;
            this.roomlist.Size = new System.Drawing.Size(482, 401);
            this.roomlist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1103, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Rooms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guests Registered:";
            // 
            // bookinglist
            // 
            this.bookinglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookinglist.Location = new System.Drawing.Point(704, 47);
            this.bookinglist.Name = "bookinglist";
            this.bookinglist.RowHeadersWidth = 51;
            this.bookinglist.RowTemplate.Height = 24;
            this.bookinglist.Size = new System.Drawing.Size(888, 345);
            this.bookinglist.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bookings:";
            // 
            // bookingid
            // 
            this.bookingid.Location = new System.Drawing.Point(192, 75);
            this.bookingid.Name = "bookingid";
            this.bookingid.Size = new System.Drawing.Size(100, 22);
            this.bookingid.TabIndex = 7;
            // 
            // guestid
            // 
            this.guestid.Location = new System.Drawing.Point(192, 118);
            this.guestid.Name = "guestid";
            this.guestid.Size = new System.Drawing.Size(100, 22);
            this.guestid.TabIndex = 8;
            // 
            // roomnumber
            // 
            this.roomnumber.Location = new System.Drawing.Point(192, 174);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(100, 22);
            this.roomnumber.TabIndex = 9;
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(192, 228);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(100, 22);
            this.checkin.TabIndex = 10;
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(192, 280);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(100, 22);
            this.checkout.TabIndex = 11;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(192, 354);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Booking ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Guest ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Room Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Check In";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Check Out";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Price";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(428, 75);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(202, 33);
            this.book.TabIndex = 20;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // deletebooking
            // 
            this.deletebooking.Location = new System.Drawing.Point(428, 206);
            this.deletebooking.Name = "deletebooking";
            this.deletebooking.Size = new System.Drawing.Size(202, 31);
            this.deletebooking.TabIndex = 21;
            this.deletebooking.Text = "Delete Booking";
            this.deletebooking.UseVisualStyleBackColor = true;
            this.deletebooking.Click += new System.EventHandler(this.deletebooking_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(428, 137);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(202, 33);
            this.update.TabIndex = 22;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 28);
            this.label11.TabIndex = 24;
            this.label11.Text = "Days";
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(192, 317);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 22);
            this.days.TabIndex = 23;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.days);
            this.Controls.Add(this.update);
            this.Controls.Add(this.deletebooking);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.roomnumber);
            this.Controls.Add(this.guestid);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookinglist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomlist);
            this.Controls.Add(this.guestlist);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(1595, 861);
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView guestlist;
        private System.Windows.Forms.DataGridView roomlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView bookinglist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookingid;
        private System.Windows.Forms.TextBox guestid;
        private System.Windows.Forms.TextBox roomnumber;
        private System.Windows.Forms.TextBox checkin;
        private System.Windows.Forms.TextBox checkout;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button deletebooking;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox days;
    }
}

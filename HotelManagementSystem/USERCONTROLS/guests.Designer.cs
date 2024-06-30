namespace HotelManagementSystem.USERCONTROLS
{
    partial class guests
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
            this.label1 = new System.Windows.Forms.Label();
            this.guestlist = new System.Windows.Forms.DataGridView();
            this.addguest = new System.Windows.Forms.Button();
            this.updateguest = new System.Windows.Forms.Button();
            this.removeguest = new System.Windows.Forms.Button();
            this.guestid = new System.Windows.Forms.TextBox();
            this.guestfirstname = new System.Windows.Forms.TextBox();
            this.guestlastname = new System.Windows.Forms.TextBox();
            this.guestaddress = new System.Windows.Forms.TextBox();
            this.guestphone = new System.Windows.Forms.TextBox();
            this.guestemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guestlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guests";
            // 
            // guestlist
            // 
            this.guestlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestlist.Location = new System.Drawing.Point(515, 32);
            this.guestlist.Name = "guestlist";
            this.guestlist.RowHeadersWidth = 51;
            this.guestlist.RowTemplate.Height = 24;
            this.guestlist.Size = new System.Drawing.Size(874, 662);
            this.guestlist.TabIndex = 1;
            // 
            // addguest
            // 
            this.addguest.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addguest.Location = new System.Drawing.Point(59, 469);
            this.addguest.Name = "addguest";
            this.addguest.Size = new System.Drawing.Size(194, 66);
            this.addguest.TabIndex = 2;
            this.addguest.Text = "Add Guest";
            this.addguest.UseVisualStyleBackColor = true;
            this.addguest.Click += new System.EventHandler(this.addguest_Click);
            // 
            // updateguest
            // 
            this.updateguest.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateguest.Location = new System.Drawing.Point(272, 469);
            this.updateguest.Name = "updateguest";
            this.updateguest.Size = new System.Drawing.Size(194, 66);
            this.updateguest.TabIndex = 3;
            this.updateguest.Text = "Update";
            this.updateguest.UseVisualStyleBackColor = true;
            this.updateguest.Click += new System.EventHandler(this.updateguest_Click);
            // 
            // removeguest
            // 
            this.removeguest.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeguest.Location = new System.Drawing.Point(172, 560);
            this.removeguest.Name = "removeguest";
            this.removeguest.Size = new System.Drawing.Size(194, 66);
            this.removeguest.TabIndex = 4;
            this.removeguest.Text = "Remove Guest";
            this.removeguest.UseVisualStyleBackColor = true;
            this.removeguest.Click += new System.EventHandler(this.removeguest_Click);
            // 
            // guestid
            // 
            this.guestid.Location = new System.Drawing.Point(205, 95);
            this.guestid.Name = "guestid";
            this.guestid.Size = new System.Drawing.Size(81, 22);
            this.guestid.TabIndex = 6;
            // 
            // guestfirstname
            // 
            this.guestfirstname.Location = new System.Drawing.Point(205, 136);
            this.guestfirstname.Name = "guestfirstname";
            this.guestfirstname.Size = new System.Drawing.Size(183, 22);
            this.guestfirstname.TabIndex = 7;
            // 
            // guestlastname
            // 
            this.guestlastname.Location = new System.Drawing.Point(205, 182);
            this.guestlastname.Name = "guestlastname";
            this.guestlastname.Size = new System.Drawing.Size(183, 22);
            this.guestlastname.TabIndex = 8;
            // 
            // guestaddress
            // 
            this.guestaddress.Location = new System.Drawing.Point(205, 220);
            this.guestaddress.Multiline = true;
            this.guestaddress.Name = "guestaddress";
            this.guestaddress.Size = new System.Drawing.Size(183, 68);
            this.guestaddress.TabIndex = 9;
            // 
            // guestphone
            // 
            this.guestphone.Location = new System.Drawing.Point(205, 312);
            this.guestphone.Name = "guestphone";
            this.guestphone.Size = new System.Drawing.Size(183, 22);
            this.guestphone.TabIndex = 10;
            // 
            // guestemail
            // 
            this.guestemail.Location = new System.Drawing.Point(205, 371);
            this.guestemail.Name = "guestemail";
            this.guestemail.Size = new System.Drawing.Size(183, 22);
            this.guestemail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guestemail);
            this.Controls.Add(this.guestphone);
            this.Controls.Add(this.guestaddress);
            this.Controls.Add(this.guestlastname);
            this.Controls.Add(this.guestfirstname);
            this.Controls.Add(this.guestid);
            this.Controls.Add(this.removeguest);
            this.Controls.Add(this.updateguest);
            this.Controls.Add(this.addguest);
            this.Controls.Add(this.guestlist);
            this.Controls.Add(this.label1);
            this.Name = "guests";
            this.Size = new System.Drawing.Size(1405, 719);
            this.Load += new System.EventHandler(this.guests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView guestlist;
        private System.Windows.Forms.Button addguest;
        private System.Windows.Forms.Button updateguest;
        private System.Windows.Forms.Button removeguest;
        private System.Windows.Forms.TextBox guestid;
        private System.Windows.Forms.TextBox guestfirstname;
        private System.Windows.Forms.TextBox guestlastname;
        private System.Windows.Forms.TextBox guestaddress;
        private System.Windows.Forms.TextBox guestphone;
        private System.Windows.Forms.TextBox guestemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

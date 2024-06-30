namespace HotelManagementSystem
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.idinput = new System.Windows.Forms.TextBox();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.creds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idinput
            // 
            this.idinput.BackColor = System.Drawing.Color.DimGray;
            this.idinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idinput.ForeColor = System.Drawing.Color.White;
            this.idinput.Location = new System.Drawing.Point(810, 375);
            this.idinput.Multiline = true;
            this.idinput.Name = "idinput";
            this.idinput.Size = new System.Drawing.Size(307, 29);
            this.idinput.TabIndex = 0;
            this.idinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordinput
            // 
            this.passwordinput.BackColor = System.Drawing.Color.DimGray;
            this.passwordinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinput.ForeColor = System.Drawing.Color.White;
            this.passwordinput.Location = new System.Drawing.Point(810, 456);
            this.passwordinput.Multiline = true;
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.PasswordChar = '*';
            this.passwordinput.Size = new System.Drawing.Size(307, 29);
            this.passwordinput.TabIndex = 1;
            this.passwordinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton.Location = new System.Drawing.Point(874, 519);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(178, 39);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLabel.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(931, 562);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(65, 19);
            this.adminLabel.TabIndex = 3;
            this.adminLabel.Text = "Admin?";
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // creds
            // 
            this.creds.AutoSize = true;
            this.creds.BackColor = System.Drawing.Color.Transparent;
            this.creds.ForeColor = System.Drawing.Color.Red;
            this.creds.Location = new System.Drawing.Point(891, 495);
            this.creds.Name = "creds";
            this.creds.Size = new System.Drawing.Size(143, 16);
            this.creds.TabIndex = 4;
            this.creds.Text = "Invalid ID or Password.";
            this.creds.Visible = false;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 749);
            this.Controls.Add(this.creds);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.idinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "loginpage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idinput;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label creds;
    }
}


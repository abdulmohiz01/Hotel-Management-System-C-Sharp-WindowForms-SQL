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
            this.SuspendLayout();
            // 
            // idinput
            // 
            this.idinput.BackColor = System.Drawing.Color.DimGray;
            this.idinput.ForeColor = System.Drawing.Color.White;
            this.idinput.Location = new System.Drawing.Point(810, 375);
            this.idinput.Multiline = true;
            this.idinput.Name = "idinput";
            this.idinput.Size = new System.Drawing.Size(307, 29);
            this.idinput.TabIndex = 0;
            // 
            // passwordinput
            // 
            this.passwordinput.BackColor = System.Drawing.Color.DimGray;
            this.passwordinput.ForeColor = System.Drawing.Color.White;
            this.passwordinput.Location = new System.Drawing.Point(810, 456);
            this.passwordinput.Multiline = true;
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(307, 29);
            this.passwordinput.TabIndex = 1;
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
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 749);
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
    }
}


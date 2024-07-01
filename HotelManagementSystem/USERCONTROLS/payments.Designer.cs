namespace HotelManagementSystem.USERCONTROLS
{
    partial class payments
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
            this.paymentlist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentmethods = new System.Windows.Forms.ComboBox();
            this.pay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payments:";
            // 
            // paymentlist
            // 
            this.paymentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentlist.Location = new System.Drawing.Point(461, 21);
            this.paymentlist.Name = "paymentlist";
            this.paymentlist.RowHeadersWidth = 51;
            this.paymentlist.RowTemplate.Height = 24;
            this.paymentlist.Size = new System.Drawing.Size(736, 677);
            this.paymentlist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Method";
            // 
            // paymentmethods
            // 
            this.paymentmethods.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentmethods.FormattingEnabled = true;
            this.paymentmethods.Location = new System.Drawing.Point(145, 336);
            this.paymentmethods.Name = "paymentmethods";
            this.paymentmethods.Size = new System.Drawing.Size(121, 39);
            this.paymentmethods.TabIndex = 4;
            this.paymentmethods.DropDown += new System.EventHandler(this.dropdown);
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(145, 455);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(121, 53);
            this.pay.TabIndex = 5;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pay);
            this.Controls.Add(this.paymentmethods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentlist);
            this.Controls.Add(this.label1);
            this.Name = "payments";
            this.Size = new System.Drawing.Size(1220, 719);
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paymentlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paymentmethods;
        private System.Windows.Forms.Button pay;
    }
}

namespace HotelManagementSystem.USERCONTROLS
{
    partial class AddRoom
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
            this.roomslistview = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomslistview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms";
            // 
            // roomslistview
            // 
            this.roomslistview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomslistview.Location = new System.Drawing.Point(623, 20);
            this.roomslistview.Name = "roomslistview";
            this.roomslistview.RowHeadersWidth = 51;
            this.roomslistview.RowTemplate.Height = 24;
            this.roomslistview.Size = new System.Drawing.Size(472, 656);
            this.roomslistview.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(84, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(117, 35);
            this.add.TabIndex = 2;
            this.add.Text = "Add Room";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(84, 317);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(117, 51);
            this.status.TabIndex = 3;
            this.status.Text = "Book/ UnBook";
            this.status.UseVisualStyleBackColor = true;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(84, 506);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(117, 50);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.status);
            this.Controls.Add(this.add);
            this.Controls.Add(this.roomslistview);
            this.Controls.Add(this.label1);
            this.Name = "AddRoom";
            this.Size = new System.Drawing.Size(1190, 693);
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomslistview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView roomslistview;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button status;
        private System.Windows.Forms.Button remove;
    }
}

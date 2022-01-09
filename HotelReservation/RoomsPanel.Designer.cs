
namespace HotelReservation
{
    partial class RoomsPanel
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
            this.desktop = new System.Windows.Forms.Panel();
            this.myTableLayoutPanel1 = new HotelReservation.MyTableLayoutPanel();
            this.desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // desktop
            // 
            this.desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.desktop.Controls.Add(this.myTableLayoutPanel1);
            this.desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktop.Location = new System.Drawing.Point(0, 0);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(1167, 654);
            this.desktop.TabIndex = 4;
            // 
            // myTableLayoutPanel1
            // 
            this.myTableLayoutPanel1.AutoScroll = true;
            this.myTableLayoutPanel1.AutoSize = true;
            this.myTableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.myTableLayoutPanel1.ColumnCount = 4;
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.myTableLayoutPanel1.Name = "myTableLayoutPanel1";
            this.myTableLayoutPanel1.RowCount = 4;
            this.myTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.myTableLayoutPanel1.Size = new System.Drawing.Size(1167, 654);
            this.myTableLayoutPanel1.TabIndex = 1;
            // 
            // RoomsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 654);
            this.Controls.Add(this.desktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomsPanel";
            this.Text = "RoomsPanel";
            this.desktop.ResumeLayout(false);
            this.desktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel desktop;
        private MyTableLayoutPanel myTableLayoutPanel1;
    }
}
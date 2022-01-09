
namespace HotelReservation
{
    partial class PaymentPanel
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
            this.btnCancelPayment = new HotelReservation.CustomButton();
            this.btnPayment = new HotelReservation.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRoomPayment = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNamePayment = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAmountPayment = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelPayment.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnCancelPayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelPayment.BorderRadius = 38;
            this.btnCancelPayment.BorderSize = 0;
            this.btnCancelPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnCancelPayment.FlatAppearance.BorderSize = 0;
            this.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPayment.ForeColor = System.Drawing.Color.OldLace;
            this.btnCancelPayment.Location = new System.Drawing.Point(59, 423);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(209, 38);
            this.btnCancelPayment.TabIndex = 50;
            this.btnCancelPayment.TabStop = false;
            this.btnCancelPayment.Text = "İptal";
            this.btnCancelPayment.TextColor = System.Drawing.Color.OldLace;
            this.btnCancelPayment.UseVisualStyleBackColor = false;
            this.btnCancelPayment.Click += new System.EventHandler(this.btnCancelPayment_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Green;
            this.btnPayment.BackGroundColor = System.Drawing.Color.Green;
            this.btnPayment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPayment.BorderRadius = 38;
            this.btnPayment.BorderSize = 0;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.Color.OldLace;
            this.btnPayment.Location = new System.Drawing.Point(59, 379);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(209, 38);
            this.btnPayment.TabIndex = 49;
            this.btnPayment.TabStop = false;
            this.btnPayment.Text = "Onayla";
            this.btnPayment.TextColor = System.Drawing.Color.OldLace;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelReservation.Properties.Resources.cashRegister;
            this.pictureBox1.Location = new System.Drawing.Point(115, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txtRoomPayment
            // 
            this.txtRoomPayment.AlwaysActive = false;
            this.txtRoomPayment.Enabled = false;
            this.txtRoomPayment.Location = new System.Drawing.Point(14, 244);
            this.txtRoomPayment.MaxLength = 20;
            this.txtRoomPayment.Name = "txtRoomPayment";
            this.txtRoomPayment.ReadOnly = true;
            this.txtRoomPayment.Size = new System.Drawing.Size(302, 49);
            this.txtRoomPayment.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtRoomPayment.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtRoomPayment.StateActive.Border.ColorAngle = 48F;
            this.txtRoomPayment.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRoomPayment.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtRoomPayment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtRoomPayment.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtRoomPayment.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtRoomPayment.StateCommon.Border.ColorAngle = 45F;
            this.txtRoomPayment.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtRoomPayment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRoomPayment.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtRoomPayment.StateCommon.Border.Rounding = 20;
            this.txtRoomPayment.StateCommon.Border.Width = 1;
            this.txtRoomPayment.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtRoomPayment.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRoomPayment.TabIndex = 48;
            this.txtRoomPayment.TabStop = false;
            this.txtRoomPayment.Tag = "Oda No :";
            this.txtRoomPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomPayment.WordWrap = false;
            // 
            // txtNamePayment
            // 
            this.txtNamePayment.AlwaysActive = false;
            this.txtNamePayment.Enabled = false;
            this.txtNamePayment.Location = new System.Drawing.Point(14, 164);
            this.txtNamePayment.MaxLength = 20;
            this.txtNamePayment.Name = "txtNamePayment";
            this.txtNamePayment.ReadOnly = true;
            this.txtNamePayment.Size = new System.Drawing.Size(302, 49);
            this.txtNamePayment.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtNamePayment.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtNamePayment.StateActive.Border.ColorAngle = 48F;
            this.txtNamePayment.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNamePayment.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtNamePayment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNamePayment.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtNamePayment.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtNamePayment.StateCommon.Border.ColorAngle = 45F;
            this.txtNamePayment.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtNamePayment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNamePayment.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtNamePayment.StateCommon.Border.Rounding = 20;
            this.txtNamePayment.StateCommon.Border.Width = 1;
            this.txtNamePayment.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtNamePayment.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNamePayment.TabIndex = 45;
            this.txtNamePayment.TabStop = false;
            this.txtNamePayment.Tag = "Adı";
            this.txtNamePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNamePayment.WordWrap = false;
            // 
            // txtAmountPayment
            // 
            this.txtAmountPayment.AlwaysActive = false;
            this.txtAmountPayment.Enabled = false;
            this.txtAmountPayment.Location = new System.Drawing.Point(14, 324);
            this.txtAmountPayment.MaxLength = 20;
            this.txtAmountPayment.Name = "txtAmountPayment";
            this.txtAmountPayment.ReadOnly = true;
            this.txtAmountPayment.Size = new System.Drawing.Size(302, 49);
            this.txtAmountPayment.StateActive.Border.Color1 = System.Drawing.Color.RosyBrown;
            this.txtAmountPayment.StateActive.Border.Color2 = System.Drawing.Color.OldLace;
            this.txtAmountPayment.StateActive.Border.ColorAngle = 48F;
            this.txtAmountPayment.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmountPayment.StateActive.Content.Color1 = System.Drawing.Color.OldLace;
            this.txtAmountPayment.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtAmountPayment.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtAmountPayment.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtAmountPayment.StateCommon.Border.ColorAngle = 45F;
            this.txtAmountPayment.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtAmountPayment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmountPayment.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAmountPayment.StateCommon.Border.Rounding = 20;
            this.txtAmountPayment.StateCommon.Border.Width = 1;
            this.txtAmountPayment.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txtAmountPayment.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmountPayment.TabIndex = 46;
            this.txtAmountPayment.TabStop = false;
            this.txtAmountPayment.Tag = "Tutar : ";
            this.txtAmountPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountPayment.WordWrap = false;
            // 
            // PaymentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(330, 485);
            this.Controls.Add(this.btnCancelPayment);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRoomPayment);
            this.Controls.Add(this.txtNamePayment);
            this.Controls.Add(this.txtAmountPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateCommon.Border.Rounding = 40;
            this.StateCommon.Border.Width = 10;
            this.Text = "PaymentForm";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnCancelPayment;
        private CustomButton btnPayment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRoomPayment;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNamePayment;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmountPayment;
    }
}

namespace HotelReservation
{
    partial class PanelCustomCalendar
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
            this.lblHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlCalendar = new System.Windows.Forms.Panel();
            this.calendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.pnlCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(600, 31);
            this.lblHeader.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblHeader.StateCommon.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.lblHeader.StateCommon.ShortText.ColorAngle = 45F;
            this.lblHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblHeader.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Values.Text = "CHECK OUT TARİHİ";
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.Controls.Add(this.calendar);
            this.pnlCalendar.Location = new System.Drawing.Point(150, 49);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(293, 218);
            this.pnlCalendar.TabIndex = 32;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(0, -1);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.OverrideFocus.Day.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.calendar.OverrideFocus.Day.Back.Color2 = System.Drawing.Color.Cyan;
            this.calendar.OverrideFocus.Day.Back.ColorAngle = 45F;
            this.calendar.OverrideFocus.Day.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.calendar.OverrideFocus.Day.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.calendar.OverrideFocus.Day.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.calendar.OverrideFocus.Day.Content.ShortText.Color2 = System.Drawing.Color.OldLace;
            this.calendar.OverrideFocus.Day.Content.ShortText.ColorAngle = 45F;
            this.calendar.OverrideFocus.Day.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.calendar.OverrideFocus.Day.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calendar.OverrideFocus.Day.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.calendar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.calendar.Size = new System.Drawing.Size(293, 218);
            this.calendar.StateCommon.Day.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.calendar.StateCommon.Day.Back.Color2 = System.Drawing.Color.Cyan;
            this.calendar.StateCommon.Day.Back.ColorAngle = 45F;
            this.calendar.StateCommon.Day.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.calendar.StateCommon.Day.Border.Color1 = System.Drawing.Color.Blue;
            this.calendar.StateCommon.Day.Border.Color2 = System.Drawing.Color.Red;
            this.calendar.StateCommon.Day.Border.ColorAngle = 45F;
            this.calendar.StateCommon.Day.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.calendar.StateCommon.Day.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.calendar.StateCommon.Day.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.calendar.StateCommon.Day.Border.Rounding = 20;
            this.calendar.StateCommon.Day.Border.Width = 1;
            this.calendar.StateCommon.Day.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calendar.StateCommon.Header.Back.Color1 = System.Drawing.Color.Teal;
            this.calendar.StateCommon.Header.Back.Color2 = System.Drawing.Color.Teal;
            this.calendar.StateCommon.Header.Back.ColorAngle = 45F;
            this.calendar.StateCommon.Header.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.calendar.StateCommon.Header.Border.Color1 = System.Drawing.Color.Blue;
            this.calendar.StateCommon.Header.Border.Color2 = System.Drawing.Color.Gray;
            this.calendar.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.calendar.StateCommon.Header.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.calendar.StateCommon.Header.Border.Rounding = 20;
            this.calendar.StateCommon.Header.Border.Width = 1;
            this.calendar.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.OldLace;
            this.calendar.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.calendar.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.TabIndex = 30;
            this.calendar.TabStop = false;
            this.calendar.TodayDate = new System.DateTime(((long)(0)));
            this.calendar.TodayFormat = "dd/MM/yyyy HH:mm";
            this.calendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calendar_MouseClick);
            // 
            // PanelCustomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pnlCalendar);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCustomCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateCommon.Border.Rounding = 360;
            this.TopMost = true;
            this.pnlCalendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHeader;
        private System.Windows.Forms.Panel pnlCalendar;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar calendar;
    }
}
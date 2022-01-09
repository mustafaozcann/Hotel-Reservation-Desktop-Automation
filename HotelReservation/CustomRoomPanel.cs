using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class CustomRoomPanel : Panel
    {

        [Category("Mustafa")]
        public Color brushColor
        {
            get
            {
                return brsColor;
            }

            set
            {
                if (!freeOrFullRoom)
                    brsColor = Color.FromArgb(0, 23, 35);
                else
                    brsColor = Color.FromArgb(20, 34, 33);

            }
        }

        private Color brsColor;


        public bool freeOrFullRoom;
        public Color lblBackColor
        {
            get
            {

                return brushColor;
            }
        }

        

        [Category("Mustafa")]
        public Font lblFont
        {
            get
            {
                return textFont;
            }
            set
            {
                textFont = value;
                this.Invalidate();
            }
            
        }

        public Font lblInfoFont
        {
            get
            {
                return InfoFont;
            }

            set
            {
                InfoFont = value;
                this.Invalidate();
            }
        }
        public Color lblForeColor
        {
            get
            {
                if (freeOrFullRoom)
                    return Color.White;


                else
                    return Color.FromArgb(192, 197, 206);
                
                
            }

            
        }

        [Category("Mustafa")]
        public string strNameSurname
        {
            get
            {
                return lblnameSurname.Text;
            }

            set
            {
                lblnameSurname.Text = value;
                this.Invalidate();
            }

        }
        
        [Category("Mustafa")]
        public string strStayGuestCount
        {
            get
            {
                return lblStayGuestCount.Text;
            }

            set
            {
                lblStayGuestCount.Text = value.ToString();
                this.Invalidate();

            }
        }

        [Category("Mustafa")]
        public string strRoomNo
        {
            get
            {
                return lblRoomNo.Text;
            }

            set
            {
                lblRoomNo.Text = value;
                this.Invalidate();

            }
        }
        
        [Category("Mustafa")]
        public string strCheckOutDate
        {
            get
            {
                return lblCheckOutDate.Text;
            }

            set
            {
                lblCheckOutDate.Text = value;
                this.Invalidate();
            }
        }

        

        private Label[] infLabels;
        private Label[] dynamicLabels;



        private Font textFont;
        private Font InfoFont;

        public CustomRoomPanel(bool freeOrFull)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.freeOrFullRoom = freeOrFull;
            this.Size = new Size(285, 159);
            infLabels = new Label[5] { this.infHeader, this.infNameSurname, this.infStayGuestCount, this.infRoomNo, this.infCheckOutDate };
            dynamicLabels = new Label[4] { this.lblnameSurname, this.lblStayGuestCount, this.lblRoomNo, this.lblCheckOutDate };
            brushColor = Color.FromArgb(0, 23, 35);
            lblFont = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblInfoFont = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblSettings();
            lblSetColor();
            lblSetFont();
            setLocationForLabels();


        }


        private void setLocationForLabels()
        {
           
            int xCoordinate = 6;
            int yCoordinate = 24;

            foreach(Label infLabel in infLabels)
            {
                if (infLabel.Tag.ToString().Equals("inf"))
                {
                    infLabel.Location = new Point(xCoordinate, yCoordinate);
                    yCoordinate += 33;
                    infLabel.AutoSize = true;
                }
                else
                {
                    infLabel.Location = new Point(86, 3);
                    infLabel.AutoSize = true;

                }

            }
            xCoordinate = 125;
            yCoordinate = 24;


            foreach (Label dynamicLabel in dynamicLabels)
            {

                dynamicLabel.Location = new Point(xCoordinate, yCoordinate);
                yCoordinate += 33;

                dynamicLabel.AutoSize = true;
            }
                
        }

        private void lblSetColor()
        {

            

            foreach(Label lbl in this.Controls.OfType<Label>())
            {
                lbl.BackColor = lblBackColor;

                if (!lbl.Tag.ToString().Equals("Header"))
                    lbl.ForeColor = lblForeColor;
               


            }

        }

        private void lblSetFont()
        {
            foreach (Label lbl in this.Controls.OfType<Label>())
            {


                if (lbl.Tag.ToString().Equals("dynamic"))
                    lbl.Font = lblFont;
                else
                    lbl.Font = InfoFont;

            }
        }
        private void lblSettings()
        {

            foreach (Label lbl in infLabels)
            {
                this.Controls.Add(lbl);
                
                
            }



            foreach (Label lbl2 in dynamicLabels)
            {
                this.Controls.Add(lbl2);
                
            }
            

            foreach(Label lbl in infLabels)
            {

                if (!freeOrFullRoom)
                {

                    this.infHeader.Text = "Misafir Bilgileri";

                    this.infNameSurname.Text = "Adı Soyadı:";
                    this.infStayGuestCount.Text = "Konaklayan Sayısı :";
                    this.infRoomNo.Text = "Oda No :";
                    this.infCheckOutDate.Text = "Check-out Tarihi :";
                    

                }

                else
                {
                    this.infHeader.Text = "Oda Bilgileri";


                    this.infNameSurname.Text = "Oda No :.";
                    this.infStayGuestCount.Text = "Oda Tipi :";
                    this.infRoomNo.Text = "Kapasite :";
                    this.infCheckOutDate.Text = "Günlük Ücret :";
                }





            }




            if (freeOrFullRoom)
                infHeader.ForeColor = Color.FromArgb(48, 197, 255);

            else
                infHeader.ForeColor = Color.Gold;
            

            
            
            
        }

        private void CustomRoomPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                brushColor
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(brushColor, 0.00f)), this.HorizontalScroll.Value, this.VerticalScroll.Value, this.Width, this.Height, 10);
            g.FillRoundedRectangle(brush, this.HorizontalScroll.Value, this.VerticalScroll.Value, this.Width, this.Height, 10);

        }
    }
}

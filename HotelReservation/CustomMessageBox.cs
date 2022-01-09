using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;



namespace HotelReservation
{
    public partial class CustomMessageBox : KryptonForm
    {
        public string message;
        public bool state;
        public bool answer { get; set; }
        
        public CustomMessageBox(string message, bool state)
        {
            InitializeComponent();
            this.TopMost = true;
            this.message = message;
            this.state = state;
            this.lblmessage.Text = message;
            
            

            if (!state)
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\Mustafa\Desktop\HRMS\HotelReservation\Properties\icons\error.png");
                
            }
            else
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\Mustafa\Desktop\HRMS\HotelReservation\Properties\icons\success.png");
                
            }

            this.Show();
            this.Invalidate();
        }

        public CustomMessageBox(string message)
        {
            InitializeComponent();

            
            this.message = message;
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\Mustafa\Desktop\HRMS\HotelReservation\Properties\icons\warning.png");
            this.lblmessage.Text = message;

            this.btnAccept.Visible = true;

            this.btnContinue.Text = "İptal";
            this.btnContinue.StateCommon.Back.Color1 = Color.FromArgb(213, 23, 0);

            this.Invalidate();
            
        }

        public CustomMessageBox(string message, bool state, int second)
        {
            InitializeComponent();

            this.TopMost = true;
            this.message = message;
            this.state = state;
            this.lblmessage.Text = message;
            timer1.Interval = second * 1000;
            timer1.Start();

            if (!state)
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\Mustafa\Desktop\HRMS\HotelReservation\Properties\icons\error.png");

            }
            else
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\Mustafa\Desktop\HRMS\HotelReservation\Properties\icons\success.png");

            }

            this.Invalidate();
            this.Show();
            
            

        }

        private void CustomMessageBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(
                Color.FromArgb(37, 50, 67)
                );
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(37, 50, 67), 0.00f)), this.HorizontalScroll.Value, this.VerticalScroll.Value, this.Width, this.Height, 10);
            g.FillRoundedRectangle(brush, this.HorizontalScroll.Value, this.VerticalScroll.Value, this.Width, this.Height, 10);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.answer = false;
            this.Hide();


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.answer = true;
            this.Hide();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Dispose();
        }
    }
}

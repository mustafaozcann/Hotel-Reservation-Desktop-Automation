using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace HotelReservation
{
    public partial class Board : KryptonForm
    {

        string adminInfo;
        Random rnd = new Random();
        public Board(string adminInfo)
        {
            InitializeComponent();
            timer1.Start();
            btnEventEnabledFalse();
            this.adminInfo = adminInfo;
            
            
        }


        private void btnEventEnabledFalse()
        {
            foreach(FontAwesome.Sharp.IconButton btn in this.menuPnl.Controls.OfType<FontAwesome.Sharp.IconButton>())
                btn.Enabled = false;
            
            

        }

        private void btnEventEnabledTrue()
        {
            foreach (FontAwesome.Sharp.IconButton btn in this.menuPnl.Controls.OfType<FontAwesome.Sharp.IconButton>())
                btn.Enabled = true;
            
            

        }



        private void btnMain_Click(object sender, EventArgs e)
        {
            //Set Title
            lblTitle.Text = btnMain.Tag.ToString();


            //Navbar Move
            navBar.Height = btnMain.Height;
            navBar.Top = btnMain.Top;
            navBar.Left = btnMain.Left;

            btnMain.BackColor = Color.FromArgb(13, 15, 107);

            buttonColorClear(btnMain);

            //create panelLoader
            this.desktopPnl.Controls.Clear();
            MainPanel mainPanel = new MainPanel(adminInfo) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mainPanel.FormBorderStyle = FormBorderStyle.None;
            this.desktopPnl.Controls.Add(mainPanel);
            mainPanel.Show();


        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //Set Title
            lblTitle.Text = btnReserve.Tag.ToString();


            //Navbar Move

            navBar.Height = btnReserve.Height;
            navBar.Top = btnReserve.Top;
            navBar.Left = btnReserve.Left;

            //Set color
            btnReserve.BackColor = Color.FromArgb(13, 15, 107);
            buttonColorClear(btnReserve);



            //create ReservePanelLoader
            this.desktopPnl.Controls.Clear();
            ReservationPanel reservePanel = new ReservationPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            reservePanel.FormBorderStyle = FormBorderStyle.None;
            this.desktopPnl.Controls.Add(reservePanel);
            reservePanel.Show();


        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            //Set Title
            lblTitle.Text = btnCheckin.Tag.ToString();



            //Navbar Move
            navBar.Height = btnCheckin.Height;
            navBar.Top = btnCheckin.Top;
            navBar.Left = btnCheckin.Left;


            btnCheckin.BackColor = Color.FromArgb(13, 15, 107);

            buttonColorClear(btnCheckin);


            //create CheckinPanelLoader
            this.desktopPnl.Controls.Clear();
            CheckInPanel checkInPanel = new CheckInPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            checkInPanel.FormBorderStyle = FormBorderStyle.None;
            this.desktopPnl.Controls.Add(checkInPanel);
            checkInPanel.Show();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            //Set Title
            lblTitle.Text = btnCheckout.Tag.ToString();




            //Navbar Move

            navBar.Height = btnCheckout.Height;
            navBar.Top = btnCheckout.Top;
            navBar.Left = btnCheckout.Left;


            btnCheckout.BackColor = Color.FromArgb(13, 15, 107);

            buttonColorClear(btnCheckout);


            //create checkOutPanelLoader
            this.desktopPnl.Controls.Clear();
            CheckOutPanel checkOutPanel = new CheckOutPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            checkOutPanel.FormBorderStyle = FormBorderStyle.None;
            this.desktopPnl.Controls.Add(checkOutPanel);
            checkOutPanel.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            //Set Title
            lblTitle.Text = btnRooms.Tag.ToString();





            //Navbar Move


            //37; 50; 67
            navBar.Height = btnRooms.Height;
            navBar.Top = btnRooms.Top;
            navBar.Left = btnRooms.Left;

            btnRooms.BackColor = Color.FromArgb(13, 15, 107);

            buttonColorClear(btnRooms);


            //create roomPanelLoader
            this.desktopPnl.Controls.Clear();
            RoomsPanel roomPanel = new RoomsPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            roomPanel.FormBorderStyle = FormBorderStyle.None;
            this.desktopPnl.Controls.Add(roomPanel);
            roomPanel.Show();

        }

        private void buttonColorClear(Button b)
        {
            foreach (Button btn in menuPnl.Controls.OfType<Button>())
            {
                if (b.Tag != btn.Tag)
                    btn.BackColor = Color.FromArgb(6, 22, 40);


            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollabseMenu();
        }

        private void CollabseMenu()
        {
            

            if (this.menuPnl.Width > 100)
            {


                

                menuPnl.Width = 100;
                pictureBox1.Visible = false;

                btnMenu.BackColor = Color.FromArgb(13, 15, 107);

                btnMenu.Dock = DockStyle.Top;
                lblHotel.Text = "";
                foreach (Button menuButton in menuPnl.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.TopCenter;
                    menuButton.Padding = new Padding(0);
                }


                seperator.Size = new Size(menuPnl.Width, 8);


            }

            else
            {



                menuPnl.Width = 150;
                pictureBox1.Visible = true;
                btnMenu.BackColor = Color.FromArgb(6, 22, 40);


                lblHotel.Text = lblHotel.Tag.ToString();
                btnMenu.Dock = DockStyle.None;
                btnMenu.Anchor = AnchorStyles.Right & AnchorStyles.Top & AnchorStyles.Left;
                foreach (Button menuButton in menuPnl.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);


                }

                seperator.Size = new Size(menuPnl.Width, 8);


            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomValue = rnd.Next(5, 20);
            if ((progressBar.Value + randomValue) <= 100)
            {
                progressBar.Value += randomValue;
                progressBar.Text = progressBar.Tag.ToString() + progressBar.Value;

            }

            else
            {

                timer1.Stop();
                btnEventEnabledTrue();
                btnMain.PerformClick();
                
            }

        }

        private void Board_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace HotelReservation
{
    public partial class UpdateCustomerPanel : KryptonForm
    {

        public string CustomerName { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Nationality { get; set; }
        public string Currency { get; set; }
        public string roomNoAndRoomType { get; set; }
        public int roomNo { get; set; }
        public DateTime checkInDate{ get; set; }
        public DateTime checkOutDate { get; set; }

        private PanelCustomCalendar pnlCustomCalendar;
        public string selectedDate { get; set; }

        public CustomMessageBox cmbox;

        Database database;

        public bool state { get; set; }
        
        public bool clickCancelButton { get; set; }




        public UpdateCustomerPanel(string Name, string Surname, string IdentityNo, string Gender,string MobileNumber, string currency,
            string Nationality, string RoomNoAndRoomType, DateTime CheckInDate, DateTime CheckOutDate)
        {
            InitializeComponent();
            database = new Database();


            

            this.CustomerName = Name;
            this.Surname = Surname;
            this.IdentityNo = IdentityNo;
            this.Gender = Gender;
            

            this.MobileNumber = MobileNumber;
            this.Nationality = Nationality;


            this.roomNoAndRoomType = RoomNoAndRoomType;

            this.Currency = currency;
            this.checkInDate = CheckInDate;
            this.checkOutDate = CheckOutDate;
            
        }
        private void updatecbRoom()
        {
            cbRoomNoUpdate.Enabled = true;

            cbRoomNoUpdate.Items.Clear();
            cbRoomNoUpdate.Tag = "Oda No";
            cbRoomNoUpdate.Text = cbRoomNoUpdate.Tag.ToString();


            database.updateRoomState(checkInDate, checkOutDate);

            List<string> emptyRoomsNo = database.getRoomsNoAndRoomtype();


            foreach (string roomTypeAndroomNo in emptyRoomsNo)
                cbRoomNoUpdate.Items.Add(roomTypeAndroomNo);


            if (emptyRoomsNo.Count == 0)
            {
                cbRoomNoUpdate.Enabled = false;
                cmbox = new CustomMessageBox("Seçilen tarih aralığında boş oda bulunamadı.", false);
            }
            
        }


        public bool validateEmptyField()
        {

            foreach (KryptonTextBox tb in this.pnlUpdateCustomer.Controls.OfType<KryptonTextBox>())
            {

                if (tb.Tag.ToString().Equals(tb.Text))
                {
                    cmbox = new CustomMessageBox(tb.Tag.ToString() + " giriniz.", false);
                    return false;
                }

            }


            foreach (KryptonComboBox cb in this.pnlUpdateCustomer.Controls.OfType<KryptonComboBox>())
            {

                if (cb.Tag.ToString().Equals(roomNoAndRoomType))
                {
                    roomNo = Convert.ToInt32(roomNoAndRoomType.Substring(0, 3));
                    return true;
                }

                if (cb.Tag.ToString().Equals(cb.Text))
                {
                    cmbox = new CustomMessageBox(cb.Tag.ToString() + " seçiniz.", false);
                    return false;
                }
            }



            int length = this.txtIdentityOrPassportUpdate.Text.Length;

            int mobileNumberLength = this.txtCustomerMobileNoUpdate.Text.Length;


            string idendityOrPassportNo = this.txtIdentityOrPassportUpdate.Text;
            int idendityLength = idendityOrPassportNo.Length;
            byte endNumber = Convert.ToByte(idendityOrPassportNo[idendityLength - 1]);


            if (idendityLength == 11 && endNumber % 2 != 0)
            {
                cmbox = new CustomMessageBox("Geçersiz TC Numarası", false);
                return false;
            }

            if (mobileNumberLength != 11)
            {
                cmbox = new CustomMessageBox("\t\tGeçerli bir " + this.txtCustomerMobileNoUpdate.Tag.ToString() + " Giriniz.\n\t\tÖrnek Format = (0545 855 4920)", false);
                return false;
            }

            if (length == 11 || length == 7)
                return true;

            else
            {
                cmbox = new CustomMessageBox("\t\tTc Kimlik No = 11 Hane\nPasaport No = 7 Hane Olmalıdır.", false);
                return false;
            }

        }

        private void UpdateCustomerPanel_Load(object sender, EventArgs e)
        {
            foreach (string room in database.getRoomsNoAndRoomtype())
                cbRoomNoUpdate.Items.Add(room);

            this.cbRoomNoUpdate.Tag = roomNoAndRoomType;
            this.cbRoomNoUpdate.SelectedItem = roomNoAndRoomType;



            this.txtCustomerNameUpdate.Text = CustomerName;
            this.txtCustomerSurnameUpdate.Text = Surname;
            this.txtCustomerMobileNoUpdate.Text = MobileNumber;
            this.txtIdentityOrPassportUpdate.Text = IdentityNo;

            this.cbGenderUpdate.SelectedItem = Gender;
            this.cbNationalityUpdate.SelectedItem = Nationality;

            this.txtCheckinUpdate.Text = checkInDate.ToString();
            this.txtCheckOutUpdate.Text = checkOutDate.ToString();

            this.cbCurrencyUpdate.SelectedItem = Currency;

            this.cbNationalityUpdate.SelectedIndexChanged += new System.EventHandler(this.cbNationalityUpdate_SelectedIndexChanged);
            this.cbRoomNoUpdate.SelectedIndexChanged += new EventHandler(this.cbRoomNo_SelectedIndexChanged);
            this.txtCheckinUpdate.TextChanged += new System.EventHandler(this.txtCheckinUpdate_TextChanged);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clickCancelButton = true;
            this.Dispose();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            this.CustomerName = this.txtCustomerNameUpdate.Text.Trim();
            this.Surname = this.txtCustomerSurnameUpdate.Text.Trim();
            this.MobileNumber = this.txtCustomerMobileNoUpdate.Text;
            this.IdentityNo = this.txtIdentityOrPassportUpdate.Text;

            this.Gender= this.cbGenderUpdate.GetItemText(cbGenderUpdate.SelectedItem);
            this.Nationality= this.cbNationalityUpdate.GetItemText(cbNationalityUpdate.SelectedItem);

            this.checkInDate = DateTime.Parse(this.txtCheckinUpdate.Text);
            this.checkOutDate = DateTime.Parse(this.txtCheckOutUpdate.Text);
            this.Currency = this.cbCurrencyUpdate.GetItemText(cbCurrencyUpdate.SelectedItem);


            if (validateEmptyField())
            {
                this.state = true;
                this.Hide();
            }

        }
        

        private void btnDateCheckIn_Click(object sender, EventArgs e)
        {
            pnlCustomCalendar = new PanelCustomCalendar
            {
                headerText = "CHECK-IN TARİHİ"

            };
            pnlCustomCalendar.checkIndDate = DateTime.MinValue;
            
            pnlCustomCalendar.ShowDialog();


            this.checkInDate = pnlCustomCalendar.selectDate;
            pnlCustomCalendar.checkIndDate = this.checkInDate;
            this.txtCheckinUpdate.Text = this.checkInDate.ToString("dd/MM/yyyy HH:mm:ss");

            this.checkOutDate = pnlCustomCalendar.selectDate;
            this.checkOutDate = this.checkOutDate.AddDays(1);

            txtCheckOutUpdate.Text = checkOutDate.ToString("dd/MM/yyyy HH:mm:ss");

            btnDateCheckOutUpdate.Visible = true;
            btnDateCheckInUpdate.Visible = false;
        }
        
            

        private void btnDateCheckOut_Click(object sender, EventArgs e)
        {
            pnlCustomCalendar.headerText = "CHECK-OUT TARİHİ";
            pnlCustomCalendar.checkOutDate = DateTime.MinValue;

            pnlCustomCalendar.ShowDialog();

            this.checkOutDate = pnlCustomCalendar.selectDate;
            txtCheckOutUpdate.Text = checkOutDate.ToString("dd/MM/yyyy HH:mm:ss");

            btnDateCheckOutUpdate.Visible = false;
            btnDateCheckInUpdate.Visible = true;
        }

      

        

        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.roomNoAndRoomType = this.cbRoomNoUpdate.GetItemText(this.cbRoomNoUpdate.SelectedItem);
            this.roomNo = Convert.ToInt32(this.roomNoAndRoomType.Substring(0, 3));

            


        }

        private void txtCheckinUpdate_TextChanged(object sender, EventArgs e)
        {
            updatecbRoom();

        }

        private void cbNationalityUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNationalityUpdate.SelectedIndex != 0)
            {
                txtIdentityOrPassportUpdate.Tag = "Pasaport No";
                txtIdentityOrPassportUpdate.Text = txtIdentityOrPassportUpdate.Tag.ToString();
                txtIdentityOrPassportUpdate.MaxLength = 7;
            }

            else
            {
                txtIdentityOrPassportUpdate.Tag = "TC Kimlik No";
                txtIdentityOrPassportUpdate.Text = txtIdentityOrPassportUpdate.Tag.ToString();
                txtIdentityOrPassportUpdate.MaxLength = 11;

            }
        }

        private void cbNationalityUpdate_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pnlUpdateCustomer_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            foreach (KryptonComboBox cb in this.pnlUpdateCustomer.Controls.OfType<KryptonComboBox>())
                cb.SelectionLength = 0;
            
            
        }

        private void nameSurnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void allTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCustomerSurnameUpdate_Leave(object sender, EventArgs e)
        {
            txtCustomerSurnameUpdate.Text = txtCustomerSurnameUpdate.Text.ToUpper();
        }

        private void txtCustomerNameUpdate_Leave(object sender, EventArgs e)
        {
            txtCustomerNameUpdate.Text = txtCustomerNameUpdate.Text.ToUpper();
        }
    }
}

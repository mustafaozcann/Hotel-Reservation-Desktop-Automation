using System;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;



namespace HotelReservation
{
    public partial class UpdateGuestPanel : KryptonForm
    {
        public string GuestName { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Nationality { get; set; }

       

        public bool state { get; set; }

        public bool clickCancelButton { get; set; }

        private CustomMessageBox cmbox;

        public UpdateGuestPanel(string Name, string Surname, string IdentityNo, string Gender, string MobileNumber, string Nationality)
        {
            InitializeComponent();


            this.GuestName = Name;
            this.Surname = Surname;
            this.IdentityNo = IdentityNo;
            this.Gender = Gender;
            this.MobileNumber = MobileNumber;
            this.Nationality = Nationality;

        }


        public bool validateEmptyField()
        {
            foreach(KryptonTextBox tb in this.pnlAddGuest.Controls.OfType<KryptonTextBox>())
            {

                if (tb.Tag.ToString().Equals(tb.Text))
                {

                    cmbox = new CustomMessageBox(tb.Tag.ToString()+" giriniz.");
                    return false;
                }

            }


            foreach(KryptonComboBox cb in this.pnlAddGuest.Controls.OfType<KryptonComboBox>())
            {

                if (cb.Tag.ToString().Equals(cb.Text))
                {
                    cmbox = new CustomMessageBox(cb.Tag.ToString()+" seçiniz.");
                    return false;
                }

            }

            int length = this.txtGuestIdentityOrPassport.Text.Length;
            byte endNumber = Convert.ToByte(this.txtGuestIdentityOrPassport.Text[length - 1]);


            int mobileNumberLength = this.txtGuestMobileNo.Text.Length;
            




            if (mobileNumberLength != 11)
            {
                cmbox = new CustomMessageBox("\t\tGeçerli bir " + this.txtGuestMobileNo.Tag.ToString() + " Giriniz.\n\t\tÖrnek Format = (0545 855 4920)", false);
                return false;
            }

            if(length == 11 && endNumber % 2 != 0)
            {
                cmbox = new CustomMessageBox("Geçersiz TC Numarası", false);
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
        private void UpdateGuestPanel_Load(object sender, EventArgs e)
        {
            this.txtGuestName.Text = GuestName;
            this.txtGuestSurname.Text = Surname;
            this.txtGuestMobileNo.Text = MobileNumber;
            this.txtGuestIdentityOrPassport.Text = IdentityNo;

            this.cbGuestGender.SelectedItem = Gender;
            this.cbGuestNationality.SelectedItem = Nationality;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clickCancelButton = true;
            this.Dispose();
        }

        private void updateGuest_Click(object sender, EventArgs e)
        {
            GuestName = txtGuestName.Text;
            Surname = txtGuestSurname.Text;
            MobileNumber = txtGuestMobileNo.Text;
            IdentityNo = txtGuestIdentityOrPassport.Text;
            Gender = cbGuestGender.GetItemText(cbGuestGender.SelectedItem);
            Nationality = cbGuestNationality.GetItemText(cbGuestNationality.SelectedItem);

            if (validateEmptyField())
            {
                this.state = true;
                this.Hide();
            }

        }

        private void pnlAddGuest_Paint(object sender, PaintEventArgs e)
        {
            foreach (KryptonComboBox cb in this.pnlAddGuest.Controls.OfType<KryptonComboBox>())
                cb.SelectionLength = 0;
        }

        private void cbGuestNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGuestSurname_Leave(object sender, EventArgs e)
        {
            txtGuestSurname.Text = txtGuestSurname.Text.ToUpper();
        }

        private void txtGuestName_Leave(object sender, EventArgs e)
        {
            txtGuestName.Text = txtGuestName.Text.ToUpper();
        }

        private void allTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void nameSurnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace HotelReservation
{
    public partial class ReservationPanel : KryptonForm
    {

        Database db;
        DataView dw;
        DataTable dt;
        CustomMessageBox cmbox;
        PanelCustomCalendar pnlCustomCalendar;
        public DateTime checkOutDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        public DateTime checkinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

        
        public TransitionPanel pnl;

        public int selectedRoomNo { get; set; }
        public string selectedRoomNoRoomType { get; set; }

        public string selectedRoomType { get; set; }


        public ReservationPanel()
        {
            db = new Database();
            InitializeComponent();

            checkOutDate = checkOutDate.AddDays(1);

            updatecbRoom();

            btnClickEventSettingFirst();
                        
            pnl = new TransitionPanel();

            //textbox default value
            txtCheckOutReserve.Tag = checkOutDate.ToString("dd/MM/yyyy HH:mm:ss");
            txtCheckinReserve.Tag = checkinDate.ToString("dd/MM/yyyy HH:mm:ss");


            setDefaultValuePnlAddCustomer();

            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoomNoRoomType = cbRoomNo.GetItemText(cbRoomNo.SelectedItem);
            selectedRoomNo = Convert.ToInt32(selectedRoomNoRoomType.Substring(0, 3));

            int index = selectedRoomNoRoomType.LastIndexOf('=');
            string price =  selectedRoomNoRoomType.Substring(index, selectedRoomNoRoomType.Length - index);

            roomPrice.Text = roomPrice.Tag.ToString()  + price;

        }

        //calendar events
        private void btnDateCheckIn_Click(object sender, EventArgs e)
        {
            pnlCustomCalendar = new PanelCustomCalendar();
            pnlCustomCalendar.checkIndDate = DateTime.MinValue;

            pnlCustomCalendar.headerText = "CHECK-IN TARİHİ";
            pnlCustomCalendar.ShowDialog();


            this.checkinDate = pnlCustomCalendar.selectDate;
            pnlCustomCalendar.checkIndDate = this.checkinDate;
            this.txtCheckinReserve.Text = checkinDate.ToString("dd/MM/yyyy HH:mm:ss");

            this.checkOutDate = pnlCustomCalendar.selectDate;
            this.checkOutDate = checkOutDate.AddDays(1);

            txtCheckOutReserve.Text = checkOutDate.ToString("dd/MM/yyyy HH:mm:ss");

            btnDateCheckOut.Visible = true;
            btnDateCheckIn.Visible = false;

        }

        private void btnDateCheckOut_Click(object sender, EventArgs e)
        {
            pnlCustomCalendar.checkOutDate = DateTime.MinValue;
            pnlCustomCalendar.headerText = "CHECK-OUT TARİHİ";

            pnlCustomCalendar.ShowDialog();


            this.checkOutDate = pnlCustomCalendar.checkOutDate;
            txtCheckOutReserve.Text = checkOutDate.ToString("dd/MM/yyyy HH:mm:ss");

            btnDateCheckOut.Visible = false;
            btnDateCheckIn.Visible = true;
        }


        private bool CustomervalidatefieldControls()
        {
            foreach (KryptonComboBox cb in this.pnlAddCustomer.Controls.OfType<KryptonComboBox>())
            {
                if (cb.SelectedIndex == -1)
                {

                    cmbox = new CustomMessageBox(cb.Tag.ToString() + " Seçiniz.", false);
                    return false;
                }
            }



            if (txtCustomerNameReserve.Text.Equals(txtCustomerNameReserve.Tag.ToString()))
            {
                cmbox = new CustomMessageBox("İsim giriniz", false);
                return false;
            }

            if (txtCustomerSurnameReserve.Text.Equals(txtCustomerSurnameReserve.Tag.ToString()))
            {
                cmbox = new CustomMessageBox("Soyisim giriniz", false);
                return false;
            }

            string idendityOrPassportNo = txtIdentityOrPassport.Text;
            int idendityLength = idendityOrPassportNo.Length;
            byte endNumber = Convert.ToByte(idendityOrPassportNo[idendityLength - 1]);


            if (idendityLength == 11 && endNumber % 2 != 0)
            {
                cmbox = new CustomMessageBox("Geçersiz TC Numarası", false);

                return false;
            }

            if (txtCustomerMobileNo.Text.Length != 11)
            {
                cmbox = new CustomMessageBox("\t\tGeçerli bir " + txtCustomerMobileNo.Tag.ToString() + " Giriniz.\n\t\tÖrnek Format = (0545 855 4920)", false);
                return false;
            }

            //database add customer
            if (txtIdentityOrPassport.Text.Length == 11 || txtIdentityOrPassport.Text.Length == 7)
            {
                string identityNo = txtIdentityOrPassport.Text;


                if (db.addCustomer(txtCustomerNameReserve.Text, txtCustomerSurnameReserve.Text, txtIdentityOrPassport.Text,
                    txtCustomerMobileNo.Text, selectedRoomNo,
                    cbNationality.GetItemText(cbNationality.SelectedItem), cbGender.GetItemText(cbGender.SelectedItem), checkinDate, checkOutDate, cbCurrency.GetItemText(cbCurrency.SelectedItem)))
                {
                    addRowDatagridView(db.getRoomCapacity(selectedRoomNo));
                    return true;
                }
                else
                {
                    cmbox = new CustomMessageBox("TC KİMLİK NO KULLANILIYOR", false);
                    return false;
                }

            }

            else
            {
                cmbox = new CustomMessageBox("\t\tTc Kimlik No = 11 Hane\nPasaport No = 7 Hane Olmalıdır.", false);
                return false;

            }

            

        }


        private bool GuestvalidatefieldControls()
        {

            foreach (KryptonComboBox cb in this.pnlAddGuest.Controls.OfType<KryptonComboBox>())
            {
                if (cb.SelectedIndex == -1)
                {

                    cmbox = new CustomMessageBox(cb.Tag.ToString() + " Seçiniz.", false);
                    return false;
                }


            }

            if (txtGuestNameReserve.Text.Equals("") || txtGuestNameReserve.Tag.ToString().Equals(txtGuestNameReserve.Text))
            {
                cmbox = new CustomMessageBox("İsim giriniz", false);
                return false;
            }

            if (txtGuestSurnameReserve.Text.Equals("") || txtGuestSurnameReserve.Tag.ToString().Equals(txtGuestSurnameReserve.Text))
            {
                cmbox = new CustomMessageBox("Soyisim giriniz", false);
                return false;

            }

            int identityLength = txtGuestIdentityOrPassport.Text.Length;
            byte identityEndNumber = Convert.ToByte(txtGuestIdentityOrPassport.Text[identityLength - 1]);

            if(identityEndNumber % 2 != 0 && identityLength == 11)
            {
                cmbox = new CustomMessageBox("Geçersiz TC Numarası", false);
                return false;
            }

            if (txtGuestMobileNumber.Text.Length != 11)
            {
                cmbox = new CustomMessageBox("\t\tGeçerli bir " + txtGuestMobileNumber.Tag.ToString() + " Giriniz.\n\t\tÖrnek Format = (0545 855 4920)", false);
                return false;
            }

            if (identityLength == 11 || identityLength == 7)
                return true;

            else
            {
                cmbox = new CustomMessageBox("\t\tTc Kimlik No = 11 Hane\nPasaport No = 7 Hane Olmalıdır.", false);
                return false;

            }




        }



        //reservation
        private void btnAddReserve_Click(object sender, EventArgs e)
        {


            if (CustomervalidatefieldControls())
            {

                cmbox = new CustomMessageBox("Rezervasyon işlemi başarılı.", true);
                
                pnlGuestInfo.Dock = DockStyle.Fill;
                btnNewReservation.Visible = true;

                kryptonDataGridView1.Rows[0].Cells[0].Value = txtCustomerNameReserve.Text; //ad
                kryptonDataGridView1.Rows[0].Cells[1].Value = txtCustomerSurnameReserve.Text; // soyad
                kryptonDataGridView1.Rows[0].Cells[2].Value = cbGender.GetItemText(cbGender.SelectedItem); //cinsiyet
                kryptonDataGridView1.Rows[0].Cells[3].Value = txtIdentityOrPassport.Text; //tc
                kryptonDataGridView1.Rows[0].Cells[4].Value = cbNationality.GetItemText(cbNationality.SelectedItem); //uyruk
                kryptonDataGridView1.Rows[0].Cells[5].Value = cbCurrency.GetItemText(cbCurrency.SelectedItem); // döviz
                kryptonDataGridView1.Rows[0].Cells[6].Value = txtCustomerMobileNo.Text; //telefon no
                kryptonDataGridView1.Rows[0].Cells[7].Value = cbRoomNo.GetItemText(cbRoomNo.SelectedItem).Substring(0, 3); //roomno

                btnClickEventSettingsFirstReservation();
            }
        }


        //get empty index in datagridview
        private int datagridviewIndexIsEmpty()
        {

            foreach (DataGridViewRow rw in this.kryptonDataGridView1.Rows)
            {

                if (rw.Cells[0].Value == null || rw.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[0].Value.ToString()))
                    return rw.Index;



            }
            return -1;
        }

        private bool datagridviewIndexIsEmpty(int rowIndex)
        {

            
            DataGridViewRow rw = kryptonDataGridView1.Rows[rowIndex];

            if (rw.Cells[0].Value == null || rw.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[0].Value.ToString()))
                return true;
            return false;

        }

        private void dataGridviewEdit(int newCapacity, int roomNo)
        {
            int rowCount = kryptonDataGridView1.Rows.Count;
            int addRowCount = newCapacity - rowCount;

            if (addRowCount < 0)
                removeRowDatagridView(-addRowCount, rowCount, roomNo);


            else if (addRowCount > 0)

                addRowDatagridView(addRowCount);

            else
                return;



        }
        //datagridview add rows for guests 
        private void addRowDatagridView(int capacity)
        {

            for (int i = 0; i < capacity; i++)
                kryptonDataGridView1.Rows.Add();

        }


        private void removeRowDatagridView(int removeRowCount, int rowCount, int roomNo)
        {


            for (int i = rowCount - 1; removeRowCount > 0; i--, removeRowCount--)
            {
                DataGridViewRow row = kryptonDataGridView1.Rows[i];
                if (!datagridviewIndexIsEmpty(i))
                {

                    string name = row.Cells["guest"].Value.ToString();
                    string identityNo = row.Cells["identityNo"].Value.ToString();
                    
                    db.removeGuest(identityNo);


                }

                kryptonDataGridView1.Rows.Remove(row);
            }
        }





        //add guests
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
           


            if (GuestvalidatefieldControls())
            {

                string identityNo = kryptonDataGridView1.Rows[0].Cells["identityNo"].Value.ToString();

                int emptyIndex = datagridviewIndexIsEmpty();
                int customerId = db.getCustomerId(identityNo);

                string guestIdentityNo = txtGuestIdentityOrPassport.Text;

                if (identityNo.Equals(guestIdentityNo) && identityNo.Length == 11)
                {

                    
                    cmbox = new CustomMessageBox("Bu TC numarasına kayıtlı farklı bir müşteri var .", false);
                    return;
                }

                else if(identityNo.Equals(guestIdentityNo) && identityNo.Length == 7)
                {
                    cmbox = new CustomMessageBox("Bu Pasaport numarasına kayıtlı farklı bir müşteri var .", false);
                    return;

                }
                    


                //Registered to guest database 
                if (db.addGuest(customerId, txtGuestNameReserve.Text,
                    txtGuestSurnameReserve.Text, guestIdentityNo, cbGuestGender.GetItemText(cbGuestGender.SelectedItem),
                    txtGuestMobileNumber.Text, cbGuestNationality.GetItemText(cbGuestNationality.SelectedItem)))
                {


                    //Registered to guest datagridview
                    kryptonDataGridView1.Rows[emptyIndex].Cells[0].Value = txtGuestNameReserve.Text; //ad
                    kryptonDataGridView1.Rows[emptyIndex].Cells[1].Value = txtGuestSurnameReserve.Text; // soyad
                    kryptonDataGridView1.Rows[emptyIndex].Cells[2].Value = cbGuestGender.GetItemText(cbGuestGender.SelectedItem); //cinsiyet
                    kryptonDataGridView1.Rows[emptyIndex].Cells[3].Value = txtGuestIdentityOrPassport.Text; //tc
                    kryptonDataGridView1.Rows[emptyIndex].Cells[4].Value = cbGuestNationality.GetItemText(cbGuestNationality.SelectedItem); //uyruk
                    kryptonDataGridView1.Rows[emptyIndex].Cells[5].Value = kryptonDataGridView1.Rows[0].Cells[5].Value; //Döviz
                    kryptonDataGridView1.Rows[emptyIndex].Cells[6].Value = txtGuestMobileNumber.Text; // telefon numarası
                    kryptonDataGridView1.Rows[emptyIndex].Cells[7].Value = kryptonDataGridView1.Rows[0].Cells["roomNo"].Value; // oda no


                    cmbox = new CustomMessageBox("Misafir başarıyla eklendi", true);

                    setDefaultValue();
                    pnlAddGuest.Visible = false;

                }


            }

        }

        //components set default value fields for pnladdGuest  
        private void setDefaultValue()
        {
            foreach (KryptonComboBox cb in pnlAddGuest.Controls.OfType<KryptonComboBox>())
                cb.Text = cb.Tag.ToString();

            foreach (KryptonTextBox tb in pnlAddGuest.Controls.OfType<KryptonTextBox>())
                tb.Text = tb.Tag.ToString();
        }

        //components set default value fields for pnladdCustomer 

        private void setDefaultValuePnlAddCustomer()
        {
            foreach (KryptonComboBox cb in pnlAddCustomer.Controls.OfType<KryptonComboBox>())
                cb.Text = cb.Tag.ToString();

            foreach (KryptonTextBox tb in pnlAddCustomer.Controls.OfType<KryptonTextBox>())
                tb.Text = tb.Tag.ToString();

        }



     
        private void btnGuestRemoveForAllReservation_Click(object sender, EventArgs e)
        {
            if (allReservationDataGridview.SelectedRows.Count == 1)
            {

                int selectedrowindex = allReservationDataGridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = allReservationDataGridview.Rows[selectedrowindex];
                string identityNo = selectedRow.Cells["IdentityNoReserve"].Value.ToString();

                string guestIdentityNo = identityNo.Equals("") ? selectedRow.Cells["passportNoReserve"].Value.ToString() : identityNo;





                int customerId = db.getCustomerId(guestIdentityNo);

                cmbox = new CustomMessageBox("\tRezervasyon İptal Edilecek\n\tİşlemi Onaylıyor musunuz ?");
                cmbox.ShowDialog();

                if (cmbox.answer)
                {
                    db.removeCustomer(customerId);
                    allReservationDataGridview.Rows.Remove(selectedRow);
                    cmbox = new CustomMessageBox("Rezervasyon iptal edildi.", true);

                }
                else
                    cmbox = new CustomMessageBox("İşlem iptal edildi.", true);

            }

        }
        //remove guest
        private void btnGuestRemove_Click(object sender, EventArgs e)
        {

            if (kryptonDataGridView1.SelectedRows.Count == 1)
            {

                int selectedrowindex = kryptonDataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = kryptonDataGridView1.Rows[selectedrowindex];

                if (!datagridviewIndexIsEmpty(selectedrowindex))
                {

                    string guestName = Convert.ToString(selectedRow.Cells["guest"].Value);
                    string guestIdentityNo = Convert.ToString(selectedRow.Cells["identityNo"].Value);
                    

                    int customerId = db.getCustomerId(kryptonDataGridView1.Rows[0].Cells["identityNo"].Value.ToString());

                    cmbox = new CustomMessageBox("İşlemi Onaylıyor musunuz ?");
                    cmbox.ShowDialog();

                    if (cmbox.answer)
                    {

                        if (selectedrowindex != 0)
                        {
                            db.removeGuest(guestIdentityNo);
                            kryptonDataGridView1.Rows.Remove(selectedRow);
                            kryptonDataGridView1.Rows.Add();
                            cmbox = new CustomMessageBox("Silme işlemi başarılı.", true);
                        }

                        else
                        {

                            db.removeCustomer(customerId);
                            kryptonDataGridView1.Rows.Clear();
                            pnlAddGuest.Visible = false;
                            setDefaultValuePnlAddCustomer();
                            cmbox = new CustomMessageBox("Rezervasyon iptal edildi.", true);

                        }

                    }
                    else
                        cmbox = new CustomMessageBox("İşlem iptal edildi.", true);



                }

                else
                    cmbox = new CustomMessageBox("Lütfen dolu satır seçiniz.", false);



            }

            else
                cmbox = new CustomMessageBox("Lütfen satır seçiniz.", false);
        }

        //fill datagridview

        private void fillDataGridView(int selectedIndex, UpdateGuestPanel guestPanel)
        {

            //Registered to guest datagridview
            kryptonDataGridView1.Rows[selectedIndex].Cells[0].Value = guestPanel.GuestName; //ad
            kryptonDataGridView1.Rows[selectedIndex].Cells[1].Value = guestPanel.Surname; // soyad
            kryptonDataGridView1.Rows[selectedIndex].Cells[2].Value = guestPanel.Gender; //cinsiyet
            kryptonDataGridView1.Rows[selectedIndex].Cells[3].Value = guestPanel.IdentityNo; //tc
            kryptonDataGridView1.Rows[selectedIndex].Cells[4].Value = guestPanel.Nationality; //uyruk
            kryptonDataGridView1.Rows[selectedIndex].Cells[6].Value = guestPanel.MobileNumber; //telefon no
            kryptonDataGridView1.Rows[selectedIndex].Cells[7].Value = selectedRoomNo;// ODA NO
            kryptonDataGridView1.Rows[selectedIndex].Cells[5].Value = kryptonDataGridView1.Rows[0].Cells[5].Value;
        }

        private void fillDataGridView(UpdateCustomerPanel customerPanel)
        {

            int rowCount = kryptonDataGridView1.Rows.Count;


            //Registered to guest datagridview
            kryptonDataGridView1.Rows[0].Cells[0].Value = customerPanel.CustomerName; //ad
            kryptonDataGridView1.Rows[0].Cells[1].Value = customerPanel.Surname; // soyad
            kryptonDataGridView1.Rows[0].Cells[2].Value = customerPanel.Gender; //cinsiyet
            kryptonDataGridView1.Rows[0].Cells[3].Value = customerPanel.IdentityNo; //tc
            kryptonDataGridView1.Rows[0].Cells[4].Value = customerPanel.Nationality; //uyruk
            kryptonDataGridView1.Rows[0].Cells[5].Value = customerPanel.Currency; //
            kryptonDataGridView1.Rows[0].Cells[6].Value = customerPanel.MobileNumber; //
            kryptonDataGridView1.Rows[0].Cells[7].Value = customerPanel.roomNo.ToString(); // ODA NO

            string currency = kryptonDataGridView1.Rows[0].Cells[5].Value.ToString();
            for (int i = 1; i < rowCount; i++)
            {
                if (!datagridviewIndexIsEmpty(i))
                {
                    kryptonDataGridView1.Rows[i].Cells["roomNo"].Value = selectedRoomNo;
                    kryptonDataGridView1.Rows[i].Cells["currency"].Value = currency;
                }
                
            }

        }

        private void fillDataGridViewGuestInfo(List<string[]> guestInfoList)
        {

            /*
             * GuestName
             * GuestSurname
             * GuestIdentity
             * GuestPassportno
             * GuestGender
             * GuestMobileNumber
             * GuestNationality
             * 
             * 
             * 
             * 
             
             */
            foreach (string[] guestInfo in guestInfoList)
            {
                int emptyIndex = datagridviewIndexIsEmpty();

                //Add guest datagridview
                kryptonDataGridView1.Rows[emptyIndex].Cells[0].Value = guestInfo[0]; //ad
                kryptonDataGridView1.Rows[emptyIndex].Cells[1].Value = guestInfo[1]; // soyad
                kryptonDataGridView1.Rows[emptyIndex].Cells[2].Value = guestInfo[4]; //cinsiyet

                if(guestInfo[2].Length == 11)
                    kryptonDataGridView1.Rows[emptyIndex].Cells[3].Value = guestInfo[2]; //tc
                else
                    kryptonDataGridView1.Rows[emptyIndex].Cells[3].Value = guestInfo[3]; //tc

                kryptonDataGridView1.Rows[emptyIndex].Cells[4].Value = guestInfo[6] ; //uyruk
                kryptonDataGridView1.Rows[emptyIndex].Cells[6].Value = guestInfo[5]; //telefon no
                kryptonDataGridView1.Rows[emptyIndex].Cells[7].Value = selectedRoomNo;// ODA NO
                kryptonDataGridView1.Rows[emptyIndex].Cells[5].Value = kryptonDataGridView1.Rows[0].Cells[5].Value;


            } 


        }

        private void btnGuestEditAllReservation_Click(object sender, EventArgs e)
        {

            if (allReservationDataGridview.SelectedRows.Count == 1)
            {
                kryptonDataGridView1.Rows.Clear();


                int selectedrowindex = allReservationDataGridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = allReservationDataGridview.Rows[selectedrowindex];

                string customerName = selectedRow.Cells["nameReserve"].Value.ToString();
                string customerSurname = selectedRow.Cells["surnameReserve"].Value.ToString();
                string identityNo = selectedRow.Cells["IdentityNoReserve"].Value.ToString();
                string passPortNo = selectedRow.Cells["passportNoReserve"].Value.ToString();
                string mobileNo = selectedRow.Cells["mobileNumberReserve"].Value.ToString();
                string gender = selectedRow.Cells["genderReserve"].Value.ToString();
                string nationality = selectedRow.Cells["nationalityReserve"].Value.ToString();
                string roomNo = selectedRow.Cells["roomNoReserve"].Value.ToString();
                string currency = selectedRow.Cells["currencyReserve"].Value.ToString();

                int customerId = 0;
                if (identityNo.Length == 11)
                    customerId = db.getCustomerId(identityNo);

                else
                    customerId = db.getCustomerId(passPortNo);

                string roomType = db.getRoomInfo(Convert.ToInt32(roomNo));
                

                

                DateTime checkinDateEdit = DateTime.Parse(selectedRow.Cells["checkinDateReserve"].Value.ToString());
                DateTime checkoutDateEdit = DateTime.Parse(selectedRow.Cells["checkoutDateReserve"].Value.ToString());

                checkinDate = checkinDateEdit;
                checkOutDate = checkoutDateEdit;

                kryptonDataGridView1.Rows.Add(db.getRoomCapacity(Convert.ToInt32(roomNo)));

                kryptonDataGridView1.Rows[0].Cells[0].Value = customerName; //ad
                kryptonDataGridView1.Rows[0].Cells[1].Value = customerSurname; // soyad
                kryptonDataGridView1.Rows[0].Cells[2].Value = gender; //cinsiyet

                if (identityNo.Length == 11)
                    kryptonDataGridView1.Rows[0].Cells[3].Value = identityNo; //tc
                else
                    kryptonDataGridView1.Rows[0].Cells[3].Value = passPortNo; //pasaport



                kryptonDataGridView1.Rows[0].Cells[4].Value = nationality; //uyruk
                kryptonDataGridView1.Rows[0].Cells[5].Value = currency; // döviz
                kryptonDataGridView1.Rows[0].Cells[6].Value = mobileNo; //telefon no
                kryptonDataGridView1.Rows[0].Cells[7].Value = roomNo; //roomno



                selectedRoomNoRoomType = roomType;
                selectedRoomNo = Convert.ToInt32(roomNo);


                allReservationDataGridview.Visible = false;
                kryptonDataGridView1.Visible = true;

                

                fillDataGridViewGuestInfo(db.getGuestInfo(customerId));

                btnClickEventSettingsFirstReservation();
                btnGuestEdit.PerformClick();

                

                
            }

        }
        private void btnGuestEdit_Click(object sender, EventArgs e)
        {

            if (kryptonDataGridView1.SelectedCells.Count > 1 && !datagridviewIndexIsEmpty(kryptonDataGridView1.SelectedCells[0].RowIndex))
            {
                int selectedrowindex = kryptonDataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = kryptonDataGridView1.Rows[selectedrowindex];

                

                if (selectedrowindex != 0)
                    openUpdateGuestPanel();
                else
                    openUpdateCustomerPanel();
            }
        }

        private void openUpdateGuestPanel()
        {
            this.Enabled = false;

            int selectedrowindex = kryptonDataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = kryptonDataGridView1.Rows[selectedrowindex];

            UpdateGuestPanel pnlUpdateGuest;

            string guestName = Convert.ToString(selectedRow.Cells["guest"].Value);
            string guestSurname = Convert.ToString(selectedRow.Cells["surname"].Value);
            string identityNo = Convert.ToString(selectedRow.Cells["identityNo"].Value);
            string gender = selectedRow.Cells["gender"].Value.ToString();
            string mobileNumber = selectedRow.Cells["mobilenumber"].Value.ToString();
            string nationality = selectedRow.Cells["nationality"].Value.ToString();

            int customerId = db.getCustomerId(identityNo);
            
            pnlUpdateGuest = new UpdateGuestPanel(guestName, guestSurname, identityNo, gender, mobileNumber, nationality);

            pnlUpdateGuest.ShowDialog();

            if (pnlUpdateGuest.state)
            {
                
                if(db.updateGuest(pnlUpdateGuest.GuestName, pnlUpdateGuest.Surname, pnlUpdateGuest.IdentityNo, pnlUpdateGuest.Gender, pnlUpdateGuest.MobileNumber, pnlUpdateGuest.Nationality, identityNo, customerId))
                {
                    fillDataGridView(selectedrowindex, pnlUpdateGuest);
                    this.Enabled = true;
                    cmbox = new CustomMessageBox("Misafir bilgileri başarıyla güncellendi.", true);
                    return;
                }
                else
                {
                    if(pnlUpdateGuest.IdentityNo.Length == 11)
                        cmbox = new CustomMessageBox("Misafirler içerisinde bu TC numarasına kayıtlı başka bir kişi var.", false);
                    else
                        cmbox = new CustomMessageBox("Misafirler içerisinde bu Pasaport numarasına kayıtlı başka bir kişi var.", false);

                    

                }
                
                    

            }

            else
            {
                cmbox = new CustomMessageBox("İşlem iptal edildi.", true);

                pnlUpdateGuest.Dispose();
                this.Enabled = true;
            }
        }
        private void openUpdateCustomerPanel()
        {
            this.Enabled = false;

            int selectedrowindex = kryptonDataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = kryptonDataGridView1.Rows[selectedrowindex];

            string guestName = Convert.ToString(selectedRow.Cells["guest"].Value);
            string guestSurname = Convert.ToString(selectedRow.Cells["surname"].Value);
            string identityNo = Convert.ToString(selectedRow.Cells["identityNo"].Value);
            string gender = selectedRow.Cells["gender"].Value.ToString();
            int customerId = db.getCustomerId(identityNo);
            
            
            string mobileNumber = selectedRow.Cells["mobilenumber"].Value.ToString();
            string nationality = selectedRow.Cells["nationality"].Value.ToString();

            string checkinDate = txtCheckinReserve.Text;
            string checkoutDate = txtCheckOutReserve.Text;
            
            string currency = selectedRow.Cells["currency"].Value.ToString();

            UpdateCustomerPanel updateCustomer;


            

            int guestCount = db.getGuestCount(customerId);
            int roomCapacity = db.getRoomCapacity(selectedRoomNo);

            updateCustomer = new UpdateCustomerPanel(guestName, guestSurname, identityNo, gender, mobileNumber, currency, nationality, selectedRoomNoRoomType, DateTime.Parse(checkinDate), DateTime.Parse(checkoutDate));
            updateCustomer.ShowDialog();

            if (updateCustomer.state)
            {
                int newRoomCapacity = roomCapacity;

                if (selectedRoomNo != updateCustomer.roomNo)
                    newRoomCapacity = db.getRoomCapacity(updateCustomer.roomNo);



                int removeGuestCount = 0;
                this.Enabled = true;


                if (newRoomCapacity != 0)
                    removeGuestCount = guestCount + 1 - newRoomCapacity;



                if (removeGuestCount > 0)
                {


                    cmbox = new CustomMessageBox("Sonradan eklenen " + removeGuestCount.ToString() + " misafir silinecek onaylıyor musunuz ?");
                    cmbox.ShowDialog();

                    if (cmbox.answer)
                    {
                        dataGridviewEdit(newRoomCapacity, selectedRoomNo);


                        if(db.updateCustomer(updateCustomer.CustomerName,
                            updateCustomer.Surname, identityNo, updateCustomer.Gender, updateCustomer.roomNo, updateCustomer.MobileNumber, updateCustomer.Nationality, updateCustomer.IdentityNo, updateCustomer.Currency, updateCustomer.checkInDate, updateCustomer.checkOutDate))
                        {
                            selectedRoomNo = updateCustomer.roomNo;
                            selectedRoomNoRoomType = updateCustomer.roomNoAndRoomType;

                            fillDataGridView(updateCustomer);
                            cmbox = new CustomMessageBox("Müşteri bilgileri başarıyla güncellendi.", true);

                            return;
                        }

                        else
                        {
                            if(updateCustomer.IdentityNo.Length == 11)
                                cmbox = new CustomMessageBox("Rezervasyonlar içerisinde bu TC numarasına kayıtlı başka bir kişi var.", false);

                            else
                                cmbox = new CustomMessageBox("Rezervasyonlar içerisinde bu Pasaport numarasına kayıtlı başka bir kişi var.", false);



                            openUpdateCustomerPanel();
                        }


                    }

                    else
                    {
                        cmbox = new CustomMessageBox("İşlem iptal edildi.", true);
                        return;

                    }



                }
                else if (removeGuestCount <= 0)
                {
                    dataGridviewEdit(newRoomCapacity, selectedRoomNo);


                    if(db.updateCustomer(updateCustomer.CustomerName,
                        updateCustomer.Surname, identityNo, updateCustomer.Gender, updateCustomer.roomNo, updateCustomer.MobileNumber, updateCustomer.Nationality, updateCustomer.IdentityNo,updateCustomer.Currency, updateCustomer.checkInDate, updateCustomer.checkOutDate))
                    {
                        selectedRoomNo = updateCustomer.roomNo;
                        selectedRoomNoRoomType = updateCustomer.roomNoAndRoomType;

                        fillDataGridView(updateCustomer);
                        cmbox = new CustomMessageBox("Müşteri bilgileri başarıyla güncellendi.", true);

                        return;
                    }
                    else
                    {
                        if(updateCustomer.IdentityNo.Length == 11)
                            cmbox = new CustomMessageBox("TC Numarası kullanılıyor", false);
                        
                        else
                            cmbox = new CustomMessageBox("Pasaport Numarası kullanılıyor.", false);


                        openUpdateCustomerPanel();
                        

                    }





                }

            }

            else
            {
                //kryptonDataGridView1.InvalidateRow(selectedrowindex);

                cmbox = new CustomMessageBox("İşlem iptal edildi", true);
                updateCustomer.Dispose();
                this.Enabled = true;
                
            }
        }

        private void txtCheckinReserve_TextChanged(object sender, EventArgs e)
        {
            updatecbRoom();

        }

        private void updatecbRoom()
        {
            cbRoomNo.Enabled = true;
            cbRoomNo.Items.Clear();
            cbRoomNo.Text = cbRoomNo.Tag.ToString();


            db.updateRoomState(checkinDate, checkOutDate);

            List<string> emptyRoomsNo = db.getRoomsNoAndRoomtype();


            foreach (string roomTypeAndroomNo in emptyRoomsNo)
                cbRoomNo.Items.Add(roomTypeAndroomNo);


            if (emptyRoomsNo.Count == 0)
            {
                cbRoomNo.Enabled = false;
                cmbox = new CustomMessageBox("Seçilen tarih aralığında boş oda bulunamadı.", false);
          
            }
            
            
            
        }


        private void btnGuestCancel_Click(object sender, EventArgs e)
        {
            pnlAddGuest.Visible = false;
            setDefaultValue();
        }

        private void addGuest_Click(object sender, EventArgs e)
        {
            int emptyIndex = datagridviewIndexIsEmpty();

            if(emptyIndex != -1)
                pnlAddGuest.Visible = true;
            
            
             

            else
                cmbox = new CustomMessageBox("Oda kapasitesi yetersiz.", false);


        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNationality.SelectedIndex != 0)
            {
                txtIdentityOrPassport.Tag = "Pasaport No";
                txtIdentityOrPassport.Text = txtIdentityOrPassport.Tag.ToString();
                txtIdentityOrPassport.MaxLength = 7;
            }

            else
            {
                txtIdentityOrPassport.Tag = "TC Kimlik No";
                txtIdentityOrPassport.Text = txtIdentityOrPassport.Tag.ToString();
                txtIdentityOrPassport.MaxLength = 11;
            }
        }

        private void cbGuestNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGuestNationality.SelectedIndex != 0)
            {
                txtGuestIdentityOrPassport.Tag = "Pasaport No";
                txtGuestIdentityOrPassport.Text = txtGuestIdentityOrPassport.Tag.ToString();
                txtGuestIdentityOrPassport.MaxLength = 7;
            }

            else
            {
                txtGuestIdentityOrPassport.Tag = "TC Kimlik No";
                txtGuestIdentityOrPassport.Text = txtGuestIdentityOrPassport.Tag.ToString();
                txtGuestIdentityOrPassport.MaxLength = 11;
            }
        }






        private void btnClickEventSettingsAllReservation()
        {
            btnClickEventSettingFirst();


            btnGuestEdit.Click += new EventHandler(btnGuestEditAllReservation_Click);
            btnGuestRemove.Click += new EventHandler(btnGuestRemoveForAllReservation_Click);

        }

        private void btnClickEventSettingsFirstReservation()
        {
            btnClickEventSettingFirst();
            addGuest.Click += new EventHandler(addGuest_Click);
            btnGuestEdit.Click += new EventHandler(btnGuestEdit_Click);
            btnGuestRemove.Click += new EventHandler(btnGuestRemove_Click);

        }
        private void btnClickEventSettingFirst()
        {
            addGuest.Click -= new EventHandler(addGuest_Click);
            btnGuestEdit.Click -= new EventHandler(btnGuestEdit_Click);
            btnGuestRemove.Click -= new EventHandler(btnGuestRemove_Click);
            btnGuestEdit.Click -= new EventHandler(btnGuestEditAllReservation_Click);
            btnGuestRemove.Click -= new EventHandler(btnGuestRemoveForAllReservation_Click);

        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {

            kryptonDataGridView1.Rows.Clear();

            btnClickEventSettingFirst();

            setDefaultValuePnlAddCustomer();
            this.pnlGuestInfo.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
           | AnchorStyles.Left)
           | AnchorStyles.Right)));
            this.pnlGuestInfo.Dock = DockStyle.None;

            allReservationDataGridview.DataSource = null;
            kryptonDataGridView1.Visible = true;
            btnNewReservation.Visible = false;
            btnShowAllReservation.Visible = true;

            pnlAddGuest.Visible = false;

            
            
            this.pnlGuestInfo.Invalidate();
            this.pnlAddGuest.Invalidate();

            this.Refresh();
            

            updatecbRoom();

        }


        private void btnShowAllReservation_Click(object sender, EventArgs e)
        {

            kryptonDataGridView1.Rows.Clear();



            btnClickEventSettingsAllReservation();
            allReservationDataGridview.DataSource = null;

            allReservationDataLoad();


            pnlAddGuest.Visible = false;

            


            btnShowAllReservation.Visible = false;
            this.pnlGuestInfo.Dock = DockStyle.Fill;
            btnNewReservation.Visible = true;
            pnlGuestInfo.Invalidate();

            

            if (!pnl.state)
                pnl.ShowDialog();
            
            
            kryptonDataGridView1.Visible = false;
            this.allReservationDataGridview.Visible = true;


            this.Refresh();


        }

        private void allReservationDataLoad()
        {
            Task.Run(() =>
            {


                this.customerTbTableAdapter.Fill(this.allReservationDataSet.CustomerTb);
                dw = new DataView(allReservationDataSet.CustomerTb);
                dw.RowFilter = "AcceptCustomer = 'False' And CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#";

                dt = dw.ToTable();

                this.allReservationDataGridview.DataSource = dt;


                allReservationDataGridview.SuspendLayout();

            });
        }

        private void ReservationPanel_Load(object sender, EventArgs e)
        {

            kryptonDataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);

            Point pt = pnlAddGuest.PointToScreen(new Point(0, 0));
            pnlAddGuest.Parent = this;
            pnlAddGuest.Location = this.PointToClient(pt);
            pnlAddGuest.BringToFront();
        }
        private void txtCustomerNameReserve_Enter(object sender, EventArgs e)
        {
            if (txtCustomerNameReserve.Text.Equals(txtCustomerNameReserve.Tag.ToString()))
                txtCustomerNameReserve.Text = "";
        }

        private void txtCustomerNameReserve_Leave(object sender, EventArgs e)
        {
            txtCustomerNameReserve.Text = txtCustomerNameReserve.Text.ToUpper();

            if (txtCustomerNameReserve.Text.Equals(""))
                txtCustomerNameReserve.Text = txtCustomerNameReserve.Tag.ToString();
        }

        private void txtCustomerSurnameReserve_Enter(object sender, EventArgs e)
        {
            if (txtCustomerSurnameReserve.Text.Equals(txtCustomerSurnameReserve.Tag.ToString()))
                txtCustomerSurnameReserve.Text = "";
        }

        private void txtCustomerSurnameReserve_Leave(object sender, EventArgs e)
        {
            txtCustomerSurnameReserve.Text = txtCustomerSurnameReserve.Text.ToUpper();

            if (txtCustomerSurnameReserve.Text.Equals(""))
                txtCustomerSurnameReserve.Text = txtCustomerSurnameReserve.Tag.ToString();
        }

        private void txtIdentityOrPassport_Enter(object sender, EventArgs e)
        {
            if (txtIdentityOrPassport.Text.Equals(txtIdentityOrPassport.Tag.ToString()))
                txtIdentityOrPassport.Text = "";
        }

        private void txtIdentityOrPassport_Leave(object sender, EventArgs e)
        {
            if (txtIdentityOrPassport.Text.Equals(""))
                txtIdentityOrPassport.Text = txtIdentityOrPassport.Tag.ToString();
        }

        private void txtCustomerMobileNo_Enter(object sender, EventArgs e)
        {
            if (txtCustomerMobileNo.Text.Equals(txtCustomerMobileNo.Tag.ToString()))
                txtCustomerMobileNo.Text = "";
        }

        private void txtCustomerMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtCustomerMobileNo.Text.Equals(""))
                txtCustomerMobileNo.Text = txtCustomerMobileNo.Tag.ToString();
        }

        private void txtGuestNameReserve_Enter(object sender, EventArgs e)
        {
            if (txtGuestNameReserve.Text.Equals(txtGuestNameReserve.Tag.ToString()))
                txtGuestNameReserve.Text = "";
        }

        private void txtGuestNameReserve_Leave(object sender, EventArgs e)
        {
            txtGuestNameReserve.Text = txtGuestNameReserve.Text.ToUpper();

            if (txtGuestNameReserve.Text.Equals(""))
                txtGuestNameReserve.Text = txtGuestNameReserve.Tag.ToString();
        }

        private void txtGuestSurnameReserve_Enter(object sender, EventArgs e)
        {
            if (txtGuestSurnameReserve.Text.Equals(txtGuestSurnameReserve.Tag.ToString()))
                txtGuestSurnameReserve.Text = "";
        }

        private void txtGuestSurnameReserve_Leave(object sender, EventArgs e)
        {
            txtGuestSurnameReserve.Text = txtGuestSurnameReserve.Text.ToUpper();

            if (txtGuestSurnameReserve.Text.Equals(""))
                txtGuestSurnameReserve.Text = txtGuestSurnameReserve.Tag.ToString();

        }

        private void txtGuestIdentityOrPassport_Enter(object sender, EventArgs e)
        {
            if (txtGuestIdentityOrPassport.Text.Equals(txtGuestIdentityOrPassport.Tag.ToString()))
                txtGuestIdentityOrPassport.Text = "";
        }

        private void txtGuestIdentityOrPassport_Leave(object sender, EventArgs e)
        {
            txtGuestIdentityOrPassport.SelectionStart = 0;

            if (txtGuestIdentityOrPassport.Text.Equals(""))
                txtGuestIdentityOrPassport.Text = txtGuestIdentityOrPassport.Tag.ToString();
        }

        private void txtGuestMobileNumber_Enter(object sender, EventArgs e)
        {
            if (txtGuestMobileNumber.Text.Equals(txtGuestMobileNumber.Tag.ToString()))
                txtGuestMobileNumber.Text = "";
        }

        private void txtGuestMobileNumber_Leave(object sender, EventArgs e)
        {
            
            if (txtGuestMobileNumber.Text.Equals(""))
                txtGuestMobileNumber.Text = txtGuestMobileNumber.Tag.ToString();
        }

        //textbox only digit input  (for identitynotextbox and mobileno textbox)
        private void allTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                   e.Handled = true;
        }

        private void nameSurnameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        
        

        private void pnlGuestInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void cbGender_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { cbGender.Select(0, 0); }));

        }

        private void cbCurrency_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { cbCurrency.Select(0, 0); }));

        }

        private void cbGuestNationality_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { cbGuestNationality.Select(0, 0); }));

        }

        private void cbGuestGender_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { cbGuestGender.Select(0, 0); }));

        }
        private void cbNationality_DropDownClosed(object sender, EventArgs ex)
        {
            this.BeginInvoke(new Action(() => { cbNationality.Select(0, 0); }));

        }

        private void cbRoomNo_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { cbRoomNo.Select(0, 0); }));
        }



        private void cbNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

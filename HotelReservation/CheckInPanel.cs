using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class CheckInPanel : Form
    {

        DataView dw;
        DataTable dt;
        CustomMessageBox cmBox;
        Database db;
        
        public CheckInPanel()
        {
            InitializeComponent();
            dw = new DataView(hotelDBDataSet.CustomerTb);
            db = new Database();
        }

        private void CheckInPanel_Load(object sender, EventArgs e)
        {
            
            this.customerTbTableAdapter.Fill(this.hotelDBDataSet.CustomerTb);

            dw.RowFilter = "CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0,0,0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckinDate <= #"
                + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'False'";

            dt = dw.ToTable();

            this.checkInDataGridView.DataSource = dt;

        }

        private void btnFindReserve_Click_1(object sender, EventArgs e)
        {

            string guestName = txtName.Text;
            string guestSurname = txtSurname.Text;



            if (!guestName.Equals(txtName.Tag.ToString()) && !guestSurname.Equals(txtSurname.Tag.ToString()))
            {

                dw.RowFilter = "CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckinDate <= #"
                    + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'False' And Name = '" + guestName + "' And Surname = '" + guestSurname + "'";
                dt = dw.ToTable();

                this.checkInDataGridView.DataSource = dt;


            }

            else if (!guestName.Equals(txtName.Tag.ToString()) && guestSurname.Equals(txtSurname.Tag.ToString()))
            {
                dw.RowFilter = "CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckinDate <= #"
                        + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'False' And Name = '" + guestName + "'";
                dt = dw.ToTable();

                this.checkInDataGridView.DataSource = dt;
            }

            else if (!guestSurname.Equals(txtSurname.Tag.ToString()) && guestName.Equals(txtName.Tag.ToString()))
            {
                dw.RowFilter = "CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckinDate <= #"
                        + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'False' And Surname = '" + guestSurname + "'";
                dt = dw.ToTable();

                this.checkInDataGridView.DataSource = dt;
            }

            else
            {
                dw.RowFilter = "CheckinDate >= #" + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).ToString("yyyy/MM/dd HH:mm:ss") + "#And CheckinDate <= #"
                + new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).ToString("yyyy/MM/dd HH:mm:ss") + "#And AcceptCustomer = 'False'";

                dt = dw.ToTable();

                this.checkInDataGridView.DataSource = dt;
            }
                



        }


        private void btnAcceptCheckin_Click_1(object sender, EventArgs e)
        {
            
            if(checkInDataGridView.SelectedRows.Count == 1)
            {

                int selectedrowindex = checkInDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = checkInDataGridView.Rows[selectedrowindex];

            
                string identityNo = Convert.ToString(selectedRow.Cells["identityNo"].Value);
                string passPortNo = Convert.ToString(selectedRow.Cells["passportNo"].Value);

                int customerId = identityNo.Length == 0 ? db.getCustomerId(passPortNo) : db.getCustomerId(identityNo);
               

                cmBox = new CustomMessageBox("Müşteri Checkin Edilecek\n\t\tOnaylıyor Musun?");
                cmBox.ShowDialog();

                if (cmBox.answer)
                {
                    db.customerCheckInAccept(customerId);
                    checkInDataGridView.Rows.Remove(selectedRow);
                    cmBox = new CustomMessageBox("Müşteri başarıyla checkin edildi.", true);


                }
                else
                    cmBox = new CustomMessageBox("İşlem İptal Edildi.", true);

            }
        }

        

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(txtName.Tag.ToString()))
                txtName.Text= "";
            

        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
                txtName.Text = txtName.Tag.ToString();
        }

        private void txtSurname_Enter(object sender, EventArgs e)
        {
            if (txtSurname.Text.Equals(txtSurname.Tag.ToString()))
                txtSurname.Text = "";

        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtSurname.Text.Equals(""))
                txtSurname.Text = txtSurname.Tag.ToString();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

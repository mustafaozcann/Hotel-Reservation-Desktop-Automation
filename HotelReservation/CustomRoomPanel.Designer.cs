
using System.Windows.Forms;

namespace HotelReservation
{
    partial class CustomRoomPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            lblnameSurname = new Label();
            lblStayGuestCount = new Label();
            lblRoomNo = new Label();
            lblCheckOutDate = new Label();

            infHeader = new Label();
            infNameSurname = new Label();
            infRoomNo = new Label();
            infStayGuestCount = new Label();
            infCheckOutDate = new Label();



            this.SuspendLayout();
            // 
            // CustomRoomPanel
            // 



            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomRoomPanel_Paint);
            this.ResumeLayout(false);
            



            this.infHeader.Tag = "Header";

            this.lblnameSurname.Tag = "dynamic";
            this.lblStayGuestCount.Tag = "dynamic";
            this.lblRoomNo.Tag = "dynamic";
            this.lblCheckOutDate.Tag = "dynamic";



            this.infNameSurname.Tag = "inf";
            this.infStayGuestCount.Tag = "inf";
            this.infRoomNo.Tag = "inf";
            this.infCheckOutDate.Tag = "inf";




        }

        #endregion
        private Label lblnameSurname;
        private Label lblStayGuestCount;
        private Label lblRoomNo;
        private Label lblCheckOutDate;

        private Label infHeader;
        private Label infNameSurname;
        private Label infRoomNo;
        private Label infStayGuestCount;
        private Label infCheckOutDate;

    }
}

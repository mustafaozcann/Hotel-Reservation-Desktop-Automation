using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class RoomsPanel : Form
    {
        Database db;
        public RoomsPanel()
        {
            InitializeComponent();
            db = new Database();


            loadStayCustomerInfoAndFreeRoomsInfo();
            //Control.CheckForIllegalCrossThreadCalls = false;

            //Thread t1 = new Thread(new ThreadStart(loadStayCustomerInfo));
            //t1.Start();
        }
      

        

        private void loadStayCustomerInfoAndFreeRoomsInfo()
        {
            List<string[]> stayCustomerInfo = db.getToStayGuests();
            List<string[]> freeRoomsInfo = db.getToFreeRoom();

            int totalStayCustomer = stayCustomerInfo.Count;
            int freeRoomCount = db.getTotalCountOfRoom() - totalStayCustomer;


            myTableLayoutPanel1.RowCount = totalStayCustomer > freeRoomCount ? totalStayCustomer / 2 + 1  : freeRoomCount / 2 + 1;

            int index = totalStayCustomer-1;
            for(int i = 0; i < myTableLayoutPanel1.ColumnCount / 2; i++)
            {
                    
                for(int j = 0; j < myTableLayoutPanel1.RowCount; j++)
                {

                    if(index >= 0)
                    {
                        CustomRoomPanel crp = new CustomRoomPanel(false);

                        crp.strNameSurname = stayCustomerInfo[index].GetValue(0) + " " + stayCustomerInfo[index].GetValue(1);
                        crp.strRoomNo = stayCustomerInfo[index].GetValue(2).ToString();
                        crp.strCheckOutDate = stayCustomerInfo[index].GetValue(3).ToString();
                        crp.strStayGuestCount = (db.getGuestCount(Convert.ToInt32(stayCustomerInfo[index].GetValue(4))) + 1).ToString();

                        myTableLayoutPanel1.Controls.Add(crp, i, j);

                        index--;
                        

                    }

                }

                
            }

            index = freeRoomCount - 1;
            for (int i = 2; i < myTableLayoutPanel1.ColumnCount; i++)
            {

                for (int j = 0; j < myTableLayoutPanel1.RowCount; j++)
                {

                    if (index >= 0)
                    {

                        CustomRoomPanel crp = new CustomRoomPanel(true);

                        crp.strNameSurname = freeRoomsInfo[index].GetValue(0).ToString();
                        crp.strStayGuestCount = freeRoomsInfo[index].GetValue(1).ToString();
                        crp.strCheckOutDate = freeRoomsInfo[index].GetValue(2).ToString()+'$';
                        crp.strRoomNo = freeRoomsInfo[index].GetValue(3).ToString();

                        myTableLayoutPanel1.Controls.Add(crp, i, j);

                        index--;


                    }

                }


            }






        }

        
    }

}

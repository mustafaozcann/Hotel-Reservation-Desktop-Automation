using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HotelReservation
{
    class Database
    {
        private SqlConnection sqlconnection;
        private SqlCommand sqlCommand;
        private SqlDataReader sqldatareader;

        private static string connectString = ConfigurationManager.ConnectionStrings["HotelReservation.Properties.Settings.HotelDBConnectionString"].ConnectionString;

        CustomMessageBox cmbox;

        public Database()
        {
            sqlconnection = new SqlConnection(connectString);
        }

        public void fakeInfoLoad()
        {

            //string[] currencyList = { "€EUR", "$USD", "₺TRY" };
            //string[] customerNameList = { "Mustafa", "Ali", "Hatice", "Jonathan", "Micheal", "Rabia", "Sude", "Gabriel", "Nazlı", "Mehmet", "Aybüke", "Mert", "Bünyamin", "Kamuran", "Gamze", "Obama", "Selman", "Radamel", "Sedat" };
            //string[] customerSurnameList = { "Özcan", "Maraşlıoğlu", "Çimen", "Çalık", "Falcao", "Erdoğan", "Aksu", "Tanyıldızı", "Uçar", "Hatipoğlu", "İmamoğlu", "Peker", "Danış", "Snape", "Alakurt", "Boyacı", "Atlıhan", "Köşk" };
            //string[] nationaliyList = { "Turkey", "United Kingdom", "United States Of America", "French", "Germany", "Syria" };
            //string[] genderList = { "ERKEK", "KADIN" };
            //string[] roomNoList = { "100", "102", "103", "104", "105", "106", "107", "108", "109", "110" };

            //int customerId = 1000;

            //int identityNo = 100;
            //int mobileNo = 100;
            //int passportNo = 100;
            //string identityNoString = "10000000";
            //string mobileNoString = "10000000";
            //string passportNoString = "1000";

            //string nationality;



            //DateTime fakeCheckinDate = DateTime.Now;
            //DateTime fakeCheckOutDate = DateTime.Now;
            //Random rnd = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    connectionUpdate();

            //    nationality = nationaliyList[rnd.Next(nationaliyList.Length)];

            //    if (!(nationality.Equals("Turkey")))
            //    {
            //        sqlCommand = new SqlCommand("Insert Into LeavingCustomerTb (CustomerId,Name, Surname, PassportNo, MobileNumber ,RoomNo, Nationality, Gender, Currency, CheckinDate, CheckoutDate) Values (@CustomerId,@name,@surname,@passPortNo," +
            //    "@mobilenumber,@roomNo,@nationality,@gender,@currency,@checkin, @checkout)", sqlconnection);
            //        sqlCommand.Parameters.Add("@passPortNo", SqlDbType.Char).Value = passportNoString + passportNo.ToString();
            //        passportNo += 2;
            //    }

            //    else
            //    {

            //        sqlCommand = new SqlCommand("Insert Into LeavingCustomerTb (CustomerId,Name, Surname, IdentityNo, MobileNumber ,RoomNo, Nationality, Gender, Currency, CheckinDate, CheckoutDate) Values (@CustomerId,@name,@surname,@identityNo," +
            //    "@mobilenumber,@roomNo,@nationality,@gender,@currency,@checkin, @checkout)", sqlconnection);
            //        sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = identityNoString + identityNo.ToString();
            //        identityNo += 2;
            //    }

            //    sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;


            //    fakeCheckinDate = new DateTime(DateTime.Now.Year, rnd.Next(1, 13), rnd.Next(1, 27));
            //    fakeCheckOutDate = fakeCheckinDate.AddDays(1);
            //    sqlCommand.Parameters.Add("@checkin", SqlDbType.DateTime).Value = fakeCheckinDate;
            //    sqlCommand.Parameters.Add("@checkout", SqlDbType.DateTime).Value = fakeCheckOutDate;



            //    sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerNameList[rnd.Next(customerNameList.Length)];
            //    sqlCommand.Parameters.Add("@surname", SqlDbType.NVarChar).Value = customerSurnameList[rnd.Next(customerSurnameList.Length)];


            //    sqlCommand.Parameters.Add("@mobilenumber", SqlDbType.Char).Value = mobileNoString + mobileNo.ToString();
            //    sqlCommand.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = nationality;
            //    sqlCommand.Parameters.Add("@gender", SqlDbType.Char).Value = genderList[rnd.Next(genderList.Length)];
            //    sqlCommand.Parameters.Add("@currency", SqlDbType.NVarChar).Value = currencyList[rnd.Next(currencyList.Length)];
            //    sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = roomNoList[rnd.Next(roomNoList.Length)];

            //    mobileNo += 2;
            //    customerId++;
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand.Parameters.Clear();
            //    sqlconnection.Close();

            //}


        }
        public void updateCurrency(DateTime updateDate, double usd, double eur)
        {
            connectionUpdate();


            sqlCommand = new SqlCommand("Update CurrencyTb set USD = @usd, EUR = @eur, lastUpdateDate = @date where [Index] = 'True'", sqlconnection);
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = updateDate;
            sqlCommand.Parameters.Add("@usd", SqlDbType.Money).Value = usd;
            sqlCommand.Parameters.Add("@eur", SqlDbType.Money).Value = eur;

            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();

        }
        public string[] getCurrency()
        {
            string[] currencys = new string[3];

            connectionUpdate();

            sqlCommand = new SqlCommand("Select USD, EUR, lastUpdateDate FROM CurrencyTb Where [Index] = '1'", sqlconnection);
            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
            {
                currencys[0] =  sqldatareader.GetValue(0).ToString();
                currencys[1] = sqldatareader.GetValue(1).ToString();
                currencys[2] = sqldatareader.GetDateTime(2).ToString();

            }

            sqlconnection.Close();

            return currencys;

        }
        public void connectionUpdate()
        {
            if (sqlconnection.State != ConnectionState.Open)
                sqlconnection.Open();
        }
        //adminlogin
        public bool adminLogin(string username, string password)
        {

            sqlCommand = new SqlCommand("Select * from Admins where Username = @username and Password = @password", sqlconnection);

            sqlCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;




            sqlconnection.Open();

            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
            {
                sqlconnection.Close();
                return true;
            }

            sqlconnection.Close();
            return false;


        }

        public string getAdminInfo(string username)
        {

            connectionUpdate();

            sqlCommand = new SqlCommand("Select Name, Surname from Admins where Username = @username", sqlconnection);
            sqlCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

            sqldatareader = sqlCommand.ExecuteReader();

            string nameSurname = null;

            while (sqldatareader.Read())
                nameSurname += sqldatareader.GetString(0) + " " + sqldatareader.GetString(1);


            sqlconnection.Close();

            return nameSurname;
            



        }

        public bool findUsername(string username)
        {

            sqlCommand = new SqlCommand("Select username from Admins where Username = @username", sqlconnection);
            sqlCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username; //protected enjection (Add kullanımı)

            sqlconnection.Open();


            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
            {
                sqlconnection.Close();
                return true;
            }
            sqlconnection.Close();
            return false;


        }
        public bool adminSignIn(string username, string password, string name, string surname)
        {
            if (!findUsername(username))
            {
                sqlconnection.Open();
                sqlCommand = new SqlCommand("Insert into Admins (Name, Surname, Username, Password) values (@Name, @Surname, @Username, @Password)", sqlconnection);

                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = surname;
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                sqlCommand.ExecuteNonQuery();

                sqlconnection.Close();

                return true;
            }

            return false;



        }
        //for incoming guest statistic
        public int[,] getLeavingGuest()
        {

            List<DateTime> datetimeList = new List<DateTime>();
            
            connectionUpdate();

            sqlCommand = new SqlCommand("Select CheckinDate from LeavingCustomerTb", sqlconnection);
            sqldatareader =  sqlCommand.ExecuteReader();
            
            int[,] incomingGuest = new int[12, 1];

            int dateYear = DateTime.Now.Year;  
            while (sqldatareader.Read())
            {
               
                DateTime date = sqldatareader.GetDateTime(0);
                if(date.Year == dateYear)
                    datetimeList.Add(date);
            }

            datetimeList.Sort();

            byte month = 0;
            short i  = 1; // incoming guest count

            if (datetimeList.Count != 0)
                month = Convert.ToByte(datetimeList[0].Month);

            

            foreach(DateTime date in datetimeList)
            {
                if (date.Month.Equals(month))
                {
                    incomingGuest[month - 1, 0] = i;
                    i++;
                }
                
                else
                {
                    i = 1;
                    month = Convert.ToByte(date.Month);
                }
            }

            sqlconnection.Close();


            return incomingGuest;



        }



        public List<string> getCustomerInfo(int customerId)
        {

            connectionUpdate();


            sqlCommand = new SqlCommand("Select * from CustomerTb Where CustomerId = @CustomerId ", sqlconnection);
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

            sqldatareader = sqlCommand.ExecuteReader();


            List<string> customerInfoList = new List<string>();

            if (sqldatareader.Read())
            {
                //12
                customerInfoList.Add(sqldatareader.GetValue(0).ToString());
                customerInfoList.Add(sqldatareader.GetValue(1).ToString());
                customerInfoList.Add(sqldatareader.GetValue(2).ToString());
                customerInfoList.Add(sqldatareader.GetValue(3).ToString());
                customerInfoList.Add(sqldatareader.GetValue(4).ToString());
                customerInfoList.Add(sqldatareader.GetValue(5).ToString());
                customerInfoList.Add(sqldatareader.GetValue(6).ToString());
                customerInfoList.Add(sqldatareader.GetValue(7).ToString());
                customerInfoList.Add(sqldatareader.GetValue(8).ToString());
                customerInfoList.Add(sqldatareader.GetValue(9).ToString());
                customerInfoList.Add(sqldatareader.GetValue(10).ToString());
                customerInfoList.Add(sqldatareader.GetValue(11).ToString());

            }

            sqlconnection.Close();

            return customerInfoList;

        }

        public void leavingGuest(List<string> customerInfoList)
        {

            connectionUpdate();
            

            sqlCommand = new SqlCommand("Insert into LeavingCustomerTb (CustomerId,Name, Surname, IdentityNo, PassportNo, MobileNumber, RoomNo, Nationality, Gender, CheckinDate, CheckoutDate, Currency) values (@CustomerId,@Name, @Surname,@IdentityNo,@PassportNo ,@MobileNumber, @RoomNo, @Nationality, @Gender, @CheckinDate, @CheckoutDate, @Currency)", sqlconnection);


            //add parameters
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Convert.ToInt32(customerInfoList[0]);

            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customerInfoList[1];
            sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = customerInfoList[2];
            sqlCommand.Parameters.Add("@IdentityNo", SqlDbType.NChar).Value = customerInfoList[3];
            sqlCommand.Parameters.Add("@PassportNo", SqlDbType.NChar).Value = customerInfoList[4];
            sqlCommand.Parameters.Add("@MobileNumber", SqlDbType.NChar).Value = customerInfoList[5];
            sqlCommand.Parameters.Add("@RoomNo", SqlDbType.Int).Value = customerInfoList[6];
            sqlCommand.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = customerInfoList[7];
            sqlCommand.Parameters.Add("@Gender", SqlDbType.NChar).Value = customerInfoList[8];
            sqlCommand.Parameters.Add("@Currency", SqlDbType.NVarChar).Value = customerInfoList[9];

            sqlCommand.Parameters.Add("@CheckinDate", SqlDbType.DateTime).Value = DateTime.Parse(customerInfoList[10]);
            sqlCommand.Parameters.Add("@CheckoutDate", SqlDbType.DateTime).Value = DateTime.Parse(customerInfoList[11]);


            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();



        }

        public void earnings(string currency, double amount)
        {

            connectionUpdate();
            sqlCommand = new SqlCommand("Insert into EarningsTb (Date, Earnings"+currency + ") values (@date, @amount)", sqlconnection);
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
            sqlCommand.Parameters.Add("@amount", SqlDbType.Money).Value = amount;

            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();

        }
        public List<string[]> getEarnings()
        {
            connectionUpdate();

            List<string[]> earningsList = new List<string[]>();

            DateTime perMounth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endMounth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31); 

            
            sqlCommand = new SqlCommand("Select EarningsUSD, EarningsTRY, EarningsEUR from EarningsTb Where Date >= @PerMounth And Date <= @EndMounth", sqlconnection);
            sqlCommand.Parameters.Add("@PerMounth", SqlDbType.DateTime).Value = perMounth;
            sqlCommand.Parameters.Add("@EndMounth", SqlDbType.DateTime).Value = endMounth;

            sqldatareader = sqlCommand.ExecuteReader();


            while (sqldatareader.Read())
            {
                string[] earningsArray = new string[3];

                earningsArray[0] = sqldatareader.GetValue(0).ToString();
                earningsArray[1] = sqldatareader.GetValue(1).ToString();
                earningsArray[2] = sqldatareader.GetValue(2).ToString();


                earningsList.Add(earningsArray);
            }


            sqlconnection.Close();

            return earningsList;

        }

        //reservation
        public bool addCustomer(string customerName, string Surname, string IdentityNo, string mobileNumber, int roomNo, string nationality, string gender, DateTime checkindate, DateTime checkoutdate, string currency)
        {



            bool state = true;



            if (IdentityNo.Length == 11 && !customerIdentityNoAvailable(IdentityNo))
            {
                sqlCommand = new SqlCommand("Insert into CustomerTb (Name, Surname, IdentityNo, MobileNumber, RoomNo, Nationality, Gender, CheckinDate, CheckoutDate, Currency) values (@Name, @Surname,@IdentityNo, @MobileNumber, @RoomNo, @Nationality, @Gender, @CheckinDate, @CheckoutDate, @Currency)", sqlconnection);
                sqlCommand.Parameters.Add("@IdentityNo", SqlDbType.NChar).Value = IdentityNo;
            }
            else if (IdentityNo.Length == 7 && !customerPassportNoAvailable(IdentityNo))
            {
                sqlCommand = new SqlCommand("Insert into CustomerTb (Name, Surname, PassportNo, MobileNumber, RoomNo, Nationality, Gender, CheckinDate, CheckoutDate, Currency) values (@Name, @Surname,@PassportNo, @MobileNumber, @RoomNo, @Nationality, @Gender, @CheckinDate, @CheckoutDate, @Currency)", sqlconnection);
                sqlCommand.Parameters.Add("@PassportNo", SqlDbType.NChar).Value = IdentityNo;
            }

            else
                state = false;




            if (state)
            {

                connectionUpdate();

                //add parameters
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customerName;
                sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = Surname;
                sqlCommand.Parameters.Add("@MobileNumber", SqlDbType.NChar).Value = mobileNumber;
                sqlCommand.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;

                sqlCommand.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = nationality;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.NChar).Value = gender;
                sqlCommand.Parameters.Add("@CheckinDate", SqlDbType.DateTime).Value = checkindate;
                sqlCommand.Parameters.Add("@CheckoutDate", SqlDbType.DateTime).Value = checkoutdate;
                sqlCommand.Parameters.Add("@Currency", SqlDbType.NVarChar).Value = currency;


                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();

                

            }


            return state;







        }
        public bool addGuest(int CustomerId, string GuestName, string GuestSurname, string GuestIdentityNo, string GuestGender, string GuestMobileNumber, string GuestNationality)
        {


            bool state = true;


            if (GuestIdentityNo.Length == 11)
            {
                sqlCommand = new SqlCommand("Insert into GuestTb (CustomerId,GuestName," +
                "GuestSurname,GuestIdentityNo," +
                "GuestGender,GuestMobileNumber,GuestNationality)" +
                " values(@CustomerId,@GuestName,@GuestSurname,@GuestIdentityNo,@GuestGender,@GuestMobileNumber,@GuestNationality)", sqlconnection);

                sqlCommand.Parameters.Add("@GuestIdentityNo", SqlDbType.Char).Value = GuestIdentityNo;
            }

            else if (GuestIdentityNo.Length == 7)
            {
                sqlCommand = new SqlCommand("Insert into GuestTb (CustomerId,GuestName," +
                "GuestSurname,GuestPassportNo," +
                "GuestGender,GuestMobileNumber,GuestNationality)" +
                " values(@CustomerId,@GuestName,@GuestSurname,@GuestPassportNo,@GuestGender,@GuestMobileNumber,@GuestNationality)", sqlconnection);

                sqlCommand.Parameters.Add("@GuestPassportNo", SqlDbType.Char).Value = GuestIdentityNo;

            }

            else
                state = false;




            if (state)
            {
                connectionUpdate();

                sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
                sqlCommand.Parameters.Add("@GuestName", SqlDbType.NVarChar).Value = GuestName;
                sqlCommand.Parameters.Add("@GuestSurname", SqlDbType.NVarChar).Value = GuestSurname;
                sqlCommand.Parameters.Add("@GuestGender", SqlDbType.Char).Value = GuestGender;
                sqlCommand.Parameters.Add("@GuestMobileNumber", SqlDbType.Char).Value = GuestMobileNumber;
                sqlCommand.Parameters.Add("@GuestNationality", SqlDbType.NVarChar).Value = GuestNationality;

                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();

            }

            return state;

        }

        public void customerCheckInAccept(int customerId)
        {

            connectionUpdate();

            sqlCommand = new SqlCommand("Update CustomerTb set AcceptCustomer = @AcceptCustomer where CustomerId = @customerId", sqlconnection);
            sqlCommand.Parameters.Add("@customerId", SqlDbType.Char).Value = customerId;
            sqlCommand.Parameters.Add("@AcceptCustomer", SqlDbType.Bit).Value = 1;

            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();
            

        }

        public void customerCheckOutAccept(int customerId)
        {
            List<string> customerInfoList = getCustomerInfo(customerId);

            connectionUpdate();
            sqlCommand = new SqlCommand("Delete From CustomerTb Where CustomerId = @customerId", sqlconnection);
            sqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();


            leavingGuest(customerInfoList);

        }

        public int getCustomerId(string identityNo)
        {
            connectionUpdate();


            if (identityNo.Length == 11)
            {
                sqlCommand = new SqlCommand("Select CustomerId from CustomerTb where IdentityNo = @IdentityNo", sqlconnection);
                sqlCommand.Parameters.Add("@IdentityNo", SqlDbType.Char).Value = identityNo;

            }

            else
            {
                sqlCommand = new SqlCommand("Select CustomerId from CustomerTb where PassportNo = @PassportNo", sqlconnection);
                sqlCommand.Parameters.Add("@PassportNo", SqlDbType.Char).Value = identityNo;

            }


            sqldatareader = sqlCommand.ExecuteReader();

            object customerId = null;

            if (sqldatareader.Read())
            {
                customerId = sqldatareader.GetValue(0);
                sqldatareader.Close();

            }


            sqlconnection.Close();
            return Convert.ToInt32(customerId);
        }

        public List<string[]> getGuestInfo(int customerId)
        {
            List<string[]> guestInfoList = new List<string[]>();


            connectionUpdate();

            sqlCommand = new SqlCommand("Select * from GuestTb Where CustomerId = @customerId", sqlconnection);
            sqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

            sqldatareader = sqlCommand.ExecuteReader();


            while (sqldatareader.Read())
            {
                //8
                string[] guestArray = new string[7];


                guestArray[0] = sqldatareader.GetValue(1).ToString();
                guestArray[1] = sqldatareader.GetValue(2).ToString();
                guestArray[2] = sqldatareader.GetValue(3).ToString();
                guestArray[3] = sqldatareader.GetValue(4).ToString();
                guestArray[4] = sqldatareader.GetValue(5).ToString();
                guestArray[5] = sqldatareader.GetValue(6).ToString();
                guestArray[6] = sqldatareader.GetValue(7).ToString();

                guestInfoList.Add(guestArray);
            }


            sqlconnection.Close();


            return guestInfoList;

        }

        public int getGuestCount(int customerId)
        {
            connectionUpdate();



            sqlCommand = new SqlCommand("Select * from GuestTb where CustomerId = @CustomerId", sqlconnection);
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;

            using (sqldatareader = sqlCommand.ExecuteReader())
            {

                int guestCount = 0;

                while (sqldatareader.Read())
                {
                    guestCount++;
                }

                return guestCount;
            }

        }
        public int getHotelTotalCapacity()
        {
            connectionUpdate();


            sqlCommand = new SqlCommand("Select Capacity From Rooms", sqlconnection);
            sqldatareader = sqlCommand.ExecuteReader();


            int totalCapacity = 0;


            while (sqldatareader.Read())
                totalCapacity += Convert.ToInt32(sqldatareader.GetValue(0));





            sqldatareader.Close();
            sqlconnection.Close();



            return totalCapacity;
        }

        public int getRoomPrice(int roomNo)
        {
            connectionUpdate();

            sqlCommand = new SqlCommand("Select Price from Rooms Where RoomNo = @roomNo", sqlconnection);
            sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = roomNo;

            sqldatareader = sqlCommand.ExecuteReader();

            int price = 0;

            if (sqldatareader.Read())
                price = Convert.ToInt32(sqldatareader.GetValue(0));

            sqlconnection.Close();

            return price;


        }

        public string[] getAmountPaid(int customerId)
        {

            connectionUpdate();

            sqlCommand = new SqlCommand("Select CheckinDate, CheckoutDate, Currency, RoomNo from CustomerTb Where CustomerId = @CustomerId", sqlconnection);
            sqlCommand.Parameters.Add("CustomerId", SqlDbType.Int).Value = customerId;

            string[] payInfo = new string[2];

            sqldatareader = sqlCommand.ExecuteReader();

            sqldatareader.Read();


            DateTime checkindate = sqldatareader.GetDateTime(0);
            DateTime checkOutdate = sqldatareader.GetDateTime(1);
            string currency = sqldatareader.GetString(2);
            int roomNo = sqldatareader.GetInt32(3);

            sqlconnection.Close();

            int stayDaysCount = Convert.ToInt32((checkOutdate - checkindate).TotalDays);

            int roomPrice = getRoomPrice(roomNo);

            string[] currencys = getCurrency();

            string cur = currency.Substring(1, 3);

            double totalAmount;

            if (cur.Equals("TRY"))
            {
                totalAmount = roomPrice * stayDaysCount * Convert.ToDouble(currencys[0]);
                cur += '₺'; 
            }

            else if (cur.Equals("EUR"))
            {
                totalAmount = roomPrice * stayDaysCount * Math.Round(Convert.ToDouble(currencys[0]) / Convert.ToDouble(currencys[1]), 4);
                cur += '€';
            }

            else
            {
                totalAmount = roomPrice * stayDaysCount;
                cur += '$';
            }

            payInfo[0] = cur;
            payInfo[1] = totalAmount.ToString();

            
            return payInfo;

        }
        public int getRoomCapacity(int roomNo)
        {


            connectionUpdate();


            sqlCommand = new SqlCommand("Select Capacity from Rooms where RoomNo = @RoomNo", sqlconnection);
            sqlCommand.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;
            sqldatareader.Close();

            sqldatareader = sqlCommand.ExecuteReader();

            int capacity = 0;
            if (sqldatareader.Read())
                capacity = (int)sqldatareader.GetValue(0);


            sqlconnection.Close();
            return capacity;
        }

        public string getRoomInfo(int roomNo)
        {
            connectionUpdate();


            sqlCommand = new SqlCommand("Select RoomType, Capacity, Price from Rooms Where RoomNo = @roomNo", sqlconnection);
            sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = roomNo;


            sqldatareader = sqlCommand.ExecuteReader();

            string roomInfo = null;

            if (sqldatareader.Read())
                roomInfo = roomNo.ToString() + " -- " + sqldatareader.GetValue(0).ToString() + " Kapasite = " + sqldatareader.GetValue(1).ToString() + " Ücret = " + sqldatareader.GetValue(2) + "$";


            sqlconnection.Close();

            return roomInfo;
        }

        public List<string> getRoomsNoAndRoomtype()
        {

            connectionUpdate();
            
            List<string> roomTypesAndRoomNo = new List<string>();
            


            sqlCommand = new SqlCommand("Select * from Rooms where State = '0'", sqlconnection);

            sqldatareader = sqlCommand.ExecuteReader();


            while (sqldatareader.Read())
                roomTypesAndRoomNo.Add(sqldatareader.GetValue(0).ToString() + " -- " + sqldatareader.GetValue(1).ToString() + " Kapasite = " + sqldatareader.GetValue(2).ToString() + " Ücret = " + sqldatareader.GetValue(3)+ "$");


            sqlconnection.Close();


            return roomTypesAndRoomNo;
            
        }

        public List<string[]> getToFreeRoom()
        {
            List<string[]> totalToStay = getToStayGuests();
            List<string[]> FreeRoomsInfoList = new List<string[]>();

            int totalRoomCount = getTotalCountOfRoom();
            int[] fullRoomNoArray = new int[totalToStay.Count];
            int[] allRoomsNoArray = new int[totalRoomCount];

            connectionUpdate();

            
            int i = 0;
            foreach(string[] fullRoomInfo in totalToStay)
            {
                fullRoomNoArray[i] = Convert.ToInt32(fullRoomInfo[2]);
                i++;

            }

            sqlCommand = new SqlCommand("Select RoomNo From Rooms", sqlconnection);
            sqldatareader = sqlCommand.ExecuteReader();

            for(i = 0; sqldatareader.Read(); i++)
                allRoomsNoArray[i] = sqldatareader.GetInt32(0);

            sqlconnection.Close();


            //array difference

            var difference = allRoomsNoArray.Except(fullRoomNoArray);
            List<int> freeRoomNoList = difference.ToList();


            
            foreach(int freeRoomNo in freeRoomNoList)
            {
                connectionUpdate();

                string[] freeRoomInfoArray = new string[4];

                
                sqlCommand = new SqlCommand("Select RoomType, Price, Capacity From Rooms where RoomNo = @RoomNo", sqlconnection);
                sqlCommand.Parameters.Add("@RoomNo", SqlDbType.Int).Value = freeRoomNo;
                sqldatareader = sqlCommand.ExecuteReader();
                sqldatareader.Read();

                freeRoomInfoArray[0] = freeRoomNo.ToString();
                freeRoomInfoArray[1] = sqldatareader.GetValue(0).ToString();
                freeRoomInfoArray[2] = sqldatareader.GetValue(1).ToString();
                freeRoomInfoArray[3] = sqldatareader.GetValue(2).ToString();


                FreeRoomsInfoList.Add(freeRoomInfoArray);


                sqlconnection.Close();

            }


            return FreeRoomsInfoList;
        }
        public List<string[]> getToStayGuests()
        {
            List<string[]> totalToStay = new List<string[]>();


            connectionUpdate();



            sqlCommand = new SqlCommand("Select Name, Surname, RoomNo, CheckOutDate, CustomerId From CustomerTb Where AcceptCustomer=@AcceptCustomer", sqlconnection);
            sqlCommand.Parameters.Add("@AcceptCustomer", SqlDbType.Bit).Value = 1;

            sqldatareader = sqlCommand.ExecuteReader();
            

            while (sqldatareader.Read())
            {
                string[] customerInfo = new string[5];

                customerInfo[0] = sqldatareader.GetValue(0).ToString();
                customerInfo[1] = sqldatareader.GetValue(1).ToString();
                customerInfo[2] = sqldatareader.GetValue(2).ToString();
                customerInfo[3] = sqldatareader.GetDateTime(3).ToString("dd/MM/yyyy");
                customerInfo[4] = sqldatareader.GetValue(4).ToString();

                totalToStay.Add(customerInfo);
            }

            sqlconnection.Close();

            return totalToStay;
        }
        public void updateRoomState()
        {

            connectionUpdate();

            sqlCommand = new SqlCommand("Update Rooms Set State = '0'", sqlconnection);
            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();

        }
        public void updateRoomState(DateTime checkin, DateTime checkout)
        {
            updateRoomState();

            connectionUpdate();

            sqlCommand = new SqlCommand("Select RoomNo, CheckinDate, CheckoutDate, AcceptCustomer from CustomerTb Where Name != 'NULL' ", sqlconnection);
            sqldatareader = sqlCommand.ExecuteReader();

            List<string[]> customersList = new List<string[]>();
            


            while (sqldatareader.Read())
            {

                string[] customer = new string[4];
                customer[0] = sqldatareader.GetInt32(0).ToString();
                customer[1] = sqldatareader.GetDateTime(1).ToString();//CHECK IN
                customer[2] = sqldatareader.GetDateTime(2).ToString();// CHECK OUT
                customer[3] = sqldatareader.GetValue(3).ToString();

                customersList.Add(customer);

            }

            sqlconnection.Close();

            connectionUpdate();

            foreach(string[] customer in customersList)
            {

                if(DateTime.Parse(customer[1]).Year != checkin.Year)
                {
                    sqlCommand = new SqlCommand("Update Rooms Set State = '0' where RoomNo = @roomNo", sqlconnection);
                    sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = Convert.ToInt32(customer[0]);
                    sqlCommand.ExecuteNonQuery();
                    continue;
                }

                if (DateTime.Parse(customer[2]).Day == checkin.Day && DateTime.Parse(customer[1]).Day < checkin.Day)    
                {

                    sqlCommand = new SqlCommand("Update Rooms Set State = '0' where RoomNo = @roomNo", sqlconnection);
                    sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = Convert.ToInt32(customer[0]);
                    sqlCommand.ExecuteNonQuery();
                    continue;
                }

                if (customer[3].Equals("1"))
                {
                    sqlCommand = new SqlCommand("Update Rooms Set State = '1' where RoomNo = @roomNo", sqlconnection);
                    sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = Convert.ToInt32(customer[0]);
                    sqlCommand.ExecuteNonQuery();
                    continue;
                }

               
                //                                                                         05/01/2022     11/01/2022                       12/01/2022       06/01/2022
                if (DateTime.Parse(customer[1]).Day == checkin.Day || (DateTime.Parse(customer[1]).Day <= checkout.Day && DateTime.Parse(customer[2]).Day >= checkin.Day))
                {
                    sqlCommand = new SqlCommand("Update Rooms Set State = '1' where RoomNo = @roomNo", sqlconnection);
                    sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = Convert.ToInt32(customer[0]);
                    sqlCommand.ExecuteNonQuery();
                    
                }




            }


            sqlconnection.Close();
        }
        //create date range
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
        public int getTotalCountOfRoom()
        {
            connectionUpdate();

            sqlCommand = new SqlCommand("Select * from Rooms", sqlconnection);

            sqldatareader = sqlCommand.ExecuteReader();

            int count = 0;

            while (sqldatareader.Read())
                count++;


            sqlconnection.Close();
            return count;

        }

        public int getFullRoomCount()
        {
            connectionUpdate();
            sqlCommand = new SqlCommand("Select RoomNo From CustomerTb Where AcceptCustomer = 'True'", sqlconnection);
            sqldatareader = sqlCommand.ExecuteReader();


            int count = 0;

            while (sqldatareader.Read())
                count++;

            sqlconnection.Close();

            return count;

        }
        public int getHotelFullRatio()
        {
            int totalRoomCount = getTotalCountOfRoom();
            int fullRoomCount = getFullRoomCount();

            double ratio = (double)fullRoomCount / totalRoomCount * 100;

            return Convert.ToInt32(ratio);
        }
        //update guest

        public bool updateGuest(string GuestName, string GuestSurname, string GuestNewIdentityNo, string GuestGender, string GuestMobileNumber, string GuestNationality, string oldIdentityNo, int customerId)
        {


            bool available = true;


            if(GuestNewIdentityNo.Length == 11)
                available = guestIdentityNoAvailable(customerId, GuestNewIdentityNo);
            
            

            else
                available = guestPassportNoAvailable(customerId, GuestNewIdentityNo);

            
            if (available)
            {
                
                connectionUpdate();
                
                if(oldIdentityNo.Length == 11 && GuestNewIdentityNo.Length == 11)
                {
                    sqlCommand = new SqlCommand("Update GuestTb Set GuestName = @guestName," +
                        " GuestSurname = @guestSurname, GuestIdentityNo = @guestIdentityNo, GuestGender = @gender, GuestMobileNumber = @guestMobileNo, GuestNationality = @nationality Where GuestIdentityNo = @oldIdentity");


                    sqlCommand.Parameters.Add("oldIdentity", SqlDbType.Char).Value = oldIdentityNo;
                    sqlCommand.Parameters.Add("guestIdentityNo", SqlDbType.Char).Value = GuestNewIdentityNo;



                }

                else if(oldIdentityNo.Length == 11 && GuestNewIdentityNo.Length == 7)
                {
                    sqlCommand = new SqlCommand("Update GuestTb Set GuestName = @guestName," +
                        " GuestSurname = @guestSurname, GuestPassportNo = @guestPassportNo, GuestGender = @gender, GuestMobileNumber = @guestMobileNo, GuestNationality = @nationality Where GuestIdentityNo = @oldIdentity");


                    sqlCommand.Parameters.Add("oldIdentity", SqlDbType.Char).Value = oldIdentityNo;
                    sqlCommand.Parameters.Add("guestPassportNo", SqlDbType.Char).Value = GuestNewIdentityNo;

                }

                else if(oldIdentityNo.Length == 7 && GuestNewIdentityNo.Length == 7)
                {
                    sqlCommand = new SqlCommand("Update GuestTb Set GuestName = @guestName," +
                        " GuestSurname = @guestSurname, GuestPassportNo = @guestPassportNo, GuestGender = @gender, GuestMobileNumber = @guestMobileNo, GuestNationality = @nationality Where GuestPassportNo = @oldPassportNo");


                    sqlCommand.Parameters.Add("oldPassportNo", SqlDbType.Char).Value = oldIdentityNo;
                    sqlCommand.Parameters.Add("guestPassportNo", SqlDbType.Char).Value = GuestNewIdentityNo;

                }

                else
                {
                    sqlCommand = new SqlCommand("Update GuestTb Set GuestName = @guestName," +
                        " GuestSurname = @guestSurname, GuestIdentityNo = @guestIdentityNo, GuestGender = @gender, GuestMobileNumber = @guestMobileNo, GuestNationality = @nationality Where GuestPassportNo = @oldPassportNo");


                    sqlCommand.Parameters.Add("oldPassportNo", SqlDbType.Char).Value = oldIdentityNo;
                    sqlCommand.Parameters.Add("guestIdentityNo", SqlDbType.Char).Value = GuestNewIdentityNo;


                }


                sqlCommand.Connection = sqlconnection;


                sqlCommand.Parameters.Add("@guestName", SqlDbType.NVarChar).Value = GuestName;
                sqlCommand.Parameters.Add("@guestSurname", SqlDbType.NVarChar).Value = GuestSurname;
                sqlCommand.Parameters.Add("@gender", SqlDbType.Char).Value = GuestGender;
                sqlCommand.Parameters.Add("@guestMobileNo", SqlDbType.Char).Value = GuestMobileNumber;
                sqlCommand.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = GuestNationality;


                sqlCommand.ExecuteNonQuery();


                sqlconnection.Close();
            }

            return available;

        }

        //update customer
        public bool updateCustomer(string Name, string Surname, string IdentityNo, string Gender, int roomNo, string MobileNumber, string Nationality, string newIdentity, string currency,DateTime checkInDate, DateTime checkOutDate)
        {
            
            bool available = false;

            int customerId = getCustomerId(IdentityNo);

            if(IdentityNo.Length == 11)
                available = customerIdentityNoAvailable(customerId, IdentityNo);
            
            

            else
                available = customerPassportNoAvailable(customerId, IdentityNo);
            
            


            if(newIdentity.Length == 11)
                available = customerIdentityNoAvailable(customerId, IdentityNo);


            
            else
                available = customerPassportNoAvailable(customerId, IdentityNo);





            if (!available)
            {

                connectionUpdate();

                if(newIdentity.Length == 11)
                {
                    sqlCommand = new SqlCommand("Update CustomerTb Set Name = @name, Surname = @surname," +
                        " IdentityNo = @identityNo, MobileNumber = @mobileNumber, RoomNo = @roomNo, Nationality = @nationality, Gender = @gender," +
                        " Currency = @currency, CheckinDate = @checkindate, CheckoutDate = @checkoutdate Where CustomerId = @customerId");

                    sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = newIdentity;

                }

                else
                {
                    sqlCommand = new SqlCommand("Update CustomerTb Set Name = @name, Surname = @surname," +
                        " PassportNo = @passportNo, MobileNumber = @mobileNumber, RoomNo = @roomNo, Nationality = @nationality, Gender = @gender," +
                        " Currency = @currency, CheckinDate = @checkindate, CheckoutDate = @checkoutdate Where CustomerId = @customerId");

                    sqlCommand.Parameters.Add("@passportNo", SqlDbType.Char).Value = newIdentity;

                }

                sqlCommand.Connection = sqlconnection;

                sqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
                sqlCommand.Parameters.Add("@surname", SqlDbType.NVarChar).Value = Surname;
                sqlCommand.Parameters.Add("@mobileNumber", SqlDbType.Char).Value = MobileNumber;
                sqlCommand.Parameters.Add("@roomNo", SqlDbType.Int).Value = roomNo;
                sqlCommand.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = Nationality;
                sqlCommand.Parameters.Add("@gender", SqlDbType.Char).Value = Gender;
                sqlCommand.Parameters.Add("@currency", SqlDbType.NVarChar).Value = currency;
                sqlCommand.Parameters.Add("@checkindate", SqlDbType.DateTime).Value = checkInDate;
                sqlCommand.Parameters.Add("@checkoutdate", SqlDbType.DateTime).Value = checkOutDate;

                sqlCommand.ExecuteNonQuery();


                sqlconnection.Close();
            }





            return !available;
        }
        private bool guestIdentityNoAvailable(int customerId, string identiyNo)
        {

            connectionUpdate();

            bool available = true;


            sqlCommand = new SqlCommand("Select GuestIdentityNo from GuestTb Where GuestIdentityNo = @identityNo and CustomerId = @customerId", sqlconnection);
            sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = identiyNo;
            sqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = false;


            sqlconnection.Close();
            return available;

        }
        private bool guestPassportNoAvailable(int customerId, string passportNo)
        {
            connectionUpdate();

            bool available = true;


            sqlCommand = new SqlCommand("Select GuestPassportNo from GuestTb Where GuestPassportNo = @passportNo and CustomerId = @customerId", sqlconnection);
            sqlCommand.Parameters.Add("@passportNo", SqlDbType.Char).Value = passportNo;
            sqlCommand.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = false;



            sqlconnection.Close();
            return available;

        }
        private bool customerIdentityNoAvailable(int customerId, string identityNo)
        {

            connectionUpdate();

            bool available = false;

            sqlCommand = new SqlCommand("Select IdentityNo from CustomerTb Where CustomerId != @CustomerId and IdentityNo = @identityNo", sqlconnection);
            sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = identityNo;
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;


            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = true;
            

            

            sqlconnection.Close();

            return available;

        }
        private bool customerIdentityNoAvailable(string identityNo)
        {

            connectionUpdate();

            bool available = false;

            sqlCommand = new SqlCommand("Select IdentityNo from CustomerTb Where IdentityNo = @identityNo", sqlconnection);
            sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = identityNo;
            


            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = true;

            sqlconnection.Close();

            return available;

        }
        private bool customerPassportNoAvailable(string passportNo)
        {

            connectionUpdate();

            bool available = false;

            sqlCommand = new SqlCommand("Select PassportNo from CustomerTb Where PassportNo = @passportNo", sqlconnection);
            sqlCommand.Parameters.Add("@passportNo", SqlDbType.NVarChar).Value = passportNo;
            


            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = true;




            sqlconnection.Close();

            return available;

        }
        private bool customerPassportNoAvailable(int customerId, string passportNo)
        {

            connectionUpdate();

            bool available = false;

            sqlCommand = new SqlCommand("Select PassportNo from CustomerTb Where CustomerId != @CustomerId and PassportNo = @passportNo", sqlconnection);
            sqlCommand.Parameters.Add("@passportNo", SqlDbType.NVarChar).Value = passportNo;
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;


            sqldatareader = sqlCommand.ExecuteReader();

            if (sqldatareader.Read())
                available = true;




            sqlconnection.Close();

            return available;

        }

        //remove guest
        public void removeGuest(string guestIdentityNo)
        {

            connectionUpdate();

            if(guestIdentityNo.Length == 11)
            {
                sqlCommand = new SqlCommand("Delete from GuestTb Where GuestIdentityNo = @GuestIdentityNo", sqlconnection);
                sqlCommand.Parameters.Add("@GuestIdentityNo", SqlDbType.Char).Value = guestIdentityNo;

                cmbox = new CustomMessageBox("Girdim");
            }

            else
            {
                sqlCommand = new SqlCommand("Delete from GuestTb Where GuestPassportNo = @GuestPassportNo", sqlconnection);
                sqlCommand.Parameters.Add("@GuestPassportNo", SqlDbType.Char).Value = guestIdentityNo;

            }



            
            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();

        }
        //remove customer
        public void removeCustomer(int customerId)
        {

            connectionUpdate();


            sqlCommand = new SqlCommand("Delete from CustomerTb Where CustomerId = @CustomerId", sqlconnection);
            sqlCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;



            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();




        }
        public void removeCustomer(string identityNO)
        {
            connectionUpdate();


            if(identityNO.Length == 11)
            {
                sqlCommand = new SqlCommand("Delete from CustomerTb Where IdentityNo = @identityNo", sqlconnection);
                sqlCommand.Parameters.Add("@identityNo", SqlDbType.Char).Value = identityNO;

            }

            else
            {
                sqlCommand = new SqlCommand("Delete from CustomerTb Where PassportNo = @PassportNo", sqlconnection);
                sqlCommand.Parameters.Add("@PassportNo", SqlDbType.Char).Value = identityNO;

            }



            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();

           


        }







    }
}

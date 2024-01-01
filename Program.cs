using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    
    internal static class Program
    {
        public static string FILE_PATH = "reservation.bin";
        public static ArrayList reservationList = new ArrayList();
        private static int reservationCount = 1;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string credential_path = @"C:\dev\GCP\sacred-vigil-404814-065ef29e0275.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_HOTEL());
        }

        public static void adjustReservationCount()
        {
            foreach(Reservation r in reservationList)
            {
                if (r.id >= reservationCount) 
                    reservationCount = r.id + 1;
            }
        }
        
        public static bool addReservation(Reservation reservation)
        {
            reservation.id = reservationCount;
            
            if (!controlStartDateAndDate(reservation))
            {
                MessageBox.Show( "Please check reservation date interval!!!");
                return false;
            }
            if (!isDatesAvailableForRoom(reservation))
            {
                MessageBox.Show(reservation.room + " is not available for these dates !!!");
                return false;
            }
            reservationList.Add(reservation);
            reservationCount++;
            return true;
        }

        public static void deleteReservation(int id)
        {
            foreach(Reservation reservation in reservationList)
            {
                if(id == reservation.id)
                {
                    reservationList.Remove(reservation);
                    break;
                }
            }
            
        }

        public static void updateReservation(Reservation r)
        {
            foreach (Reservation reservation in reservationList)
            {
                if (r.id == reservation.id)
                {
                    reservation.name = r.name;
                    reservation.surname = r.surname;
                    reservation.phone = r.phone;
                    reservation.room = r.room;
                    reservation.end = r.end;
                    reservation.start = r.start;
                    break;
                }
            }
        }

        public static Reservation getReservation(int id)
        {
            foreach (Reservation reservation in reservationList)
            {
                if (id == reservation.id)
                {
                    return reservation;
                }
            }
            return null;
        }

        private static bool controlStartDateAndDate(Reservation reservation)
        {
            if(reservation.start.Date >= reservation.end.Date)
            {
                return false;
            }

            if (reservation.start.Date < DateTime.Today)
            {
                return false;
            }

            return true;

        }

        private static bool isDatesAvailableForRoom(Reservation reservation)
        {
            foreach(Reservation r in reservationList)
            {
                if(r.id!=reservation.id)
                {
                    if(r.room==reservation.room)
                    {
                        if( 
                            (r.start <= reservation.start && reservation.start < r.end)
                            || (r.start < reservation.end && reservation.end <= r.end)

                            )
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }


        public static ArrayList getReservationList(int room)
        {
            ArrayList list = new ArrayList();

            foreach (Reservation r in reservationList)
            {
                if (r.room.Equals("Room-"+room))
                {
                    list.Add(r);
                }
            }

            return list;
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

    }

    [Serializable]
    public class Reservation
    {
        public int id;
        public string name;
        public string surname;
        public string phone;
        public string room;
        public DateTime start;
        public DateTime end;
        private static Random random= new Random();
        public int nights {
            get {

                if (start==null || end == null || start > end) return 0;
                return (end.Date-start.Date).Days;
            }
            set { } }

        private int _billno;
        public int billNo
        {
            get
            {
                if (this._billno==0)
                {
                    this._billno= random.Next(222222222, 
                                         999999999);
                }
                return this._billno;
            }
            set { }
        }
        private DateTime _billDate;
        public DateTime billDate
        {
            get
            {
                if (this._billDate.Year==1)
                {
                    this._billDate= DateTime.Now;
                }
                return this._billDate;
            }
            set { }
        }

        public Reservation()
        { 
        
        }
    }
}

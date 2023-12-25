using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;


namespace WindowsFormsApp
{
    public partial class HOTEL_App2 : UserControl
    {
        public HOTEL_App2()
        {
            InitializeComponent();
            buttonList = new System.Collections.ArrayList();
            buttonList.Add(btn_HRoom1);
            buttonList.Add(btn_HRoom2);
            buttonList.Add(btn_HRoom3);
            buttonList.Add(btn_HRoom4);
            buttonList.Add(btn_HRoom5);
            buttonList.Add(btn_HRoom6);
            buttonList.Add(btn_HRoom7);
            buttonList.Add(btn_HRoom8);
            buttonList.Add(btn_HRoom9);
            buttonList.Add(btn_HRoom10);
        }
        bool _streaming;
        Capture _capture;
        private void streaming(object sender,System.EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            //picturePreview.Image = bmp;
        }
         public void Time()
        {
            h = DateTime.Now.Hour.ToString();
            m = DateTime.Now.Minute.ToString();
            s = DateTime.Now.Second.ToString();
            D = DateTime.Now.Day.ToString();
            M = DateTime.Now.Month.ToString();
            Y = DateTime.Now.Year.ToString();
        }
        public string PersonelAdi;
        public string PersonelSoyadi;
        public string PersonelId;
        public string PersonelVardiya;

        public string MüşteriAdi;
        public string MüşteriSoyadi;
        public string MüşteriOda;
        public string MüşteriGece;

        string
        h = "",
        m = "",
        s = "",
        D = "",
        M = "",
        Y = "";

        private void btn_HRoom1_Click(object sender, EventArgs e)
        {
            showReservationInfo(1);
        }

        private void btn_HRoom2_Click(object sender, EventArgs e)
        {
            showReservationInfo(2);
        }

        private void btn_HRoom3_Click(object sender, EventArgs e)
        {
            showReservationInfo(3);
        }

        private void btn_HRoom4_Click(object sender, EventArgs e)
        {
            showReservationInfo(4);
        }

        private void btn_HRoom5_Click(object sender, EventArgs e)
        {
            showReservationInfo(5);
        }

        private void btn_HRoom6_Click(object sender, EventArgs e)
        {
            showReservationInfo(6);
        }

        private void btn_HRoom7_Click(object sender, EventArgs e)
        {
            showReservationInfo(7);
        }

        private void btn_HRoom8_Click(object sender, EventArgs e)
        {
            showReservationInfo(8);
        }

        private void btn_HRoom9_Click(object sender, EventArgs e)
        {
            showReservationInfo(9);
        }

        private void btn_HRoom10_Click(object sender, EventArgs e)
        {
            showReservationInfo(10);
        }

        private void showReservationInfo(int room)
        {
            Reservation r = reservations[room-1];
            if (reservations[room-1] !=null)
            {
                MessageBox.Show("" +
                    "Reservation Id:   "+ r.id + "\n\n"+
                    "Customer Name:   "+ r.name + "\n\n"+
                    "Customer Surname:   "+ r.surname + "\n\n"+
                    "Start:   "+ r.start.ToShortDateString() + "\n\n"+
                    "End:   "+ r.end.ToShortDateString() + "\n\n"+
                    "","ROOM-"+room);
            }
        }


        private void HOTEL_App2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                RefreshRoomStates();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Reservation[] reservations = new Reservation[10];
        private void RefreshRoomStates()
        {
            DateTime now = DateTime.Now;
            resetAllRoomsButtons();
            foreach (Reservation r in Program.reservationList)
            {
                if(now >= r.start && now < r.end) {
                    int roomNo = Convert.ToInt16(r.room.Split("-".ToCharArray())[1]);
                    roomIsFull(roomNo) ;
                    reservations[roomNo-1] = r;
                }
            }
        }

        private void roomIsFull(int room)
        {
            ((Button)buttonList[room-1]).BackColor= Color.Red;
        }

        private void roomIsEmpty(int room)
        {
            ((Button)buttonList[room-1]).BackColor= Color.Green;
        }

        private void resetAllRoomsButtons()
        {
            for(int i=0;i<buttonList.Count;i++)
            {
                roomIsEmpty(i+1);
                reservations[i] = null;
            }
        }

        DateTime dt;
        private void HOTEL_App2_Load(object sender, EventArgs e)
        {
            
        }

        private void CustommerShear()
        {
            string k = "";
            Time();
            string[] Musteriler =
            {
                "Müşteri Adı = "+MüşteriAdi+"\n",
                "Müşteri Soyadı = "+MüşteriSoyadi+"\n",
                "MüşteriOda = "+MüşteriOda+"\n",
                "Müşteri Vardiyası = "+MüşteriGece+"\n",
                "Saat Kaç = "+h+"."+m+"."+s+"\n"
            };
            for (int i = 0; i < Musteriler.Length; i++)
            {
                k += Musteriler[i];
            }
            MessageBox.Show(k, "MEVCUT PERSONEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class RoomCalendar : Form
    {
        private string roomNo;
        public RoomCalendar(string roomNo)
        {
            InitializeComponent();
            this.roomNo = roomNo;
            this.labelRoomNo.Text = roomNo;
            /*this.monthCalendar1.SelectionStart = new DateTime(2024, 1, 1);
            this.monthCalendar1.SelectionEnd = new DateTime(2024, 12, 31);
            this.monthCalendar1.TodayDate= new DateTime(2024, 1, 1);
            this.monthCalendar1.SelectionEnd = new DateTime(2024, 1, 1);*/

            ArrayList list = Program.getReservationList(Convert.ToInt32( roomNo));

            foreach (Reservation r in list)
            {
                DateTime d = r.start;
                while(d <= r.end)
                {
                    this.monthCalendar1.AddBoldedDate(d);
                    d=d.AddDays(1);
                }
            }

        }


    }
}

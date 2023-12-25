using System;
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
    public partial class HOTEL_App1 : UserControl
    {
        HOTEL_App3 app3;
        public HOTEL_App1()
        {
            InitializeComponent();
        }

        private void app1_frm_pnl_HOTEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HOTEL_App1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;
        }

        private void btn_Reneval_Click(object sender, EventArgs e)
        {
            app3 = new HOTEL_App3();
            //DataGridViewRow 
            //foreach(List index in app3.customerTable.Rows)

        }

        public void refreshTable()
        {
            customerTable.Rows.Clear();
            foreach (Reservation reservation in Program.reservationList)
            {
                customerTable.Rows.Add(new object[] {
                    reservation.id+"",
                    reservation.name,
                    reservation.surname,
                    reservation.phone,
                    reservation.room,
                    reservation.start.ToShortDateString(),
                    reservation.end.ToShortDateString(),
                    reservation.nights+""
                });
            }
        }

        private void customerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow row = customerTable.Rows[e.RowIndex];
                string cellValue = row.Cells[0].Value.ToString();
                //MessageBox.Show(cellValue);
                BillForm billForm =  new BillForm(row);
                billForm.ShowDialog();
            }
        }
    }
}

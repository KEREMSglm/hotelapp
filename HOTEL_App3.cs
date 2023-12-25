using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp
{
    public partial class HOTEL_App3 : UserControl
    {
        internal object customerTabel;

        public HOTEL_App3()
        {
            InitializeComponent();
        }
        DataTable table;
        int SelectedRow;
        int selectedReservationId = 0;

        private void btn_BrCo_num_Click(object sender, EventArgs e)
        {
            string[][] a =
            {
                new string[] {txt_NAME+"\t"},
                new string[] {txt_SORNAME+"\t"}/*,
                new string[] {txt_ID+"\t"},
                new string[] {txt_NDur+"\t"},
                new string[] {txt_Spe+"\t"},
                new string[] {txt_Random+"\t"},
                new string[] {txt_SAdd+"\t"}*/
            };
            //string[] b = lbox_Costommers.Text.Split('\t');
            /*for(int i = 0;i< a.Length;i++)
            {
                if (b[5].ToString()==a[5].ToString())
                {
                    for(int j = 0;j < a.Length; i++)
                    {
                        b[j].Trim();
                        b[j] = a[j].ToString();
                    }
                }
            }*/
            
        }

        private void HOTEL_App3_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;

        }
        private void txt_NAME_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //table = new DataTable();
            /*customerTable.Rows.Add(new string[] { 
                txt_NAME.Text,
                txt_SORNAME.Text,
                txt_Phonenum.Text,
                comboBox1.Text,
                MonthC1.SelectionRange.Start.ToShortDateString(),
                MonthC1.SelectionRange.End.ToShortDateString()
            });*/
            //customerTable.DataSource = table;

            Reservation r = new Reservation();
            r.name= txt_NAME.Text;
            r.surname= txt_SORNAME.Text;
            r.phone= txt_Phonenum.Text;
            r.room= comboBox1.Text;
            r.start=startDate.Value;
            r.end=endDate.Value;
            if (Program.addReservation(r))
            {
                refreshTable();
                resetForm();
            }

            
            


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow nrow = customerTable.Rows[SelectedRow];
            nrow.Cells[0].Value = txt_NAME.Text;
            nrow.Cells[1].Value = txt_SORNAME.Text;
            nrow.Cells[2].Value = txt_Phonenum.Text;
            nrow.Cells[3].Value = txt_ROOM.Text;
            nrow.Cells[4].Value = txt_DATE.Text;*/

            Reservation r = new Reservation();
            r.id = selectedReservationId;
            r.name= txt_NAME.Text;
            r.surname= txt_SORNAME.Text;
            r.phone= txt_Phonenum.Text;
            r.room= comboBox1.Text;
            r.start=startDate.Value;
            r.end=endDate.Value;

            Program.updateReservation(r);
            refreshTable();
            resetForm();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Program.deleteReservation(selectedReservationId);
            refreshTable();
            resetForm();
            //table= new DataTable();

            //SelectedRow = customerTabel.CurrentCell.RowIndex;
            //customerTabel.Rows.RemoveAt(SelectedRow);
        }

        private void customerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (SelectedRow<0)
            {
                clearSelection();
                return;
            }
            DataGridViewRow row = customerTable.Rows[SelectedRow];
            if(row.Cells[0].Value == null)
            {
                clearSelection();
                return;
            }
            /*txt_NAME.Text = row.Cells[1].Value.ToString();
            txt_SORNAME.Text = row.Cells[2].Value.ToString();
            txt_Phonenum.Text = row.Cells[3].Value.ToString();
            txt_ROOM.Text = row.Cells[4].Value.ToString();
            txt_DATE.Text = row.Cells[5].Value.ToString();*/
            selectedReservationId =  Int32.Parse(row.Cells[0].Value.ToString());
            refreshForm();
        }

        private void txt_Phonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        public void refreshTable()
        {
            customerTable.Rows.Clear();
            foreach(Reservation reservation in Program.reservationList)
            {
                customerTable.Rows.Add(new object[] {
                    reservation.id+"",
                    reservation.name,
                    reservation.surname,
                    reservation.phone,
                    reservation.room,
                    reservation.start.ToShortDateString(),
                    reservation.end.ToShortDateString(),
                    reservation.nights+"", new Button()
                }) ;
            }
        }

        private void resetForm()
        {
            txt_NAME.Text = "";
            txt_SORNAME.Text = "";
            txt_Phonenum.Text = "";
            comboBox1.Text="";
            startDate.Value=DateTime.Now;
            endDate.Value= DateTime.Now;
        }

        private void refreshForm()
        {
            resetForm();
            if (selectedReservationId!=0)
            {
                Reservation reservation = Program.getReservation(selectedReservationId);
                if (reservation!=null)
                {
                    refreshForm(reservation);
                }
            }
        }

        private void refreshForm(Reservation reservation)
        {
            if (reservation == null || reservation.id<=0) return;
            txt_NAME.Text = reservation.name;
            txt_SORNAME.Text = reservation.surname;
            txt_Phonenum.Text = reservation.phone;
            comboBox1.Text=reservation.room;
            startDate.Value=reservation.start;
            endDate.Value= reservation.end;
        }

        private void clearSelection()
        {
            selectedReservationId=-1;
            customerTable.ClearSelection();
            resetForm();
            refreshTable();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            resetForm();
            refreshTable();
            clearSelection();
        }
    }
}

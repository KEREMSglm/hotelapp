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
    public partial class BillForm : Form
    {
        DataGridViewRow row;
        public BillForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            loadComponents();
        }

        private void loadComponents()
        {
            Reservation r = Program.getReservation(Convert.ToInt32(this.row.Cells[0].Value.ToString()));


            this.name.Text=r.name;
            this.surname.Text=r.surname;
            this.reservationId.Text=r.id.ToString();
            this.days.Text=r.nights.ToString();
            this.payment.Text= (r.nights*123).ToString();
            this.date.Text = r.billDate.ToShortDateString();
            this.no.Text = r.billNo.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void print_Click(object sender, EventArgs e)
        {
            this.print.Hide();
            Graphics g = this.CreateGraphics();
            this.bmp= new Bitmap(this.Size.Width,this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            Size s = new Size(this.Size.Width-40, this.Size.Height-70);
            mg.CopyFromScreen(this.Location.X+20,this.Location.Y+50,0,0,s);
            printPreviewDialog1.ShowDialog();
            this.print.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }
    }
}

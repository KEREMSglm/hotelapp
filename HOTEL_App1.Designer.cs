namespace WindowsFormsApp
{
    partial class HOTEL_App1
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
            this.app1_frm_pnl2_HOTEL = new System.Windows.Forms.Panel();
            this.app1_frm_pnl1_ = new System.Windows.Forms.TableLayoutPanel();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridViewButtonColumn();
            this.app1_frm_pnl2_HOTEL.SuspendLayout();
            this.app1_frm_pnl1_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // app1_frm_pnl2_HOTEL
            // 
            this.app1_frm_pnl2_HOTEL.BackColor = System.Drawing.Color.Transparent;
            this.app1_frm_pnl2_HOTEL.Controls.Add(this.app1_frm_pnl1_);
            this.app1_frm_pnl2_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app1_frm_pnl2_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.app1_frm_pnl2_HOTEL.Name = "app1_frm_pnl2_HOTEL";
            this.app1_frm_pnl2_HOTEL.Size = new System.Drawing.Size(1095, 605);
            this.app1_frm_pnl2_HOTEL.TabIndex = 2;
            // 
            // app1_frm_pnl1_
            // 
            this.app1_frm_pnl1_.ColumnCount = 1;
            this.app1_frm_pnl1_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
            this.app1_frm_pnl1_.Controls.Add(this.customerTable, 0, 0);
            this.app1_frm_pnl1_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app1_frm_pnl1_.Location = new System.Drawing.Point(0, 0);
            this.app1_frm_pnl1_.Name = "app1_frm_pnl1_";
            this.app1_frm_pnl1_.RowCount = 1;
            this.app1_frm_pnl1_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.app1_frm_pnl1_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.app1_frm_pnl1_.Size = new System.Drawing.Size(1095, 605);
            this.app1_frm_pnl1_.TabIndex = 0;
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToOrderColumns = true;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.surname,
            this.phone,
            this.room,
            this.checkin,
            this.checkout,
            this.days,
            this.Bill});
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTable.Location = new System.Drawing.Point(3, 3);
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            this.customerTable.Size = new System.Drawing.Size(1089, 599);
            this.customerTable.TabIndex = 9;
            this.customerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "SURNAME";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "PHONE";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // room
            // 
            this.room.HeaderText = "ROOM";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // checkin
            // 
            this.checkin.HeaderText = "CHECK IN";
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Width = 150;
            // 
            // checkout
            // 
            this.checkout.HeaderText = "CHECK OUT";
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Width = 150;
            // 
            // days
            // 
            this.days.HeaderText = "DAYS";
            this.days.Name = "days";
            this.days.ReadOnly = true;
            // 
            // Bill
            // 
            this.Bill.HeaderText = "BILL";
            this.Bill.Name = "Bill";
            this.Bill.ReadOnly = true;
            this.Bill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Bill.Text = "Bill";
            this.Bill.UseColumnTextForButtonValue = true;
            this.Bill.Width = 40;
            // 
            // HOTEL_App1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.app1_frm_pnl2_HOTEL);
            this.Name = "HOTEL_App1";
            this.Size = new System.Drawing.Size(1095, 605);
            this.Load += new System.EventHandler(this.HOTEL_App1_Load);
            this.app1_frm_pnl2_HOTEL.ResumeLayout(false);
            this.app1_frm_pnl1_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel app1_frm_pnl2_HOTEL;
        private System.Windows.Forms.TableLayoutPanel app1_frm_pnl1_;
        public System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewButtonColumn Bill;
    }
}

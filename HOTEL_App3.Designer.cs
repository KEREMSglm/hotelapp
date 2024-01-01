namespace WindowsFormsApp
{
    partial class HOTEL_App3
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
            this.app3_frm_pnl2_HOTEL = new System.Windows.Forms.Panel();
            this.app3_frm_pnl2_tblp2_HOTEL = new System.Windows.Forms.TableLayoutPanel();
            this.tblp1_tblp2_HOTEL = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phonenum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_NAME = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Sorname = new System.Windows.Forms.Label();
            this.txt_SORNAME = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.app3_frm_pnl1_HOTEL = new System.Windows.Forms.Panel();
            this.app3_frm_pnl1_tblp1_HOTEL = new System.Windows.Forms.TableLayoutPanel();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.app3_frm_pnl2_HOTEL.SuspendLayout();
            this.app3_frm_pnl2_tblp2_HOTEL.SuspendLayout();
            this.tblp1_tblp2_HOTEL.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.app3_frm_pnl1_HOTEL.SuspendLayout();
            this.app3_frm_pnl1_tblp1_HOTEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // app3_frm_pnl2_HOTEL
            // 
            this.app3_frm_pnl2_HOTEL.Controls.Add(this.app3_frm_pnl2_tblp2_HOTEL);
            this.app3_frm_pnl2_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app3_frm_pnl2_HOTEL.Location = new System.Drawing.Point(234, 0);
            this.app3_frm_pnl2_HOTEL.Name = "app3_frm_pnl2_HOTEL";
            this.app3_frm_pnl2_HOTEL.Size = new System.Drawing.Size(861, 605);
            this.app3_frm_pnl2_HOTEL.TabIndex = 0;
            // 
            // app3_frm_pnl2_tblp2_HOTEL
            // 
            this.app3_frm_pnl2_tblp2_HOTEL.ColumnCount = 1;
            this.app3_frm_pnl2_tblp2_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.81998F));
            this.app3_frm_pnl2_tblp2_HOTEL.Controls.Add(this.tblp1_tblp2_HOTEL, 0, 0);
            this.app3_frm_pnl2_tblp2_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app3_frm_pnl2_tblp2_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.app3_frm_pnl2_tblp2_HOTEL.Name = "app3_frm_pnl2_tblp2_HOTEL";
            this.app3_frm_pnl2_tblp2_HOTEL.RowCount = 1;
            this.app3_frm_pnl2_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.app3_frm_pnl2_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 605F));
            this.app3_frm_pnl2_tblp2_HOTEL.Size = new System.Drawing.Size(861, 605);
            this.app3_frm_pnl2_tblp2_HOTEL.TabIndex = 4;
            // 
            // tblp1_tblp2_HOTEL
            // 
            this.tblp1_tblp2_HOTEL.ColumnCount = 1;
            this.tblp1_tblp2_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp1_tblp2_HOTEL.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tblp1_tblp2_HOTEL.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tblp1_tblp2_HOTEL.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblp1_tblp2_HOTEL.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblp1_tblp2_HOTEL.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tblp1_tblp2_HOTEL.Controls.Add(this.customerTable, 0, 6);
            this.tblp1_tblp2_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblp1_tblp2_HOTEL.Location = new System.Drawing.Point(3, 3);
            this.tblp1_tblp2_HOTEL.Name = "tblp1_tblp2_HOTEL";
            this.tblp1_tblp2_HOTEL.RowCount = 7;
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblp1_tblp2_HOTEL.Size = new System.Drawing.Size(855, 599);
            this.tblp1_tblp2_HOTEL.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 727F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Room, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(849, 29);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Room.Location = new System.Drawing.Point(3, 0);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(116, 29);
            this.lbl_Room.TabIndex = 7;
            this.lbl_Room.Text = "Room";
            this.lbl_Room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Room-1",
            "Room-2",
            "Room-3",
            "Room-4",
            "Room-5",
            "Room-6",
            "Room-7",
            "Room-8",
            "Room-9",
            "Room-10"});
            this.comboBox1.Location = new System.Drawing.Point(125, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(721, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 727F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Phone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_Phonenum, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(849, 29);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Phone.Location = new System.Drawing.Point(3, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(116, 29);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "Phone";
            this.lbl_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Phonenum
            // 
            this.txt_Phonenum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Phonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Phonenum.Location = new System.Drawing.Point(125, 3);
            this.txt_Phonenum.Multiline = true;
            this.txt_Phonenum.Name = "txt_Phonenum";
            this.txt_Phonenum.Size = new System.Drawing.Size(721, 23);
            this.txt_Phonenum.TabIndex = 5;
            this.txt_Phonenum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phonenum_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.74794F));
            this.tableLayoutPanel1.Controls.Add(this.txt_NAME, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 29);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txt_NAME
            // 
            this.txt_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_NAME.Location = new System.Drawing.Point(123, 3);
            this.txt_NAME.Multiline = true;
            this.txt_NAME.Name = "txt_NAME";
            this.txt_NAME.Size = new System.Drawing.Size(723, 23);
            this.txt_NAME.TabIndex = 0;
            this.txt_NAME.TextChanged += new System.EventHandler(this.txt_NAME_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(114, 29);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 728F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Sorname, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_SORNAME, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(849, 29);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lbl_Sorname
            // 
            this.lbl_Sorname.AutoSize = true;
            this.lbl_Sorname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sorname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Sorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sorname.Location = new System.Drawing.Point(3, 0);
            this.lbl_Sorname.Name = "lbl_Sorname";
            this.lbl_Sorname.Size = new System.Drawing.Size(115, 29);
            this.lbl_Sorname.TabIndex = 2;
            this.lbl_Sorname.Text = "Surname";
            this.lbl_Sorname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SORNAME
            // 
            this.txt_SORNAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SORNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SORNAME.Location = new System.Drawing.Point(124, 3);
            this.txt_SORNAME.Multiline = true;
            this.txt_SORNAME.Name = "txt_SORNAME";
            this.txt_SORNAME.Size = new System.Drawing.Size(722, 23);
            this.txt_SORNAME.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7384F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.2616F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel5.Controls.Add(this.startDate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_Date, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.endDate, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(849, 29);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // startDate
            // 
            this.startDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startDate.Location = new System.Drawing.Point(120, 3);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(334, 30);
            this.startDate.TabIndex = 15;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Date.Location = new System.Drawing.Point(3, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(111, 29);
            this.lbl_Date.TabIndex = 8;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endDate
            // 
            this.endDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endDate.Location = new System.Drawing.Point(460, 3);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(386, 30);
            this.endDate.TabIndex = 14;
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
            this.days});
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTable.Location = new System.Drawing.Point(3, 213);
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            this.customerTable.Size = new System.Drawing.Size(849, 383);
            this.customerTable.TabIndex = 8;
            this.customerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellClick);
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // app3_frm_pnl1_HOTEL
            // 
            this.app3_frm_pnl1_HOTEL.Controls.Add(this.app3_frm_pnl1_tblp1_HOTEL);
            this.app3_frm_pnl1_HOTEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.app3_frm_pnl1_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.app3_frm_pnl1_HOTEL.Name = "app3_frm_pnl1_HOTEL";
            this.app3_frm_pnl1_HOTEL.Size = new System.Drawing.Size(234, 605);
            this.app3_frm_pnl1_HOTEL.TabIndex = 0;
            // 
            // app3_frm_pnl1_tblp1_HOTEL
            // 
            this.app3_frm_pnl1_tblp1_HOTEL.ColumnCount = 1;
            this.app3_frm_pnl1_tblp1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.app3_frm_pnl1_tblp1_HOTEL.Controls.Add(this.btn_del, 0, 2);
            this.app3_frm_pnl1_tblp1_HOTEL.Controls.Add(this.btn_Update, 0, 1);
            this.app3_frm_pnl1_tblp1_HOTEL.Controls.Add(this.btn_Add, 0, 0);
            this.app3_frm_pnl1_tblp1_HOTEL.Controls.Add(this.ResetBtn, 0, 3);
            this.app3_frm_pnl1_tblp1_HOTEL.Controls.Add(this.pictureBox1, 0, 4);
            this.app3_frm_pnl1_tblp1_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app3_frm_pnl1_tblp1_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.app3_frm_pnl1_tblp1_HOTEL.Name = "app3_frm_pnl1_tblp1_HOTEL";
            this.app3_frm_pnl1_tblp1_HOTEL.RowCount = 5;
            this.app3_frm_pnl1_tblp1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.app3_frm_pnl1_tblp1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.app3_frm_pnl1_tblp1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.app3_frm_pnl1_tblp1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.app3_frm_pnl1_tblp1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.app3_frm_pnl1_tblp1_HOTEL.Size = new System.Drawing.Size(234, 605);
            this.app3_frm_pnl1_tblp1_HOTEL.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_del.Location = new System.Drawing.Point(3, 192);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(228, 86);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(3, 98);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(228, 88);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(228, 89);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResetBtn.Location = new System.Drawing.Point(3, 284);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(228, 76);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources._1496677256_3_84637;
            this.pictureBox1.Location = new System.Drawing.Point(3, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HOTEL_App3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.app3_frm_pnl2_HOTEL);
            this.Controls.Add(this.app3_frm_pnl1_HOTEL);
            this.Name = "HOTEL_App3";
            this.Size = new System.Drawing.Size(1095, 605);
            this.Load += new System.EventHandler(this.HOTEL_App3_Load);
            this.app3_frm_pnl2_HOTEL.ResumeLayout(false);
            this.app3_frm_pnl2_tblp2_HOTEL.ResumeLayout(false);
            this.tblp1_tblp2_HOTEL.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.app3_frm_pnl1_HOTEL.ResumeLayout(false);
            this.app3_frm_pnl1_tblp1_HOTEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel app3_frm_pnl2_HOTEL;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TableLayoutPanel app3_frm_pnl2_tblp2_HOTEL;
        private System.Windows.Forms.TableLayoutPanel tblp1_tblp2_HOTEL;
        public System.Windows.Forms.TextBox txt_SORNAME;
        public System.Windows.Forms.TextBox txt_Phonenum;
        public System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.Panel app3_frm_pnl1_HOTEL;
        private System.Windows.Forms.TableLayoutPanel app3_frm_pnl1_tblp1_HOTEL;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Sorname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
    }
}

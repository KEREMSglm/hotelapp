namespace WindowsFormsApp
{
    partial class frm_HOTEL
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HOTEL));
            this.frm_pnl1_HOTEL = new System.Windows.Forms.Panel();
            this.frm_tblp_pnl1_HOTEL = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Mic = new System.Windows.Forms.Button();
            this.btn_Custommer_Bill = new System.Windows.Forms.Button();
            this.btn_Costomer_List = new System.Windows.Forms.Button();
            this.btn_Costommer_Add = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.frm_pnl2_HOTEL = new System.Windows.Forms.Panel();
            this.LstCommands = new System.Windows.Forms.ListBox();
            this.nfyi_HOTEL = new System.Windows.Forms.NotifyIcon(this.components);
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.hoteL_App2 = new WindowsFormsApp.HOTEL_App2();
            this.hoteL_App1 = new WindowsFormsApp.HOTEL_App1();
            this.hoteL_App0 = new WindowsFormsApp.HOTEL_App0();
            this.hoteL_App3 = new WindowsFormsApp.HOTEL_App3();
            this.frm_pnl1_HOTEL.SuspendLayout();
            this.frm_tblp_pnl1_HOTEL.SuspendLayout();
            this.frm_pnl2_HOTEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_pnl1_HOTEL
            // 
            this.frm_pnl1_HOTEL.Controls.Add(this.frm_tblp_pnl1_HOTEL);
            this.frm_pnl1_HOTEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.frm_pnl1_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.frm_pnl1_HOTEL.Name = "frm_pnl1_HOTEL";
            this.frm_pnl1_HOTEL.Size = new System.Drawing.Size(1095, 47);
            this.frm_pnl1_HOTEL.TabIndex = 0;
            // 
            // frm_tblp_pnl1_HOTEL
            // 
            this.frm_tblp_pnl1_HOTEL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frm_tblp_pnl1_HOTEL.ColumnCount = 8;
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.frm_tblp_pnl1_HOTEL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Mic, 5, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.button1, 6, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Custommer_Bill, 2, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Costomer_List, 1, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Costommer_Add, 0, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.txt_Search, 4, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Search, 3, 0);
            this.frm_tblp_pnl1_HOTEL.Controls.Add(this.btn_Home, 7, 0);
            this.frm_tblp_pnl1_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_tblp_pnl1_HOTEL.Location = new System.Drawing.Point(0, 0);
            this.frm_tblp_pnl1_HOTEL.Name = "frm_tblp_pnl1_HOTEL";
            this.frm_tblp_pnl1_HOTEL.RowCount = 1;
            this.frm_tblp_pnl1_HOTEL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.frm_tblp_pnl1_HOTEL.Size = new System.Drawing.Size(1095, 47);
            this.frm_tblp_pnl1_HOTEL.TabIndex = 0;
            this.frm_tblp_pnl1_HOTEL.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_tblp_pnl1_HOTEL_Paint);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Home.BackgroundImage = global::WindowsFormsApp.Properties.Resources.house_fill_page_1;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.Location = new System.Drawing.Point(986, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(106, 41);
            this.btn_Home.TabIndex = 8;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Mic
            // 
            this.btn_Mic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Mic.BackgroundImage = global::WindowsFormsApp.Properties.Resources.mic_page_1;
            this.btn_Mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Mic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Mic.Location = new System.Drawing.Point(878, 3);
            this.btn_Mic.Name = "btn_Mic";
            this.btn_Mic.Size = new System.Drawing.Size(48, 41);
            this.btn_Mic.TabIndex = 7;
            this.btn_Mic.UseVisualStyleBackColor = false;
            this.btn_Mic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mic_MouseDown);
            this.btn_Mic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mic_MouseUp);
            // 
            // btn_Custommer_Bill
            // 
            this.btn_Custommer_Bill.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Custommer_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Custommer_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Custommer_Bill.Location = new System.Drawing.Point(441, 3);
            this.btn_Custommer_Bill.Name = "btn_Custommer_Bill";
            this.btn_Custommer_Bill.Size = new System.Drawing.Size(213, 41);
            this.btn_Custommer_Bill.TabIndex = 3;
            this.btn_Custommer_Bill.Text = "Current States of Rooms";
            this.btn_Custommer_Bill.UseVisualStyleBackColor = false;
            this.btn_Custommer_Bill.Click += new System.EventHandler(this.btn_Costommer_Path_Click);
            // 
            // btn_Costomer_List
            // 
            this.btn_Costomer_List.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Costomer_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Costomer_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Costomer_List.Location = new System.Drawing.Point(222, 3);
            this.btn_Costomer_List.Name = "btn_Costomer_List";
            this.btn_Costomer_List.Size = new System.Drawing.Size(213, 41);
            this.btn_Costomer_List.TabIndex = 2;
            this.btn_Costomer_List.Text = "List of Reservations";
            this.btn_Costomer_List.UseVisualStyleBackColor = false;
            this.btn_Costomer_List.Click += new System.EventHandler(this.btn_Costomer_List_Click);
            // 
            // btn_Costommer_Add
            // 
            this.btn_Costommer_Add.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Costommer_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Costommer_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Costommer_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Costommer_Add.Name = "btn_Costommer_Add";
            this.btn_Costommer_Add.Size = new System.Drawing.Size(213, 41);
            this.btn_Costommer_Add.TabIndex = 1;
            this.btn_Costommer_Add.Text = "Add Reservation";
            this.btn_Costommer_Add.UseVisualStyleBackColor = false;
            this.btn_Costommer_Add.Click += new System.EventHandler(this.btn_Costommer_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_Search.Location = new System.Drawing.Point(714, 3);
            this.txt_Search.MaxLength = 10000;
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(158, 41);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Text = "Only Write Orders...";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Search.BackgroundImage = global::WindowsFormsApp.Properties.Resources.search_page_1;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.Location = new System.Drawing.Point(660, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(48, 41);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // frm_pnl2_HOTEL
            // 
            this.frm_pnl2_HOTEL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.frm_pnl2_HOTEL.Controls.Add(this.LstCommands);
            this.frm_pnl2_HOTEL.Controls.Add(this.hoteL_App2);
            this.frm_pnl2_HOTEL.Controls.Add(this.hoteL_App1);
            this.frm_pnl2_HOTEL.Controls.Add(this.hoteL_App0);
            this.frm_pnl2_HOTEL.Controls.Add(this.hoteL_App3);
            this.frm_pnl2_HOTEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_pnl2_HOTEL.Location = new System.Drawing.Point(0, 47);
            this.frm_pnl2_HOTEL.Name = "frm_pnl2_HOTEL";
            this.frm_pnl2_HOTEL.Size = new System.Drawing.Size(1095, 605);
            this.frm_pnl2_HOTEL.TabIndex = 0;
            // 
            // LstCommands
            // 
            this.LstCommands.FormattingEnabled = true;
            this.LstCommands.Location = new System.Drawing.Point(3, 3);
            this.LstCommands.Name = "LstCommands";
            this.LstCommands.Size = new System.Drawing.Size(120, 95);
            this.LstCommands.TabIndex = 4;
            this.LstCommands.Visible = false;
            // 
            // nfyi_HOTEL
            // 
            this.nfyi_HOTEL.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyi_HOTEL.Icon")));
            this.nfyi_HOTEL.Text = "HOTEL Applıcation Work";
            this.nfyi_HOTEL.Visible = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImage = global::WindowsFormsApp.Properties.Resources.mic_page_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(932, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 41);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // hoteL_App2
            // 
            this.hoteL_App2.BackColor = System.Drawing.Color.DimGray;
            this.hoteL_App2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoteL_App2.Location = new System.Drawing.Point(0, 0);
            this.hoteL_App2.Name = "hoteL_App2";
            this.hoteL_App2.Size = new System.Drawing.Size(1095, 605);
            this.hoteL_App2.TabIndex = 2;
            // 
            // hoteL_App1
            // 
            this.hoteL_App1.BackColor = System.Drawing.Color.DarkGray;
            this.hoteL_App1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoteL_App1.Location = new System.Drawing.Point(0, 0);
            this.hoteL_App1.Name = "hoteL_App1";
            this.hoteL_App1.Size = new System.Drawing.Size(1095, 605);
            this.hoteL_App1.TabIndex = 1;
            // 
            // hoteL_App0
            // 
            this.hoteL_App0.BackColor = System.Drawing.Color.DarkGray;
            this.hoteL_App0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoteL_App0.Location = new System.Drawing.Point(0, 0);
            this.hoteL_App0.Name = "hoteL_App0";
            this.hoteL_App0.Size = new System.Drawing.Size(1095, 605);
            this.hoteL_App0.TabIndex = 0;
            // 
            // hoteL_App3
            // 
            this.hoteL_App3.BackColor = System.Drawing.Color.DarkGray;
            this.hoteL_App3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoteL_App3.Location = new System.Drawing.Point(0, 0);
            this.hoteL_App3.Name = "hoteL_App3";
            this.hoteL_App3.Size = new System.Drawing.Size(1095, 605);
            this.hoteL_App3.TabIndex = 3;
            // 
            // frm_HOTEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 652);
            this.Controls.Add(this.frm_pnl2_HOTEL);
            this.Controls.Add(this.frm_pnl1_HOTEL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_HOTEL";
            this.Text = "HOTEL APPLICATION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HOTEL_FormClosing);
            this.Load += new System.EventHandler(this.frm_HOTEL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_HOTEL_KeyDown);
            this.frm_pnl1_HOTEL.ResumeLayout(false);
            this.frm_tblp_pnl1_HOTEL.ResumeLayout(false);
            this.frm_tblp_pnl1_HOTEL.PerformLayout();
            this.frm_pnl2_HOTEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel frm_pnl1_HOTEL;
        private System.Windows.Forms.TableLayoutPanel frm_tblp_pnl1_HOTEL;
        private System.Windows.Forms.Button btn_Custommer_Bill;
        private System.Windows.Forms.Button btn_Costomer_List;
        private System.Windows.Forms.Button btn_Costommer_Add;
        private System.Windows.Forms.Panel frm_pnl2_HOTEL;
        public System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Mic;
        private HOTEL_App0 hoteL_App0;
        private HOTEL_App3 hoteL_App3;
        private HOTEL_App1 hoteL_App1;
        private System.Windows.Forms.NotifyIcon nfyi_HOTEL;
        private System.Windows.Forms.Timer TmrSpeaking;
        private System.Windows.Forms.ListBox LstCommands;
        private HOTEL_App2 hoteL_App2;
        private System.Windows.Forms.Button button1;
    }
}


namespace WindowsFormsApp
{
    partial class RoomCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No :";
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.BackColor = System.Drawing.Color.White;
            this.labelRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRoomNo.Location = new System.Drawing.Point(407, 0);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(133, 30);
            this.labelRoomNo.TabIndex = 1;
            this.labelRoomNo.Text = "...............";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 4);
            this.monthCalendar1.CausesValidation = false;
            this.monthCalendar1.ForeColor = System.Drawing.Color.Red;
            this.monthCalendar1.Location = new System.Drawing.Point(-4, 0);
            this.monthCalendar1.MaxSelectionCount = 366;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.TodayDate = new System.DateTime(((long)(0)));
            // 
            // RoomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 587);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "RoomCalendar";
            this.Text = "RoomCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
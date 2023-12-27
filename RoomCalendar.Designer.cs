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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No :";
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Location = new System.Drawing.Point(78, 13);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(52, 13);
            this.labelRoomNo.TabIndex = 1;
            this.labelRoomNo.Text = "...............";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 12, 1, 0, 0, 0, 0),
        new System.DateTime(2023, 12, 29, 0, 0, 0, 0)};
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(3, 4);
            this.monthCalendar.Location = new System.Drawing.Point(42, 48);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar.TitleForeColor = System.Drawing.Color.Red;
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.Yellow;
            this.monthCalendar.UseWaitCursor = true;
            // 
            // RoomCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 683);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.label1);
            this.Name = "RoomCalendar";
            this.Text = "RoomCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}
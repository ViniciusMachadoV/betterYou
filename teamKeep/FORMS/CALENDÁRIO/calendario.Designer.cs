namespace teamKeep
{
    partial class calendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tblLembretes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCalendario = new System.Windows.Forms.Panel();
            this.lblSemLembretes = new System.Windows.Forms.Label();
            this.pnlCalendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(76, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // tblLembretes
            // 
            this.tblLembretes.AutoScroll = true;
            this.tblLembretes.Location = new System.Drawing.Point(0, 0);
            this.tblLembretes.Name = "tblLembretes";
            this.tblLembretes.Size = new System.Drawing.Size(580, 325);
            this.tblLembretes.TabIndex = 8;
            // 
            // pnlCalendario
            // 
            this.pnlCalendario.Controls.Add(this.tblLembretes);
            this.pnlCalendario.Location = new System.Drawing.Point(10, 184);
            this.pnlCalendario.Name = "pnlCalendario";
            this.pnlCalendario.Size = new System.Drawing.Size(580, 325);
            this.pnlCalendario.TabIndex = 9;
            // 
            // lblSemLembretes
            // 
            this.lblSemLembretes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemLembretes.ForeColor = System.Drawing.Color.White;
            this.lblSemLembretes.Location = new System.Drawing.Point(0, 320);
            this.lblSemLembretes.Name = "lblSemLembretes";
            this.lblSemLembretes.Size = new System.Drawing.Size(600, 20);
            this.lblSemLembretes.TabIndex = 10;
            this.lblSemLembretes.Text = "Você não possui compromissos registrados";
            this.lblSemLembretes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSemLembretes.Visible = false;
            // 
            // calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.lblSemLembretes);
            this.Controls.Add(this.pnlCalendario);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calendario";
            this.Text = "calendario";
            this.pnlCalendario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel tblLembretes;
        private System.Windows.Forms.Panel pnlCalendario;
        private System.Windows.Forms.Label lblSemLembretes;

    }
}
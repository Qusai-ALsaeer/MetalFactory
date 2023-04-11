namespace Acco.Model
{
    partial class Start
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_close = new System.Windows.Forms.ToolStripMenuItem();
            this.التعاريفالرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMP_cars = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_Car = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جدولالعملاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.S_Label_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.S_Label_prog = new System.Windows.Forms.ToolStripStatusLabel();
            this.S_Label_database = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.التعاريفالرئيسيةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_close});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // SM_close
            // 
            this.SM_close.Name = "SM_close";
            this.SM_close.Size = new System.Drawing.Size(100, 22);
            this.SM_close.Text = "إغلاق";
            this.SM_close.Click += new System.EventHandler(this.SM_close_Click);
            // 
            // التعاريفالرئيسيةToolStripMenuItem
            // 
            this.التعاريفالرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMP_cars,
            this.العملاتToolStripMenuItem});
            this.التعاريفالرئيسيةToolStripMenuItem.Name = "التعاريفالرئيسيةToolStripMenuItem";
            this.التعاريفالرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.التعاريفالرئيسيةToolStripMenuItem.Text = "التعاريف الرئيسية";
            // 
            // SMP_cars
            // 
            this.SMP_cars.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_Car});
            this.SMP_cars.Name = "SMP_cars";
            this.SMP_cars.Size = new System.Drawing.Size(180, 22);
            this.SMP_cars.Text = "السيارات";
            // 
            // SM_Car
            // 
            this.SM_Car.Name = "SM_Car";
            this.SM_Car.Size = new System.Drawing.Size(180, 22);
            this.SM_Car.Text = "جدول السيارات";
            this.SM_Car.Click += new System.EventHandler(this.SM_Car_Click);
            // 
            // العملاتToolStripMenuItem
            // 
            this.العملاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جدولالعملاتToolStripMenuItem});
            this.العملاتToolStripMenuItem.Name = "العملاتToolStripMenuItem";
            this.العملاتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.العملاتToolStripMenuItem.Text = "العملات";
            // 
            // جدولالعملاتToolStripMenuItem
            // 
            this.جدولالعملاتToolStripMenuItem.Name = "جدولالعملاتToolStripMenuItem";
            this.جدولالعملاتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.جدولالعملاتToolStripMenuItem.Text = "جدول العملات";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S_Label_date,
            this.S_Label_prog,
            this.S_Label_database});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // S_Label_date
            // 
            this.S_Label_date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.S_Label_date.Name = "S_Label_date";
            this.S_Label_date.Size = new System.Drawing.Size(32, 17);
            this.S_Label_date.Text = "date";
            // 
            // S_Label_prog
            // 
            this.S_Label_prog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.S_Label_prog.Name = "S_Label_prog";
            this.S_Label_prog.Size = new System.Drawing.Size(33, 17);
            this.S_Label_prog.Text = "prog";
            // 
            // S_Label_database
            // 
            this.S_Label_database.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.S_Label_database.Name = "S_Label_database";
            this.S_Label_database.Size = new System.Drawing.Size(87, 17);
            this.S_Label_database.Text = "databasename";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Start_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SM_close;
        private System.Windows.Forms.ToolStripMenuItem التعاريفالرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMP_cars;
        private System.Windows.Forms.ToolStripMenuItem SM_Car;
        private System.Windows.Forms.ToolStripMenuItem العملاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جدولالعملاتToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel S_Label_date;
        private System.Windows.Forms.ToolStripStatusLabel S_Label_prog;
        private System.Windows.Forms.ToolStripStatusLabel S_Label_database;
    }
}
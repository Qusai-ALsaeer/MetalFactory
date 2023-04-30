namespace Acco.Forms
{
    partial class Connection
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.networkAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.localAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.passwordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.userTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.connectButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Browse_btn = new DevExpress.XtraEditors.SimpleButton();
            this.txt_cr = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_databasename = new DevExpress.XtraEditors.TextEdit();
            this.radioBtn_openolddatabase = new System.Windows.Forms.RadioButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.radioBtn_creatnewdatabase = new System.Windows.Forms.RadioButton();
            this.Creat_btn = new DevExpress.XtraEditors.SimpleButton();
            this.attach_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_databasename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.networkAuthRadioButton);
            this.groupControl1.Controls.Add(this.localAuthRadioButton);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.databaseComboBox);
            this.groupControl1.Controls.Add(this.serverComboBox);
            this.groupControl1.Location = new System.Drawing.Point(12, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(325, 151);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الاتصال";
            // 
            // networkAuthRadioButton
            // 
            this.networkAuthRadioButton.AutoSize = true;
            this.networkAuthRadioButton.Location = new System.Drawing.Point(112, 58);
            this.networkAuthRadioButton.Name = "networkAuthRadioButton";
            this.networkAuthRadioButton.Size = new System.Drawing.Size(165, 17);
            this.networkAuthRadioButton.TabIndex = 5;
            this.networkAuthRadioButton.TabStop = true;
            this.networkAuthRadioButton.Text = "المصادقة على الشبكة المحلية";
            this.networkAuthRadioButton.UseVisualStyleBackColor = true;
            this.networkAuthRadioButton.CheckedChanged += new System.EventHandler(this.networkAuthRadioButton_CheckedChanged);
            // 
            // localAuthRadioButton
            // 
            this.localAuthRadioButton.AutoSize = true;
            this.localAuthRadioButton.Location = new System.Drawing.Point(105, 32);
            this.localAuthRadioButton.Name = "localAuthRadioButton";
            this.localAuthRadioButton.Size = new System.Drawing.Size(172, 17);
            this.localAuthRadioButton.TabIndex = 4;
            this.localAuthRadioButton.TabStop = true;
            this.localAuthRadioButton.Text = "المصادقة على الكمبيوتر المحلي";
            this.localAuthRadioButton.UseVisualStyleBackColor = true;
            this.localAuthRadioButton.CheckedChanged += new System.EventHandler(this.localAuthRadioButton_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(214, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "اسم قاعدة البيانات";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(214, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "اسم السيرفر";
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Location = new System.Drawing.Point(60, 116);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.Size = new System.Drawing.Size(136, 21);
            this.databaseComboBox.TabIndex = 1;
            // 
            // serverComboBox
            // 
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(60, 87);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(136, 21);
            this.serverComboBox.TabIndex = 0;
            this.serverComboBox.SelectedValueChanged += new System.EventHandler(this.serverComboBox_SelectedValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.passwordTextBox);
            this.groupControl2.Controls.Add(this.userTextBox);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(12, 309);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(325, 96);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "بيانات المصادقة للسيرفر";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(60, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(136, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(60, 36);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(136, 20);
            this.userTextBox.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(214, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "كلمة المرور";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(214, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "اسم المستخدم";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(259, 413);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "اتصال";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 413);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Browse_btn);
            this.groupControl3.Controls.Add(this.txt_cr);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.txt_databasename);
            this.groupControl3.Controls.Add(this.radioBtn_openolddatabase);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.radioBtn_creatnewdatabase);
            this.groupControl3.Location = new System.Drawing.Point(12, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(324, 143);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "انشاء قاعدة بيانات";
            // 
            // Browse_btn
            // 
            this.Browse_btn.ImageOptions.Image = global::Acco.Properties.Resources.open_16x16;
            this.Browse_btn.Location = new System.Drawing.Point(60, 50);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Browse_btn.Size = new System.Drawing.Size(31, 23);
            this.Browse_btn.TabIndex = 9;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // txt_cr
            // 
            this.txt_cr.Location = new System.Drawing.Point(5, 86);
            this.txt_cr.Name = "txt_cr";
            this.txt_cr.Size = new System.Drawing.Size(218, 20);
            this.txt_cr.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(229, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "مكان الحفظ";
            // 
            // txt_databasename
            // 
            this.txt_databasename.Location = new System.Drawing.Point(105, 53);
            this.txt_databasename.Name = "txt_databasename";
            this.txt_databasename.Size = new System.Drawing.Size(116, 20);
            this.txt_databasename.TabIndex = 7;
            // 
            // radioBtn_openolddatabase
            // 
            this.radioBtn_openolddatabase.AutoSize = true;
            this.radioBtn_openolddatabase.Location = new System.Drawing.Point(134, 121);
            this.radioBtn_openolddatabase.Name = "radioBtn_openolddatabase";
            this.radioBtn_openolddatabase.Size = new System.Drawing.Size(143, 17);
            this.radioBtn_openolddatabase.TabIndex = 6;
            this.radioBtn_openolddatabase.TabStop = true;
            this.radioBtn_openolddatabase.Text = "فتح قاعدة موجودة مسباقا";
            this.radioBtn_openolddatabase.UseVisualStyleBackColor = true;
            this.radioBtn_openolddatabase.CheckedChanged += new System.EventHandler(this.radioBtn_openolddatabase_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(227, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "اسم قاعدة البيانات";
            // 
            // radioBtn_creatnewdatabase
            // 
            this.radioBtn_creatnewdatabase.AutoSize = true;
            this.radioBtn_creatnewdatabase.Location = new System.Drawing.Point(140, 26);
            this.radioBtn_creatnewdatabase.Name = "radioBtn_creatnewdatabase";
            this.radioBtn_creatnewdatabase.Size = new System.Drawing.Size(137, 17);
            this.radioBtn_creatnewdatabase.TabIndex = 5;
            this.radioBtn_creatnewdatabase.TabStop = true;
            this.radioBtn_creatnewdatabase.Text = "انشاء قاعدة بيانات جديدة";
            this.radioBtn_creatnewdatabase.UseVisualStyleBackColor = true;
            this.radioBtn_creatnewdatabase.CheckedChanged += new System.EventHandler(this.radioBtn_creatnewdatabase_CheckedChanged);
            // 
            // Creat_btn
            // 
            this.Creat_btn.Location = new System.Drawing.Point(176, 413);
            this.Creat_btn.Name = "Creat_btn";
            this.Creat_btn.Size = new System.Drawing.Size(75, 23);
            this.Creat_btn.TabIndex = 8;
            this.Creat_btn.Text = "انشاء";
            this.Creat_btn.Click += new System.EventHandler(this.Creat_btn_Click);
            // 
            // attach_btn
            // 
            this.attach_btn.Location = new System.Drawing.Point(95, 413);
            this.attach_btn.Name = "attach_btn";
            this.attach_btn.Size = new System.Drawing.Size(75, 23);
            this.attach_btn.TabIndex = 9;
            this.attach_btn.Text = "ربط";
            this.attach_btn.Click += new System.EventHandler(this.attach_btn_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 445);
            this.Controls.Add(this.attach_btn);
            this.Controls.Add(this.Creat_btn);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_databasename.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox databaseComboBox;
        private System.Windows.Forms.ComboBox serverComboBox;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit passwordTextBox;
        private DevExpress.XtraEditors.TextEdit userTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton connectButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.RadioButton networkAuthRadioButton;
        private System.Windows.Forms.RadioButton localAuthRadioButton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txt_cr;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_databasename;
        private System.Windows.Forms.RadioButton radioBtn_openolddatabase;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton radioBtn_creatnewdatabase;
        private DevExpress.XtraEditors.SimpleButton Creat_btn;
        private DevExpress.XtraEditors.SimpleButton Browse_btn;
        private DevExpress.XtraEditors.SimpleButton attach_btn;
    }
}
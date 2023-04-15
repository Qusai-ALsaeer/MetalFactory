namespace Acco.Forms
{
    partial class Jop
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.tb_jopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_jop_nam = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_jop = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForjop_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_jop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljop_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jop_nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_jop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForjop_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(352, 71);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "نوع العمل";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_jop_nam);
            this.dataLayoutControl1.DataSource = this.tb_jopBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(348, 46);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_jopBindingSource, "id_jop", true));
            this.txt_id.Location = new System.Drawing.Point(227, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Properties.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(52, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_jopBindingSource
            // 
            this.tb_jopBindingSource.DataSource = typeof(Acco.Model.tb_jop);
            // 
            // txt_jop_nam
            // 
            this.txt_jop_nam.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_jopBindingSource, "jop_name", true));
            this.txt_jop_nam.Location = new System.Drawing.Point(12, 12);
            this.txt_jop_nam.Name = "txt_jop_nam";
            this.txt_jop_nam.Size = new System.Drawing.Size(154, 20);
            this.txt_jop_nam.StyleController = this.dataLayoutControl1;
            this.txt_jop_nam.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(348, 46);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_jop,
            this.ItemForjop_name});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(328, 26);
            // 
            // ItemForid_jop
            // 
            this.ItemForid_jop.Control = this.txt_id;
            this.ItemForid_jop.Location = new System.Drawing.Point(215, 0);
            this.ItemForid_jop.Name = "ItemForid_jop";
            this.ItemForid_jop.Size = new System.Drawing.Size(113, 26);
            this.ItemForid_jop.Text = "الرقم";
            this.ItemForid_jop.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForjop_name
            // 
            this.ItemForjop_name.Control = this.txt_jop_nam;
            this.ItemForjop_name.Location = new System.Drawing.Point(0, 0);
            this.ItemForjop_name.Name = "ItemForjop_name";
            this.ItemForjop_name.Size = new System.Drawing.Size(215, 26);
            this.ItemForjop_name.Text = "نوع العمل";
            this.ItemForjop_name.TextSize = new System.Drawing.Size(45, 13);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 87);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(352, 278);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول نوع العمل";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_jopBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(348, 253);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_jop,
            this.coljop_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_jop
            // 
            this.colid_jop.Caption = "الرقم";
            this.colid_jop.FieldName = "id_jop";
            this.colid_jop.Name = "colid_jop";
            this.colid_jop.Visible = true;
            this.colid_jop.VisibleIndex = 0;
            this.colid_jop.Width = 55;
            // 
            // coljop_name
            // 
            this.coljop_name.Caption = "نوع العمل";
            this.coljop_name.FieldName = "jop_name";
            this.coljop_name.Name = "coljop_name";
            this.coljop_name.Visible = true;
            this.coljop_name.VisibleIndex = 1;
            this.coljop_name.Width = 270;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(23, 371);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 17;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(106, 371);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 16;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(189, 371);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 15;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(272, 371);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 14;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Jop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 409);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Jop";
            this.Text = "Jop";
            this.Load += new System.EventHandler(this.Jop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_jopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jop_nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_jop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForjop_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource tb_jopBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_jop_nam;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_jop;
        private DevExpress.XtraLayout.LayoutControlItem ItemForjop_name;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_jop;
        private DevExpress.XtraGrid.Columns.GridColumn coljop_name;
    }
}
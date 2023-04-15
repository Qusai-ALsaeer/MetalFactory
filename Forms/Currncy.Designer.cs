namespace Acco.Forms
{
    partial class Currncy
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
            this.tb_currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_sym = new DevExpress.XtraEditors.TextEdit();
            this.txt_part = new DevExpress.XtraEditors.TextEdit();
            this.txt_iso = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_cur_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_cur_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_cur_sym = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_cur_part = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_cur_iso = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcu_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcu_sym = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcu_part = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcu_iso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sym.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_part.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_sym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_part)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_iso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(439, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(219, 249);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات العملة";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_name);
            this.dataLayoutControl1.Controls.Add(this.txt_sym);
            this.dataLayoutControl1.Controls.Add(this.txt_part);
            this.dataLayoutControl1.Controls.Add(this.txt_iso);
            this.dataLayoutControl1.DataSource = this.tb_currencyBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(215, 224);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_currencyBindingSource, "id_cu", true));
            this.txt_id.Location = new System.Drawing.Point(74, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Size = new System.Drawing.Size(63, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_currencyBindingSource
            // 
            this.tb_currencyBindingSource.DataSource = typeof(Acco.Model.tb_currency);
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_currencyBindingSource, "cu_name", true));
            this.txt_name.Location = new System.Drawing.Point(12, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(125, 20);
            this.txt_name.StyleController = this.dataLayoutControl1;
            this.txt_name.TabIndex = 5;
            // 
            // txt_sym
            // 
            this.txt_sym.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_currencyBindingSource, "cu_sym", true));
            this.txt_sym.Location = new System.Drawing.Point(12, 60);
            this.txt_sym.Name = "txt_sym";
            this.txt_sym.Size = new System.Drawing.Size(125, 20);
            this.txt_sym.StyleController = this.dataLayoutControl1;
            this.txt_sym.TabIndex = 6;
            // 
            // txt_part
            // 
            this.txt_part.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_currencyBindingSource, "cu_part", true));
            this.txt_part.Location = new System.Drawing.Point(12, 84);
            this.txt_part.Name = "txt_part";
            this.txt_part.Size = new System.Drawing.Size(125, 20);
            this.txt_part.StyleController = this.dataLayoutControl1;
            this.txt_part.TabIndex = 7;
            // 
            // txt_iso
            // 
            this.txt_iso.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_currencyBindingSource, "cu_iso", true));
            this.txt_iso.Location = new System.Drawing.Point(12, 108);
            this.txt_iso.Name = "txt_iso";
            this.txt_iso.Size = new System.Drawing.Size(125, 20);
            this.txt_iso.StyleController = this.dataLayoutControl1;
            this.txt_iso.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(215, 224);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txt_cur_id,
            this.txt_cur_name,
            this.txt_cur_sym,
            this.txt_cur_part,
            this.txt_cur_iso,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(195, 204);
            // 
            // txt_cur_id
            // 
            this.txt_cur_id.Control = this.txt_id;
            this.txt_cur_id.Location = new System.Drawing.Point(62, 0);
            this.txt_cur_id.Name = "txt_cur_id";
            this.txt_cur_id.Size = new System.Drawing.Size(133, 24);
            this.txt_cur_id.Text = "الرقم";
            this.txt_cur_id.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txt_cur_name
            // 
            this.txt_cur_name.Control = this.txt_name;
            this.txt_cur_name.Location = new System.Drawing.Point(0, 24);
            this.txt_cur_name.Name = "txt_cur_name";
            this.txt_cur_name.Size = new System.Drawing.Size(195, 24);
            this.txt_cur_name.Text = "اسم العملة";
            this.txt_cur_name.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txt_cur_sym
            // 
            this.txt_cur_sym.Control = this.txt_sym;
            this.txt_cur_sym.Location = new System.Drawing.Point(0, 48);
            this.txt_cur_sym.Name = "txt_cur_sym";
            this.txt_cur_sym.Size = new System.Drawing.Size(195, 24);
            this.txt_cur_sym.Text = "رمز العملة";
            this.txt_cur_sym.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txt_cur_part
            // 
            this.txt_cur_part.Control = this.txt_part;
            this.txt_cur_part.Location = new System.Drawing.Point(0, 72);
            this.txt_cur_part.Name = "txt_cur_part";
            this.txt_cur_part.Size = new System.Drawing.Size(195, 24);
            this.txt_cur_part.Text = "جزء العملة";
            this.txt_cur_part.TextSize = new System.Drawing.Size(54, 13);
            // 
            // txt_cur_iso
            // 
            this.txt_cur_iso.Control = this.txt_iso;
            this.txt_cur_iso.Location = new System.Drawing.Point(0, 96);
            this.txt_cur_iso.Name = "txt_cur_iso";
            this.txt_cur_iso.Size = new System.Drawing.Size(195, 108);
            this.txt_cur_iso.Text = "ISO";
            this.txt_cur_iso.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(62, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(421, 249);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول العملات";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_currencyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cu,
            this.colcu_name,
            this.colcu_sym,
            this.colcu_part,
            this.colcu_iso});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cu
            // 
            this.colid_cu.Caption = "الرقم";
            this.colid_cu.FieldName = "id_cu";
            this.colid_cu.Name = "colid_cu";
            this.colid_cu.Visible = true;
            this.colid_cu.VisibleIndex = 0;
            this.colid_cu.Width = 35;
            // 
            // colcu_name
            // 
            this.colcu_name.Caption = "اسم العملة";
            this.colcu_name.FieldName = "cu_name";
            this.colcu_name.Name = "colcu_name";
            this.colcu_name.Visible = true;
            this.colcu_name.VisibleIndex = 1;
            this.colcu_name.Width = 132;
            // 
            // colcu_sym
            // 
            this.colcu_sym.Caption = "رمز العملة";
            this.colcu_sym.FieldName = "cu_sym";
            this.colcu_sym.Name = "colcu_sym";
            this.colcu_sym.Visible = true;
            this.colcu_sym.VisibleIndex = 2;
            this.colcu_sym.Width = 68;
            // 
            // colcu_part
            // 
            this.colcu_part.Caption = "جزء العملة";
            this.colcu_part.FieldName = "cu_part";
            this.colcu_part.Name = "colcu_part";
            this.colcu_part.Visible = true;
            this.colcu_part.VisibleIndex = 3;
            this.colcu_part.Width = 83;
            // 
            // colcu_iso
            // 
            this.colcu_iso.Caption = "ISO";
            this.colcu_iso.FieldName = "cu_iso";
            this.colcu_iso.Name = "colcu_iso";
            this.colcu_iso.Visible = true;
            this.colcu_iso.VisibleIndex = 4;
            this.colcu_iso.Width = 57;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(130, 290);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 9;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(236, 290);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 8;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(338, 290);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 7;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(442, 290);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 6;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Currncy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 328);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Currncy";
            this.Text = "Currncy";
            this.Load += new System.EventHandler(this.Currncy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sym.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_part.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_sym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_part)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cur_iso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource tb_currencyBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.TextEdit txt_sym;
        private DevExpress.XtraEditors.TextEdit txt_part;
        private DevExpress.XtraEditors.TextEdit txt_iso;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem txt_cur_id;
        private DevExpress.XtraLayout.LayoutControlItem txt_cur_name;
        private DevExpress.XtraLayout.LayoutControlItem txt_cur_sym;
        private DevExpress.XtraLayout.LayoutControlItem txt_cur_part;
        private DevExpress.XtraLayout.LayoutControlItem txt_cur_iso;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cu;
        private DevExpress.XtraGrid.Columns.GridColumn colcu_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcu_sym;
        private DevExpress.XtraGrid.Columns.GridColumn colcu_part;
        private DevExpress.XtraGrid.Columns.GridColumn colcu_iso;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
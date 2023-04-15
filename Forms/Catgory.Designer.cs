namespace Acco.Forms
{
    partial class Catgory
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
            this.tb_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_cat_name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_cat = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForcat_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcat_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcat_name)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(337, 70);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الفئة";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_cat_name);
            this.dataLayoutControl1.DataSource = this.tb_categoryBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(333, 45);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_categoryBindingSource, "id_cat", true));
            this.txt_id.Location = new System.Drawing.Point(212, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Size = new System.Drawing.Size(73, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_categoryBindingSource
            // 
            this.tb_categoryBindingSource.DataSource = typeof(Acco.Model.tb_category);
            // 
            // txt_cat_name
            // 
            this.txt_cat_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_categoryBindingSource, "cat_name", true));
            this.txt_cat_name.Location = new System.Drawing.Point(12, 12);
            this.txt_cat_name.Name = "txt_cat_name";
            this.txt_cat_name.Size = new System.Drawing.Size(150, 20);
            this.txt_cat_name.StyleController = this.dataLayoutControl1;
            this.txt_cat_name.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(333, 45);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_cat,
            this.emptySpaceItem1,
            this.ItemForcat_name});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(313, 25);
            // 
            // ItemForid_cat
            // 
            this.ItemForid_cat.Control = this.txt_id;
            this.ItemForid_cat.Location = new System.Drawing.Point(200, 0);
            this.ItemForid_cat.Name = "ItemForid_cat";
            this.ItemForid_cat.Size = new System.Drawing.Size(113, 25);
            this.ItemForid_cat.Text = "الرقم";
            this.ItemForid_cat.TextSize = new System.Drawing.Size(24, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(190, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForcat_name
            // 
            this.ItemForcat_name.Control = this.txt_cat_name;
            this.ItemForcat_name.Location = new System.Drawing.Point(0, 0);
            this.ItemForcat_name.Name = "ItemForcat_name";
            this.ItemForcat_name.Size = new System.Drawing.Size(190, 25);
            this.ItemForcat_name.Text = "الفئة";
            this.ItemForcat_name.TextSize = new System.Drawing.Size(24, 13);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 88);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(337, 239);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول الفئات";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_categoryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(333, 214);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cat,
            this.colcat_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_cat
            // 
            this.colid_cat.Caption = "الرقم";
            this.colid_cat.FieldName = "id_cat";
            this.colid_cat.Name = "colid_cat";
            this.colid_cat.Visible = true;
            this.colid_cat.VisibleIndex = 0;
            this.colid_cat.Width = 50;
            // 
            // colcat_name
            // 
            this.colcat_name.Caption = "اسم الفئة";
            this.colcat_name.FieldName = "cat_name";
            this.colcat_name.Name = "colcat_name";
            this.colcat_name.Visible = true;
            this.colcat_name.VisibleIndex = 1;
            this.colcat_name.Width = 260;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(17, 340);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 13;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(100, 340);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 12;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(183, 340);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 11;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(266, 340);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 10;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Catgory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 377);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = global::Acco.Properties.Resources.boproduct_32x32;
            this.Name = "Catgory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catgory";
            this.Load += new System.EventHandler(this.Catgory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cat_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcat_name)).EndInit();
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
        private System.Windows.Forms.BindingSource tb_categoryBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_cat_name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_cat;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcat_name;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cat;
        private DevExpress.XtraGrid.Columns.GridColumn colcat_name;
    }
}
namespace Acco.Forms
{
    partial class Item
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
            this.tb_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lkp_id_cat = new DevExpress.XtraEditors.LookUpEdit();
            this.tb_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_u_name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_it = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForit_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForid_cat = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForu_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_it = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colit_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_id_cat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_u_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_it)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForit_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForu_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(363, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(240, 319);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات المادة";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_name);
            this.dataLayoutControl1.Controls.Add(this.lkp_id_cat);
            this.dataLayoutControl1.Controls.Add(this.txt_u_name);
            this.dataLayoutControl1.DataSource = this.tb_itemBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(236, 294);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_itemBindingSource, "id_it", true));
            this.txt_id.Location = new System.Drawing.Point(111, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.AllowFocused = false;
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Properties.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(50, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_itemBindingSource
            // 
            this.tb_itemBindingSource.DataSource = typeof(Acco.Model.tb_item);
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_itemBindingSource, "it_name", true));
            this.txt_name.Location = new System.Drawing.Point(12, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(149, 20);
            this.txt_name.StyleController = this.dataLayoutControl1;
            this.txt_name.TabIndex = 5;
            // 
            // lkp_id_cat
            // 
            this.lkp_id_cat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_itemBindingSource, "id_cat", true));
            this.lkp_id_cat.Location = new System.Drawing.Point(12, 60);
            this.lkp_id_cat.Name = "lkp_id_cat";
            this.lkp_id_cat.Properties.Appearance.Options.UseTextOptions = true;
            this.lkp_id_cat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lkp_id_cat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkp_id_cat.Properties.DataSource = this.tb_categoryBindingSource;
            this.lkp_id_cat.Properties.DisplayMember = "cat_name";
            this.lkp_id_cat.Properties.NullText = "";
            this.lkp_id_cat.Properties.ValueMember = "id_cat";
            this.lkp_id_cat.Size = new System.Drawing.Size(149, 20);
            this.lkp_id_cat.StyleController = this.dataLayoutControl1;
            this.lkp_id_cat.TabIndex = 6;
            // 
            // tb_categoryBindingSource
            // 
            this.tb_categoryBindingSource.DataSource = typeof(Acco.Model.tb_category);
            // 
            // txt_u_name
            // 
            this.txt_u_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_itemBindingSource, "u_name", true));
            this.txt_u_name.Location = new System.Drawing.Point(111, 84);
            this.txt_u_name.Name = "txt_u_name";
            this.txt_u_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txt_u_name.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_u_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_u_name.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_u_name.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_u_name.Properties.MaskSettings.Set("mask", "N0");
            this.txt_u_name.Properties.ReadOnly = true;
            this.txt_u_name.Size = new System.Drawing.Size(50, 20);
            this.txt_u_name.StyleController = this.dataLayoutControl1;
            this.txt_u_name.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(236, 294);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_it,
            this.ItemForit_name,
            this.ItemForid_cat,
            this.ItemForu_name,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(216, 274);
            // 
            // ItemForid_it
            // 
            this.ItemForid_it.Control = this.txt_id;
            this.ItemForid_it.Location = new System.Drawing.Point(99, 0);
            this.ItemForid_it.Name = "ItemForid_it";
            this.ItemForid_it.Size = new System.Drawing.Size(117, 24);
            this.ItemForid_it.Text = "م";
            this.ItemForid_it.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForit_name
            // 
            this.ItemForit_name.Control = this.txt_name;
            this.ItemForit_name.Location = new System.Drawing.Point(0, 24);
            this.ItemForit_name.Name = "ItemForit_name";
            this.ItemForit_name.Size = new System.Drawing.Size(216, 24);
            this.ItemForit_name.Text = "اسم المادة";
            this.ItemForit_name.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForid_cat
            // 
            this.ItemForid_cat.Control = this.lkp_id_cat;
            this.ItemForid_cat.Location = new System.Drawing.Point(0, 48);
            this.ItemForid_cat.Name = "ItemForid_cat";
            this.ItemForid_cat.Size = new System.Drawing.Size(216, 24);
            this.ItemForid_cat.Text = "الفئة";
            this.ItemForid_cat.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForu_name
            // 
            this.ItemForu_name.Control = this.txt_u_name;
            this.ItemForu_name.Location = new System.Drawing.Point(99, 72);
            this.ItemForu_name.Name = "ItemForu_name";
            this.ItemForu_name.Size = new System.Drawing.Size(117, 202);
            this.ItemForu_name.Text = "رقم المادة";
            this.ItemForu_name.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(99, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(99, 202);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(345, 319);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول المواد";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_itemBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(341, 294);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_it,
            this.colit_name,
            this.colid_cat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_it
            // 
            this.colid_it.Caption = "م";
            this.colid_it.FieldName = "id_it";
            this.colid_it.Name = "colid_it";
            this.colid_it.Visible = true;
            this.colid_it.VisibleIndex = 0;
            this.colid_it.Width = 49;
            // 
            // colit_name
            // 
            this.colit_name.Caption = "اسم المادة";
            this.colit_name.FieldName = "it_name";
            this.colit_name.Name = "colit_name";
            this.colit_name.Visible = true;
            this.colit_name.VisibleIndex = 1;
            this.colit_name.Width = 161;
            // 
            // colid_cat
            // 
            this.colid_cat.Caption = "رقم الفئة";
            this.colid_cat.FieldName = "id_cat";
            this.colid_cat.Name = "colid_cat";
            this.colid_cat.Visible = true;
            this.colid_cat.VisibleIndex = 2;
            this.colid_cat.Width = 108;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(148, 349);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 25;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(231, 349);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 24;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(314, 349);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 23;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(397, 349);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 22;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 384);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_id_cat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_u_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_it)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForit_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForu_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
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
        private System.Windows.Forms.BindingSource tb_itemBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LookUpEdit lkp_id_cat;
        private System.Windows.Forms.BindingSource tb_categoryBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_u_name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_it;
        private DevExpress.XtraLayout.LayoutControlItem ItemForit_name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_cat;
        private DevExpress.XtraLayout.LayoutControlItem ItemForu_name;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_it;
        private DevExpress.XtraGrid.Columns.GridColumn colit_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cat;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
namespace Acco.Forms
{
    partial class Cars
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
            this.tb_carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_car_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_car_num = new DevExpress.XtraEditors.TextEdit();
            this.txt_car_space = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_car = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcar_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcar_num = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcar_space = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_car = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcar_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcar_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcar_space = new DevExpress.XtraGrid.Columns.GridColumn();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_space.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_space)).BeginInit();
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
            this.groupControl1.Location = new System.Drawing.Point(433, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(253, 289);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات السيارة";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_car_name);
            this.dataLayoutControl1.Controls.Add(this.txt_car_num);
            this.dataLayoutControl1.Controls.Add(this.txt_car_space);
            this.dataLayoutControl1.DataSource = this.tb_carBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(249, 264);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_carBindingSource, "id_car", true));
            this.txt_id.Location = new System.Drawing.Point(115, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Size = new System.Drawing.Size(50, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_carBindingSource
            // 
            this.tb_carBindingSource.DataSource = typeof(Acco.Model.tb_car);
            // 
            // txt_car_name
            // 
            this.txt_car_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_carBindingSource, "car_name", true));
            this.txt_car_name.Location = new System.Drawing.Point(12, 36);
            this.txt_car_name.Name = "txt_car_name";
            this.txt_car_name.Size = new System.Drawing.Size(153, 20);
            this.txt_car_name.StyleController = this.dataLayoutControl1;
            this.txt_car_name.TabIndex = 5;
            // 
            // txt_car_num
            // 
            this.txt_car_num.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_carBindingSource, "car_num", true));
            this.txt_car_num.Location = new System.Drawing.Point(12, 60);
            this.txt_car_num.Name = "txt_car_num";
            this.txt_car_num.Size = new System.Drawing.Size(153, 20);
            this.txt_car_num.StyleController = this.dataLayoutControl1;
            this.txt_car_num.TabIndex = 6;
            // 
            // txt_car_space
            // 
            this.txt_car_space.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_carBindingSource, "car_space", true));
            this.txt_car_space.Location = new System.Drawing.Point(12, 84);
            this.txt_car_space.Name = "txt_car_space";
            this.txt_car_space.Size = new System.Drawing.Size(153, 20);
            this.txt_car_space.StyleController = this.dataLayoutControl1;
            this.txt_car_space.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(249, 264);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_car,
            this.ItemForcar_name,
            this.ItemForcar_num,
            this.ItemForcar_space,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(229, 244);
            // 
            // ItemForid_car
            // 
            this.ItemForid_car.Control = this.txt_id;
            this.ItemForid_car.Location = new System.Drawing.Point(103, 0);
            this.ItemForid_car.Name = "ItemForid_car";
            this.ItemForid_car.Size = new System.Drawing.Size(126, 24);
            this.ItemForid_car.Text = "الرقم";
            this.ItemForid_car.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForcar_name
            // 
            this.ItemForcar_name.Control = this.txt_car_name;
            this.ItemForcar_name.Location = new System.Drawing.Point(0, 24);
            this.ItemForcar_name.Name = "ItemForcar_name";
            this.ItemForcar_name.Size = new System.Drawing.Size(229, 24);
            this.ItemForcar_name.Text = "اسم السيارة";
            this.ItemForcar_name.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForcar_num
            // 
            this.ItemForcar_num.Control = this.txt_car_num;
            this.ItemForcar_num.Location = new System.Drawing.Point(0, 48);
            this.ItemForcar_num.Name = "ItemForcar_num";
            this.ItemForcar_num.Size = new System.Drawing.Size(229, 24);
            this.ItemForcar_num.Text = "رقم السيارة";
            this.ItemForcar_num.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForcar_space
            // 
            this.ItemForcar_space.Control = this.txt_car_space;
            this.ItemForcar_space.Location = new System.Drawing.Point(0, 72);
            this.ItemForcar_space.Name = "ItemForcar_space";
            this.ItemForcar_space.Size = new System.Drawing.Size(229, 172);
            this.ItemForcar_space.Text = "سعة الحمولة";
            this.ItemForcar_space.TextSize = new System.Drawing.Size(60, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(103, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(415, 289);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول السيارات";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_carBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(411, 264);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_car,
            this.colcar_name,
            this.colcar_num,
            this.colcar_space});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_car
            // 
            this.colid_car.Caption = "الرقم";
            this.colid_car.FieldName = "id_car";
            this.colid_car.Name = "colid_car";
            this.colid_car.Visible = true;
            this.colid_car.VisibleIndex = 0;
            this.colid_car.Width = 39;
            // 
            // colcar_name
            // 
            this.colcar_name.Caption = "اسم السيارة";
            this.colcar_name.FieldName = "car_name";
            this.colcar_name.Name = "colcar_name";
            this.colcar_name.Visible = true;
            this.colcar_name.VisibleIndex = 1;
            this.colcar_name.Width = 180;
            // 
            // colcar_num
            // 
            this.colcar_num.Caption = "رقم الحساب";
            this.colcar_num.FieldName = "car_num";
            this.colcar_num.Name = "colcar_num";
            this.colcar_num.Visible = true;
            this.colcar_num.VisibleIndex = 2;
            this.colcar_num.Width = 101;
            // 
            // colcar_space
            // 
            this.colcar_space.Caption = "السعة";
            this.colcar_space.FieldName = "car_space";
            this.colcar_space.Name = "colcar_space";
            this.colcar_space.Visible = true;
            this.colcar_space.VisibleIndex = 3;
            this.colcar_space.Width = 68;
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(454, 326);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 2;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(350, 326);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 3;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(142, 326);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 5;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(248, 326);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 4;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 363);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = global::Acco.Properties.Resources.transit_32x32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_car_space.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcar_space)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource tb_carBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_car_name;
        private DevExpress.XtraEditors.TextEdit txt_car_num;
        private DevExpress.XtraEditors.TextEdit txt_car_space;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_car;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcar_name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcar_num;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcar_space;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_car;
        private DevExpress.XtraGrid.Columns.GridColumn colcar_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcar_num;
        private DevExpress.XtraGrid.Columns.GridColumn colcar_space;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
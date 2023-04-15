namespace Acco.Forms
{
    partial class Final_Acco
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
            this.tb_finalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_f_num = new DevExpress.XtraEditors.TextEdit();
            this.txt_f_name = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_fin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForf_num = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForf_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_finalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_f_num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_f_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForf_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForf_name)).BeginInit();
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
            this.groupControl1.Location = new System.Drawing.Point(400, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(235, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الحساب الختامي";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_f_num);
            this.dataLayoutControl1.Controls.Add(this.txt_f_name);
            this.dataLayoutControl1.DataSource = this.tb_finalBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(231, 267);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_finalBindingSource, "id_fin", true));
            this.txt_id.Location = new System.Drawing.Point(100, 12);
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
            // tb_finalBindingSource
            // 
            this.tb_finalBindingSource.DataSource = typeof(Acco.Model.tb_final);
            // 
            // txt_f_num
            // 
            this.txt_f_num.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_finalBindingSource, "f_num", true));
            this.txt_f_num.Location = new System.Drawing.Point(12, 36);
            this.txt_f_num.Name = "txt_f_num";
            this.txt_f_num.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_f_num.Size = new System.Drawing.Size(138, 20);
            this.txt_f_num.StyleController = this.dataLayoutControl1;
            this.txt_f_num.TabIndex = 5;
            // 
            // txt_f_name
            // 
            this.txt_f_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_finalBindingSource, "f_name", true));
            this.txt_f_name.Location = new System.Drawing.Point(12, 60);
            this.txt_f_name.Name = "txt_f_name";
            this.txt_f_name.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_f_name.Size = new System.Drawing.Size(138, 20);
            this.txt_f_name.StyleController = this.dataLayoutControl1;
            this.txt_f_name.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(231, 267);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_fin,
            this.ItemForf_num,
            this.ItemForf_name,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(211, 247);
            // 
            // ItemForid_fin
            // 
            this.ItemForid_fin.Control = this.txt_id;
            this.ItemForid_fin.Location = new System.Drawing.Point(88, 0);
            this.ItemForid_fin.Name = "ItemForid_fin";
            this.ItemForid_fin.Size = new System.Drawing.Size(123, 24);
            this.ItemForid_fin.Text = "الرقم";
            this.ItemForid_fin.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForf_num
            // 
            this.ItemForf_num.Control = this.txt_f_num;
            this.ItemForf_num.Location = new System.Drawing.Point(0, 24);
            this.ItemForf_num.Name = "ItemForf_num";
            this.ItemForf_num.Size = new System.Drawing.Size(211, 24);
            this.ItemForf_num.Text = "رقم الحساب";
            this.ItemForf_num.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForf_name
            // 
            this.ItemForf_name.Control = this.txt_f_name;
            this.ItemForf_name.Location = new System.Drawing.Point(0, 48);
            this.ItemForf_name.Name = "ItemForf_name";
            this.ItemForf_name.Size = new System.Drawing.Size(211, 199);
            this.ItemForf_name.Text = "الاسم";
            this.ItemForf_name.TextSize = new System.Drawing.Size(57, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(88, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(382, 292);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول الحسابات الختامية";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_finalBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(378, 267);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_fin,
            this.colf_num,
            this.colf_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_fin
            // 
            this.colid_fin.Caption = "م";
            this.colid_fin.FieldName = "id_fin";
            this.colid_fin.Name = "colid_fin";
            this.colid_fin.Visible = true;
            this.colid_fin.VisibleIndex = 0;
            this.colid_fin.Width = 40;
            // 
            // colf_num
            // 
            this.colf_num.Caption = "الرقم";
            this.colf_num.FieldName = "f_num";
            this.colf_num.Name = "colf_num";
            this.colf_num.Visible = true;
            this.colf_num.VisibleIndex = 1;
            this.colf_num.Width = 66;
            // 
            // colf_name
            // 
            this.colf_name.Caption = "اسم الحساب الختامي";
            this.colf_name.FieldName = "f_name";
            this.colf_name.Name = "colf_name";
            this.colf_name.Visible = true;
            this.colf_name.VisibleIndex = 2;
            this.colf_name.Width = 249;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(129, 317);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 13;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(235, 317);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 12;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(337, 317);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 11;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(441, 317);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 10;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Final_Acco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 353);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Final_Acco";
            this.Text = "Final_Acco";
            this.Load += new System.EventHandler(this.Final_Acco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_finalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_f_num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_f_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForf_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForf_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private System.Windows.Forms.BindingSource tb_finalBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_f_num;
        private DevExpress.XtraEditors.TextEdit txt_f_name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_fin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForf_num;
        private DevExpress.XtraLayout.LayoutControlItem ItemForf_name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_fin;
        private DevExpress.XtraGrid.Columns.GridColumn colf_num;
        private DevExpress.XtraGrid.Columns.GridColumn colf_name;
    }
}
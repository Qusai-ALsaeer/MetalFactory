namespace Acco.Forms
{
    partial class Faran
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
            this.tb_franBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lkp_account = new DevExpress.XtraEditors.LookUpEdit();
            this.tb_accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForid_farn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForfar_name = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForid_Acco = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_farn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfar_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_Acco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repo_account = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.C_btn = new DevExpress.XtraEditors.SimpleButton();
            this.D_btn = new DevExpress.XtraEditors.SimpleButton();
            this.S_btn = new DevExpress.XtraEditors.SimpleButton();
            this.N_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_franBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_farn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfar_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_Acco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_account)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(366, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(224, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات الفرن";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.txt_name);
            this.dataLayoutControl1.Controls.Add(this.lkp_account);
            this.dataLayoutControl1.DataSource = this.tb_franBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 23);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(220, 267);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_franBindingSource, "id_farn", true));
            this.txt_id.Location = new System.Drawing.Point(87, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_id.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_id.Properties.MaskSettings.Set("mask", "N0");
            this.txt_id.Properties.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(60, 20);
            this.txt_id.StyleController = this.dataLayoutControl1;
            this.txt_id.TabIndex = 4;
            // 
            // tb_franBindingSource
            // 
            this.tb_franBindingSource.DataSource = typeof(Acco.Model.tb_fran);
            // 
            // txt_name
            // 
            this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_franBindingSource, "far_name", true));
            this.txt_name.Location = new System.Drawing.Point(12, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txt_name.Size = new System.Drawing.Size(135, 20);
            this.txt_name.StyleController = this.dataLayoutControl1;
            this.txt_name.TabIndex = 5;
            // 
            // lkp_account
            // 
            this.lkp_account.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tb_franBindingSource, "id_Acco", true));
            this.lkp_account.Location = new System.Drawing.Point(12, 60);
            this.lkp_account.Name = "lkp_account";
            this.lkp_account.Properties.Appearance.Options.UseTextOptions = true;
            this.lkp_account.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lkp_account.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkp_account.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ac_num", "الرقم", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ac_name", "اسم الحساب", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkp_account.Properties.DataSource = this.tb_accountBindingSource;
            this.lkp_account.Properties.DisplayMember = "ac_name";
            this.lkp_account.Properties.NullText = "";
            this.lkp_account.Properties.ValueMember = "id_ac";
            this.lkp_account.Size = new System.Drawing.Size(135, 20);
            this.lkp_account.StyleController = this.dataLayoutControl1;
            this.lkp_account.TabIndex = 6;
            // 
            // tb_accountBindingSource
            // 
            this.tb_accountBindingSource.DataSource = typeof(Acco.Model.tb_account);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(220, 267);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_farn,
            this.ItemForfar_name,
            this.ItemForid_Acco,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(200, 247);
            // 
            // ItemForid_farn
            // 
            this.ItemForid_farn.Control = this.txt_id;
            this.ItemForid_farn.Location = new System.Drawing.Point(75, 0);
            this.ItemForid_farn.Name = "ItemForid_farn";
            this.ItemForid_farn.Size = new System.Drawing.Size(125, 24);
            this.ItemForid_farn.Text = "الرقم";
            this.ItemForid_farn.TextSize = new System.Drawing.Size(49, 13);
            // 
            // ItemForfar_name
            // 
            this.ItemForfar_name.Control = this.txt_name;
            this.ItemForfar_name.Location = new System.Drawing.Point(0, 24);
            this.ItemForfar_name.Name = "ItemForfar_name";
            this.ItemForfar_name.Size = new System.Drawing.Size(200, 24);
            this.ItemForfar_name.Text = "اسم الفرن";
            this.ItemForfar_name.TextSize = new System.Drawing.Size(49, 13);
            // 
            // ItemForid_Acco
            // 
            this.ItemForid_Acco.Control = this.lkp_account;
            this.ItemForid_Acco.Location = new System.Drawing.Point(0, 48);
            this.ItemForid_Acco.Name = "ItemForid_Acco";
            this.ItemForid_Acco.Size = new System.Drawing.Size(200, 199);
            this.ItemForid_Acco.Text = "الحساب";
            this.ItemForid_Acco.TextSize = new System.Drawing.Size(49, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(75, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(348, 294);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "جدول الافران";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tb_franBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repo_account});
            this.gridControl1.Size = new System.Drawing.Size(344, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_farn,
            this.colfar_name,
            this.colid_Acco});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_farn
            // 
            this.colid_farn.Caption = "الرقم";
            this.colid_farn.FieldName = "id_farn";
            this.colid_farn.Name = "colid_farn";
            this.colid_farn.Visible = true;
            this.colid_farn.VisibleIndex = 0;
            this.colid_farn.Width = 39;
            // 
            // colfar_name
            // 
            this.colfar_name.Caption = "اسم الفرن";
            this.colfar_name.FieldName = "far_name";
            this.colfar_name.Name = "colfar_name";
            this.colfar_name.Visible = true;
            this.colfar_name.VisibleIndex = 1;
            this.colfar_name.Width = 105;
            // 
            // colid_Acco
            // 
            this.colid_Acco.Caption = "اسم الحساب";
            this.colid_Acco.ColumnEdit = this.repo_account;
            this.colid_Acco.FieldName = "id_Acco";
            this.colid_Acco.Name = "colid_Acco";
            this.colid_Acco.Visible = true;
            this.colid_Acco.VisibleIndex = 2;
            this.colid_Acco.Width = 105;
            // 
            // repo_account
            // 
            this.repo_account.AutoHeight = false;
            this.repo_account.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repo_account.Name = "repo_account";
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(108, 310);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 23);
            this.C_btn.TabIndex = 13;
            this.C_btn.Text = "اغلاق";
            this.C_btn.Click += new System.EventHandler(this.C_btn_Click);
            // 
            // D_btn
            // 
            this.D_btn.Location = new System.Drawing.Point(214, 310);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(75, 23);
            this.D_btn.TabIndex = 12;
            this.D_btn.Text = "حذف";
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // S_btn
            // 
            this.S_btn.Location = new System.Drawing.Point(316, 310);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(75, 23);
            this.S_btn.TabIndex = 11;
            this.S_btn.Text = "حفظ";
            this.S_btn.Click += new System.EventHandler(this.S_btn_Click);
            // 
            // N_btn
            // 
            this.N_btn.Location = new System.Drawing.Point(420, 310);
            this.N_btn.Name = "N_btn";
            this.N_btn.Size = new System.Drawing.Size(75, 23);
            this.N_btn.TabIndex = 10;
            this.N_btn.Text = "جديد";
            this.N_btn.Click += new System.EventHandler(this.N_btn_Click);
            // 
            // Faran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.N_btn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = global::Acco.Properties.Resources.pictureshapefillcolor_32x32;
            this.Name = "Faran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول الافران";
            this.Load += new System.EventHandler(this.Faran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_franBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_farn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfar_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_Acco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource tb_franBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton C_btn;
        private DevExpress.XtraEditors.SimpleButton D_btn;
        private DevExpress.XtraEditors.SimpleButton S_btn;
        private DevExpress.XtraEditors.SimpleButton N_btn;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LookUpEdit lkp_account;
        private System.Windows.Forms.BindingSource tb_accountBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_farn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfar_name;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_Acco;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_farn;
        private DevExpress.XtraGrid.Columns.GridColumn colfar_name;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Acco;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repo_account;
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Acco.Model;
using System.Data.Entity.Migrations;

namespace Acco.Forms
{
    public partial class Item : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_item ItemData;
        public Item()
        {
            InitializeComponent();

            dbContext.tb_item.Load();
            tb_itemBindingSource.DataSource = dbContext.tb_item.Local.ToBindingList();

            dbContext.tb_category.Load();
            tb_categoryBindingSource.DataSource = dbContext.tb_category.Local.ToBindingList();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            RefreshData();
            gridView1.RowCellStyle += GridView1_RowCellStyle;
        }
        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // تحديد لون الخلفية للصفوف الفردية
            if (e.RowHandle % 2 == 1)
            {
                e.Appearance.BackColor = Color.LightGray;
            }
            // تحديد لون الخلفية للصفوف الزوجية
            else
            {
                e.Appearance.BackColor = Color.White;
            }
        }

        private void RefreshData()
        {
            tb_itemBindingSource .DataSource = dbContext.tb_item .ToList();
            tb_categoryBindingSource .DataSource = dbContext.tb_category .ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_item.Any())
            {
                maxID = dbContext.tb_item.Max(c => c.id_it );
            }
            return maxID + 1;
        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            ItemData = new tb_item()
            {
                id_it   = GetMaxID(),
                id_cat =1

            };
            tb_itemBindingSource .DataSource = ItemData;
            gridControl1.DataSource = dbContext.tb_item.ToList();
        }

        private void S_btn_Click(object sender, EventArgs e)
        {
            if (txt_id.EditValue == null || txt_id.EditValue == DBNull.Value)
            {
                MessageBox.Show("ان الجدول فارغ .. يجب اضافة حقل جديد");
                this.N_btn_Click(sender, e);
            }
            else
            {
                var _id = Convert.ToInt32(txt_id.EditValue);
                var max = GetMaxID();

                using (Model1 dbContext = new Model1())
                {
                    DialogResult dialogResult = XtraMessageBox.Show("هل تريد حفظ البيانات؟", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (max == _id)  // اذا كان الصف جديد
                        {
                            ItemData.it_name   = txt_name.EditValue.ToString();
                            ItemData.cat_name    =Convert .ToInt32( lkp_id_cat .EditValue);


                            dbContext.tb_item .AddOrUpdate(ItemData);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_itemBindingSource .DataSource = ItemData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var ItemED = dbContext.tb_item.SingleOrDefault(p => p.id_it == _id);
                            ItemED.it_name = txt_name.EditValue.ToString();
                            ItemED.cat_name = Convert.ToInt32(lkp_id_cat.EditValue);
                            dbContext.tb_item.AddOrUpdate(ItemED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_itemBindingSource.DataSource = ItemED;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();
                gridControl1.DataSource = dbContext.tb_item.ToList();


                N_btn.Enabled = true;
                D_btn.Enabled = true;
                C_btn.Enabled = true;
            }

        }

        private void D_btn_Click(object sender, EventArgs e)
        {
            var _id = Convert.ToInt32(txt_id.EditValue);
            var max = GetMaxID();

            using (Model1 dbContext = new Model1())
            {
                DialogResult dialogResult = XtraMessageBox.Show("هل تريد حذف البيانات البيانات؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {

                    // اذا كان الصف قديم
                    var ItemED = dbContext.tb_item.SingleOrDefault(p => p.id_it == _id);

                    dbContext.tb_item.Remove(ItemED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_itemBindingSource .DataSource = ItemData;
            gridControl1.DataSource = dbContext.tb_item.ToList();

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
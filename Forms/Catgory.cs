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
    public partial class Catgory : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_category CatagoryData;
        public Catgory()
        {
            InitializeComponent();
            dbContext.tb_category.Load();
            tb_categoryBindingSource.DataSource = dbContext.tb_category.Local.ToBindingList();
        }

        private void Catgory_Load(object sender, EventArgs e)
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
            tb_categoryBindingSource.DataSource = dbContext.tb_category.ToList();
        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            CatagoryData = new tb_category()
            {
                id_cat = GetMaxID()

            };
            tb_categoryBindingSource.DataSource = CatagoryData;
            gridControl1.DataSource = dbContext.tb_category.ToList();
        }

        private void S_btn_Click(object sender, EventArgs e)
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
                       CatagoryData.cat_name = txt_cat_name.EditValue.ToString();
                      

                        dbContext.tb_category.AddOrUpdate(CatagoryData);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();

                    }
                    else
                    {
                        // اذا كان الصف قديم
                        var CatED = dbContext.tb_category.SingleOrDefault(p => p.id_cat == _id);
                        CatED.cat_name = txt_cat_name.EditValue.ToString();
                     
                        dbContext.tb_category.AddOrUpdate(CatED);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_categoryBindingSource.DataSource = dbContext.tb_category.ToList();
            gridControl1.DataSource = tb_categoryBindingSource;


            N_btn.Enabled = true;
            D_btn.Enabled = true;
            C_btn.Enabled = true;
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
                    var CatED = dbContext.tb_category.SingleOrDefault(p => p.id_cat == _id);

                    dbContext.tb_category.Remove(CatED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_categoryBindingSource.DataSource = dbContext.tb_category.ToList();
            gridControl1.DataSource = tb_categoryBindingSource;

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_category.Any())
            {
                maxID = dbContext.tb_category.Max(c => c.id_cat);
            }
            return maxID + 1;
        }

    }
}
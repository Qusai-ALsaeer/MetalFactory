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
using DevExpress.Utils.VisualEffects;
using System.Runtime.Remoting.Contexts;

namespace Acco.Forms
{
    public partial class Final_Acco : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_final FinalData;

        public Final_Acco()
        {
            InitializeComponent();

            dbContext.tb_final.Load();
            tb_finalBindingSource.DataSource = dbContext.tb_final.Local.ToBindingList();

        }

        private void Final_Acco_Load(object sender, EventArgs e)
        {
            if(dbContext.tb_final.Count() == 0)
            {
                MessageBox.Show("جدول الحسابات الختامية فارغ.. سيتم اضافة الحسابات الختامية");
                AddDefultAccount();
                MessageBox.Show("تمت اضافة الحسابات الختامية بنجاح");

            }
            else
            {
                dbContext.tb_final.Load();
                tb_finalBindingSource.DataSource = dbContext.tb_final.Local.ToBindingList();
            }
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
            tb_finalBindingSource.DataSource = dbContext.tb_final.ToList();
        }
        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            FinalData = new tb_final()
            {
                id_fin = GetMaxID()

            };
            tb_finalBindingSource.DataSource = FinalData;
            gridControl1.DataSource = dbContext.tb_final.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_final.Any())
            {
                maxID = dbContext.tb_final.Max(c => c.id_fin);
            }
            return maxID + 1;
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
                        FinalData.f_num = txt_f_num.Text;
                        FinalData.f_name = txt_f_name.Text;
                        dbContext.tb_final.AddOrUpdate(FinalData);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();

                    }
                    else
                    {
                        // اذا كان الصف قديم
                        var FinalED = dbContext.tb_final.SingleOrDefault(p => p.id_fin == _id);
                       FinalED.f_num = txt_f_num.Text;
                       FinalED.f_name = txt_f_name.Text;
                        dbContext.tb_final.AddOrUpdate(FinalED);
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
            tb_finalBindingSource.DataSource = dbContext.tb_final.ToList();
            gridControl1.DataSource = tb_finalBindingSource;


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
                    var FinalED = dbContext.tb_final.SingleOrDefault(p => p.id_fin == _id);

                    dbContext.tb_final.Remove(FinalED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_finalBindingSource.DataSource = dbContext.tb_final.ToList();
            gridControl1.DataSource = tb_finalBindingSource;


        }
        private void AddDefultAccount()
        {
            using (var db = new Model1())
            {
                if (!db.tb_final.Any())
                {
                    db.tb_final.AddRange(new List<tb_final>()
        {
            new tb_final() { f_num = "1000", f_name = "الأصول الثابتة" },
            new tb_final() { f_num = "2000", f_name = "المخزون" },
            new tb_final() { f_num = "3000", f_name = "المدفوعات المقدمة" },
            new tb_final() { f_num = "4000", f_name = "الحسابات المدينة" },
            new tb_final() { f_num = "5000", f_name = "المبيعات" },
            new tb_final() { f_num = "6000", f_name = "المصروفات" },
            new tb_final() { f_num = "7000", f_name = "الحسابات الدائنة" },
            new tb_final() { f_num = "8000", f_name = "رأس المال" },
            new tb_final() { f_num = "9000", f_name = "الأرباح والخسائر" }
        });

                    db.SaveChanges();
                }
            }

        }
        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
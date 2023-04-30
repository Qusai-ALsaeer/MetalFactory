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
using DevExpress.XtraEditors.Repository;

namespace Acco.Forms
{
    public partial class Faran : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_fran FarnData;
        public Faran()
        {
            InitializeComponent();

            dbContext.tb_fran.Load();
            tb_franBindingSource.DataSource = dbContext.tb_fran.Local.ToBindingList();

            dbContext.tb_account.Load();
            tb_accountBindingSource.DataSource = dbContext.tb_account.Local.Where(d => d.ac_type == false).ToList();
        }

        private void Faran_Load(object sender, EventArgs e)
        {
            RefreshData();
            InitionReopAccount();
            gridView1.RowCellStyle += GridView1_RowCellStyle;

        }
        private void InitionReopAccount()
        {
            repo_account.DataSource = dbContext.tb_account.Select(ac => new
            {
                ac.ac_name,
                ac.id_ac
            }).ToList();
            repo_account.DisplayMember = nameof(tb_account.ac_name);
            repo_account.ValueMember = nameof(tb_account.id_ac).ToString();
            repo_account.NullText = "";
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
            tb_franBindingSource.DataSource = dbContext.tb_fran.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_fran.Any())
            {
                maxID = dbContext.tb_fran.Max(c => c.id_farn);
            }
            return maxID + 1;
        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            FarnData = new tb_fran()
            {
                id_farn = GetMaxID()

            };
            tb_franBindingSource.DataSource = FarnData;
            gridControl1.DataSource = dbContext.tb_fran.ToList();
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
                            FarnData.far_name = txt_name.EditValue.ToString();
                            FarnData.id_Acco = Convert.ToInt32(lkp_account.EditValue);


                            dbContext.tb_fran.AddOrUpdate(FarnData);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_franBindingSource.DataSource = FarnData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var FarnED = dbContext.tb_fran.SingleOrDefault(p => p.id_farn == _id);
                            FarnED.far_name = txt_name.EditValue.ToString();
                            FarnED.id_Acco = Convert.ToInt32(lkp_account.EditValue);

                            dbContext.tb_fran.AddOrUpdate(FarnED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_franBindingSource.DataSource = FarnED;
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();
                gridControl1.DataSource = dbContext.tb_fran.ToList();


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
                    var FarnED = dbContext.tb_fran.SingleOrDefault(p => p.id_farn == _id);

                    dbContext.tb_fran.Remove(FarnED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_franBindingSource.DataSource = dbContext.tb_fran.ToList();
            gridControl1.DataSource = tb_franBindingSource;

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
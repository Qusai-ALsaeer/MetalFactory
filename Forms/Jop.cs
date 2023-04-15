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
    public partial class Jop : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_jop JobData;
        public Jop()
        {
            InitializeComponent();
            dbContext.tb_jop.Load();
            tb_jopBindingSource.DataSource = dbContext.tb_jop.Local.ToBindingList();
        }

        private void Jop_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            tb_jopBindingSource.DataSource = dbContext.tb_jop.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_jop.Any())
            {
                maxID = dbContext.tb_jop.Max(c => c.id_jop);
            }
            return maxID + 1;
        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            JobData = new tb_jop()
            {
                id_jop = GetMaxID()

            };
            tb_jopBindingSource.DataSource = JobData;
            gridControl1.DataSource = dbContext.tb_jop.ToList();
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
                            JobData.jop_name = txt_jop_nam.Text;


                            dbContext.tb_jop.AddOrUpdate(JobData);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_jopBindingSource.DataSource = JobData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var JopED = dbContext.tb_jop.SingleOrDefault(p => p.id_jop == _id);
                            JopED.jop_name = txt_jop_nam.EditValue.ToString();

                            dbContext.tb_jop.AddOrUpdate(JopED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_jopBindingSource.DataSource = JopED;
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();
                gridControl1.DataSource = dbContext.tb_jop.ToList();


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
                    var JopED = dbContext.tb_jop.SingleOrDefault(p => p.id_jop == _id);

                    dbContext.tb_jop.Remove(JopED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_jopBindingSource.DataSource = JobData;
            gridControl1.DataSource = dbContext.tb_jop.ToList();

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
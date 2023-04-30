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
using System.Runtime.Remoting.Contexts;

namespace Acco.Forms
{
    public partial class Motion : DevExpress.XtraEditors.XtraForm
    {
         Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_motion MotionData;
        public Motion()
        {
            InitializeComponent();
        }
        private void Motion_Load(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                if (db.tb_motion.Count() == 0)
                {
                    MessageBox.Show("جدول الحركات فارغ.. سيتم اضافة الحركات الافتراضية");
                    AddDefaultAccounts(db);
                }
                else
                {
                    LoadAccountsFromDatabase(db);
                }
            }

            RefreshData();
            gridView1.RowCellStyle += GridView1_RowCellStyle;
        }

        private void AddDefaultAccounts(Model1 db)
        {
            tb_motion pay = new tb_motion();
            pay.mo_name = "مدفوعات";
            db.tb_motion.Add(pay);

            tb_motion recive = new tb_motion();
            recive.mo_name = "مقبوضات";
            db.tb_motion.Add(recive);

            tb_motion purchace = new tb_motion();
            purchace.mo_name = "مشتريات";
            db.tb_motion.Add(purchace);

            tb_motion repurchace = new tb_motion();
            repurchace.mo_name = "مرتجع مشتريات";
            db.tb_motion.Add(repurchace);

            tb_motion sales = new tb_motion();
            sales.mo_name = "مبيعات";
            db.tb_motion.Add(sales);

            tb_motion resales = new tb_motion();
            resales.mo_name = "مرتجع مبيعات";
            db.tb_motion.Add(resales);

            tb_motion tranc = new tb_motion();
            tranc.mo_name = "سند قيد";
            db.tb_motion.Add(tranc);

            tb_motion com = new tb_motion();
            com.mo_name = "ايرادات";
            db.tb_motion.Add(com);

            tb_motion panssev = new tb_motion();
            panssev.mo_name = "مصاريف";
            db.tb_motion.Add(panssev);

            db.SaveChanges();

            LoadAccountsFromDatabase(db);
        }

        private void LoadAccountsFromDatabase(Model1 db)
        {
            // جلب الحسابات من قاعدة البيانات وعرضها في النموذج
            db.tb_motion.Load();
            tb_motionBindingSource.DataSource = db.tb_motion.Local.ToBindingList();
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
            tb_motionBindingSource.DataSource = dbContext.tb_motion.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_motion.Any())
            {
                maxID = dbContext.tb_motion.Max(c => c.id_mo);
            }
            return maxID + 1;
        }
        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            MotionData = new tb_motion()
            {
                id_mo = GetMaxID(),

            };
            tb_motionBindingSource.DataSource = MotionData;
            gridControl1.DataSource = dbContext.tb_motion.ToList();
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
                            MotionData.mo_name = txt_name.EditValue.ToString();


                            dbContext.tb_motion.AddOrUpdate(MotionData);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_motionBindingSource.DataSource = MotionData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var MotionED = dbContext.tb_motion.SingleOrDefault(p => p.id_mo == _id);
                            MotionED.mo_name = txt_name.EditValue.ToString();
                            dbContext.tb_motion.AddOrUpdate(MotionED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_motionBindingSource.DataSource = MotionED;
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();
                gridControl1.DataSource = dbContext.tb_motion.ToList();


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
                    var MotionED = dbContext.tb_motion.SingleOrDefault(p => p.id_mo == _id);

                    dbContext.tb_motion.Remove(MotionED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_motionBindingSource.DataSource = MotionData;
            gridControl1.DataSource = dbContext.tb_item.ToList();

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }

    }
}
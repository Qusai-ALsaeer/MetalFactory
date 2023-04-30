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
    public partial class Unit : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_unit UnitData;
        public Unit()
        {
            InitializeComponent();
            dbContext.tb_unit.Load();
            tb_unitBindingSource.DataSource = dbContext.tb_unit.Local.ToBindingList();
        }
        private void Unit_Load(object sender, EventArgs e)
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
            tb_unitBindingSource.DataSource = dbContext.tb_unit.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_unit.Any())
            {
                maxID = dbContext.tb_unit.Max(c => c.id_unit);
            }
            return maxID + 1;
        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            UnitData = new tb_unit()
            {
                id_unit = GetMaxID()

            };
            tb_unitBindingSource.DataSource = UnitData;
            gridControl1.DataSource = dbContext.tb_unit.ToList();
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
                            UnitData.u_name = txt_name.EditValue.ToString();


                            dbContext.tb_unit.AddOrUpdate(UnitData);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_unitBindingSource .DataSource = UnitData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var UnitED = dbContext.tb_unit.SingleOrDefault(p => p.id_unit  == _id);
                            UnitED.u_name  = txt_name .EditValue.ToString();

                            dbContext.tb_unit.AddOrUpdate(UnitED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_unitBindingSource .DataSource = UnitED ;
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();
                gridControl1.DataSource = dbContext.tb_unit.ToList();


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
                    var UnitED = dbContext.tb_unit.SingleOrDefault(p => p.id_unit == _id);

                    dbContext.tb_unit.Remove(UnitED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_unitBindingSource .DataSource = UnitData ;
            gridControl1.DataSource = dbContext.tb_unit .ToList();

        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
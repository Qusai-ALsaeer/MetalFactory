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
    public partial class Currncy : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_currency CurrencyData;


        public Currncy()
        {
            InitializeComponent();

            dbContext.tb_currency.Load();
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.Local.ToBindingList();
        }

        private void Currncy_Load(object sender, EventArgs e)
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
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.ToList();
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_currency.Any())
            {
                maxID = dbContext.tb_currency.Max(c => c.id_cu);
            }
            return maxID + 1;
        }


        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            CurrencyData = new tb_currency()
            {
                id_cu = GetMaxID()

            };
            tb_currencyBindingSource.DataSource = CurrencyData;
            gridControl1.DataSource = dbContext.tb_currency.ToList();
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
                        CurrencyData.cu_name = txt_name.Text;
                        CurrencyData.cu_sym =  txt_sym.Text;
                        CurrencyData.cu_part = txt_part.Text;
                        CurrencyData.cu_iso  = txt_iso.Text;

                        dbContext.tb_currency.AddOrUpdate(CurrencyData);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();

                    }
                    else
                    {
                        // اذا كان الصف قديم
                        var CarED = dbContext.tb_currency.SingleOrDefault(p => p.id_cu == _id);
                        CarED.cu_name =txt_name.Text;
                        CarED.cu_sym = txt_sym.Text;
                        CarED.cu_part =txt_part.Text;
                        CarED.cu_iso = txt_iso.Text;
                        dbContext.tb_currency.AddOrUpdate(CurrencyData);
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
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.ToList();
            gridControl1.DataSource = tb_currencyBindingSource;


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
                    var CarED = dbContext.tb_currency.SingleOrDefault(p => p.id_cu == _id);

                    dbContext.tb_currency.Remove(CarED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.ToList();
            gridControl1.DataSource = tb_currencyBindingSource;

        }
        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
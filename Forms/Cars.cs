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
using System.Runtime.Remoting.Contexts;
using DevExpress.Data;
using Acco.Model;
using System.Data.Entity.Migrations;
using DevExpress.XtraGrid;

namespace Acco.Forms
{
    public partial class Cars : DevExpress.XtraEditors.XtraForm
    {

        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_car CarData ;
        public Cars()
        {
            InitializeComponent();

            dbContext.tb_car.Load();
            tb_carBindingSource.DataSource = dbContext.tb_car.Local.ToBindingList();

        }
        private void RefreshData()
        {
            tb_carBindingSource.DataSource = dbContext.tb_car.ToList();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Enabled = false;

            CarData = new tb_car()
            {
                id_car = GetMaxID()

            };
            tb_carBindingSource.DataSource = CarData;
            gridControl1  .DataSource = dbContext.tb_car.ToList();
        }

        private void S_btn_Click(object sender, EventArgs e)
        {
            var _id =Convert.ToInt32( txt_id.EditValue);
            var max = GetMaxID();
            
            using (Model1 dbContext = new Model1())
            {
                DialogResult dialogResult = XtraMessageBox.Show("هل تريد حفظ البيانات؟", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (max == _id)  // اذا كان الصف جديد
                    {
                        CarData.car_name = txt_car_name.Text;
                        CarData.car_num = txt_car_num.Text;
                        CarData.car_space = txt_car_space.Text;
                        dbContext.tb_car.AddOrUpdate(CarData);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();

                    }
                    else
                    {
                        // اذا كان الصف قديم
                        var CarED = dbContext.tb_car.SingleOrDefault(p => p.id_car == _id);
                        CarED.car_name = txt_car_name.Text;
                        CarED.car_num = txt_car_num.Text;
                        CarED.car_space = txt_car_space.Text;
                        dbContext.tb_car.AddOrUpdate(CarED);
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
            tb_carBindingSource.DataSource = dbContext.tb_car.ToList();
            gridControl1.DataSource = tb_carBindingSource;


            N_btn.Enabled = true;
            D_btn.Enabled = true;
            C_btn.Enabled = true;

        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_car.Any())
            {
                maxID = dbContext.tb_car.Max(c => c.id_car);
            }
            return maxID + 1;
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
                        var CarED = dbContext.tb_car.SingleOrDefault(p => p.id_car == _id);

                        dbContext.tb_car.Remove(CarED);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_carBindingSource.DataSource = dbContext.tb_car.ToList();
            gridControl1.DataSource = tb_carBindingSource;


        }
    }
}
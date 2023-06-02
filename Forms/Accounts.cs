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
using System.Security.Principal;
using DevExpress.XtraGrid;
using System.Data.Entity.Migrations;

namespace Acco.Forms
{
    public partial class Accounts : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();
        tb_account SelecctAccountData;
        tb_account NewAccountData;
        public Accounts()
        {
            InitializeComponent();

            dbContext.tb_account.Load();
            tb_accountBindingSource.DataSource = dbContext.tb_account.Local.ToBindingList();

            dbContext.tb_currency.Load();
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.Local.ToBindingList();

            dbContext.tb_final.Load();
            tb_finalBindingSource.DataSource = dbContext.tb_final.Local.ToBindingList();

        }
        private void bindtreeview()
        {
            var node = dbContext.tb_account.Where(a => a.ac_fnum == 0);
            foreach (var item in node)
            {
                TreeNode rootnode = new TreeNode(item.ac_num + "  " + item.ac_name);
                tb_account tb = item as tb_account;
                var childnode = dbContext.tb_account.Where(a => a.ac_fnum == tb.ac_num);
                foreach (var child in childnode)
                {
                    TreeNode childno = new TreeNode(child.ac_num + "  " + child.ac_name);
                    tb_account tb2 = child as tb_account;
                    var childnode2 = dbContext.tb_account.Where(a => a.ac_fnum == tb2.ac_num);
                    foreach (var child2 in childnode2)
                    {
                        TreeNode childno2 = new TreeNode(child2.ac_num + "  " + child2.ac_name);
                        tb_account tb3 = child2 as tb_account;
                        var childnode3 = dbContext.tb_account.Where(a => a.ac_fnum == tb3.ac_num);
                        foreach (var child3 in childnode3)
                        {
                            TreeNode childno3 = new TreeNode(child3.ac_num + "  " + child3.ac_name);

                            childno3.Tag = child3.id_ac;
                            childno2.Nodes.Add(childno3);
                        }
                        childno2.Tag = child2.id_ac;
                        childno.Nodes.Add(childno2);
                    }
                    childno.Tag = child.id_ac;
                    rootnode.Nodes.Add(childno);
                }
                rootnode.Tag = item.id_ac;
                treeView1.Nodes.Add(rootnode);
            }

        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            if (dbContext.tb_account.Count() == 0)
            {
                MessageBox.Show("جدول الحسابات فارغ.. سيتم انشاء الحسابات الرئيسية");

                // إضافة حسابات الأصول
                tb_account assets = new tb_account();
                assets.ac_name = "الأصول";
                assets.ac_type = true;
                assets.ac_fnum = 0;
                assets.ac_num = 1;
                assets.ac_level = 1;
                dbContext.tb_account.Add(assets);

                // إضافة حسابات الخصوم
                tb_account liabilities = new tb_account();
                liabilities.ac_name = "الخصوم";
                liabilities.ac_type = true;
                liabilities.ac_fnum = 0;
                liabilities.ac_num = 2;
                liabilities.ac_level = 1;

                dbContext.tb_account.Add(liabilities);

                // إضافة حساب رأس المال
                tb_account equity = new tb_account();
                equity.ac_name = "رأس المال";
                equity.ac_type = true;
                equity.ac_fnum = 0;
                equity.ac_num = 3;
                equity.ac_level = 1;
                dbContext.tb_account.Add(equity);

                // إضافة حسابات الإيرادات
                tb_account revenues = new tb_account();
                revenues.ac_name = "الإيرادات";
                revenues.ac_type = true;
                revenues.ac_fnum = 0;
                revenues.ac_num = 4;
                revenues.ac_level = 1;

                dbContext.tb_account.Add(revenues);

                // إضافة حسابات المصروفات
                tb_account expenses = new tb_account();
                expenses.ac_name = "المصروفات";
                expenses.ac_type = true;
                expenses.ac_fnum = 0;
                expenses.ac_num = 5;
                expenses.ac_level = 1;

                dbContext.tb_account.Add(expenses);

                // حفظ التغييرات
                dbContext.SaveChanges();

                // تحميل الحسابات من قاعدة البيانات وعرضها في النموذج
                dbContext.tb_account.Load();
                tb_accountBindingSource.DataSource = dbContext.tb_account.Local.ToBindingList();
            }
            else
            {
                // جلب الحسابات من قاعدة البيانات وعرضها في النموذج
                dbContext.tb_account.Load();
                tb_accountBindingSource.DataSource = dbContext.tb_account.Local.ToBindingList();
            }

            bindtreeview();
        }
        private void SelectedAccount(int accountId)
        {
            SelecctAccountData = dbContext.tb_account.FirstOrDefault(a => a.id_ac == accountId);
            tb_accountBindingSource.DataSource = SelecctAccountData;
        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_type_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_type.Checked == true)
            {
                txt_open.Enabled = false;
                txt_open.EditValue ="";
                lkp_cur.Enabled = false;
                lkp_cur.EditValue = null;
            }
            else
            {
                txt_open.Enabled = true;
                txt_open.EditValue = 0;

                lkp_cur.Enabled = true;
                lkp_cur.EditValue = 1;

            }
        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                int accountId = (int)e.Node.Tag;
                SelectedAccount(accountId);
                //SelecctAccountData = dbContext.tb_account.FirstOrDefault(a => a.id_ac == accountId);
                tb_accountBindingSource.DataSource = SelecctAccountData;
            }
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_account.Any())
            {
                maxID = dbContext.tb_account.Max(c => c.id_ac);
            }
            return maxID + 1;
        }
        private void RefreshData()
        {
            tb_accountBindingSource.DataSource = dbContext.tb_account.ToList();
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.ToList();
            tb_finalBindingSource.DataSource = dbContext.tb_final.ToList();


        }

        private void N_btn_Click(object sender, EventArgs e)
        {
            int lvl ;
            string num;
            if (SelecctAccountData == null)
            {
                MessageBox.Show("يجب تحديد حساب من شجرة الحسابات");
                SelectedAccount(1);

            }
            else
            {
                if (SelecctAccountData.ac_level < 4)
                {
                    string acNum = Convert.ToString(SelecctAccountData.ac_num);
                    int acNumLength = acNum.Length + 1;
                    int? maxValue = dbContext.tb_account
                      .Where(x => x.ac_num.ToString().StartsWith(acNum) && x.ac_num.ToString().Length == acNumLength)
                      .Max(x => (int?)x.ac_num);
                    if (maxValue == null)
                    {
                        num = Convert.ToString(SelecctAccountData.ac_num) + "1";
                    }
                    else
                    {
                        num = (maxValue + 1).ToString();
                    }
                     lvl = Convert.ToInt32(SelecctAccountData.ac_level) + 1;
                    if (int.TryParse(num, out int numValue))
                    {
                        NewAccountData = new tb_account()
                        {
                            id_ac = GetMaxID(),
                            ac_level = lvl,
                            ac_num = numValue,
                            ac_fnum = SelecctAccountData.ac_num,
                            ac_type = true,
                            ac_open = 0
                        };
                        tb_accountBindingSource.DataSource = NewAccountData;
                    }
                    else
                    {
                        MessageBox.Show("يرجى التاكد من القيم المدخلة");

                    }

                    //NewAccountData = new tb_account()
                    //{
                    //    id_ac = GetMaxID(),
                    //    ac_level = Convert.ToInt32(lvl),
                    //    ac_num = Convert.ToInt32(num),
                    //    ac_fnum = SelecctAccountData.ac_num,
                    //    ac_type = true,
                    //    ac_open = 0,

                    //};
                    //tb_accountBindingSource.DataSource = NewAccountData;
                }
            }

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
                        NewAccountData.ac_level =Convert.ToInt32( txt_level.EditValue);
                        NewAccountData.ac_open =Convert.ToInt32(txt_open.EditValue) ;
                        NewAccountData.ac_type =Convert.ToBoolean( txt_type.EditValue) ;
                        NewAccountData.ac_fnum =Convert.ToInt32( txt_fnum .EditValue) ;
                        NewAccountData.ac_name =Convert.ToString( txt_name .EditValue) ;
                        NewAccountData.ac_num =Convert.ToInt32( txt_ac_num .EditValue) ;
                        if (lkp_final.EditValue != DBNull.Value && Convert.ToString(lkp_final.EditValue) != "")
                        {
                            NewAccountData.ac_final = Convert.ToInt32(lkp_final.EditValue);
                        }
                        else
                        {
                            NewAccountData.ac_final = null;
                        }
                        if (lkp_cur.EditValue != DBNull.Value && Convert.ToString(lkp_cur.EditValue)!= "")
                        {
                            NewAccountData.ac_cu = Convert.ToInt32(lkp_cur.EditValue);
                        }
                        else
                        {
                            NewAccountData.ac_cu = null;
                        }

                        dbContext.tb_account.AddOrUpdate(NewAccountData);
                        dbContext.SaveChanges();
                        XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData();

                    }
                    else
                    {
                        // اذا كان الصف قديم
                        var AccoED = dbContext.tb_account.SingleOrDefault(p => p.id_ac == _id);
                        AccoED.ac_level = Convert.ToInt32(txt_level.EditValue);
                        AccoED.ac_open = Convert.ToInt32(txt_open.EditValue);
                        AccoED.ac_type = Convert.ToBoolean(txt_type.EditValue);
                        AccoED.ac_fnum = Convert.ToInt32(txt_fnum.EditValue);
                        AccoED.ac_name = Convert.ToString(txt_name.EditValue);
                        AccoED.ac_num = Convert.ToInt32(txt_ac_num.EditValue);
                        //AccoED.ac_final = Convert.ToInt32(lkp_final.EditValue);
                        AccoED.ac_final = lkp_final.EditValue != DBNull.Value ? Convert.ToInt32(lkp_final.EditValue) : 1 ;
                        AccoED.ac_cu = Convert.ToInt32(lkp_cur.EditValue);
                        dbContext.tb_account.AddOrUpdate(AccoED);
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
            tb_accountBindingSource.DataSource = dbContext.tb_account.ToList();
            SelecctAccountData = null;
            // Reload the data in the treeview
            treeView1.Nodes.Clear();
            bindtreeview();

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
                    var AcoouED = dbContext.tb_account.SingleOrDefault(p => p.id_ac == _id);

                    dbContext.tb_account.Remove(AcoouED);
                    dbContext.SaveChanges();
                    XtraMessageBox.Show("تم الحذف بنجاح!", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("تم الغاء العملية");
                }

            }
            RefreshData();
            tb_accountBindingSource.DataSource = dbContext.tb_account.ToList();
            // تحديث البيانات في شجرة الحسابات بعد الحذف
            treeView1.Nodes.Clear();
            bindtreeview();
        }
    }
}
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
using DevExpress.XtraGrid;
using System.Data.Entity.Migrations;

namespace Acco.Forms
{
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        Acco.Model.Model1 dbContext = new Acco.Model.Model1();

        tb_payment PaymentData;
        tb_general generalData;
        tb_account CreditAcountData;
        tb_account DebitAcountData;

        private BindingSource tb_accountBindingSource_Credit = new BindingSource();
        private BindingSource tb_accountBindingSource_Debit = new BindingSource();

        public Payment()
        {
            InitializeComponent();

            dbContext.tb_payment.Load();
            tb_paymentBindingSource.DataSource = dbContext.tb_payment.Local.ToBindingList();

            dbContext.tb_currency.Load();
            tb_currencyBindingSource.DataSource = dbContext.tb_currency.Local.ToBindingList();

            LoadAccounts();

            dbContext.tb_general.Load();
            tb_generalBindingSource.DataSource = dbContext.tb_general.Local.ToBindingList();
        }
        public void LoadAccounts()
        {
            using (var dbContext = new Model1())
            {
                dbContext.tb_account.Load();
                // set the credit account binding source
                var creditAccounts = dbContext.tb_account.Local
                    .Where(a => a.ac_type == false)
                    .Select(ac => new
                    {
                        ac.ac_name,
                        ac.id_ac,
                        ac.ac_num
                    }).ToList();
                tb_accountBindingSource_Credit.DataSource = creditAccounts;
                lkp_pay_credit.Properties.DataSource = tb_accountBindingSource_Credit;

                // set the initial debit account binding source
                var debitAccounts = creditAccounts;
                tb_accountBindingSource_Debit.DataSource = debitAccounts;
                lkp_pay_debit.Properties.DataSource = tb_accountBindingSource_Debit;
            }
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            tb_paymentBindingSource.DataSource = dbContext.tb_payment.ToList();
        }
        private void lkp_id_cur_EditValueChanged(object sender, EventArgs e)
        {
            using (Model1 model = new Model1())
            {
                if (int.TryParse(lkp_id_cur.EditValue.ToString(), out int cure))
                {

                    var accounts = model.tb_account.Where(a => a.ac_type == false && a.ac_cu == cure)
                        .Select(ac => new
                        {
                            ac.ac_name,
                            ac.id_ac ,
                            ac.ac_num
                        }).ToList();
                    tb_accountBindingSource_Credit.DataSource = accounts;
                    tb_accountBindingSource_Debit.DataSource = accounts;

                }
            }
            if (lkp_id_cur.EditValue != DBNull.Value && Convert.ToInt32(lkp_id_cur.EditValue) == 1)
            {
                spn_pay_exch.ReadOnly = true;
            }
            else
            {
                spn_pay_exch.ReadOnly = false;

            }
        }
        private void lkp_pay_credit_EditValueChanged(object sender, EventArgs e)
        {
            if (lkp_pay_credit.EditValue != DBNull.Value)
            {
                // get the selected account id from the credit lookup control
                int selectedAccountId = Convert.ToInt32(lkp_pay_credit.EditValue);

                // filter the debit accounts to exclude the selected account
                var debitAccounts = tb_accountBindingSource_Credit.List.OfType<object>()
                    .Where(a => ((dynamic)a).id_ac != selectedAccountId)
                    .Select(ac => new
                    {
                        ((dynamic)ac).ac_name,
                        ((dynamic)ac).id_ac,
                        ((dynamic)ac).ac_num
                    }).ToList();

                // update the binding source of the debit lookup control
                tb_accountBindingSource_Debit.DataSource = debitAccounts;
                lkp_pay_debit.Properties.DataSource = tb_accountBindingSource_Debit;
            }
        }
        private int GetMaxID()
        {
            int maxID = 0;
            if (dbContext.tb_payment.Any())
            {
                maxID = dbContext.tb_payment.Max(c => c.id_pay);
            }
            return maxID + 1;
        }
        private int GetMaxGeneralID()
        {
            int maxID = 0;
            if (dbContext.tb_general.Any())
            {
                maxID = dbContext.tb_general.Max(c => c.id);
            }
            return maxID + 1;
        }
        private void N_btn_Click(object sender, EventArgs e)
        {
            N_btn.Enabled = false;
            D_btn.Enabled = false;
            C_btn.Text = "الغاء";

            PaymentData = new tb_payment()
            {
                id_pay = GetMaxID(),
                pay_date = DateTime.Today,
                pay_credit = 12,
                id_cur=1,
                pay_exch=0,

            };
            tb_paymentBindingSource.DataSource = PaymentData;
            generalData = new tb_general()
            {
                id = GetMaxGeneralID(),
            };
            tb_generalBindingSource.DataSource = generalData;
        }
        private void S_btn_Click(object sender, EventArgs e)
        {
            if (txt_id.EditValue == null || txt_id.EditValue == DBNull.Value)
            {
                MessageBox.Show(" يجب اضافة حركة دفع جديدة");
                this.N_btn_Click(sender, e);
            }
            else
            {
                var _id = Convert.ToInt32(txt_id.EditValue);
                var max = GetMaxID();

                var _id_g = Convert.ToInt32(txt_id_g.EditValue);
                var max_g = GetMaxGeneralID();

                using (Model1 dbContext = new Model1())
                {
                    DialogResult dialogResult = XtraMessageBox.Show("هل تريد حفظ البيانات؟", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (max == _id)  // اذا كان الصف جديد
                        {
                            // add PaymentData
                            PaymentData.pay_date =Convert.ToDateTime( txt_date.EditValue);
                            PaymentData.id_cur =Convert.ToInt32( lkp_id_cur.EditValue);
                            PaymentData.pay_credit =Convert.ToInt32( lkp_pay_credit.EditValue);
                            PaymentData.pay_debit =Convert.ToInt32( lkp_pay_debit.EditValue);
                            PaymentData.pay_amount =Convert.ToInt32( spn_pay_amount.EditValue);
                            PaymentData.pay_exch =Convert.ToInt32( spn_pay_exch.EditValue);
                            PaymentData.explan = txt_pay_explan.EditValue.ToString();
                            PaymentData.note = txt_pay_note.EditValue.ToString();

                            dbContext.tb_payment.AddOrUpdate(PaymentData);

                            // add general credit


                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم الحفظ بنجاح!", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_paymentBindingSource.DataSource = PaymentData;


                        }
                        else
                        {
                            // اذا كان الصف قديم
                            var PayED = dbContext.tb_payment.SingleOrDefault(p => p.id_pay == _id);

                            PayED.pay_date = Convert.ToDateTime(txt_date.EditValue);
                            PayED.id_cur = Convert.ToInt32(lkp_id_cur.EditValue);
                            PayED.pay_credit = Convert.ToInt32(lkp_pay_credit.EditValue);
                            PayED.pay_debit = Convert.ToInt32(lkp_pay_debit.EditValue);
                            PayED.pay_amount = Convert.ToInt32(spn_pay_amount.EditValue);
                            PayED.pay_exch = Convert.ToInt32(spn_pay_exch.EditValue);
                            PayED.explan = txt_pay_explan.EditValue.ToString();
                            PayED.note = txt_pay_note.EditValue.ToString();

                            dbContext.tb_payment.AddOrUpdate(PayED);
                            dbContext.SaveChanges();
                            XtraMessageBox.Show("تم التعديل بنجاح!", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData();
                            tb_paymentBindingSource.DataSource = PayED;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("تم الغاء العملية");
                    }

                }
                //RefreshData();


                N_btn.Enabled = true;
                D_btn.Enabled = true;
                C_btn.Enabled = true;
            }

        }
        private void D_btn_Click(object sender, EventArgs e)
        {

        }
        private void C_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
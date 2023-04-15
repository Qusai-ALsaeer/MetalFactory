using Acco.Forms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acco.Model
{
    public partial class Start : DevExpress.XtraEditors.XtraForm
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

            S_Label_date.Text = "    " + DateTime.Now.ToString("yyyy-MM-dd") + "    |    " + DateTime.Now.ToString("hh:mm:ss") + "    |    " + DateTime.Now.ToString("MMMM") + "  -  " + DateTime.Now.ToString("dddd ");
            S_Label_prog.Text = "                          ||                                 " + "برنامج الساير لمحاسبة معامل الحديد";

        }
        private void SM_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SM_Car_Click(object sender, EventArgs e)
        {
            Form form = new Cars();
            form.Owner = this;
            form.Show();
        }



        private void S_Currncy_Click(object sender, EventArgs e)
        {
            Form form = new Currncy();
            form.Owner = this;
            form.Show();
        }

        private void S_Accounts_Click(object sender, EventArgs e)
        {
            Form form = new Accounts();
            form.Owner = this;
            form.Show();
        }

        private void S_final_Click(object sender, EventArgs e)
        {
            Form form = new Final_Acco();
            form.Owner = this;
            form.Show();
        }

        private void S_catagory_Click(object sender, EventArgs e)
        {
            Form form = new Catgory();
            form.Owner = this;
            form.Show();
        }

        private void جدولنوعالعملToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Jop();
            form.Owner = this;
            form.Show();
        }
    }
}
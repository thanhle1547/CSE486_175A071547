using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Tickets_App
{
    public partial class AccountForm : Form
    {
        //private static AccountForm ins;

        //public static AccountForm Ins { get { if (ins == null) ins = new AccountForm(); return ins; } private set => ins = value; }

        public AccountForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChangeAcc_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            /*this.Dispose();
            this.Parent.Dispose();
            this.Parent.Parent.Show();*/
        }
    }
}

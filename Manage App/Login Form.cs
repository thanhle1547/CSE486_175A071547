using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // C# - Adding a Simple Drop Shadow in Borderless WinForm
        // https://www.youtube.com/watch?v=UoYD_6VgazE
        private const int FORM_Shadow = 0x00020000; // 0x00020000

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= FORM_Shadow;
                return cp;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void TxB_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

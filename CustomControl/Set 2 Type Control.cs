using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class Set_2_Type_Control : UserControl
    {
        public Set_2_Type_Control() { }

        public Set_2_Type_Control(
            DataTable table1, string displayMem1, string valMem1, 
            DataTable table2, string displayMem2, string valMem2,
            string setValMem1 = null, string setValMem2 = null
            )
        {
            InitializeComponent();

            cB_1.DataSource = table1;
            cB_1.DisplayMember = displayMem1;
            cB_1.ValueMember = valMem1;

            cB_2.DataSource = table2;
            cB_2.DisplayMember = displayMem2;
            cB_2.ValueMember = valMem2;

            if (setValMem1 != null)
            {
                cB_1.SelectedIndex = cB_1.FindStringExact(setValMem1);
                cB_2.SelectedIndex = cB_2.FindStringExact(setValMem2);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        //public ComboBox cBx_1 { get => cB_1; set => cB_1 = value; }
        //public ComboBox cBx_2 { get => cB_2; set => cB_2 = value; }

        public string value1 { get => cB_1.SelectedValue.ToString(); }
        public string value2 { get => cB_2.SelectedValue.ToString(); }
    }
}

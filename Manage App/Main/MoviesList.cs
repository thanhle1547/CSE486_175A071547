using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
using Manage_App.Function_Form;

namespace Manage_App
{
    public partial class MoviesList : UserControl
    {
        private static MoviesList ins;
        private Dictionary<int, string> keyValues = new Dictionary<int, string>()
        {
            {0, "Tất cả phim (đang & sắp chiếu)" },
            {1, "Phim đang chiếu" },
            {2, "Phim sắp chiếu" }
        };
        //DataSet dn;

        public MoviesList()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cB_Loc.DataSource = new BindingSource(keyValues, null);
            cB_Loc.DisplayMember = "Value";
            cB_Loc.ValueMember = "Key";

            cB_Loc.SelectedIndex = 1;
        }

        /*private void btn_Refresh_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Refresh";
            // Phải sửa lại size
        }*/
        public static MoviesList Ins { get { if (ins == null) ins = new MoviesList(); return ins; } private set => ins = value; }

        //public DataSet Dn { get { if (dn == null) dn = CT_Phim_DAO.Ins.GetAllDetails(); return dn; } set => dn = value; }

        private void MoviesList_Load(object sender, EventArgs e)
        {
            dgv_Phim.DataSource = CT_Phim_DAO.Ins.GetMovies_Details(false);
        }

        private void cB_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cB_Loc.SelectedIndex)
            {
                case 0:
                    dgv_Phim.DataSource = CT_Phim_DAO.Ins.GetAllMovies_Details();
                    break;
                case 1:
                    dgv_Phim.DataSource = CT_Phim_DAO.Ins.GetMovies_Details(false);
                    break;
                case 2:
                    dgv_Phim.DataSource = CT_Phim_DAO.Ins.GetMovies_Details(true);
                    break;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cB_Loc_SelectedIndexChanged(sender, e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgv_Phim.SelectedRows[0];
            // https://stackoverflow.com/a/1822343
            //ChiTietPhim phim = new ChiTietPhim(
            //        ((DataRowView)dgv_Phim.SelectedRows[0].DataBoundItem).Row
            //    );
            if (dgv_Phim.SelectedRows.Count == 0)
                return;

            using (Movie_Details form = new Movie_Details(
                true,
                // https://stackoverflow.com/a/34132066
                new ChiTietPhim( ((DataRowView)dgv_Phim.SelectedRows[0].DataBoundItem).Row)
                ))
            {
                form.ShowDialog();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                CT_Phim_DAO.Ins.DeleteMovie( (int)dgv_Phim.Rows[dgv_Phim.SelectedRows[0].Index].Cells["IDPhim"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (Movie_Details form = new Movie_Details(false))
            {
                form.ShowDialog();
            }
        }
    }
}

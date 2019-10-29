using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using Manage_App.Function_Form;

namespace Manage_App
{
    public partial class Personnel : UserControl
    {
        private static Personnel ins;
        //List<NhanVien> nhanVien;
        private DataTable chucVu;
        public Personnel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            chucVu = NhanVien_DAO.Ins.GetPosition();
            cB_ChucVu.DataSource = chucVu;
            cB_ChucVu.DisplayMember = "ChucVu";
            cB_ChucVu.ValueMember = "IDChucVu";
        }
        public static Personnel Ins { get { if (ins == null) ins = new Personnel(); return ins; } private set => ins = value; }

        private void Personnel_Load(object sender, EventArgs e)
        {
            cB_ChucVu.SelectedIndex = 0;
        }

        private void cB_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // https://stackoverflow.com/a/23865197
            //MessageBox.Show((cB_ChucVu.SelectedItem as DataRowView).Row["ChucVu"].ToString());
            dgv_NhanVien.DataSource = NhanVien_DAO.Ins.GetPerPosition(
                (cB_ChucVu.SelectedItem as DataRowView).Row["ChucVu"].ToString());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows != null)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            using (PersonnelDetails form = new PersonnelDetails(
                    true, chucVu,
                    new NhanVien( ((DataRowView)dgv_NhanVien.SelectedRows[0].DataBoundItem).Row )
                ))
                form.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            NhanVien_DAO.Ins.DeletePer( (int)dgv_NhanVien.SelectedRows[0].Cells["IDNhanVien"].Value );
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = NhanVien_DAO.Ins.GetPerPosition(
                (cB_ChucVu.SelectedItem as DataRowView).Row["ChucVu"].ToString());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PersonnelDetails form = new PersonnelDetails(false, chucVu);
            form.ShowDialog();
        }
    }
}

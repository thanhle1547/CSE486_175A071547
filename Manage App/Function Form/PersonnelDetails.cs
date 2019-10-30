using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace Manage_App.Function_Form
{
    public partial class PersonnelDetails : Form
    {
        NhanVien nv = new NhanVien();
        DataTable chucVu;

        public PersonnelDetails(bool isUpdate, DataTable chucvu, NhanVien nv = null)
        {
            InitializeComponent();

            if (isUpdate)
            {
                btn_Update.Visible = true;
                this.nv = nv;
                this.Tag = nv;
                txB_UserName.Visible = false;
                txB_Pass.Visible = false;
            }
            else
                btn_Add.Visible = true;
            this.chucVu = chucvu;
            cB_ChucVu.DataSource = chucVu;
            cB_ChucVu.DisplayMember = "ChucVu";
            cB_ChucVu.ValueMember = "IDChucVu";
        }

        private void PersonnelDetails_Load(object sender, EventArgs e)
        {
            txB_HoTen.DataBindings.Add("Text", nv, "Hoten", false, DataSourceUpdateMode.OnPropertyChanged, "");
            dtp_NgaySinh.DataBindings.Add("Text", nv, "NgaySinh", false, DataSourceUpdateMode.OnPropertyChanged);
            cB_GioiTinh.DataBindings.Add("SelectedValue", nv, "GioiTinh", false, DataSourceUpdateMode.OnPropertyChanged);
            txB_Que.DataBindings.Add("Text", nv, "QueQuan", false, DataSourceUpdateMode.OnPropertyChanged, "");
            txB_CMT.DataBindings.Add("Text", nv, "SoCMT", false, DataSourceUpdateMode.OnPropertyChanged, "");
            cB_ChucVu.DataBindings.Add("SelectedValue", nv, "ChucVu", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            //chucVu.Dispose(); nếu Dispose -> comboBox chức vụ ở form trước sẽ lỗi vì 0 còn dl
            this.Close();
        }


        // thuộc NhanVienBUS
        private void btn_Update_Click(object sender, EventArgs e)
        {
            AccountNV_BUS.Ins.UpdatePer(nv, Tag as NhanVien);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            /*NhanVien_DAO.Ins.AddPer(new NhanVien() { 
                Hoten = txB_HoTen.Text,
                NgaySinh = dtp_NgaySinh.Value.ToString(),
                GioiTinh = cB_GioiTinh.SelectedText,
                QueQuan = txB_Que.Text,
                SoCMT = txB_CMT.Text,
            }, new Account_NV() { 
                UserName = txB_UserName.Text,
                Password = txB_Pass.Text,
                IDChucVu = ((DataRowView)cB_ChucVu.SelectedItem).Row["IDChucVu"].ToString()
            });*/
            NhanVien_DAO.Ins.AddPer(nv, new Account_NV()
            {
                UserName = txB_UserName.Text,
                Password = txB_Pass.Text,
                IDChucVu = ((DataRowView)cB_ChucVu.SelectedItem).Row["IDChucVu"].ToString()
            });
        }
    }
}

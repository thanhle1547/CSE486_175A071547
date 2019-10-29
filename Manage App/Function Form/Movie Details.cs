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
using CustomControl;

namespace Manage_App.Function_Form
{
    public partial class Movie_Details : Form
    {
        ChiTietPhim chiTiet = new ChiTietPhim();
        DataSet data;

        public Movie_Details(bool isUpdate, ChiTietPhim chiTiet = null)
        {
            InitializeComponent();

            if (isUpdate)
            {
                btn_Update.Visible = true;
                this.chiTiet = chiTiet;
                this.Tag = chiTiet;
            }
            else
                btn_Add.Visible = true;

            data = CT_Phim_DAO.Ins.GetAllDetails();

            if (chiTiet != null)
            {
                string[] ct = chiTiet.DinhDang.Split(',');
                string[] nn = chiTiet.NgonNgu.Split(',');
                for (int i = 0; i < ct.Length; i++)
                    flp_DN.Controls.Add(new Set_2_Type_Control(
                        data.Tables["DinhDang"], "TenDinhDang", "ID_DinhDang",
                        data.Tables["NgonNgu"], "NgonNgu", "ID_NgonNgu",
                        ct[i], nn[i]
                        ));
            }
            else
                flp_DN.Controls.Add(new Set_2_Type_Control(
                        data.Tables["DinhDang"], "TenDinhDang", "ID_DinhDang",
                        data.Tables["NgonNgu"], "NgonNgu", "ID_NgonNgu"
                    ));
            cB_Rated.SelectedIndex = 0;
        }

        private void Movie_Details_Load(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/1453958/databinding-to-a-custom-class-in-c-sharp
            if (chiTiet.Poster != null)
                Poster.BackgroundImageLayout = ImageLayout.Zoom;
            Poster.DataBindings.Add("BackgroundImage", chiTiet, "Poster", true, 
                DataSourceUpdateMode.OnPropertyChanged,
                global::Manage_App.Properties.Resources.icons8_add_image_iOS_Glyph_60);
            txB_TenPhim.DataBindings.Add("Text", chiTiet, "TenPhim", false, DataSourceUpdateMode.OnPropertyChanged, "");
            txB_DaoDien.DataBindings.Add("Text", chiTiet, "DaoDien", false, DataSourceUpdateMode.OnPropertyChanged, "");
            txB_DienVien.DataBindings.Add("Text", chiTiet, "DienVien", false, DataSourceUpdateMode.OnPropertyChanged, "");
            txB_TheLoai.DataBindings.Add("Text", chiTiet, "TheLoai", false, DataSourceUpdateMode.OnPropertyChanged, "");
            txB_ThoiLuong.DataBindings.Add("Text", chiTiet, "ThoiLuong", false, DataSourceUpdateMode.OnPropertyChanged, "");
            dtp_KhoiChieu.DataBindings.Add("Value", chiTiet, "KhoiChieu", true, DataSourceUpdateMode.OnPropertyChanged);
            
            cB_Rated.DataBindings.Add("SelectedValue", chiTiet, "Rated", true, DataSourceUpdateMode.OnPropertyChanged);
            txB_MoTa.DataBindings.Add("Text", chiTiet, "MoTa", false, DataSourceUpdateMode.OnPropertyChanged, "");

            AddSuggestData(ref txB_DaoDien, "DaoDien", "TenDaoDien");
            AddSuggestData(ref txB_DienVien, "DienVien", "TenDienVien");
            AddSuggestData(ref txB_TheLoai, "TheLoai", "TenTheLoai");
            AddSuggestData(ref txB_NSX, "NhaSanXuat", "TenNSX");
        }

        private void AddSuggestData(ref BottomBorder_TextBox tb, string tblName, string colName)
        {
            // https://stackoverflow.com/a/3349465
            string[] s = data.Tables[tblName].AsEnumerable()
                    .Select<DataRow, string>(x => x.Field<string>(colName)).ToArray();
            tb.AutoCompleteCustomSource.AddRange(s);
        }


        #region Control
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            data.Dispose();
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CT_Phim_BUS.Ins.UpdateMovie(chiTiet, (ChiTietPhim)this.Tag, ref data);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            chiTiet.IDPhim = CT_Phim_DAO.Ins.GetLastIDPhim();
            chiTiet.Rated = cB_Rated.SelectedItem.ToString();
            if (String.IsNullOrEmpty(chiTiet.MoTa))
                chiTiet.MoTa = "";
            foreach(Set_2_Type_Control c in flp_DN.Controls)
            {
                chiTiet.NgonNgu += c.value1;
                chiTiet.DinhDang += c.value2;
            }
            CT_Phim_BUS.Ins.InsertMovie(chiTiet, ref data);
        }
        #endregion

        #region 
        private void Poster_Click(object sender, EventArgs e)
        {
            // https://www.youtube.com/watch?v=BqyAAGMfTD8&t=821s
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "PNG File (*.png)|*.png";
                    dialog.Title = "Chọn 1 poster của phim";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        Poster.ImageLocation = dialog.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_DN_Click(object sender, EventArgs e)
        {
            flp_DN.Controls.Add(new Set_2_Type_Control(
                        data.Tables["DinhDang"], "TenDinhDang", "ID_DinhDang",
                        data.Tables["NgonNgu"], "NgonNgu", "ID_NgonNgu"
                    ));
        }
        #endregion
    }
}

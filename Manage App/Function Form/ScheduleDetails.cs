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

namespace Manage_App.Function_Form
{
    public partial class ScheduleDetails : Form
    {
        LichChieuPhim lich = new LichChieuPhim();
        public ScheduleDetails(bool isUpdate, LichChieuPhim lich = null)
        {
            InitializeComponent();

            cB_Phong.DataSource = Properties.Settings.Default.ListOfRoom;
            cB_Phong.DisplayMember = "TenPhong";
            cB_Phong.ValueMember = "IDPhong";

            if (isUpdate)
            {
                btn_Update.Visible = true;
                this.lich = lich;
                this.Tag = lich;
                cB_TenPhim.Enabled = false;
                // cB_TenPhim sẽ đc bind khi load
                cB_TenPhim.DataBindings.Add("SelectedValue", lich, "TenPhim", true, DataSourceUpdateMode.OnPropertyChanged);
                cB_DN.DataBindings.Add("SelectedValue", lich, "DN", true, DataSourceUpdateMode.OnPropertyChanged);
                cB_Phong.DataBindings.Add("SelectedValue", lich, "TenPhong", true, DataSourceUpdateMode.OnPropertyChanged);
                //dtp_Ngay.DataBindings.Add("Value", lich, "ThoiGian", true, DataSourceUpdateMode.OnPropertyChanged);
                //dtp_TG.DataBindings.Add("Value", lich, "ThoiGian", true, DataSourceUpdateMode.OnPropertyChanged);
                dtp_Ngay.Value = DateTime.ParseExact(lich.ThoiGianChieu, "dd/MM/yyyy", null);
                dtp_TG.Value = DateTime.ParseExact(lich.ThoiGianChieu, "hh:mm", null);
            }
            else
            {
                cB_TenPhim.DataSource = Properties.Settings.Default.ListOfMovies;
                cB_TenPhim.DisplayMember = "TenPhim";
                cB_TenPhim.ValueMember = "IDPhim";
                btn_Add.Visible = true;
                //dtp_Ngay.MinDate = DateTime.Now;
                //dtp_TG.MinDate = DateTime.Now;

                //cB_TenPhim.Items.RemoveAt(0);
            }

            //cB_Phong.Items.RemoveAt(0);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // https://stackoverflow.com/a/30259683
                lich.ThoiGianChieu = (dtp_Ngay.Value.Date + dtp_TG.Value.TimeOfDay).ToString("yyyy-MM-dd HH:mm");
                lich.TenPhong = cB_Phong.SelectedValue.ToString();
                lich.ID_PDN = (int)cB_DN.SelectedValue;
                LC_PhimDAO.Ins.InsertSchedule(lich);
                btn_Huy_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                lich.ThoiGianChieu = (dtp_Ngay.Value.Date + dtp_TG.Value.TimeOfDay).ToString("yyyy-MM-dd HH:mm");
                LC_PhimDAO.Ins.UpdateSchedule(lich);
                btn_Huy_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void cB_TenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_DN.DataSource = CT_Phim_DAO.Ins.GetMovieDL( (int)((DataRowView)cB_TenPhim.SelectedItem).Row["IDPhim"]);
            cB_DN.DisplayMember = "DN";
            cB_DN.ValueMember = "ID_PDN";
        }
    }
}

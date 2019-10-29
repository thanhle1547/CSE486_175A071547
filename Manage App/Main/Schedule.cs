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
    public partial class Schedule : UserControl
    {
        private static Schedule ins;

        public Schedule()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static Schedule Ins { get { if (ins == null) ins = new Schedule(); return ins; } private set => ins = value; }

        private void Schedule_Load(object sender, EventArgs e)
        {
            DataSet dataSet = LC_PhimDAO.Ins.GetMoviesRoom();

// https://social.msdn.microsoft.com/Forums/en-US/607ea334-e8e2-4a73-9468-ae73b74e3e65/can-i-add-an-item-to-a-combobox-already-populated-from-a-datasource?forum=Vsexpressvcs
            DataRow row = dataSet.Tables["Phim"].NewRow();
            row["TenPhim"] = "(none)";
            row["IDPhim"] = 0;
            dataSet.Tables["Phim"].Rows.InsertAt(row, 0);

            row = dataSet.Tables["Phong"].NewRow();
            row["TenPhong"] = "(none)";
            row["IDPhong"] = 0;
            dataSet.Tables["Phong"].Rows.InsertAt(row, 0);


            cB_Phim.DataSource = dataSet.Tables["Phim"];
            cB_Phim.DisplayMember = "TenPhim";
            cB_Phim.ValueMember = "IDPhim";

            cB_PhongChieu.DataSource = dataSet.Tables["Phong"];
            cB_PhongChieu.DisplayMember = "TenPhong";
            cB_PhongChieu.ValueMember = "IDPhong";

            Properties.Settings.Default.ListOfRoom = dataSet.Tables["Phong"];
            Properties.Settings.Default.ListOfMovies = dataSet.Tables["Phim"];

            dataSet.Dispose();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if (cB_Phim.SelectedText == "(none)" || cB_PhongChieu.SelectedText == "(none)")
            {
                MessageBox.Show("Không thể thực hiện thao tác này", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgv_Phim.DataSource = LC_PhimDAO.Ins.GetScheduleRoom(
                (int)((cB_Phim.SelectedItem as DataRowView).Row["IDPhim"]),
                ((cB_PhongChieu.SelectedItem as DataRowView).Row["TenPhong"]).ToString()
                );
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Phim.DataSource = LC_PhimDAO.Ins.GetScheduleRoom(
                (int)((cB_Phim.SelectedItem as DataRowView).Row["IDPhim"]),
                ((cB_PhongChieu.SelectedItem as DataRowView).Row["TenPhong"]).ToString()
                );
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ScheduleDetails form = new ScheduleDetails(false);
            form.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Phim.SelectedRows.Count == 0)
                return;
            using (ScheduleDetails form = new ScheduleDetails(true,
                new LichChieuPhim(((DataRowView)dgv_Phim.SelectedRows[0].DataBoundItem).Row)))
                form.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                LC_PhimDAO.Ins.DeleteSchedule((int)dgv_Phim.Rows[dgv_Phim.SelectedRows[0].Index].Cells["IDPhim"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

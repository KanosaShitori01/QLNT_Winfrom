using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLNT_Winform
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-MC\SQLEXPRESS;Database=QL_NHATTRINH;Integrated Security=true");
        DataTable dt;
        SqlDataAdapter adap;
        public Form3()
        {
            InitializeComponent();
        }
        private void activeSqlData()
        {
            adap = new SqlDataAdapter("SELECT * FROM TUYENDUONG", conn);
            dt = new DataTable();
            adap.Fill(dt);
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox) ctr.DataBindings.Clear();
            }
            cb_matuyen.DataSource = dt;
            cb_matuyen.ValueMember = "MaTuyen";
            cb_matuyen.DisplayMember = "MaTuyen";

            txt_giave.DataBindings.Add("Text", dt, "GiaVe");
            txt_tentuyen.DataBindings.Add("Text", dt, "TenTuyen");
            txt_sokm.DataBindings.Add("Text", dt, "SoKM");

            activeSqlDataGrid();
        }
        private void activeSqlDataGrid()
        {
            adap = new SqlDataAdapter(String.Format(
            "SELECT DMXE.MAXE, DMXE.TENXE, DMXE.TENLAIXE, DMXE.SOCHO, (TUYENDUONG.GIAVE * DMXE.SOCHO) AS THANHTIEN " +
            "FROM TUYENDUONG INNER JOIN CHITIET ON CHITIET.MATUYEN = TUYENDUONG.MATUYEN " +
            "INNER JOIN NHATTRINH ON NHATTRINH.SONT = CHITIET.SONT " +
            "INNER JOIN DMXE ON DMXE.MAXE = NHATTRINH.MAXE WHERE TUYENDUONG.MATUYEN = N'{0}'",
                cb_matuyen.Text), conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGV.DataSource = dt;
            paySum();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            activeSqlData();
        }
        private void paySum()
        {
            int tongtien = 0;
            for(int i = 0; i < dataGV.RowCount - 1; i++)
            {
                tongtien += Convert.ToInt32(dataGV.Rows[i].Cells["THANHTIEN"].Value);
            }
            lb_tongtien.Text = tongtien.ToString();
        }
        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_matuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeSqlDataGrid();
        }

        private void lb_tongtien_Click(object sender, EventArgs e)
        {

        }
    }
}

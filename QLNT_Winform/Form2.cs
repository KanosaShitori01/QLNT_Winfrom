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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-MC\SQLEXPRESS;Database=QL_NHATTRINH;Integrated Security=true");
        DataSet ds;
        SqlDataAdapter adap;

        public void activeDataSQL()
        {
            adap = new SqlDataAdapter("SELECT * FROM NHATTRINH", conn);
            ds = new DataSet();
            adap.Fill(ds, "dpl");
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "dpl";
            dataGV_NT.DataSource = bs;
            bindingNav_top.BindingSource = bs;
        }
        public void activeDataSQL_Child()
        {
            string query = String.Format("SELECT * FROM CHITIET INNER JOIN NHATTRINH " +
                "ON NHATTRINH.SONT = CHITIET.SONT AND CHITIET.SONT='{0}'", dataGV_NT.CurrentRow.Cells[0].Value);
            //MessageBox.Show(query);
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "dpl");
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = "dpl";
            dataGV_CT.DataSource = bs;
            bindingNav_bottom.BindingSource = bs;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            activeDataSQL();
            activeDataSQL_Child();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            activeDataSQL_Child();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            activeDataSQL_Child();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            activeDataSQL_Child();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            activeDataSQL_Child();
        }

        private void dataGV_CT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            activeDataSQL_Child();
        }
    }
}

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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-MC\SQLEXPRESS;Database=QL_NHATTRINH;Integrated Security=true");
        DataTable dt;
        SqlDataAdapter adap;
        CurrencyManager cum;
        public Form1()
        {
            InitializeComponent();
        }
        public void activeCommandBTN(string type)
        {
            string alert = "";
            string query = "";
            switch (type)
            {
                case "Add":
                    query = String.Format("ADD_LX '{0}', N'{1}', N'{2}', '{3}'",
                        txt_maxe.Text, txt_tenxe.Text, txt_tenlaixe.Text, txt_socho.Text);
                    alert = "Đã thêm thành công loại xe " + txt_tenxe.Text;
                    break;
                case "Edit":
                    query = String.Format("EDIT_LX '{0}', N'{1}', N'{2}', '{3}'",
                        txt_maxe.Text, txt_tenxe.Text, txt_tenlaixe.Text, txt_socho.Text);
                    alert = "Đã cập nhật thành công loại xe " + txt_tenxe.Text;
                    break;
                case "Delete":
                    query = String.Format("DELETE_LX '{0}'", txt_maxe.Text);
                    alert = "Đã thêm thành công loại xe " + txt_tenxe.Text;
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(alert);
                activeDataSQL();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Connection.Close();
        }
        private void clearTxt()
        {
            txt_maxe.Text = "";
            txt_tenxe.Text = "";
            txt_tenlaixe.Text = "";
            txt_socho.Text = "";
            txt_maxe.Enabled = true;
        }
        public void activeDataSQL()
        {
            adap = new SqlDataAdapter("SELECT * FROM DMXE", conn);
            dt = new DataTable();
            adap.Fill(dt);
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox) ctr.DataBindings.Clear();
            }
            txt_maxe.DataBindings.Add("Text", dt, "MaXe");
            txt_tenxe.DataBindings.Add("Text", dt, "TenXe");
            txt_tenlaixe.DataBindings.Add("Text", dt, "TenLaiXe");
            txt_socho.DataBindings.Add("Text", dt, "SoCho");

            cum = (CurrencyManager)this.BindingContext[dt];
            txt_pagec.Text = String.Format("{0}/{1}", cum.Position + 1, cum.Count);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            activeDataSQL();
            txt_maxe.Enabled = false;
        }

        private void txt_pagec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_prevfirst_Click(object sender, EventArgs e)
        {
            cum.Position = 0;
            txt_pagec.Text = String.Format("{0}/{1}", cum.Position + 1, cum.Count);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            cum.Position--;
            txt_pagec.Text = String.Format("{0}/{1}", cum.Position + 1, cum.Count);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            cum.Position++;
            txt_pagec.Text = String.Format("{0}/{1}", cum.Position + 1, cum.Count);
        }

        private void btn_nextlast_Click(object sender, EventArgs e)
        {
            cum.Position = cum.Count;
            txt_pagec.Text = String.Format("{0}/{1}", cum.Position + 1, cum.Count);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Visible = false;
            clearTxt();
            btn_luu.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            activeCommandBTN("Add");
            btn_them.Visible = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            activeCommandBTN("Edit");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult diares = MessageBox.Show("Bạn có chắc muốn xóa loại xe " + txt_tenxe.Text + "?", "Xóa Loại Xe",
                MessageBoxButtons.YesNo);
            if(diares == DialogResult.Yes)
                activeCommandBTN("Delete");
        }
    }
}

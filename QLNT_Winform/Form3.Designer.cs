
namespace QLNT_Winform
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sokm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.cb_matuyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.txt_tentuyen = new System.Windows.Forms.TextBox();
            this.txt_giave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sokm
            // 
            this.txt_sokm.Location = new System.Drawing.Point(124, 88);
            this.txt_sokm.Name = "txt_sokm";
            this.txt_sokm.Size = new System.Drawing.Size(121, 20);
            this.txt_sokm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TỔNG HỢP VẬN TẢI KHÁCH HÀNG";
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(13, 131);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(515, 182);
            this.dataGV.TabIndex = 3;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MÃ TUYẾN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Tiền:";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(472, 335);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(13, 13);
            this.lb_tongtien.TabIndex = 6;
            this.lb_tongtien.Text = "0";
            this.lb_tongtien.Click += new System.EventHandler(this.lb_tongtien_Click);
            // 
            // cb_matuyen
            // 
            this.cb_matuyen.FormattingEnabled = true;
            this.cb_matuyen.Location = new System.Drawing.Point(124, 52);
            this.cb_matuyen.Name = "cb_matuyen";
            this.cb_matuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_matuyen.TabIndex = 7;
            this.cb_matuyen.SelectedIndexChanged += new System.EventHandler(this.cb_matuyen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SỐ KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GIÁ VÉ";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(289, 55);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(69, 13);
            this.T.TabIndex = 10;
            this.T.Text = "TÊN TUYẾN";
            // 
            // txt_tentuyen
            // 
            this.txt_tentuyen.Location = new System.Drawing.Point(364, 52);
            this.txt_tentuyen.Name = "txt_tentuyen";
            this.txt_tentuyen.Size = new System.Drawing.Size(121, 20);
            this.txt_tentuyen.TabIndex = 9;
            // 
            // txt_giave
            // 
            this.txt_giave.Location = new System.Drawing.Point(364, 88);
            this.txt_giave.Name = "txt_giave";
            this.txt_giave.Size = new System.Drawing.Size(121, 20);
            this.txt_giave.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 364);
            this.Controls.Add(this.txt_giave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.T);
            this.Controls.Add(this.txt_tentuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_matuyen);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sokm);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sokm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.ComboBox cb_matuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.TextBox txt_tentuyen;
        private System.Windows.Forms.TextBox txt_giave;
    }
}
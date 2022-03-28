
namespace QLNT_Winform
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maxe = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenlaixe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_socho = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_prevfirst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.txt_pagec = new System.Windows.Forms.TextBox();
            this.btn_nextlast = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC CÁC LOẠI XE";
            // 
            // txt_maxe
            // 
            this.txt_maxe.Location = new System.Drawing.Point(107, 73);
            this.txt_maxe.Name = "txt_maxe";
            this.txt_maxe.Size = new System.Drawing.Size(131, 20);
            this.txt_maxe.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(6, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(106, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dong);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Location = new System.Drawing.Point(265, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Xe";
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(107, 110);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(131, 20);
            this.txt_tenxe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Lái Xe";
            // 
            // txt_tenlaixe
            // 
            this.txt_tenlaixe.Location = new System.Drawing.Point(107, 149);
            this.txt_tenlaixe.Name = "txt_tenlaixe";
            this.txt_tenlaixe.Size = new System.Drawing.Size(131, 20);
            this.txt_tenlaixe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Chở";
            // 
            // txt_socho
            // 
            this.txt_socho.Location = new System.Drawing.Point(107, 189);
            this.txt_socho.Name = "txt_socho";
            this.txt_socho.Size = new System.Drawing.Size(131, 20);
            this.txt_socho.TabIndex = 9;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(6, 47);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 23);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(6, 76);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(106, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(6, 105);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(106, 23);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            // 
            // btn_prevfirst
            // 
            this.btn_prevfirst.Location = new System.Drawing.Point(8, 15);
            this.btn_prevfirst.Name = "btn_prevfirst";
            this.btn_prevfirst.Size = new System.Drawing.Size(52, 23);
            this.btn_prevfirst.TabIndex = 6;
            this.btn_prevfirst.Text = "!<";
            this.btn_prevfirst.UseVisualStyleBackColor = true;
            this.btn_prevfirst.Click += new System.EventHandler(this.btn_prevfirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nextlast);
            this.groupBox2.Controls.Add(this.btn_next);
            this.groupBox2.Controls.Add(this.txt_pagec);
            this.groupBox2.Controls.Add(this.btn_prev);
            this.groupBox2.Controls.Add(this.btn_prevfirst);
            this.groupBox2.Location = new System.Drawing.Point(25, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(66, 15);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(56, 23);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // txt_pagec
            // 
            this.txt_pagec.Location = new System.Drawing.Point(128, 17);
            this.txt_pagec.Name = "txt_pagec";
            this.txt_pagec.Size = new System.Drawing.Size(70, 20);
            this.txt_pagec.TabIndex = 12;
            this.txt_pagec.TextChanged += new System.EventHandler(this.txt_pagec_TextChanged);
            // 
            // btn_nextlast
            // 
            this.btn_nextlast.Location = new System.Drawing.Point(264, 15);
            this.btn_nextlast.Name = "btn_nextlast";
            this.btn_nextlast.Size = new System.Drawing.Size(56, 23);
            this.btn_nextlast.TabIndex = 14;
            this.btn_nextlast.Text = ">|";
            this.btn_nextlast.UseVisualStyleBackColor = true;
            this.btn_nextlast.Click += new System.EventHandler(this.btn_nextlast_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(206, 15);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 23);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(6, 18);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(106, 23);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_socho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenlaixe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenxe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maxe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maxe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenlaixe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_socho;
        private System.Windows.Forms.Button btn_prevfirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_nextlast;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_pagec;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_luu;
    }
}


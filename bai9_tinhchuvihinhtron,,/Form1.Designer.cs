namespace bai9_tinhchuvihinhtron__
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.bnttinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdt = new System.Windows.Forms.RadioButton();
            this.rdbcv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tính chu vi hình tròn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "số thứ hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "kết quả";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(193, 96);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 2;
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(193, 153);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(100, 20);
            this.txtdientich.TabIndex = 2;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(193, 206);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 2;
            // 
            // bnttinh
            // 
            this.bnttinh.Location = new System.Drawing.Point(193, 262);
            this.bnttinh.Name = "bnttinh";
            this.bnttinh.Size = new System.Drawing.Size(75, 23);
            this.bnttinh.TabIndex = 3;
            this.bnttinh.Text = "tính";
            this.bnttinh.UseVisualStyleBackColor = true;
            this.bnttinh.Click += new System.EventHandler(this.bnttinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv);
            this.groupBox1.Controls.Add(this.rdbdt);
            this.groupBox1.Location = new System.Drawing.Point(476, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 232);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tính chu vi hình tròn";
            // 
            // rdbdt
            // 
            this.rdbdt.AutoSize = true;
            this.rdbdt.Location = new System.Drawing.Point(37, 43);
            this.rdbdt.Name = "rdbdt";
            this.rdbdt.Size = new System.Drawing.Size(67, 17);
            this.rdbdt.TabIndex = 0;
            this.rdbdt.TabStop = true;
            this.rdbdt.Text = "diện tích";
            this.rdbdt.UseVisualStyleBackColor = true;
            // 
            // rdbcv
            // 
            this.rdbcv.AutoSize = true;
            this.rdbcv.Location = new System.Drawing.Point(37, 84);
            this.rdbcv.Name = "rdbcv";
            this.rdbcv.Size = new System.Drawing.Size(54, 17);
            this.rdbcv.TabIndex = 0;
            this.rdbcv.TabStop = true;
            this.rdbcv.Text = "chu vi";
            this.rdbcv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnttinh);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtdientich);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button bnttinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcv;
        private System.Windows.Forms.RadioButton rdbdt;
    }
}


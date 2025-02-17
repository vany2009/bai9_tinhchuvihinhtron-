using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9_tinhchuvihinhtron__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bnttinh_Click(object sender, EventArgs e)
        {
            double bankinh, chuvi, dientich;
            bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbcv.Checked)
            {
                chuvi = Math.PI * (bankinh * 2);
                txtkq.Text = chuvi.ToString();
            }
            if (rdbdt.Checked)
            {
                dientich = Math.PI * (bankinh * bankinh);
                txtkq.Text = dientich.ToString();
            }


        }
    }
}

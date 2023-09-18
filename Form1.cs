using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Module2BaiSo3_TrinhHongNgoc
{
    public partial class bntThoat : Form
    {
        public bntThoat()
        {
            InitializeComponent();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
           lblHoTen.Text = txtTen.Text;
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
           lblHoTen.Text = txtHo.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btnHoTen_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnHoTen_Enter(object sender, EventArgs e)
        {
            
        }
    }
}

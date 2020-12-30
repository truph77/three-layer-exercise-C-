using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace MoHinh3Lop
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            UserBUS.Instance.Xem(dgvHello);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Sua(dgvHello))
            {
                MessageBox.Show("Sửa thành công!!!");
                btnXem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi!!!");
            }
        }
    }
}

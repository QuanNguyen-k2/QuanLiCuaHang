using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHang.DataAccessLayer;

namespace QuanLiCuaHang.PresentationLayer
{
    public partial class OverviewHangHoa : UserControl
    {
        public OverviewHangHoa()
        {
            InitializeComponent();
        }

        private void OverviewHangHoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAL_HangHoa.Instance.GetAllHangHoa();
        }
    }
}

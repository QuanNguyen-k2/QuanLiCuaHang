using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace QuanLiCuaHang.PresentationLayer
{
    public partial class MainForm : Form
    {
        public delegate void DelExit();
        public DelExit d;
 
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc,object sender)
        {
            ActivateButton(sender);
            this.panelDesktop.Controls.Clear();
            this.panelDesktop.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
        
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                ReloadBackColorBtn();
                Button currentButton = sender as Button;
                currentButton.BackColor = Color.BlueViolet;
            }
        }

        private void ReloadBackColorBtn()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(15, 30, 84);
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            var Overview = new OverViewNhanVien();
            AddUserControl(Overview, sender);

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            var Overview = new OverviewHangHoa();
            AddUserControl(Overview,sender);
        }
    }
}
        
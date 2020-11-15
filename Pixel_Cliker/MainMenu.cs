using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Cliker
{
    public partial class MainMenu : Form
    {
        Configs _config;

        public MainMenu()
        {
            InitializeComponent();
            _config = new Configs();
        }

        private void btnPixelScan_Click(object sender, EventArgs e)
        {
            Scan form = new Scan(_config);
            var result = form.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                _config = form._config;
            }
        }

        private void btnImageScan_Click(object sender, EventArgs e)
        {
            ScannerConfig form = new ScannerConfig(_config);
            var result = form.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                _config = form._config;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _config = new Configs();
        }
    }
}

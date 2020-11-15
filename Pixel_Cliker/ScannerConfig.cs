using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pixel_Cliker
{
    public partial class ScannerConfig : Form
    {

        public Configs _config;
        public static bool waitClick = false;
        public static int X;
        public static int Y;
        public bool colorPick = false;

        public ScannerConfig(Configs config)
        {
            InitializeComponent();
            this._config = config;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (_config.path == "" || _config.path == null)
                    _config.path = getPath();

                _config.posX = Convert.ToInt32(txtX.Text);
                _config.posY = Convert.ToInt32(txtY.Text);

                _config.click = rdbLeftClick.Checked ? "left" : "right";
                _config.typeScan = rdbAreaScan.Checked ? "area" : "screen";

                _config.intervalClick = txtInterval.Text;
                _config.R = picColor.BackColor.R;
                _config.G = picColor.BackColor.G;
                _config.B = picColor.BackColor.B;

                _config.Save();
            }
            catch
            {
                MessageBox.Show("Erro!", "Erro ao salvar configurações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            //TODO: Opção para pegar cor apartir do ponteiro   
            colorPick = true;
        }

        public Color GetColorAt()
        {
            Graphics myGraphics = this.CreateGraphics();

            Bitmap screenPixel = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, myGraphics);

            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            Graphics captureGraphics = Graphics.FromImage(screenPixel);

            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            return screenPixel.GetPixel(Cursor.Position.X, Cursor.Position.Y);
        }

        private void PixelScanner_Load(object sender, EventArgs e)
        {
            if (_config == null)
                return;
            if (_config.R.ToString() != "")
                picColor.BackColor = Color.FromArgb(_config.R, _config.G, _config.B);

            if (_config.posX != 0)
                txtX.Text = _config.posX.ToString();
            if (_config.posY != 0)
                txtY.Text = _config.posY.ToString();

        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            _config = new Configs(getPath()); //Aparece na primeira vez apenas para pegar o path
        }

        private String getPath()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.SelectedPath;
                    path += @"\config.xml";
                    return path;
                }
            }
            return "";
        }

        private void txtX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtX.Text = Cursor.Position.X.ToString();
            }
        }

        private void txtY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtY.Text = Cursor.Position.Y.ToString();
            }
        }

        private void PixelScanner_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPickColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && colorPick)
            {
                var c = GetColorAt();

                picColor.BackColor = Color.FromArgb(c.R, c.G, c.B);
            }
        }


    }
}
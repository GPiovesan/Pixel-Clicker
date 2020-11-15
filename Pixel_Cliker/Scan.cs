using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Pixel_Cliker
{
    public partial class Scan : Form
    {

        public Configs _config;
        static bool scanning = false;
        public Thread scan;

        public Scan(Configs _config)
        {
            InitializeComponent();
        }

        private void btnStart(object sender, EventArgs e)
        {            
            scan = new Thread(ScanThread);
            scan.Start();
            scanning = true;
            button2.Enabled = true;
        }

        static void ScanThread()
        {
            while (scanning)
            {
                Bitmap screenPixel = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                Graphics captureGraphics = Graphics.FromImage(screenPixel);

                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                return screenPixel.GetPixel(Cursor.Position.X, Cursor.Position.Y);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (scanning)
                scan.Abort();
        }
    }
}

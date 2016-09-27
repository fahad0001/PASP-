using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revision3Fyp
{
    public partial class LoadingForm : Form
    {
        Timer loadingTimer = new Timer();
        public LoadingForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            loadingTimer.Interval = 5000;
            loadingTimer.Enabled = true;
            loadingTimer.Start();
            loadingTimer.Tick += LoadingTimer_Tick;
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
            loadingTimer.Stop();
        }
    }
}

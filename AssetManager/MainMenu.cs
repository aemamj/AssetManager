using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AssetManager
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
            Combox1.SelectedIndex = 0;
        }

        private void BtnAssetTool_Click(object sender, EventArgs e)
        {
            AssetEditor subwindow = new AssetEditor();
            subwindow.ShowInTaskbar = false;
            subwindow.Show();
        }

        private void BtnCopyTools_Click(object sender, EventArgs e)
        {
            CopyTools copyTools = new CopyTools();
            copyTools.ShowInTaskbar = false;
            copyTools.Show();
        }

        private void Combox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combox1.SelectedIndex == 0)
                Program.Android = true;
            else
                Program.Android = false;


        }
    }
}

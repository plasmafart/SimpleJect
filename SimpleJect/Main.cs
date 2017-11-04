using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleJect
{
    public partial class Main : Form
    {
        /*=====Panel Dragging=====*/
        static bool isTopPanelDragged = false;
        private Point offset;
        private Point _normalWindowLocation = Point.Empty;
        /*=======================*/
        static OpenFileDialog dialog = new OpenFileDialog();
        static string selectedFilePath = null;
        static Process strProc = null;
        /*=======================*/

        public Main()
        {
            InitializeComponent();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
                isTopPanelDragged = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dialog.Title = "Select a file.";
            dialog.Filter = "(DLL FIles)|*.dll|All files (*.*)|*.*";
            if (!File.Exists(Config.cfgPath))
                File.Create(Config.cfgPath).Close();

            try
            {
                txtProc.Text = Config.ReadConfig(1);
                selectedFilePath = Config.ReadConfig(2);
                txtDll.Text = Path.GetFileName(selectedFilePath);
            }
            catch { return; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            selectedFilePath = dialog.FileName;
            txtDll.Text = Path.GetFileName(selectedFilePath);
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            Injection.InjectionSuccess = false;
            try { strProc = Process.GetProcessesByName(txtProc.Text)[0]; }
            catch { MessageBox.Show("Invalid process."); }
            Injection.Inject(strProc, selectedFilePath);
            if (Injection.InjectionSuccess)
            {
                MessageBox.Show("Success!");
                Config.SaveConfig($"{strProc.ProcessName}", selectedFilePath);
                return;
            }
            else
            { MessageBox.Show("Injection failed, check your inputs."); return; }
        }
    }
}

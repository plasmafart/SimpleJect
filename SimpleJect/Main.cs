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
using SimpleJect;

namespace SimpleJect
{
    public partial class Main : Form
    {
        /*=====Panel Dragging=====*/
        static bool isTopPanelDragged = false;
        private Point offset;
        private Point _normalWindowLocation = Point.Empty;
        /*=======================*/
        static bool FirstRun = false;
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
                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //Centering Github link label

            linkLabel1.Left = (this.ClientSize.Width - linkLabel1.Size.Width) / 2;

            this.CenterToScreen();
            dialog.Title = "Select a file.";
            dialog.Filter = "(DLL FIles)|*.dll|All files (*.*)|*.*";
            notifyIcon.Icon = Properties.Resources.logo;
            if (!File.Exists(Config.cfgPath))
            {
                File.Create(Config.cfgPath).Close();
                FirstRun = true;
            }

            try
            {
                SimpleJect.Update.CheckForUpdate(); // Check for update
                if (!SimpleJect.Update.IsCorrectVersion)
                    ShowBalloonTip("SimpleJect Updater", "You are using an outdated version of SimpleJect! Please check the discord server for any new updates. Click me to join server!", 30000, notifyIcon);
                else { ShowBalloonTip("SimpleJect Updater", $"No new updates found.\nCurrent injector version {SimpleJect.Update.appVers}", 2000, notifyIcon); }
                notifyIcon.BalloonTipClicked += OpenBrowser; 

                if (FirstRun)
                    ShowBalloonTip($"Welcome to SimpleJect!", $"SimpleJect by AVexxed#1602 | Build {SimpleJect.Update.appVers}", 2000, notifyIcon);
                txtProc.Text = Config.ReadConfig(1);
                selectedFilePath = Config.ReadConfig(2);
                txtDll.Text = Path.GetFileName(selectedFilePath);
            }
            catch { return; }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            selectedFilePath = dialog.FileName;
            txtDll.Text = Path.GetFileName(selectedFilePath);
        }

        static void OpenBrowser(object sender, EventArgs e)
        {
            Process.Start("https://discord.io/SimpleJect");
        }

        private void BtnInject_Click(object sender, EventArgs e)
        {
            string cutStr = null;
            if (txtProc.Text.Contains(".exe"))
                cutStr = txtProc.Text.Trim(new Char[] { '.', 'e', 'x', 'e' });
            else
                cutStr = txtProc.Text;

            Injection.InjectionSuccess = false;
            try {                  
                strProc = Process.GetProcessesByName(cutStr)[0];
            }
            catch {
                ShowBalloonTip("SimpleJect", "Invalid process.", 2000, notifyIcon);
                return;
            }
            Injection.Inject(strProc, selectedFilePath);
            if (Injection.InjectionSuccess)
            {
                ShowBalloonTip("SimpleJect", "Injection has succeeded!", 2000, notifyIcon);
                Config.SaveConfig($"{strProc.ProcessName}", selectedFilePath, null);
                return;
            }
            else
            {
                ShowBalloonTip("SimpleJect", "Injection failed, check your inputs.", 2000, notifyIcon);
                return;
            }
        }

        public static void ShowBalloonTip(string title, string message, int timeout, NotifyIcon icon)
        {
            icon.BalloonTipTitle = title;
            icon.BalloonTipText = message;
            icon.ShowBalloonTip(timeout);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkeys;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;
using IWshRuntimeLibrary;
namespace AutoScreenshot
{
    /*
     * this code was decompiled from a .exe file using dnSpy
     * because I lost the original source code due to clicnking buttons without thinking
     * It is working, but missing some design changes added later 
     */
    public partial class Form1 : Form
    {
        private Random r = new Random();

        // Token: 0x04000005 RID: 5
        private GlobalHotkey ghk;

        // Token: 0x04000006 RID: 6
        private int screenWidth = int.Parse(Screen.PrimaryScreen.Bounds.Width.ToString());

        // Token: 0x04000007 RID: 7
        private int screenHeight = int.Parse(Screen.PrimaryScreen.Bounds.Height.ToString());

        public Form1()
        {
            this.InitializeComponent();
            Form1.AddApplicationToStartup();
            Form1.CreateShortcut("ASS", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Assembly.GetExecutingAssembly().Location);
            this.ghk = new GlobalHotkey(0, Keys.Snapshot, this);
            this.ghk.Register();
        }

        // Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C  
        private void HandleHotkey()
        {
            this.WriteLine("Captured Screen!");
            this.takeScreenshot();
        }

        // Token: 0x0600000B RID: 11 RVA: 0x0000218F File Offset: 0x0000038F
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 786)
            {
                this.HandleHotkey();
            }
            base.WndProc(ref m);
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000021AB File Offset: 0x000003AB
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WriteLine("Trying to register SHIFT+ALT+O");
            if (this.ghk.Register())
            {
                this.WriteLine("Hotkey registered.");
                return;
            }
            this.WriteLine("Hotkey failed to register");
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000021DC File Offset: 0x000003DC
        private void takeScreenshot()
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.UtcNow.ToString("hh-mm-ss");
            string name = WindowsIdentity.GetCurrent().Name;
            new string((from x in Enumerable.Range(0, 15)
                        select "abcdefghijklmnopqrstuvwxyz0123456789"[this.r.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)]).ToArray<char>());
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), date + "_" + time + ".jpg");
            try
            {
                Bitmap captureBitmap = new Bitmap(this.screenWidth, this.screenHeight, PixelFormat.Format64bppPArgb);
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics.FromImage(captureBitmap).CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                this.screencapbox.BackgroundImage = captureBitmap;
                this.screencapbox.SizeMode = PictureBoxSizeMode.StretchImage;
                captureBitmap.Save(path, ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Token: 0x0600000E RID: 14 RVA: 0x000022EC File Offset: 0x000004EC
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == base.WindowState)
            {
                base.Hide();
            }
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000022FD File Offset: 0x000004FD
        private void WriteLine(string text)
        {
            Label label = this.label3;
            label.Text = label.Text + text + Environment.NewLine;
        }

        // Token: 0x06000010 RID: 16 RVA: 0x0000231B File Offset: 0x0000051B
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
            base.Show();
            base.WindowState = FormWindowState.Normal;
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002331 File Offset: 0x00000531
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002339 File Offset: 0x00000539
        private void button1_Click(object sender, EventArgs e)
        {
            this.HandleHotkey();
        }

        // Token: 0x06000013 RID: 19 RVA: 0x00002344 File Offset: 0x00000544
        public static void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("ASS", "\"" + Application.ExecutablePath + "\"");
            }
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "My shortcut description";   // The description of the shortcut
            shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

    }
}

using externalKeystrokes;
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
using System.Drawing.Drawing2D;

namespace externalKeystrokes
{
    public partial class Form1 : Form
    {
        public const string WINDOW_NAME = "Minecraft";

        public const int VK_LCONTROL = 0xA2;
        const uint KEYEVENTF_KEYUP = 0x0002;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            int initialStyle = imports.GetWindowLong(this.Handle, -20);
            imports.SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);

            imports.GetWindowRect(imports.handle, out imports.rect);
            this.Size = new Size(imports.rect.right - imports.rect.left, imports.rect.bottom - imports.rect.top);
            this.Left = imports.rect.left;

            this.Top = imports.rect.top;

            mainTimer.Start();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            int chars = 256;
            StringBuilder buff = new StringBuilder(chars);

            IntPtr handle = imports.GetForegroundWindow();

            if (imports.GetWindowText(handle, buff, chars) > 0)
            {
                string windowName = buff.ToString(); // this extra variable is here so you can check if contains

                if (windowName.Contains("Minecraft"))
                {
                    this.BringToFront();
                    this.TopMost = true;

                    this.Opacity = 100;
                }
                else
                {
                    this.Opacity = 0;
                }
            }

            if (imports.GetAsyncKeyState(Keys.W) < 0)
            {
                btnW.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                btnW.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.S) < 0)
            {
                btnS.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                btnS.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.A) < 0)
            {
                btnA.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                btnA.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.D) < 0)
            {
                btnD.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                btnD.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.LButton) < 0)
            {
                LMButton.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                LMButton.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.RButton) < 0)
            {
                RMButton.BackColor = Color.FromArgb(80, 80, 80);
            }
            else
            {
                RMButton.BackColor = Color.FromArgb(30, 30, 30);
            }


            if (imports.GetAsyncKeyState(Keys.W) < 0)
            {
                imports.keybd_event(VK_LCONTROL, 0, 0, 0);
                toggleLabel.Text = @"[(Toggle Sprint: Sprinting)]";
            }
            else
            {
                imports.keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
                toggleLabel.Text = @"[(Toggle Sprint: Not Sprinting)]";
            }
        }
    }
}

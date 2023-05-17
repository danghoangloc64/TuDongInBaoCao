using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDongInBaoCao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BaoCao1()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            //pointToClick = AutoControl.GetGlobalPoint(hWnd, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 90);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);


            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 10, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(3000);

            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }

            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }
        private void BaoCao2()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 115);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 55, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(3000);
            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }
            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);

            Thread.Sleep(3000);
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }

        private void BaoCao3()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 125);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            AutoControl.SendKeyDown(KeyCode.ENTER);

            Thread.Sleep(20000);



            //hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            //pointToClick = AutoControl.GetGlobalPoint(hWnd, 55, 35);
            //AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            //Thread.Sleep(3000);
            //for (int i = 0; i < 9; i++)
            //{
            //    AutoControl.SendKeyDown(KeyCode.TAB);
            //    Thread.Sleep(200);
            //}
            //Thread.Sleep(2000);
            //AutoControl.SendKeyDown(KeyCode.ENTER);
            //Thread.Sleep(10000);



            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1520, 10);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(1000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 340, 10);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

        }

        private void BaoCao8()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 270);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 10, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(3000);

            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }

            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);


            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }

        private void BaoCao9()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 300);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 55, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(3000);

            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }

            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);


            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }

        private void BaoCao14()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 440);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 10, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(3000);

            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }

            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);


            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }
        private void BaoCao22()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);

            int count = 0;
            while (hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
                count++;
                if (count > 20)
                {
                    break;
                }
            }
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            Point pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 55);
            AutoControl.BringToFront(hWnd);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
            Thread.Sleep(1000);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 380, 680);
            Thread.Sleep(1000);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(10000);

            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 10, 35);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);

            Thread.Sleep(3000);

            for (int i = 0; i < 9; i++)
            {
                AutoControl.SendKeyDown(KeyCode.TAB);
                Thread.Sleep(200);
            }

            Thread.Sleep(3000);
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(10000);


            hWnd = AutoControl.FindWindowHandle("WindowsForms10.Window.8.app.0.13965fa_r10_ad1", null);
            pointToClick = AutoControl.GetGlobalPoint(hWnd, 1500, 5);
            AutoControl.MouseClick(pointToClick, EMouseKey.LEFT);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxBC1.Checked)
            {
                BaoCao1();
            }
            if (checkBoxBC2.Checked)
            {
                Thread.Sleep(2000);
                BaoCao2();
            }
            if (checkBoxBC3.Checked)
            {
                Thread.Sleep(2000);
                BaoCao3();
            }
            if (checkBoxBC8.Checked)
            {
                Thread.Sleep(2000);
                BaoCao8();
            }
            if (checkBoxBC9.Checked)
            {
                Thread.Sleep(2000);
                BaoCao9();
            }
            if (checkBoxBC14.Checked)
            {
                Thread.Sleep(2000);
                BaoCao14();
            }
            if (checkBoxBC22.Checked)
            {
                Thread.Sleep(2000);
                BaoCao22();
            }
        }
    }
}

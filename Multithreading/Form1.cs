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

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountFun_Click(object sender, EventArgs e)
        {
            //btnCountFun.Enabled = false;
            //btnPrint.Enabled = false;

            //DoTimeCounsumingWork();
            Thread workThread = new Thread(DoTimeCounsumingWork);
            workThread.Start();
            //btnCountFun.Enabled = true;
            //btnPrint.Enabled = true;
        }

        private void DoTimeCounsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBoxText.Items.Add(i);
            }
        }
    }
}

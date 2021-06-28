using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMB
{
    public partial class LMB : Form
    {
        public LMB()
        {
            InitializeComponent();
        }

        public static SettingReader.Configurações set = new SettingReader.Configurações();
        public static string reminderfile = "rmd.scfg";
        public static string msg = "";
        public static TimeSpan cnt = new TimeSpan();
        static TimeSpan end = new TimeSpan(0, 0, 0);
        
        private void bkg_DoWork(object sender, DoWorkEventArgs e)
        {
            cnt -= new TimeSpan(0, 0, 1);
        }

        private void cmdIg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTn_Click(object sender, EventArgs e)
        {
            msg = txtLm.Text;
            cnt = new TimeSpan(0, Convert.ToInt16(txtTm.Text), 0);
            txtLm.Enabled = false;
            cmdIg.Enabled = false;
            cmdTn.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            tmT.Start();
            return;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (cmdOK.Text == "&OK")
            {
                msg = txtLm.Text;
                cnt = new TimeSpan(0, Convert.ToInt16(txtTm.Text), 0);
                cmdOK.Text = "&Cancelar";
                txtLm.Enabled = false;
                cmdIg.Enabled = false;
                cmdTn.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
                tmT.Start();
                return;
            }
            if (cmdOK.Text == "&Cancelar")
            {
                tmT.Stop();
                txtLm.Enabled = true;
                cmdOK.Text = "&OK";
            }
        }

        private void LMB_Load(object sender, EventArgs e)
        {
            txtLm.SelectionAlignment = HorizontalAlignment.Center;
            txtLm.Enabled = true;
        }

        private void tmT_Tick(object sender, EventArgs e)
        {
            bkg.RunWorkerAsync();
            if (cnt == end)
            {
                tmT.Stop();
                this.WindowState = FormWindowState.Normal;
                txtLm.Text = msg;
                cmdIg.Enabled = true;
                cmdTn.Enabled = true;
            }
        }

        private void LMB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                NLMB nv = new NLMB();
                nv.ShowDialog();
            }
        }
    }
}

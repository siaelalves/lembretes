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
    public partial class NLMB : Form
    {
        public NLMB()
        {
            InitializeComponent();
        }

        private void cmdNv_Enter(object sender, EventArgs e)
        {            
            txtNv.SelectAll();            
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}

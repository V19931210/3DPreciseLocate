using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PclSharp;
using PclSharp.IO;
using PclSharp.Common;
using PclSharp.Registration;

namespace _3DPreciseLocate
{
    public partial class frmPreciseLocate : Form
    {
        public frmPreciseLocate()
        {
            InitializeComponent();

            cbbRegisMethod.SelectedIndex = 0;
        }

        private void frmPreciseLocate_Load(object sender, EventArgs e)
        {

        }

        private void cbbRegisMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRegisMethod.SelectedIndex == 0)
            {
                labelNormal.Visible = false;
                numNormal.Visible = false;
            }
            else if (cbbRegisMethod.SelectedIndex == 1)
            {
                labelNormal.Visible = true;
                numNormal.Visible = true;
            }
            else
            {

            }
        }
    }
}

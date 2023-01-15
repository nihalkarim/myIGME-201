using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karim_groupProjectModule
{
    public partial class sectionDetails : Form
    {
        public sectionDetails()
        {
            InitializeComponent();

            this.backArrow.Click += new EventHandler(BackArrow__Click);
        }

        private void BackArrow__Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

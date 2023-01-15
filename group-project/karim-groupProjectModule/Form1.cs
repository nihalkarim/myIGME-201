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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.star1.Click += new EventHandler(Star1__Click);
            this.star2.Click += new EventHandler(Star2__Click);
            this.star3.Click += new EventHandler(Star3__Click);
            this.star4.Click += new EventHandler(Star4__Click);
            this.star5.Click += new EventHandler(Star5__Click);
            this.star6.Click += new EventHandler(Star6__Click);

            Button[] arrows = { arrow1, arrow2, arrow3, arrow4, arrow5, arrow6 };

            this.arrow1.Click += new EventHandler(Arrow__Click);
            this.arrow2.Click += new EventHandler(Arrow__Click);
            this.arrow3.Click += new EventHandler(Arrow__Click);
            this.arrow4.Click += new EventHandler(Arrow__Click);
            this.arrow5.Click += new EventHandler(Arrow__Click);
            this.arrow6.Click += new EventHandler(Arrow__Click);
        }
        private void Star1__Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            groupBox6.Location = groupBox5.Location;
            groupBox5.Location = groupBox4.Location;
            groupBox4.Location = groupBox3.Location;
            groupBox3.Location = groupBox2.Location;
            groupBox2.Location = groupBox1.Location;
        }

        private void Star2__Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

            groupBox6.Location = groupBox5.Location;
            groupBox5.Location = groupBox4.Location;
            groupBox4.Location = groupBox3.Location;
            groupBox3.Location = groupBox2.Location;
        }

        private void Star3__Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

            groupBox6.Location = groupBox5.Location;
            groupBox5.Location = groupBox4.Location;
            groupBox4.Location = groupBox3.Location;
        }

        private void Star4__Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;

            groupBox6.Location = groupBox5.Location;
            groupBox5.Location = groupBox4.Location;
        }

        private void Star5__Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

            groupBox6.Location = groupBox5.Location;
        }

        private void Star6__Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void Arrow__Click(object sender, EventArgs e)
        {
            sectionDetails details = new sectionDetails();
            details.ShowDialog();
        }

    }
}

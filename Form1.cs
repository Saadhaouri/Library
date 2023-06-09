using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            reservation1.BringToFront();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            livre1.BringToFront();
        }

        private void btnmembre_Click(object sender, EventArgs e)
        {
            membre1.BringToFront();
        }

        private void btnmoney_Click(object sender, EventArgs e)
        {
            prete1.BringToFront();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            categorie1.BringToFront();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

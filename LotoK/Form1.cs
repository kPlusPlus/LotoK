using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoK
{
    public partial class Form1 : Form
    {
        public Loto LO = new Loto();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            LO = new Loto();
            LO.Generate();

            MessageBox.Show("aaa " + LO.Numbers[0] + " " + LO.Numbers[4] );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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

            txtCombination.Text = RetLotoComb();
            SaveJSON();

            MessageBox.Show("aaa " + LO.Numbers[0] + " " + LO.Numbers[4] );
        }

        private string RetLotoComb() {
            string retVal = string.Empty;
            foreach( var item in LO.Numbers )
            {
                retVal += item.ToString() + " | ";
            }
            foreach( var item in LO.ReserveNumbers )
            {
                retVal += item.ToString() + " | ";
            }

            return retVal;
        }

        private void SaveJSON()
        {
            string sJson = JsonConvert.SerializeObject(LO);
            File.WriteAllText(txtFileName.Text, sJson);
        }

    }
}

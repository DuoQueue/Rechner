using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Rechner : Form
    {
        private Double ergebnis = 0;
        private String grundrechenarten = "";
        public Rechner()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
           if(ergebnisTextBox.Text=="0")
            {
                ergebnisTextBox.Clear();
            }
            Button zahl = (Button)sender;
            ergebnisTextBox.Text = ergebnisTextBox.Text + zahl.Text;
        }

        private void komplettenClearButton_Click(object sender, EventArgs e)
        {
            ergebnisTextBox.Text="0";
        }

        private void grundrechenarten_Click(object sender, EventArgs e)
        {
            Button grundrechenartenButton = (Button)sender;
            grundrechenarten = grundrechenartenButton.Text;
        }
    }
}

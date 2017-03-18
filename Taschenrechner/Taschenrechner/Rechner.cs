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
        private Double wert = 0;
        private String grundrechenarten = "";
        private bool grundrechenartenGedrückt = false;
        public Rechner()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
           if(ergebnisTextBox.Text=="0"||(grundrechenartenGedrückt))
            {
                ergebnisTextBox.Clear();
            }
            grundrechenartenGedrückt = false;
            Button zahl = (Button)sender;
            if(zahl.Text ==".")
            {
                if(!ergebnisTextBox.Text.Contains("."))
                {
                    ergebnisTextBox.Text = ergebnisTextBox.Text + zahl.Text;
                }
            }
            else
            ergebnisTextBox.Text = ergebnisTextBox.Text + zahl.Text;
        }

        private void komplettenClearButton_Click(object sender, EventArgs e)
        {
            ergebnisTextBox.Text="0";
        }

        private void grundrechenarten_Click(object sender, EventArgs e)
        {
            Button grundrechenartenButton = (Button)sender;
            if (wert != 0)
            {
                if(grundrechenartenButton.Text== "√")
                {
                    ergebnisTextBox.Text=Operatoren.Wurzel(Double.Parse(ergebnisTextBox.Text)).ToString();
                }
                ergebnisButton.PerformClick();
                grundrechenartenGedrückt = true;
                grundrechenarten = grundrechenartenButton.Text;
                rechnungsLabel.Text = wert + " " + grundrechenarten;
            }
            else if(grundrechenartenButton.Text== "√")
            {
                ergebnisTextBox.Text=Operatoren.Wurzel(Double.Parse(ergebnisTextBox.Text)).ToString();
                wert = Math.Sqrt(Double.Parse(ergebnisTextBox.Text));
            }
            else
            {
                grundrechenarten = grundrechenartenButton.Text;
                wert = Double.Parse(ergebnisTextBox.Text);
                grundrechenartenGedrückt = true;
                rechnungsLabel.Text = wert + " " + grundrechenarten;
            }
            rechnungsLabel.Focus();
        }

        private void ergebnisButton_Click(object sender, EventArgs e)
        {
            rechnungsLabel.Text="";
            switch(grundrechenarten)
            {
                case "+":
                    //ergebnisTextBox.Text = (wert + Double.Parse(ergebnisTextBox.Text)).ToString();
                    ergebnisTextBox.Text = Operatoren.Add(wert,Double.Parse(ergebnisTextBox.Text)).ToString();
                    break;
                case "-":
                    //ergebnisTextBox.Text = (wert + Double.Parse(ergebnisTextBox.Text)).ToString();
                    ergebnisTextBox.Text = Operatoren.Div(wert, Double.Parse(ergebnisTextBox.Text)).ToString();
                    break;
                case "*":
                    //ergebnisTextBox.Text = (wert + Double.Parse(ergebnisTextBox.Text)).ToString();
                    ergebnisTextBox.Text = Operatoren.Multi(wert, Double.Parse(ergebnisTextBox.Text)).ToString();
                    break;
                case "/":
                    //ergebnisTextBox.Text = (wert + Double.Parse(ergebnisTextBox.Text)).ToString();
                    ergebnisTextBox.Text = Operatoren.Div(wert, Double.Parse(ergebnisTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            wert = Int32.Parse(ergebnisTextBox.Text);
            grundrechenarten = "";
            rechnungsLabel.Focus();
        }

        private void löschButton_Click(object sender, EventArgs e)
        {
            ergebnisTextBox.Text="0";
            wert = 0;
            rechnungsLabel.Text = "";
        }

        private void Rechner_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                  zahl1Button.PerformClick();
                    break;
                case "2":
                    zahl2Button.PerformClick();
                    break;
                case "3":
                    zahl3Button.PerformClick();
                    break;
                case "4":
                    zahl4Button.PerformClick();
                    break;
                case "5":
                    zahl5Button.PerformClick();
                    break;
                case "6":
                    zahl6Button.PerformClick();
                    break;
                case "7":
                    zahl7Button.PerformClick();
                    break;
                case "8":
                    zahl8Button.PerformClick();
                    break;
                case "9":
                    zahl9Button.PerformClick();
                    break;
                case "0":
                    zahl0Button.PerformClick();
                    break;
                case "*":
                    multiButton.PerformClick();
                    break;
                case "+":
                    plusButton.PerformClick();
                    break;
                case "-":
                    minusButton.PerformClick();
                    break;
                case "/":
                    divButton.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}

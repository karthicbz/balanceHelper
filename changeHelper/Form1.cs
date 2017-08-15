using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeHelper
{
    public partial class Form1 : Form
    {
        Changer change;
        public int money = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            change = new Changer() { amount = int.Parse(amountBox.Text), cost = int.Parse(costBox.Text) };
            balanceBox.Text = change.currencybalance().ToString();

            /*tensLabel.Text = change.hundreds().ToString();
            hundredsLabel.Text = change.balancer().ToString();
            fiftysLabel.Text = change.balancer().ToString();*/

            money = int.Parse(change.currencybalance().ToString());
            int hundreds = 0;
            int fiftys = 0;
            int tens = 0;
            int twoThousands = 0;
            int fiveHundreds = 0;
            int twentys = 0;
            int ones = 0;
            int twos = 0;
            int fives = 0;

            while (money != 0)
            {
                if(money % 2000 == 0)
                {
                    money -= 2000;
                    twoThousands += 1;
                }
                else if(money % 500 == 0)
                {
                    money -= 500;
                    fiveHundreds += 1;
                }
                else if(money % 100 == 0)
                {
                    money -= 100;
                    hundreds += 1;
                    //hundredsLabel.Text = hundreds.ToString();
                    
                }
                else if(money % 50 == 0)
                {
                    money -= 50;
                    fiftys += 1;
                    //fiftysLabel.Text = fiftys.ToString();
                    
                }
                else if(money%20 == 0)
                {
                    money -= 20;
                    twentys += 1;
                }
                else if(money % 10 == 0)
                {
                    money -= 10;
                    tens += 1;
                    //tensLabel.Text = tens.ToString();
                    
                }
                else if(money % 5 ==0)
                {
                    money -= 5;
                    fives += 1;
                }
                else if(money % 2 == 0)
                {
                    money -= 2;
                    twos += 1;
                }
                else if(money % 1 ==0)
                {
                    money -= 1;
                    ones += 1;
                }
            }
            tThousandsLabel.Text = twoThousands.ToString();
            fhundredsLabel.Text = fiveHundreds.ToString();
            hundredsLabel.Text = hundreds.ToString();
            fiftysLabel.Text = fiftys.ToString();
            twentysLabel.Text = twentys.ToString();
            tensLabel.Text = tens.ToString();
            fivesLabel.Text = fives.ToString();
            twosLabel.Text = twos.ToString();
            onesLabel.Text = ones.ToString();


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            balanceBox.Clear();
            amountBox.Clear();
            costBox.Clear();
            tThousandsLabel.Text = 0.ToString();
            fhundredsLabel.Text = 0.ToString();
            hundredsLabel.Text = 0.ToString();
            fiftysLabel.Text = 0.ToString();
            twentysLabel.Text = 0.ToString();
            tensLabel.Text = 0.ToString();
            fivesLabel.Text = 0.ToString();
            twosLabel.Text = 0.ToString();
            onesLabel.Text = 0.ToString();

        }
    }
}

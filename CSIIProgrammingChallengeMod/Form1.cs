using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIIProgrammingChallengeMod
{
    public partial class Form1 : Form
    {

        double addSquare;
        double squareAdd;
        double subtractResult;
        double finalAnswer;
        bool odd = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < 101; i++)
            {
                squareAdd += Math.Pow(i,2);
                addSquare += i;
            }
            addSquare = Math.Pow(addSquare, 2);
            subtractResult = addSquare - squareAdd;
            finalAnswer = Math.Round(Math.Pow(subtractResult, 1.0 / 3.0));
            if (finalAnswer % 2 == 0)
            {
                odd = false;
            }
            else if(finalAnswer%2 != 0)
            {
                odd = true;
            }

            MessageBox.Show(addSquare + " " + squareAdd + " " + subtractResult + " " + finalAnswer + " " + odd);
        }
    }
}

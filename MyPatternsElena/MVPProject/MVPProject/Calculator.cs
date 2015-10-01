using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPProject
{
    public partial class Calculator : Form
    {
        Controller controller = new Controller();
        int number1;
        int number2;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            if (txtNumber1.Text == "" || txtNumber2.Text == "")
            { MessageBox.Show("Enter number 1 and number 2!"); }
         
            if(!Int32.TryParse(txtNumber1.Text, out number1)||(!Int32.TryParse(txtNumber2.Text, out number2)))
            {
                MessageBox.Show("You enter not number in textbox number 1 and/or number 2!"); 
            }

            else if (rbtAdd.Checked)
            {
                txtRezult.Text = (controller.ResultSumm(number1, number2)).ToString();
            }

            else if (rbtDiv.Checked)
            {
                txtRezult.Text = (controller.ResultDifference(number1, number2)).ToString();
            }

            else if (rbtMult.Checked)
            {
                txtRezult.Text = (controller.ResultMiltiplication (number1, number2)).ToString();
            }
            else if (rbtDivis.Checked)
            {
                if (number2 == 0)
                { MessageBox.Show("You cannt divide by zero!"); }
                else
                {
                    txtRezult.Text = (controller.ResultDivision(number1, number2)).ToString();
                }
            }


        }

    }
}

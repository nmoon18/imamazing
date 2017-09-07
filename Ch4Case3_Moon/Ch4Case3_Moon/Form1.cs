/*Name: noah Moon
 * Date: 2/17/17
 * Program: CH4 Case 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4Case3_Moon
{
    public partial class Form1 : Form
    {

        public decimal basePriceDecimal, totalPriceDecimal, ordertotalDecimal, personDecimal;

        private void summaryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Number of Customers:" + personDecimal + Environment.NewLine +
                "Total Price: " + ordertotalDecimal.ToString("c"), "error, jk lol");


            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            totalTExtBox.Clear();
            invisibleRadioButton.Checked = true;
            dvdRadioButton.Checked = false;
            blueRadioButton.Checked = false;
            newReleaseCheckBox.Checked = false;
            orderButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits program
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvdRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void invisibleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
          

            //order message box
            DialogResult dialogResult = MessageBox.Show("YOU SURE BRUV?", "LOLOL", MessageBoxButtons.YesNo);

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {

                //adds calculations
                ordertotalDecimal += totalPriceDecimal;

                personDecimal++;

               //resets total
                totalPriceDecimal = 0;

                summaryButton.Enabled = true;
                orderButton.Enabled = true;
                dvdRadioButton.Checked = false;
                blueRadioButton.Checked = false;
                newReleaseCheckBox.Checked = false;
                memberCheckBox.Checked = false;
                memberCheckBox.Enabled = true;
                totalTExtBox.Clear();
                subtotalTextBox.Clear();

            }




        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //checks name text box
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {

                MessageBox.Show("invalid Movie Name", "ERROR");

            }
            else if(string.IsNullOrWhiteSpace(nameTextBox.Text) == false){

                //checks video format
                if(invisibleRadioButton.Checked == true)
                {
                    MessageBox.Show("No Movie Format Selected", "ERROR");
                }


                
                if (invisibleRadioButton.Checked == false)
                {
                    //performs calculations
                    if (blueRadioButton.Checked)
                    {
                        basePriceDecimal = 5;
                    }
                    if (dvdRadioButton.Checked)
                    {
                        basePriceDecimal = 4.5m;
                    }

                    if (newReleaseCheckBox.Checked)
                    {
                        basePriceDecimal += 1;
                    }
                    if (memberCheckBox.Checked)
                    {
                        basePriceDecimal -= basePriceDecimal * .1m;


                    }

                    totalPriceDecimal += basePriceDecimal;

                    
                    orderButton.Enabled = false;

                    memberCheckBox.Enabled = false;
                    summaryButton.Enabled = false;



                    //displays calculations
                    subtotalTextBox.Text = totalPriceDecimal.ToString("c");
                    totalTExtBox.Text = basePriceDecimal.ToString("c");
                }

            }
        }
    }
}

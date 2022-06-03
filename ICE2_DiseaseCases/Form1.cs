/* Name: Smit Patel
 * Student ID: 100846414
 * Date: June 3rd, 2022
 * Subject: NETD 
 * ICE 2 - Modularity
 */


// TODO: comment Header
// TODO: add regions to organize your code

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE2_DiseaseCases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         double total = 0;

        // Global Variables
        Label[] weekDays;
        TextBox[] txtboundarray;
        double avg = 0;
        int infection = 0;
        // TODO: Add an event (ValueChanged) to the DateTimePicker control such that the weekday names are updated to match the chosen date. Note: the custom method to enter the names is already created, just call it.

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize the weekdays label array and populate with the appropriate labels
            weekDays = new Label[] { lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6, lblDay7 };

            // TODO: initialize the infections textbox array and populate with the appropriate textboxes
            txtboundarray = new TextBox[]
            {
                txtDay1, txtDay2, txtDay3, txtDay4, txtDay5, txtDay6, txtDay7 };
            // populate the week day name labels with the actual names.
            SetDayNames();

            // TODO: Create the method to set the form defaults called SetDefaults and uncomment out the line below.  The date picker should default to the current date and the infection textboxes should be empty.  review the SetDayNames() method for a hint how to do this.
            // SetDefaults();
        }


        private void SetDayNames()
        {
            for (int day = 1; day <= 7; day++)
            {
                //TODO: review the below line to see if you can figure out how it works!
                weekDays[day - 1].Text = (dtpStartingDate.Value.AddDays(day - 1)).DayOfWeek.ToString();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            

           foreach(TextBox textBoxToCheck in txtboundarray)
            { 
            if (ValidateInfections(textBoxToCheck))
               {
                    infection++;
                //TODO: Using a loop, calculate the average
                // Hint, int.Parse() should work as your validation should have already tested it using TryParse.

                }
            }
            if(infection == txtboundarray.Length)
            {
                avg = Math.Round(total / txtboundarray.Length, 2);
            }


            lblDailyAverage.Text = avg.ToString(); 
   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SetDefaults()

        {

            txtDay1.Clear();
            txtDay2.Clear();
            txtDay3.Clear();
            txtDay4.Clear();
            txtDay5.Clear();
            txtDay6.Clear();
            txtDay7.Clear();
            lblDailyAverage.ResetText();
            avg = 0;
            total = 0;
            infection = 0;  
            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: Create the method to set the form defaults called SetDefaults and uncomment out the line below.
            SetDefaults();

        }

        private bool ValidateInfections(TextBox textBoxInput)
        {
            double userinput;


            bool retVal = false;



            //TODO: complete this function such that if any of the infection textboxes are not numeric then validation fails.  It is expected to do this in a modular way (i.e. looping, rather than using the textbox names.)


            if (double.TryParse(textBoxInput.Text, out userinput))
            {

                retVal = true;

                total += userinput;




            }
            else
                
            {
                
            }        
                return retVal;
        }

        private void lblDailyAverage_Click(object sender, EventArgs e)
        {

        }
    }
}

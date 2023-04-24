using HoursLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoursCalculator
{
    public partial class hoursCalculatorForm : Form
    {
        private AMorPM item = new AMorPM();

        public hoursCalculatorForm()
        {
            InitializeComponent();
            SetupData();
                
        }

        private void SetupData()
        {
            
            item.Text1 = "AM";
            item.Value1 = 0;
            
            item.Text2 = "PM";
            item.Value2 = 1;

            string[] AMPM_List = { item.Text1, item.Text2 }; //local variable

            AMorPMCombobox1.Items.Add(AMPM_List[0]);
            AMorPMCombobox1.Items.Add(AMPM_List[1]);
            AMorPMCombobox1.SelectedIndex = 0;

            AMorPMCombobox2.Items.Add(AMPM_List[0]);
            AMorPMCombobox2.Items.Add(AMPM_List[1]);
            AMorPMCombobox2.SelectedIndex = 1;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start_hour = Convert.ToInt32(hour1TextBox.Text);
            int start_minute = Convert.ToInt32(minute1TextBox.Text);

            int end_hour = Convert.ToInt32(hour2TextBox.Text);
            int end_minute = Convert.ToInt32(minute2TextBox.Text);

            int sumHours = 0;
            
            int sumMinutes;
         
            item.Text1 = AMorPMCombobox1.Text; //AM or PM based on user choice
            item.Text2 = AMorPMCombobox2.Text; //AM or PM based on user choice

            if (item.Text1 == "PM" && item.Text2 == "PM") //if they are [both PM]
            {
                int end_hourL;  //new value we will end up with
                int end_minuteL; //new value we will end up with
                
                int result3, result4;
                
                end_hourL = end_hour;  //copying values
                end_minuteL = end_minute; //copying values

                hourMinuteResultText2.Text = "The time between " + start_hour + ":" + start_minute
                      + item.Text1 + " and " + end_hour + ":" + end_minute + item.Text2 + " is: ";

                if (start_minute > end_minute && start_hour > end_hour) // if start_hour is greater than end_min
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;
                    end_minuteLT += 60;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = result4;
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_minute == end_minute && start_hour > end_hour) // if start_hour is greater than end_min
                {
                    int start3 = 11; //11th hour
               
                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = (result4 + 1);
                    sumMinutes = (end_minuteL - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_minute < end_minute && start_hour > end_hour)
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = (result4 + 1);
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }
                
                if (start_minute > end_minute && end_hour > start_hour) 
                {
                    end_minuteL += 60;
                    end_hourL -= 1;

                    sumHours = (end_hourL - start_hour);
                    sumMinutes = (end_minuteL - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }
                if (start_minute == end_minute && end_hour > start_hour)
                {
                  
                    sumHours = (end_hour - start_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }
                if (start_minute < end_minute && end_hour > start_hour)
                {
                    sumHours = (end_hour - start_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }

                if (start_hour == end_hour && start_minute < end_minute)
                {
                    sumHours = (start_hour - end_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_hour == end_hour && start_minute > end_minute)
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;
                    end_minuteLT += 60;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = result4;
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }

            } // if they are [both PM]

            if (item.Text1 == "AM" && item.Text2 == "AM") // if they are [both AM]
            {
                int end_hourL;  //new value we will end up with
                int end_minuteL; //new value we will end up with

                int result3, result4;

                end_hourL = end_hour;  //copying values
                end_minuteL = end_minute; //copying values

                hourMinuteResultText2.Text = "The time between " + start_hour + ":" + start_minute
                      + item.Text1 + " and " + end_hour + ":" + end_minute + item.Text2 + " is: ";

                if (start_minute > end_minute && start_hour > end_hour) // if start_hour is greater than end_min
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;
                    end_minuteLT += 60;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = result4;
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_minute == end_minute && start_hour > end_hour) // if start_hour is greater than end_min
                {
                    int start3 = 11; //11th hour

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = (result4 + 1);
                    sumMinutes = (end_minuteL - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_minute < end_minute && start_hour > end_hour)
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = (result4 + 1);
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }

                if (start_minute > end_minute && end_hour > start_hour)
                {
                    end_minuteL += 60;
                    end_hourL -= 1;

                    sumHours = (end_hourL - start_hour);
                    sumMinutes = (end_minuteL - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }
                if (start_minute == end_minute && end_hour > start_hour)
                {

                    sumHours = (end_hour - start_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }
                if (start_minute < end_minute && end_hour > start_hour)
                {
                    sumHours = (end_hour - start_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

                }

                if (start_hour == end_hour && start_minute < end_minute)
                {
                    sumHours = (start_hour - end_hour);
                    sumMinutes = (end_minute - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
                if (start_hour == end_hour && start_minute > end_minute)
                {
                    int start3 = 11; //11th hour
                    int end_minuteLT = end_minute;
                    end_minuteLT += 60;

                    start_hour += 12;
                    start3 += 12;  //11:59 PM plus 12
                    result3 = (start3 - start_hour);
                    result4 = ((end_hour + 12) + result3);

                    sumHours = result4;
                    sumMinutes = (end_minuteLT - start_minute);

                    hourMinuteResultText.Text = sumHours.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";
                }
            } // if they are [both AM]

            if (item.Text1 == "AM" && item.Text2 == "PM") // if they are [AM 1st] then [PM 2nd]
            {
                int start_hourL;
                int end_hourL;
                int sumHoursL;

                start_hourL = start_hour;
                end_hourL = end_hour;
                sumHoursL = sumHours;

                end_hourL += 12;

                if (start_minute > end_minute)
                {
                    end_minute += 60;
                    end_hourL -= 1;
                    
                }

                sumHoursL = (end_hourL - start_hourL);
                
                sumMinutes = (end_minute - start_minute);

                hourMinuteResultText2.Text = "The time between " + start_hour + ":" + start_minute
                      + item.Text1 + " and " + end_hour + ":" + end_minute + item.Text2 + " is: ";
                hourMinuteResultText.Text = sumHoursL.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

            } // if they are [AM 1st] then [PM 2nd]

            if (item.Text1 == "PM" && item.Text2 == "AM") // if they are [AM 1st] then [PM 2nd]
            {
                int start_hourL;
                int end_hourL;
                int sumHoursL;

                start_hourL = start_hour;
                end_hourL = end_hour;
                sumHoursL = sumHours;

                end_hourL += 12;

                if (start_minute > end_minute)
                {
                    end_minute += 60;
                    end_hourL -= 1;

                }

                sumHoursL = (end_hourL - start_hourL);

                sumMinutes = (end_minute - start_minute);

                hourMinuteResultText2.Text = "The time between " + start_hour + ":" + start_minute
                      + item.Text1 + " and " + end_hour + ":" + end_minute + item.Text2 + " is: ";
                hourMinuteResultText.Text = sumHoursL.ToString() + " Hours "
                      + sumMinutes.ToString() + " Minutes";

            } // if they are [PM 1st] then [AM 2nd]


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears everything if clicked
            hour1TextBox.Clear();
            minute1TextBox.Clear();
            hour2TextBox.Clear();
            minute2TextBox.Clear();
            hourMinuteResultText.Text = "";
        }
    }
}

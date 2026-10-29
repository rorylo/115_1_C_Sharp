using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double PASS_SCORE = 60.0;

            const double HIGH_SCORE = 95.0;

            double test1, test2, test3, average;

            try
            {
                // Get the test scores from the TextBoxes.
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                // Calculate the average.
                average = (test1 + test2 + test3) / 3.0;
                // Display the average in the averageLabel control.
                averageLabel.Text = average.ToString("f1");
                // If the average is greater than or equal to HIGH_SCORE, display a message box.

                //if (average >= HIGH_SCORE)
                //{
                //    MessageBox.Show("恭喜！你獲得了高分！");
                //}

                if (average >= PASS_SCORE)
                {
                    if(average >= HIGH_SCORE)
                    {
                        MessageBox.Show("恭喜！你通過了測試並拿到高分。");
                    }
                    else
                    {
                        MessageBox.Show("恭喜！你通過了測試。");
                    }

                }
                else
                {
                    MessageBox.Show("抱歉，您未通過測試。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.Message"Please enter valid numeric values for all test scores.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

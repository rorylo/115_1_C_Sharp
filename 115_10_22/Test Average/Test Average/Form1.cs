using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單及其控制項。
            InitializeComponent();
        }

        // 處理「計算平均」按鈕的點擊事件。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告各次測驗分數及平均成績的變數。
            double test1, test2, test3, average;

            try
            {
                // 解析三次測驗分數的輸入值。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                // 計算平均成績。
                average = (test1 + test2 + test3) / 3;
                // 顯示平均成績，格式化為一位小數。
                averageLabel.Text = average.ToString("f1");
            }
            catch (Exception ex)
            {
                // 如果輸入的分數格式不正確，顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }


            test1 = double.Parse(test1TextBox.Text);
            test2 = double.Parse(test2TextBox.Text);
            test3 = double.Parse(test3TextBox.Text);

            average = (test1 + test2 + test3) / 3;

            averageLabel.Text = average.ToString("f1");
        }

        // 處理「清除」按鈕的點擊事件。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三次測驗分數及平均成績。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        // 處理「離開」按鈕的點擊事件。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        // 處理第一次測驗分數輸入內容變更事件。
        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

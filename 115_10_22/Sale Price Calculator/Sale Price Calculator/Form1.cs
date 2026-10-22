using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的控制項與介面設定。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告商品原價、折扣百分比與計算後的特價變數。
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 讀取文字欄位內容，並轉換為小數數值。
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 依照原價與折扣百分比計算折後價格。
            salePrice = originalPrice * (1 - discountPercentage / 100);

            // 將特價格式化為貨幣文字並顯示在結果欄位。
            salePriceLabel.Text = salePrice.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // 商品原價輸入內容變更時執行。
        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            // 折扣百分比輸入內容變更時執行。
        }
    }
}

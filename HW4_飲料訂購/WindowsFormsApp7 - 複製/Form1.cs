using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        //類別變數
        int amount01 = 0, amount02 = 0, amount03 = 0, amount04 = 0, amount05 = 0;
        int price01 = 0, price02 = 0, price03 = 0, price04 = 0, price05 = 0;
        double discounts = 0.0;
        double total = 0.0;
        double totalAfterDiscounts = 0.0;
        double total01 = 0.0, total02 = 0.0, total03 = 0.0, total04= 0.0, total05=0.0;
        double totalAfterDiscounts01 = 0.0, totalAfterDiscounts02 = 0.0, totalAfterDiscounts03= 0.0, totalAfterDiscounts04= 0.0, totalAfterDiscounts05 = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblItem01.Text = "麥香紅茶";
            lblItem02.Text = "茉莉綠茶";
            lblItem03.Text = "珍珠奶茶";
            lblItem04.Text = "玫瑰花茶";
            lblItem05.Text = "現打西瓜汁";

            price01 = 35;
            price02 = 40;
            price03 = 65;
            price04 = 50;
            price05 = 55;

            lblPrice01.Text = price01.ToString();
            lblPrice02.Text = price02.ToString();
            lblPrice03.Text = price03.ToString();
            lblPrice04.Text = price04.ToString();
            lblPrice05.Text = price05.ToString();

            discounts = 10.0;
        }

        private void btnCut01_Click(object sender, EventArgs e)
        {
            amount01 -= 1;
            if (amount01 < 0)
            {
                amount01 = 0;
                btnCut01.Enabled = false;
            }
            tbAmount01.Text = amount01.ToString();

        }

        private void btnAdd01_Click(object sender, EventArgs e)
        {
            amount01 += 1;
            btnCut01.Enabled = true;

            tbAmount01.Text = amount01.ToString();
        }

        private void btnBuy1Free1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("是否自動補足免費杯數?", "同品項買一送一", MessageBoxButtons.YesNoCancel);

           
            if (dialogResult == DialogResult.Yes)
            {
                if (amount01 % 2 == 1)
                {
                    tbAmount01.Text = (amount01 + 1).ToString();
                }
                if (amount02 % 2 == 1)
                {
                    tbAmount02.Text = (amount02 + 1).ToString();
                }
                if (amount03 % 2 == 1)
                {
                    tbAmount03.Text = (amount03 + 1).ToString();
                }
                if (amount04 % 2 == 1)
                {
                    tbAmount04.Text = (amount04 + 1).ToString();
                }
                if (amount05 % 2 == 1)
                {
                    tbAmount05.Text = (amount05 + 1).ToString();
                }
                buy1free1();
            }
            else if (dialogResult == DialogResult.No)
            {
                buy1free1();
            }
            else
            {
                //do nothing
            }
 
        }
        void buy1free1()
        {
            if (amount01 % 2 == 1)
            {
                amount01 += 1;
            }
            if (amount02 % 2 == 1)
            {
                amount02 += 1;
            }
            if (amount03 % 2 == 1)
            {
                amount03 += 1;
            }
            if (amount04 % 2 == 1)
            {
                amount04 += 1;
            }
            if (amount05 % 2 == 1)
            {
                amount05 += 1;
            }
            total01 = price01 * amount01;
            total02 = price02 * amount02;
            total03 = price03 * amount03;
            total04 = price04 * amount04;
            total05 = price05 * amount05;
            total = total01 + total02 + total03 + total04 + total05;

            totalAfterDiscounts = total / 2;
            tbTotalAfterDiscounts.Text = string.Format($"{totalAfterDiscounts:C}");
        }

        private void btnSixtyOff_Click(object sender, EventArgs e)
        {
            ArrayList iteminfo1 = new ArrayList();
            iteminfo1.Add("麥香紅茶");
            item


           // arrayPrice.Sort();

            

            /*foreach (double item in arrayPrice)
            {
                MessageBox.Show(item.ToString());
            }*/



            //int disAmounts = arrayAmount.Sum()/2;


            //MessageBox.Show(disAmounts.ToString());
            /*if (arrayAmount.IndexOf(arrayPrice[0]) > 0 )
            {
                int disAmounts01 = arrayAmount[arrayPrice[0]];
                MessageBox.Show(disAmounts01.ToString());
            }*/

        }

        private void tbAmount01_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount01.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbAmount01.Text, out amount01);
                    if (ifNum && amount01 >= 0)
                {
                    //正確輸入;
                    btnCut01.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amount01 = 0;
                    tbAmount01.Text = "0";
                }
            }
            else
            {
                amount01 = 0;
            }
            CalculateTotal();
        }

        private void btnCut02_Click(object sender, EventArgs e)
        {
            amount02 -= 1;
            if (amount02 < 0)
            {
                amount02 = 0;
                btnCut02.Enabled = false;
            }
            tbAmount02.Text = amount02.ToString();
        }

        private void btnAdd02_Click(object sender, EventArgs e)
        {
            amount02 += 1;
            btnCut02.Enabled = true;

            tbAmount02.Text = amount02.ToString();
        }

        private void tbAmount02_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount02.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbAmount02.Text, out amount02);
                if (ifNum && amount02 >= 0)
                {
                    //正確輸入;
                    btnCut02.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amount02 = 0;
                    tbAmount02.Text = "0";
                }
            }
            else
            {
                amount02 = 0;
            }
            CalculateTotal();
        }

        private void btnCut03_Click(object sender, EventArgs e)
        {
            amount03 -= 1;
            if (amount03 < 0)
            {
                amount03 = 0;
                btnCut03.Enabled = false;
            }
            tbAmount03.Text = amount03.ToString();
        }

        private void btnAdd03_Click(object sender, EventArgs e)
        {
            amount03 += 1;
            btnCut03.Enabled = true;

            tbAmount03.Text = amount03.ToString();
        }

        private void tbAmount03_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount03.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbAmount03.Text, out amount03);
                if (ifNum && amount03 >= 0)
                {
                    //正確輸入;
                    btnCut03.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amount03 = 0;
                    tbAmount03.Text = "0";
                }
            }
            else
            {
                amount03 = 0;
            }
            CalculateTotal();
        }

        private void btnCut04_Click(object sender, EventArgs e)
        {
            amount04 -= 1;
            if (amount04 < 0)
            {
                amount04 = 0;
                btnCut04.Enabled = false;
            }
            tbAmount04.Text = amount04.ToString();
        }

        private void btnAdd04_Click(object sender, EventArgs e)
        {
            amount04 += 1;
            btnCut04.Enabled = true;

            tbAmount04.Text = amount04.ToString();
        }

        private void tbAmount04_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount04.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbAmount04.Text, out amount04);
                if (ifNum && amount04 >= 0)
                {
                    //正確輸入;
                    btnCut04.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amount04 = 0;
                    tbAmount04.Text = "0";
                }
            }
            else
            {
                amount04 = 0;
            }
            CalculateTotal();
        }

        private void btnCut05_Click(object sender, EventArgs e)
        {
            amount05 -= 1;
            if (amount05 < 0)
            {
                amount05 = 0;
                btnCut05.Enabled = false;
            }
            tbAmount05.Text = amount05.ToString();
        }

        private void btnAdd05_Click(object sender, EventArgs e)
        {
            amount05 += 1;
            btnCut05.Enabled = true;

            tbAmount05.Text = amount05.ToString();
        }

        private void tbAmount05_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount05.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tbAmount05.Text, out amount05);
                if (ifNum && amount05 >= 0)
                {
                    //正確輸入;
                    btnCut05.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amount05 = 0;
                    tbAmount05.Text = "0";
                }
            }
            else
            {
                amount01 = 0;
            }
            CalculateTotal();
        }

        private void tbDiscounts_TextChanged(object sender, EventArgs e)
        {
            if(tbDiscounts.Text.Length > 0)
            {

                bool ifNum = double.TryParse(tbDiscounts.Text, out discounts);
                if (ifNum)
                {
                //轉換雙浮點數成功
                    if((discounts >= 0.0) && (discounts <= 10.0)){
                        //合理折數
                    }else{
                        MessageBox.Show("折數輸入錯誤(0.0-10.0)");
                        tbDiscounts.Text = "";
                        discounts = 10.0;
                    }
                }
                else
                {
                    MessageBox.Show("折數輸入錯誤(0.0-10.0)");
                    tbDiscounts.Text = "";
                    discounts = 10.0;
                }
            }
            else
            {
                discounts = 10.0;
            }

            CalculateTotal();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認送出訂購單?", "訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)
            {
                //取消

            }
            else
            {
                //確認訂購
                string strOrderList = "璇璇冷飲店訂購單           \n";
                strOrderList += "------------------------\n";
                if(amount01 > 0)
                {
                    strOrderList += lblItem01.Text + ":" + lblPrice01.Text +
                        "x" + tbAmount01.Text + "=" + total01.ToString() + "\n";
                }
                if (amount02 > 0)
                {
                    strOrderList += lblItem02.Text + ":" + lblPrice02.Text +
                        "x" + tbAmount02.Text + "=" + total02.ToString() + "\n";
                }
                if (amount03 > 0)
                {
                    strOrderList += lblItem03.Text + ":" + lblPrice03.Text +
                        "x" + tbAmount03.Text + "=" + total03.ToString() + "\n";
                }
                if (amount04 > 0)
                {
                    strOrderList += lblItem04.Text + ":" + lblPrice04.Text +
                        "x" + tbAmount04.Text + "=" + total04.ToString() + "\n";
                }
                if (amount05 > 0)
                {
                    strOrderList += lblItem05.Text + ":" + lblPrice05.Text +
                        "x" + tbAmount05.Text + "=" + total05.ToString() + "\n";
                }
                strOrderList += "------------------------\n";
                if (discounts < 10.0)
                {
                    strOrderList += "折數" + string.Format($"{discounts:F2}") + "\n";
                }

                strOrderList += "總價" + string.Format($"{total:C}")+ "\n";
                strOrderList += "折扣後總價" + string.Format($"{totalAfterDiscounts:C}")+ "\n\n";
                strOrderList += DateTime.Now + "\n";
                MessageBox.Show(strOrderList);
            }
        }
        void CalculateTotal()
        {
            
            total01 = price01 * amount01;
            total02 = price02 * amount02;
            total03 = price03 * amount03;
            total04 = price04 * amount04;
            total05 = price05 * amount05;

            totalAfterDiscounts01 = price01 * amount01 * discounts/10;
            totalAfterDiscounts02 = price02 * amount02 * discounts/10;
            totalAfterDiscounts03 = price03 * amount03 * discounts/10;
            totalAfterDiscounts04 = price04 * amount04 * discounts/10;
            totalAfterDiscounts05 = price05 * amount05 * discounts/10;



            total = total01 + total02 + total03 + total04 + total05;
            totalAfterDiscounts = (totalAfterDiscounts01 + totalAfterDiscounts02 + totalAfterDiscounts03 +
                totalAfterDiscounts04 +totalAfterDiscounts05);

            tbTotal.Text = string.Format($"{total:C}");
            tbTotalAfterDiscounts.Text = string.Format($"{totalAfterDiscounts:C}");
        }
        

    }
}

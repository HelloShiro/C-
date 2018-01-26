using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    if (tb公分.Text != "")
                    {
                        float myCM = 0.0f;
                        float myInche = 0.0f;
                        myCM = Convert.ToSingle(tb公分.Text);
                        myInche = myCM * 0.3937f;
                        tb英吋.Text = String.Format($"{myInche:F2}");


                    }
                    else if (tb英吋.Text != "")
                    {
                        float myCM = 0.0f;
                        float myInche = 0.0f;
                        myInche = Convert.ToSingle(tb英吋.Text);
                        myCM = myInche / 0.3937f;
                        tb公分.Text = String.Format($"{myCM:F2}");
                    }
                    else
                    {
                        MessageBox.Show("請輸入公分數值");
                        tb公分.Focus();
                    }
                }
                catch (Exception error)
                {
                    //MessageBox.Show(Convert.ToString(error));
                    MessageBox.Show("請輸入公分數值 \n \n error:1234");
                    tb公分.Focus();
                }

            }
            
        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            
                try
                {
                double myPing = 0.0;
                double mySquareMeter = 0.0;

                if (tb坪數.Text != "")
                    {
                        
                        myPing = Convert.ToDouble(tb坪數.Text);
                        mySquareMeter = myPing * 3.3058;
                        tb平方公尺.Text = Convert.ToString(mySquareMeter);
                    }
                    else if(tb平方公尺.Text != "")
                {

                    mySquareMeter = Convert.ToDouble(tb平方公尺.Text);
                    myPing = mySquareMeter / 3.3058;
                    tb坪數.Text = Convert.ToString(myPing);

                }
       
                    else
                    {
                        MessageBox.Show("請輸入坪數數值");

                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(Convert.ToString(error));
                }
            
            
        }

        private void btn公斤轉磅數_Click(object sender, EventArgs e)
        {
            if (tb公斤.Text != "")
            {
                try
                {
                    double mykg = 0.0;
                    double myPound = 0.0;
                    mykg = Convert.ToDouble(tb公斤.Text);
                    myPound = mykg * 2.2;
                    tb磅數.Text = Convert.ToString(myPound);

                }
                catch (Exception error)
                {
                    MessageBox.Show(Convert.ToString(error));
                }
            }
            else
            {
                MessageBox.Show("請輸入公斤數值");
            }
        }

 
       private void btn呎吋轉公分_Click(object sender, EventArgs e)
        {
           try
           {
                    if (tb公分.Text != "")
                    {
                        float myCM = 0.0f;
                        float myft = 0.0f;
                        float myInch = 0.0f;
                        myCM = Convert.ToSingle(tb公分.Text);
                        myft = (int)(myCM / 30.48f);
                        myInch = (myCM - myft * 30.48f) / 2.53999f;
                        tb呎.Text = String.Format($"{myft:F0}");
                        tb吋.Text = String.Format($"{myInch:F2}");

                    }
                    else if (tb吋.Text != "" && tb呎.Text != "")
                    {
                        float myCM = 0.0f;
                        float myft = 0.0f;
                        float myInch = 0.0f;
                        myft = Convert.ToSingle(tb呎.Text);
                        myInch = Convert.ToSingle(tb吋.Text);
                        myCM = myft * 30.48f + myInch * 2.53999f;
                        tb公分.Text = String.Format($"{myCM:F2}");
                    }
                    else
                    {
                        MessageBox.Show("請輸入數值 \n \n error: 1234");

                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(Convert.ToString(error));
                    //MessageBox.Show("請輸入公分數值 \n \n error:1234");

                }

            
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            tb公分.Clear();
            tb公斤.Clear();
            tb吋.Clear();
            tb呎.Clear();
            tb坪數.Clear();
            tb平方公尺.Clear();
            tb磅數.Clear();
            tb英吋.Clear();
        }
    }
}


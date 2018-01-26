using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form_chooseNum : Form
    {
        List<Button> myBtnList1 = new List<Button>();
        List<Button> myBtnList2 = new List<Button>();
        public Form_chooseNum()
        {
            InitializeComponent();
        }

        public void set_btn_tabpage1(int x,int y,int z)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j >= 8 && i == x - 1 )
                    {
                        break;
                    }
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Red;
                    btn.Size = new Size(45, 45);
                    btn.Location = new Point(40 + 50 * j, 80 + 50 * i);
                    btn.Text = (j + 1 + i * y).ToString();
                    btn.Name = "btn" + (j + 1 + i * y).ToString();
                    btn.Font = new Font("微軟正黑體", 13);
                    btn.Click += new EventHandler(btn_Click);

                    tabPage1.Controls.Add(btn);

                    myBtnList1.Add(btn);


                }
            }
            for(int i = 0; i < z; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Red;
                btn.Size = new Size(45, 45);
                btn.Location = new Point(40 + 50 * i, 280);
                btn.Text = (i+1).ToString();
                btn.Name = "btn_two" + i.ToString();
                btn.Font = new Font("微軟正黑體", 13);
                btn.Click += new EventHandler(btn_Click);
                tabPage1.Controls.Add(btn);
                myBtnList2.Add(btn);

            }
        }
        void btn_Click(object sender,EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            

                if (clickedBtn.BackColor == Color.White)
                {
                    clickedBtn.BackColor = Color.Pink;
                    tbResult.Text += clickedBtn.Text + " ";

                }
                else
                {
                    clickedBtn.BackColor = Color.White;
                }
            
        }
        private void Form_chooseNum_Load(object sender, EventArgs e)
        {
            set_btn_tabpage1(4, 10, 8);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
        
        }
    }
}

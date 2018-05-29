using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class Form1 : Form
    {

        
        int[] answers;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)  //開始
        {
            button1.Click += ChangeTheWords;
        }

        private void ChangeTheWords(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            button1.Text = "遊戲已開始！";
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            textBox1.MaxLength = 4;
            Random num = new Random();
            answers = new int[4];
            int i = 0;
            while(i<4)
            {
                
                int a = num.Next(0, 10);   //產生亂數0-9
                /* foreach (var item in answers)
                {
                    if(!answers.Contains(a))
                    {
                        answers[i] = a;
                    }
                }*/
                answers[i] = a;
                for (int j = 0; j < i; j++) //推進answers判斷的位置
                {
                    if (answers[j] == a)
                    {
                        i--;
                    }
                }
                i++;
            }
            //  MessageBox.Show(answers[0].ToString()+ answers[1].ToString() + answers[2].ToString() + answers[3].ToString());
        }

        private void button2_Click(object sender, EventArgs e)  //放棄
        {
            MessageBox.Show("好吧真沒有耐心~答案是"+answers[0].ToString() + answers[1].ToString() + answers[2].ToString() + answers[3].ToString() + "啦!");
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            button1.Text = "點擊再次開始！";

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //輸入欄
        {

        }
        
           
        private void button3_Click(object sender, EventArgs e)   //確認鍵
        {
            char[] input = textBox1.Text.ToCharArray();
            //MessageBox.Show("你輸入了"+ input[0].ToString() + input[1].ToString() + input[2].ToString() + input[3].ToString());

            int a = 0;
            int b = 0;
            
            if (textBox1.Text.Length == 4)
            {
                //var ins = answers.ToString().Intersect(input.ToString());
                for (int i = 0; i < 4; i++)
                {
                    if (answers[i].ToString() == input[i].ToString())
                    {
                        a++;
                        if (a == 4)
                        {
                            MessageBox.Show("恭喜你！答對囉！答案就是" + answers[0].ToString() + answers[1].ToString() + answers[2].ToString() + answers[3].ToString() + "啦!");
                            button1.Enabled = true;
                            button2.Enabled = false;
                            textBox1.Enabled = true;
                        }
                    }
                    else
                    {
                        for( int j =0; j < 4; j++)
                        {
                            if (i == j)
                            {
                                continue;
                            }
                            else
                            {
                                if(answers[i].ToString() == input[j].ToString())
                                {
                                    b++;
                                }
                            }
                        }
                        
                    }

                }
                label3.Text += input[0].ToString()+ input[1].ToString()+ input[2].ToString() +input[3].ToString()+"----"+a + "A" + b + "B \n";
            }
            else  //如果為非4數字
            {
                MessageBox.Show("請輸入4個數字！");
            }
        }

        private void label3_Click(object sender, EventArgs e)  //顯示欄
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


    }
}

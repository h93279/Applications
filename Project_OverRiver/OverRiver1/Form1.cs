using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverRiver1
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            原始清單();
            清單選擇方式();
            ChangeData();
        }


        private void 原始清單()
        {
            _leftList = new List<string> { "無辜的農夫", "看起來很餓的狼", "看起來很餓的羊", "瑟瑟發抖的高麗菜" };
            _rightList = new List<string>();
        }

        private void 清單選擇方式()
        {
            listBox1.SelectionMode = SelectionMode.One; //多選
            listBox2.SelectionMode = SelectionMode.One; //多選
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "1.只有農夫能夠划船，而且船比較小，除農夫之外每次只能運一種東西。\n\n" +
                "2.還有一個棘手問題，就是如果沒有農夫看著，羊會偷吃菜，狼會吃羊。\n\n" +
                "請考慮一種方法，讓農夫能夠安全地安排這些東西和他自己過河。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem;
                if (item == "無辜的農夫")
                {
                    _leftList.Remove(item);
                    _rightList.Add(item);
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else
                {
                    _leftList.Remove(item);
                    _rightList.Add(item);
                    _leftList.Remove("無辜的農夫");
                    _rightList.Add("無辜的農夫");
                    button1.Enabled = false;
                    button2.Enabled = true;
                }

                ChangeData();

                if (_leftList.Contains("瑟瑟發抖的高麗菜") && _leftList.Contains("看起來很餓的羊") && _leftList.Contains("看起來很餓的狼"))
                {
                    MessageBox.Show("你的身家被吃掉了啦！笨農夫！");
                    Application.Restart();
                }
                else if (_leftList.Contains("瑟瑟發抖的高麗菜") && _leftList.Contains("看起來很餓的羊"))
                {
                    MessageBox.Show("很餓的羊把瑟瑟發抖的高麗菜\n ...吃掉了O口Q！快點重來！");
                    Application.Restart();
                }
                else if (_leftList.Contains("看起來很餓的狼") && _leftList.Contains("看起來很餓的羊"))
                {
                    MessageBox.Show("很餓的狼嘿嘿嘿地接近了肥美的羊(in狼視角)...\n ... \n 羊羊被吃掉了！O口Q 快點重來！");
                    Application.Restart();
                }

                else if (_rightList.Contains("瑟瑟發抖的高麗菜") && _rightList.Contains("看起來很餓的羊") &&
                         _rightList.Contains("看起來很餓的狼") && _rightList.Contains("無辜的農夫"))
                {
                    MessageBox.Show("過河成功！所有的身家都平安無事！\n 大吉大利！今晚吃雞！");
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                if (item == "無辜的農夫")
                {
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
                else
                {
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    _rightList.Remove("無辜的農夫");
                    _leftList.Add("無辜的農夫");
                    button1.Enabled = true;
                    button2.Enabled = false;
                }

                ChangeData();

                if (_rightList.Contains("瑟瑟發抖的高麗菜") && _rightList.Contains("看起來很餓的羊") &&
                          _rightList.Contains("看起來很餓的狼"))
                {
                    MessageBox.Show("你的身家被吃掉了！趕快重來！笨農夫！");
                    Application.Restart();
                }

                else if (_rightList.Contains("瑟瑟發抖的高麗菜") && _rightList.Contains("看起來很餓的羊"))
                {
                    MessageBox.Show("很餓的羊把瑟瑟發抖的高麗菜\n ...吃掉了O口Q！快點重來！");
                    Application.Restart();
                }

                else if (_rightList.Contains("看起來很餓的狼") && _rightList.Contains("看起來很餓的羊"))
                {
                    MessageBox.Show("很餓的狼嘿嘿嘿地接近了肥美的羊(in狼視角)...\n 羊羊被吃掉了！O口Q 快點重來！");
                    Application.Restart();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSamples001
{
    public partial class Form1 : Form
    {
        private List<Rectangle> _list;
        private void CreateList()
        {
            _list = new List<ListSamples001.Rectangle>();
            _list.Add(new Rectangle { Name = "A", Width = 2, Height = 3 });
            _list.Add(new Rectangle { Name = "B", Width = 3, Height = 4 });
            _list.Add(new Rectangle { Name = "C", Width = 4, Height = 5 });
            _list.Add(new Rectangle { Name = "D", Width = 5, Height = 6 });

        }

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle item = (Rectangle)comboBox1.SelectedItem;
            MessageBox.Show(item.Name + "的面積為：" + item.GetArea().ToString());
        }
    }
}

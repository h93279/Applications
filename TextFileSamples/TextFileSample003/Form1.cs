using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSample003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = CreateData();
            dataGridView1.DataSource = list;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var source = (List<Restaurant>)dataGridView1.DataSource;
            List<Restaurant> ordered;
            switch (e.ColumnIndex)
            {
                case 1:
                    ordered = source.OrderBy((x) => x.DishName).ToList();
                    break;
                default:
                    ordered = source.OrderBy((x) => x.Seq).ToList();
                    break;
            }
            dataGridView1.DataSource = ordered;
        }

        private List <Restaurant> CreateData()
        {
            char[] splits = new char[] { ','};   ////區分以,分隔的字串
            string fileName = "Ori.csv";
            List<Restaurant> result = new List<Restaurant>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i=1; i < lines.Count(); i++)
                {
                    string[] item = lines[i].Split(splits);

                    var restaurant = new Restaurant
                    {
                        Seq = int.Parse(item[0]),
                        DishName = item[1],
                        Shop = item[3],
                        Address = item[4],
                        Tel = item[5]
                    };
                    result.Add(restaurant);
                }
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> lists { get; set; } = new List<string>
        {
            "apple",
             "banana",
             "blueberry",
             "cherry",
             "grape",
             "kiwi",
             "litchi",
             "mango",
             "mangosteen",
             "orange",
             "peach",
             "pear",
             "pineapple",
             "pitaya",
             "strawberry",
             "watermelon"
        };
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(btn.Text == "开始")
            {
                timer1.Enabled = true;
                btn.Text = "停止";
            }
            else if (btn.Text == "停止")
            {
                timer1.Enabled = false;
                btn.Text = "开始";
            }
            
        }

        private void start(object sender, EventArgs e)
        {
            Random rd = new Random();
            int index = rd.Next(15);
            string name = lists[index];
            ResourceManager resourceManager = Properties.Resources.ResourceManager;
            Bitmap image = (Bitmap)resourceManager.GetObject(name);
            pictureBox1.Image = image;
        }
    }
}

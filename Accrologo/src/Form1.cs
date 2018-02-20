using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accrologo
{
    public partial class Form1 : Form
    {
        public Graphics g { get; set; }
        private Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);
        private Tortoise turtle; 
        Parser Parser = new Parser();
        
        public Form1()
        {
            InitializeComponent();
            g = draw_box.CreateGraphics();
            turtle = new Tortoise(0 ,new Point(draw_box.Size.Width / 2, draw_box.Size.Height / 2));
        }

        private PictureBox newpic(string id, System.Drawing.Bitmap pb)
        {
            myPictureBox pf = new myPictureBox(id);
            pf.SizeMode = PictureBoxSizeMode.StretchImage;
            pf.Height = 53;
            pf.Width = 53;
            pf.Image = pb;
            return pf;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_clic(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("TOKEN1", global::Accrologo.Properties.Resources.discord1));
        }

        private void test_run(object sender, EventArgs e)
        {
            Queue<string> listToken = new Queue<string>();

            foreach (myPictureBox VARIABLE in layoutPanel.Controls)
            {
                Console.WriteLine(VARIABLE.token);
                listToken.Enqueue(VARIABLE.token);
            }

            Parser.Parse(listToken, turtle, g);

            listToken.Clear();
            layoutPanel.Controls.Clear();
        }

        private void forwardClick(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("FORWARD", global::Accrologo.Properties.Resources.dolphin));
        }


        private void button_left_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("LEFT", global::Accrologo.Properties.Resources.pandicorn));
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("RIGHT", global::Accrologo.Properties.Resources.Platypus));
        }

        private void button_repeate_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("REPEAT", global::Accrologo.Properties.Resources.alpaga));
        }

        private void button_one_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("ONE", global::Accrologo.Properties.Resources.un));
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("TWO", global::Accrologo.Properties.Resources.deux));
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("THREE", global::Accrologo.Properties.Resources.trois));
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("FOUR", global::Accrologo.Properties.Resources.quatre));
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("FIVE", global::Accrologo.Properties.Resources.cinq));
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("SIX", global::Accrologo.Properties.Resources.six));
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("SEVEN", global::Accrologo.Properties.Resources.sept));
        }

        private void button_eight_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("EIGHT", global::Accrologo.Properties.Resources.huit));
        }

        private void button_nine_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("NINE", global::Accrologo.Properties.Resources.neuf));
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("ZERO", global::Accrologo.Properties.Resources.zero));
        }

        private void button_rightbrace_Click(object sender, EventArgs e)
        {

            layoutPanel.Controls.Add(newpic("RIGHTBRACE", global::Accrologo.Properties.Resources.rightbrace));
        }

        private void button_leftbrace_Click(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("LEFTBRACE", global::Accrologo.Properties.Resources.leftbrace));
        }
    }
}

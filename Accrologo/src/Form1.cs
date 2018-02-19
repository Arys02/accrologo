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
        private Graphics g;
        private Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);
        private Image img = global::Accrologo.Properties.Resources.discord1;
        
        public Form1()
        {
            InitializeComponent();
            g = draw_box.CreateGraphics();
        }

        private PictureBox newpic(string id)
        {
            myPictureBox pf = new myPictureBox(id);
            pf.SizeMode = PictureBoxSizeMode.StretchImage;
            pf.Height = 53;
            pf.Width = 53;
            pf.Image = img;
            return pf;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_clic(object sender, EventArgs e)
        {
            layoutPanel.Controls.Add(newpic("TOKEN1"));
        }

        private void test_run(object sender, EventArgs e)
        {
            g.DrawLine(pen1, 250, 50, 400, 200);



            foreach (myPictureBox VARIABLE in layoutPanel.Controls)
            {

                //call parser 
                // parser.parse(variable.id)
                Console.WriteLine(VARIABLE.Image);
                Console.WriteLine(VARIABLE.token);
            }
        }

        private void forwardClick(object sender, EventArgs e)
        {

        }
    }
}

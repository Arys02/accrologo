using System.Windows.Forms;

namespace Accrologo
{
    public class myPictureBox : PictureBox
    {
        public string token;

        public myPictureBox(string token)
        {
            this.token = token;
        }
    }
}
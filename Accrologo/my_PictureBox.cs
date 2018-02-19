using System.Windows.Forms;

namespace Accrologo
{
    public class myPictureBox : PictureBox
    {
        public uint id;

        public myPictureBox(uint id)
        {
            this.id = id;
        }
    }
}
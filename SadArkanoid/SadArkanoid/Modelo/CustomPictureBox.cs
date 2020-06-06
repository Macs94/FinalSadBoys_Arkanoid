using System.Windows.Forms;

namespace SadArkanoid.Modelo
{
    public class CustomPictureBox : PictureBox
    {
        public int golpes { get; set; }
        public int addedScore { get; set; }

        public CustomPictureBox() : base()
        {
        }
    }
}
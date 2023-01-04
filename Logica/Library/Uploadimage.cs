using System.Windows.Forms;

namespace Logica.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"; ;
            fd.ShowDialog();
            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;


            }
        }

    }
}

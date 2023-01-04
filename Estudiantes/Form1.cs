using Logica;
using System.Drawing;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        //public LEstudiante estudiante = new LEstudiante();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, System.EventArgs e)
        {
            // estudiante.CargarImagen(pictureBoxImage);
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxId.Text.Equals(""))
            {
                label7.ForeColor = Color.Red;

            }
            else
            {
                label7.ForeColor = Color.Green;
                label7.Text = "ID ";
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                label5.ForeColor = Color.Red;

            }
            else
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Nombre ";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                label6.ForeColor = Color.Red;

            }
            else
            {
                label6.ForeColor = Color.Green;
                label6.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                label8.ForeColor = Color.Red;

            }
            else
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Email";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

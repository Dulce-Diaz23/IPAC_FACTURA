using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un usuario");
                UsuarioTextBox.Focus();

                return;
            }
            errorProvider1.Clear();

            if (ContrasenaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContrasenaTextBox, "Ingrese una contrasena");
                ContrasenaTextBox.Focus();

                return;
            }
            errorProvider1.Clear();


            Menu menuFormulario = new Menu();
            Hide();  //Ocultar formulario login
            menuFormulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContrasenaTextBox.PasswordChar == '*')
            {
                ContrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContrasenaTextBox.PasswordChar = '*';
            }
        }
    }
}

using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Esta es la funcion del boton donde al hacer click iniciamos la comprobacion de los campos de texto.
        private void button1_Click(object sender, EventArgs e)
        {
            //Estas son las variables de las contraseñas las cuales seran validadas.
            string contrasena1 = txtPassword1.Text;
            string contrasena2 = txtPassword2.Text;

            //Este if funciona para verificar que los campos de texto no se encuentren vacios.
            if (string.IsNullOrEmpty(txtPassword1.Text) || string.IsNullOrEmpty(txtPassword2.Text))
            {
                MessageBox.Show("Rellene ambos recuadros", "Error");
                return;
            }

            //Este if verifica que ambas contraseñas sean iguales.
            if (!contrasena1.Equals(contrasena2))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error");
                return;
            }
            
            //Este if y else funcionan para mandar el mensaje de si la contraseña es correcta y
            //cumple con los parametros o si es erronea.
            if (ValidarContrasena(contrasena1))
            {
                MessageBox.Show("Contraseña Validada", "Exito");
            }
            else
            {
                MessageBox.Show("La contraseña no es valida favor de usar los siguientes caracteres: " +
                    "\n-Una Mayuscula. \n-Un Caracter especial. \n-Una minuscula \n-Un numero. " +
                    "\n-Minimo 8 caracteres. ", "Error");
            }

        }

        //Esta funcion lee el texto y verifica que cumpla con lo que se pide.
        public bool ValidarContrasena(string password)
        {
            // Regex: 
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}

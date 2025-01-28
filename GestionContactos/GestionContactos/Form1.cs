namespace GestionContactos
{
    public partial class Form1 : Form
    {
        private const int MAX_CONTACTOS = 10;
        private string[] nombres = new string[MAX_CONTACTOS];
        private string[] telefonos = new string[MAX_CONTACTOS];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA�adirContacto_Click(object sender, EventArgs e)
        {
            /*Hecho por nacho*/
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del contacto:", "A�adir Contacto");
            string telefono = Microsoft.VisualBasic.Interaction.InputBox("Introduce el tel�fono del contacto:", "A�adir Contacto");

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Debe ingresar un nombre y un tel�fono.", "Error");
                return;
            }
            /*Esto comprueba que no se repita el contacto en el vector*/
            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == nombre)
                {
                    MessageBox.Show("El contacto ya existe.", "Error");
                    return;
                }
            }
            /*Esto a�ade el contacto al vector*/
            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = nombre;
                    telefonos[i] = telefono;
                    MessageBox.Show("Contacto a�adido correctamente.", "�xito");
                    return;
                }
            }

            MessageBox.Show("No hay espacio en la lista de contactos.", "Error");
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            /*Hecho por brayan*/
        }

        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            /*Hecho por nacho*/
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /*Hecho por brayan*/
        }
    }
}

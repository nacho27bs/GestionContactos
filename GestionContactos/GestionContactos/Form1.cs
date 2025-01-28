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

        private void A�adirContacto(string nombre, string telefono)
        {
            bool existe = false;
            bool espacioDisponible = false;

            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == nombre)
                {
                    existe = true;
                }
                if (nombres[i] == null && !existe)
                {
                    nombres[i] = nombre;
                    telefonos[i] = telefono;
                    espacioDisponible = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("El contacto ya existe.", "Error");
            }
            else if (!espacioDisponible)
            {
                MessageBox.Show("No hay espacio en la lista de contactos.", "Error");
            }
            else
            {
                MessageBox.Show("Contacto a�adido correctamente.", "�xito");
            }
        }

        private void ValidarEntrada(string nombre, string telefono)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Debe introducir tanto el nombre como el tel�fono.", "Error");
            }
        }

        private void btnA�adirContacto_Click(object sender, EventArgs e)
        {
            /*Hecho por nacho*/
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del contacto:", "A�adir Contacto");
            string telefono = Microsoft.VisualBasic.Interaction.InputBox("Introduce el tel�fono del contacto:", "A�adir Contacto");
            ValidarEntrada(nombre, telefono);
            A�adirContacto(nombre, telefono);
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            /*Hecho por brayan*/
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del contacto a eliminar:", "Eliminar Contacto");
            EliminarContacto(nombre);
        }
        private void EliminarContacto(string nombre)
        {
            bool encontrado = false;

            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == nombre)
                {
                    nombres[i] = null;
                    telefonos[i] = null;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Contacto eliminado correctamente.", "�xito");
            }
            else
            {
                MessageBox.Show("El contacto no existe.", "Error");
            }
        }

        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            /*Hecho por nacho*/
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del contacto a modificar:", "Modificar Contacto");
            string nuevoTelefono = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nuevo tel�fono:", "Modificar Contacto");
            ValidarEntrada(nombre, nuevoTelefono);
            ModificarTelefono(nombre, nuevoTelefono);
        }
        private void ModificarTelefono(string nombre, string nuevoTelefono)
        {
            bool encontrado = false;
            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == nombre)
                {
                    telefonos[i] = nuevoTelefono;
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                MessageBox.Show("Tel�fono actualizado correctamente.", "�xito");
            }
            else
            {
                MessageBox.Show("El contacto no existe.", "Error");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            /*Hecho por brayan*/
        }
    }
}

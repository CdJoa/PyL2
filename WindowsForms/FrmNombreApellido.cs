namespace WindowsForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = lb_Nombre.Text;
            string apellido = lb_Apellido.Text;

            // Crear un string con el formato deseado
            string nombreApellido = $"{nombre} {apellido}";

            // Pasar el string con el nombre y apellido a la siguiente forma
            FrmSaludar saludo = new FrmSaludar(nombreApellido);

            // Suscribir al evento Closed del formulario saludo
            saludo.Closed += (s, args) => this.Close();

            // Mostrar el formulario saludo
            saludo.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

/*namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}*/
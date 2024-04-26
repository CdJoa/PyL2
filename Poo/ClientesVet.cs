using System.Text;


namespace Poo
{
    public class ClientesVet
    {
        private string domicilio;
        private string apellido;
        private string nombre;
        private string telefono;
        private List<MascotasVet> mascotas;

        public ClientesVet(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = new List<MascotasVet>();
        }

        public void AgregarMascota(MascotasVet mascota)
        {
            mascotas.Add(mascota);
        }

        public string ObtenerNombreCompleto()
        {
            return $"{nombre} {apellido}";
        }

        public string ObtenerDomicilio()
        {
            return domicilio;
        }

        public string ObtenerTelefono()
        {
            return telefono;
        }

        public List<MascotasVet> ObtenerMascotas()
        {
            return mascotas;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo: {nombre} {apellido}");
            sb.AppendLine($"Domicilio: {domicilio}");
            sb.AppendLine($"Teléfono: {telefono}");
            sb.AppendLine("Mascotas:");
            foreach (var mascota in mascotas)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }
    }
}

/*    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar los clientes y mascotas solicitados
            var cliente1 = new ClientesVet("Juan", "Pérez", "Calle A 123", "123456789");
            var perroSinVacunar = new MascotasVet("Perro", "Firulais", new DateTime(2019, 5, 10));
            cliente1.AgregarMascota(perroSinVacunar);

            var cliente2 = new ClientesVet("María", "González", "Calle B 456", "987654321");
            var gatoConVacuna = new MascotasVet("Gato", "Pelusa", new DateTime(2020, 2, 15));
            gatoConVacuna.AgregarVacuna("Triple Felina");
            cliente2.AgregarMascota(gatoConVacuna);

            var cliente3 = new ClientesVet("Pedro", "López", "Calle C 789", "555555555");
            var gatoSinVacunas = new MascotasVet("Gato", "Michi", new DateTime(2021, 8, 20));
            var perroConVacuna = new MascotasVet("Perro", "Rex", new DateTime(2020, 10, 5));
            perroConVacuna.AgregarVacuna("Rabia");
            cliente3.AgregarMascota(gatoSinVacunas);
            cliente3.AgregarMascota(perroConVacuna);

            // Mostrar los datos por consola
            Console.WriteLine("Datos del cliente 1:");
            Console.WriteLine(cliente1);

            Console.WriteLine("\nDatos del cliente 2:");
            Console.WriteLine(cliente2);

            Console.WriteLine("\nDatos del cliente 3:");
            Console.WriteLine(cliente3);
        }*/
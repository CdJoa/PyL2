using System.ComponentModel;

namespace HilosYEventos
{
    public delegate void DelegadoString(string mensaje);


    public class PersonaH : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged(nameof(apellido));
                }
            }
        }
        public string Mostrar()
        {
            return $"{nombre} {apellido}";
        }

        public PersonaH(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}





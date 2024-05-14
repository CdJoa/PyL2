namespace Polimorfismo
{
    public abstract class SobreEscrito
    {
        protected string miAtributo;

        protected SobreEscrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get;}

        public abstract string MiMetodo();
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            SobreEscrito aux = obj as SobreEscrito;
            if(aux is not null){
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
/*
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Ejercicio Sobre-Sobrescrito";
        Sobrescrito objetoSobrescrito = new Sobreescrito();

        Console.WriteLine(objetoSobrescrito.ToString());

        string objeto = "¡Este es mi método ToString sobrescrito!";

        Console.WriteLine("----------------------------------------------");
        Console.Write("Comparación Sobrecargas con String: ");
        Console.WriteLine(objetoSobrescrito.Equals(objeto));

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(objetoSobrescrito.GetHashCode());

        Console.ReadKey();
    }
}
*/
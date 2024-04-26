namespace Calculadora
{
    public class Pitagoras
    {
        public static double CalcularHipotenusa(double ladoA, double ladoB)
        {
            return Math.Sqrt((ladoA * ladoA) + (ladoB * ladoB));
        }
        public static double CalcularLado(double lado, double hipotenusa)
        {
            return Math.Sqrt((hipotenusa * hipotenusa) - (lado * lado));
        }
    }
}
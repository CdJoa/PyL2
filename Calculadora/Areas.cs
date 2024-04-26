namespace Calculadora
{
    public class Areas
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)

        {
            return ((baseTriangulo * altura) / 2);
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }

    }
}
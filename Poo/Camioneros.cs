using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Camioneros
    {
        public string nombre;
        private int dia1;
        private int dia2;
        private int dia3;
        private int dia4;
        private int dia5;
        private int dia6;
        private int dia7;

        public Camioneros(string nombre, int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this.nombre = nombre;
            this.dia1 = dia1 >= 0 ? dia1 : 0;
            this.dia2 = dia2 >= 0 ? dia2 : 0;
            this.dia3 = dia3 >= 0 ? dia3 : 0;
            this.dia4 = dia4 >= 0 ? dia4 : 0;
            this.dia5 = dia5 >= 0 ? dia5 : 0;
            this.dia6 = dia6 >= 0 ? dia6 : 0;
            this.dia7 = dia7 >= 0 ? dia7 : 0;
        }
        public int KmDia(int dia)
        {
            switch (dia)
            {
                case 1: return dia1;
                case 2: return dia2;
                case 3: return dia3;
                case 4: return dia4;
                case 5: return dia5;
                case 6: return dia6;
                case 7: return dia7;
                default: return 0; // Si el día no está en el rango 1-7, retornar 0
            }
        }
        public int kmTotal()

        {
            return dia1 + dia2 + dia3 + dia4 + dia5 + dia6 + dia7;
        }
    }
}
/*
     class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de los tres camioneros con distancias aleatorias
            Camioneros camionero1 = new Camioneros("Jorge", 100, 150, -20, 180, 160, 140, 120);
            Camioneros camionero2 = new Camioneros("Miguel", 120, 130, 80, 170, 190, 110, 200);
            Camioneros camionero3 = new Camioneros("Pedro", 90, 140, 170, 150, 130, 160, 480);

        // Calcular los kilómetros totales recorridos por cada camionero
        int kmCamionero1Dia3 = camionero1.KmDia(3);
        int kmCamionero2Dia3 = camionero2.KmDia(3);
        int kmCamionero3Dia3 = camionero3.KmDia(3);

        int kmCamionero1 = camionero1.kmTotal();
        int kmCamionero2 = camionero2.kmTotal();
        int kmCamionero3 = camionero3.kmTotal();

        string camioneroMasKm = camionero1.nombre;
        int maxKm = kmCamionero1;

        camioneroMasKm = kmCamionero2 > maxKm ? camionero2.nombre : camioneroMasKm;
        maxKm = Math.Max(maxKm, kmCamionero2);

        camioneroMasKm = kmCamionero3 > maxKm ? camionero3.nombre : camioneroMasKm;
        maxKm = Math.Max(maxKm, kmCamionero3);


        string camioneroMasKmDia3 = camionero1.nombre;
        int maxKmDia3 = kmCamionero1Dia3;

        camioneroMasKmDia3 = kmCamionero2Dia3 > maxKmDia3 ? camionero2.nombre : camioneroMasKmDia3;
        maxKmDia3 = Math.Max(maxKmDia3, kmCamionero2Dia3);

        camioneroMasKmDia3 = kmCamionero3Dia3 > maxKmDia3 ? camionero3.nombre : camioneroMasKmDia3;
        maxKmDia3 = Math.Max(maxKmDia3, kmCamionero3Dia3);


        Console.WriteLine("El camionero que viajó más el día 3 es: " + camioneroMasKmDia3);
        Console.WriteLine("Kilómetros recorridos el día 3: " + maxKmDia3);
        Console.WriteLine("El camionero que recorrió más kilómetros en total es: " + camioneroMasKm);
        Console.WriteLine("Kilómetros totales recorridos: " + maxKm);
    }
*/
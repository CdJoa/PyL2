﻿
using System.Drawing;

namespace Herencia
{
    public enum Colores
    {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
    }
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}


/*
class Program
{
    static void Main(string[] args)
    {
        Camion camioncito = new Camion(8, 2, Colores.Azul, 5,5000);
        Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantidadRuedas, camioncito.cantidadPuertas, camioncito.color, camioncito.cantidadMarchas, camioncito.pesoCarga);
        Console.WriteLine("--------------");
        Automovil autito = new Automovil(4, 5, 5, Colores.Blanco, 3);
        Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantidadRuedas, autito.cantidadPuertas, autito.color, autito.cantidadMarchas, autito.cantidadPasajeros);
        Console.WriteLine("-----------");
        Moto motito = new Moto(2, 0, Colores.Rojo, 1000);
        Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantidadRuedas, motito.cantidadPuertas, motito.color, motito.cilindradas);
    }
}



*/
using System;
using System.Collections.Generic;

interface IVehiculo
{
    void Encender();
    void Apagar();
    void Detener();
    void Mover();
}

abstract class Monoplaza : IVehiculo
{
    public string Escuderia { get; set; }
    public bool Encendido { get; private set; }
    public bool Detenido { get; private set; }

    public Monoplaza(string escuderia)
    {
        Escuderia = escuderia;
        Encendido = false;
        Detenido = true;
    }

    public void Encender()
    {
        if (!Encendido)
        {
            Encendido = true;
            Console.WriteLine("Monoplaza encendido.");
        }
    }

    public void Apagar()
    {
        if (Encendido && Detenido)
        {
            Encendido = false;
            Console.WriteLine("Monoplaza apagado.");
        }
    }

    public void Detener()
    {
        if (Encendido && !Detenido)
        {
            Detenido = true;
            Console.WriteLine("Monoplaza detenido.");
        }
    }

    public void Mover()
    {
        if (Encendido && Detenido)
        {
            Detenido = false;
            Console.WriteLine("Monoplaza en movimiento.");
        }
    }
} 
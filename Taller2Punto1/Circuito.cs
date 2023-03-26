using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2Punto1
{
    internal class Circuito
    { 

            public string Nombre { get; set; }
            public int Vueltas { get; set; }
            public Monoplaza MonoplazaEnCircuito { get; private set; }

            public Circuito(string nombre, int vueltas)
            {
                Nombre = nombre;     
                Vueltas = vueltas;
            }

            public void AgregarMonoplaza(Monoplaza monoplaza)
            {
                if (MonoplazaEnCircuito == null)
                    MonoplazaEnCircuito = monoplaza;
            }

            public void SacarMonoplaza()
            {
                if (MonoplazaEnCircuito != null)
                    MonoplazaEnCircuito = null;
            }

            public double RealizarPrueba()
            {
                if (MonoplazaEnCircuito == null)
                    return -1;

                MonoplazaEnCircuito.Encender();
                MonoplazaEnCircuito.Mover();

                Random random = new Random();
                double mejorTiempo = double.MaxValue;

                for (int i = 0; i < Vueltas; i++)
                {
                double tiempoVuelta = new Random().Next(0, 999999)/1000.0;
                Console.WriteLine($"Tiempo de vuelta {i + 1}: {tiempoVuelta}");
                mejorTiempo = Math.Min(mejorTiempo, tiempoVuelta);
            }

            MonoplazaEnCircuito.Detener();
                MonoplazaEnCircuito.Apagar();

                return mejorTiempo;
            }
        }
    }

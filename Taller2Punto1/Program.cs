using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2Punto1
{
    internal class Program
    {
        
    static void Main(string[] args)
        {
            Circuito circuito = new Circuito("Circuito de pruebas", 5);
            List<Monoplaza> monoplazas = new List<Monoplaza> { new McLaren(), new Ferrari(), new RedBull() };
            Dictionary<string, double> resultados = new Dictionary<string, double>();
               
            foreach (Monoplaza monoplaza in monoplazas)
            {
                circuito.AgregarMonoplaza(monoplaza);
                double mejorTiempo = circuito.RealizarPrueba();
                resultados.Add(monoplaza.Escuderia, mejorTiempo);
                circuito.SacarMonoplaza();
            }

            Console.WriteLine("\nTabla de posiciones:");
            foreach (var resultado in resultados)
            {
                Console.WriteLine($"{resultado.Key}: {resultado.Value} segundos");
            }
        }     
    }
    class McLaren : Monoplaza
    {
        public McLaren() : base("McLaren") { }
    }

    class Ferrari : Monoplaza
    {
        public Ferrari() : base("Ferrari") { }
    }

    class RedBull : Monoplaza
    {
        public RedBull() : base("RedBull") { }
    }
}


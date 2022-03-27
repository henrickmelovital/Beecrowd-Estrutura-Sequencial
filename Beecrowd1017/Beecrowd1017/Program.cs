using System;
using System.Globalization;

namespace Beecrowd1017 {
    class Program {
        static void Main(string[] args) {

            int tempo, velocidade, distancia;
            double litronecessario;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            litronecessario = distancia / 12.0;

            Console.WriteLine(litronecessario.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

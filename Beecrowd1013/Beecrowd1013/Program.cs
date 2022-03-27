using System;
using System.Globalization;

namespace Beecrowd1013 {
    class Program {
        static void Main(string[] args) {

            double A, B, C, maiorAB, maior;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;

            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}

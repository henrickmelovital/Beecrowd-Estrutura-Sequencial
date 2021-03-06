using System;
using System.Globalization;

namespace Beecrowd1011 {
    class Program {
        static void Main(string[] args) {

            double volume, pi = 3.14159, R;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

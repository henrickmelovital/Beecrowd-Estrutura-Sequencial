using System;
using System.Globalization;

namespace Beecrowd1009 {
    class Program {
        static void Main(string[] args) {

            string nome;
            double salariofixo, totalvendas, salariototal;

            nome = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salariototal = totalvendas * 15.0 / 100 + salariofixo;

            Console.WriteLine("TOTAL = R$ " + salariototal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

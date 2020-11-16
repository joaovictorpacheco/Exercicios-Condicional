using System;

namespace ExercíciosCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            int meses = (idade * 12);
            int dias = (idade * 365);
            int horas = (dias * 24);
            int minutos = (horas * 60);

            System.Console.WriteLine("idade em meses: "+ meses);
            System.Console.WriteLine("idade em dias: "+ dias);
            System.Console.WriteLine("idade em horas: "+ horas);
            System.Console.WriteLine("idade em minutos: "+ minutos);
        }
    }
}

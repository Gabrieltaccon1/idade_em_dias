using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, dias, meses, resto;

            Console.WriteLine("DIGITE SUA IDADE EM DIAS");
            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine("anos:" + anos);
            Console.WriteLine("meses:" + meses);
            Console.WriteLine("dias:" + dias);


        }
    }
}

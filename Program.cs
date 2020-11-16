using System;

namespace Excercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex02-Ano de nascimento de uma pessoa e o ano atual ");
          
            int anoAtual = 2020;

            Console.WriteLine("Digite o ano de seu nascimento:");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int idadeEmAnos = anoAtual - anoDeNascimento;
            int idadeEmSemanas = idadeEmAnos * 52;

            Console.WriteLine("Você tem " + idadeEmAnos + " anos. Isso é equivalente há " + idadeEmSemanas + " semanas.");

        }
    }
}

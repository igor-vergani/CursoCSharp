using System;
using System.Runtime.Serialization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1

            Console.WriteLine("Digite um numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("A soma dos números digitados é: " + soma);



        }

    }


}


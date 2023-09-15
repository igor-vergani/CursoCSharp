using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 3
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Console.WriteLine("digite o valor A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B:");
            int B = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de C:");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine("Diferença = " + diferenca);









        }

    }


}


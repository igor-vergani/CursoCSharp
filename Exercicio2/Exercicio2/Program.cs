using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2

            

            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * raio * raio;

            Console.WriteLine("O valor da área é :" +  area.ToString());




        }

    }


}


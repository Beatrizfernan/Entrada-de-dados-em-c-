using System;
using System.Globalization;

namespace Exercicio_de_fixaçâo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");

            string nome = Console.ReadLine();
           

            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de um produto:");
            double preço = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com seu ultimo nome,idade e altura(mesma linha):");
            string[] vet=Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura =double.Parse(vet[2],CultureInfo.InvariantCulture);



            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preço);
            Console.WriteLine(lastname);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}

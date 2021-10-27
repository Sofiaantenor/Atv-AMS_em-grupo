using System;

namespace WhileCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int contador = 1;
            int qtdPessoas = 0;

           

           while (contador <= 10)
           {
               contador++;
               Console.WriteLine("Informe sua idade:");
               idade = Convert.ToInt32(Console.ReadLine());
           
               if (idade >= 18)
           {
               qtdPessoas = qtdPessoas + 1;
           }

           }
           Console.WriteLine($"Dentre essas pessoas, {qtdPessoas} têm permissão para dirigir!");

        }
    }
}

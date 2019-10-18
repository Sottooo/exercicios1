using System;

namespace cliete
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Jeferson", "55 5555-4444" , "jedroguinha@email.com");

            System.Console.WriteLine("Nome: " + cliente1.Nome);
            System.Console.WriteLine("Telefone: " + cliente1.Telefone);
            System.Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}

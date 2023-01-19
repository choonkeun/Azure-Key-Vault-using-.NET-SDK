using ConsoleApp1.Azure;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Key Vault access using .NET Client with .NET Core 3.1");

            KeyVaultManager keyVaultmanager = new KeyVaultManager();

            Console.WriteLine("my-test-secret-1: {0}", keyVaultmanager.GetSecret("my-test-secret-1"));
            Console.WriteLine("BookStores: {0}", keyVaultmanager.GetSecret("BookStores"));

            Console.ReadLine();
        }
    }
}


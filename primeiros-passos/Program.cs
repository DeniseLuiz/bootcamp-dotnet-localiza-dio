using System;

namespace primeiros_passos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDevezes = 5;
            
            for(int i=0; i< numeroDevezes; i++)
            {
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            }
        }
    }    
}

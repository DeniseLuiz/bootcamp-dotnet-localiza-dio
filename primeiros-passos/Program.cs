using System;

namespace primeiros_passos
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numeroDevezes = 5;
            
            // for(int i=0; i< numeroDevezes; i++)
            // {
            //     Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            // }
            
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }    
}

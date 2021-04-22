using System;

namespace DIO.bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Denise Luiz");
            Console.WriteLine(minhaConta.ToString());
            //minhaConta.Depositar(50);
            //Console.WriteLine($"O saldo da conta é {minhaConta.Saldo}");

            //minhaConta.Sacar(100);
            //Console.WriteLine($"O saldo da conta é {minhaConta.Saldo}");


            Console.ReadLine();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        public double Saldo { get; private set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public double NumeroConta { get; set; }

        public int[] Senha { get; set; }

        public Conta(TipoConta tipoConta,  double saldo, double credito, string nome, int[] senha)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
            Senha = senha;
           //Tem como eu mudar a visibilidade após setar esse valor???
        }

        public bool VerificarSenha(int[] senha)
        {

            int verificadorSenha = 0; 

            for(int i = 0; i <4; i++)
            {
                if(senha[i] == Senha[i])
                {
                    verificadorSenha++;
                }
            }

            if(verificadorSenha != 4)
            {
                Console.WriteLine($"Senha inválida! Saque não autorizado");
                return false;
            }

            return true;
        }

        public bool Sacar(double valorSaque)
        {
            if(Saldo - valorSaque < (Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        }
       
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Tipo Conta: {TipoConta} |";                          
            retorno += $"Nome: {Nome} |";                          
            retorno += $"Saldo: {Saldo} |";                          
            retorno += $"Credito: {Credito} |";
            //retorno += $"Senha: {Senha[0]}{Senha[1]}{Senha[2]}{Senha[3]}";

            return retorno;
        }
    }
}

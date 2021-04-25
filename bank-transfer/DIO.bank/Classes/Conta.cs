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
        public string NumeroConta { get; set; }
        public string DigitoConta { get; set; }
        public int[] Senha { get; set; }

        public Conta(TipoConta tipoConta,  double saldo, double credito, string nome, int[] senha)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome; //Como evitar que o nome digitado seja um espaço vazio?
            Senha = senha;  //Tem como eu mudar a visibilidade após setar esse valor???
            NumeroConta = gerarNumeroDaConta();

            Console.Clear();
            Console.WriteLine($"Conta criada com sucesso! O número da sua conta é {NumeroConta}.");
            Console.WriteLine("Anote-o para que possa realizar transações mais tarde.");
            Console.ReadLine();
        }

        public string gerarNumeroDaConta()
        {
            Random random = new Random();
            string numeroConta = "";
            DigitoConta = Convert.ToString(random.Next(9));

            for(int i = 0; i<= 4; i++)
            {
                numeroConta += $"{random.Next(9)}"; //Como fazer uma máscara para quando o usuário digitar ficar com o tracinho.
            }

            return $"{numeroConta}-{DigitoConta}";
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
            retorno += $"Número da conta: {NumeroConta} |";
            retorno += $"Tipo Conta: {TipoConta} |"; // Como fazer para imprimir a descrição do enum e não a string junta PessoaFisica
            retorno += $"Nome: {Nome} |";
            retorno += $"Saldo: {Saldo} |";
            retorno += $"Credito: {Credito} |";
            //retorno += $"Senha: {Senha[0]}{Senha[1]}{Senha[2]}{Senha[3]}";

            return retorno;
        }
    }
}

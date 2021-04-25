using System;
using System.Collections.Generic;

namespace DIO.bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        try{
                            InserirContas();
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Argumento inválido");
                            Console.WriteLine();
                            opcaoUsuario = ObterOpcaoUsuario();
                        }
                        break;
                    case "3":
                        Tranferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void Tranferir()
        {
            Console.Clear();
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Clear();
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Clear();

            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            int[] senha = new int[4];
            Console.WriteLine("Digite sua senha númerica de 4 dígitos: ");
            for(int i = 0; i<4; i++)
            {
                Console.Write($"Digite o caracter numérico {i + 1}: ");
                //Tem como limitar o readlie a ler somente um caracter por vez?
                senha[i] = int.Parse(Console.ReadLine());
            }
            

            if (listContas[indiceConta].VerificarSenha(senha))
            {
                Console.Write("Digite o valor a ser sacado: ");
                double valorSaque = double.Parse(Console.ReadLine());

                listContas[indiceConta].Sacar(valorSaque);
                Console.ReadLine();
            }
        }

        private static void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write($"#{i+1} - ");
                Console.WriteLine(conta);
            }
        }

        private static void InserirContas()
        {
            Console.Clear();
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            //if(entradaTipoConta != 1 || entradaTipoConta != 2)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            // Implementar numero da conta
            // Implementar senha e verificação da senha para sacar de determinada conta;
            //Tentar aplicar esses conceitos usando vetor;
            // Implementar atualização de senha;
            
            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma senha númerica (4 dígitos): ");
            int[] entradaSenha = new int[4];
            
            for(int i =  0; i< 4; i++)
            {
                Console.Write($"Digite o caracter numérico {i + 1}: ");
                entradaSenha[i] = int.Parse(Console.ReadLine());
            }

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        //numeroDaConta: 12345,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome,
                                        senha: entradaSenha);
            
            listContas.Add(novaConta);

            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.Clear();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-Listar contas");
            Console.WriteLine("2-Inserir nova conta");
            Console.WriteLine("3-Transferir");
            Console.WriteLine("4-Sacar");
            Console.WriteLine("5-Depositar");
            Console.WriteLine("6-Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            Console.Write("Informe a opção desejada: ");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }


    }
}

# Criando uma aplicação de transferências bancárias com .NET

> .NET Core 3.1

> O programa simula funções bancárias. No ínicio são apresetados as seguintes opções. 
> 1-Listar contas";
> 2-Inserir nova conta;
> 3-Transferir;
> 4-Sacar;
> 5-Depositar;
> 6-Limpar tela;
> X- Sair;

## 💻 Conceitos Aprendidos:
<br>

- [x] Classes; 
- [X] Enum;
- [X] override (ToString);
- [X] List<T> (Collections.Generic);
- [X] Constructor;
- [X] Clear;
- [X] Switch-case;
- [X] Parse;
- [X] ArgumentOutOfRangeException
- 
___________________________________________________________________________________________________________________________________________
  ## 💻 Novas implementações propostas:<br>
  
  -[x] Senha:
  > Ao escolher a função de inserir nova conta, além das opções de tipo de conta, nome do títular, saldo inicial e crédito, o usuário é direcionado para cadastrar uma chave númerica de 4 dígitos.
  A implementação dessa senha foi proposta para permitir que a função saque só seja com senha. Ao soliciar a opção saque, o programa solicita a senha e faz uma verificação se a mesma corresponde com a senha cadastrada no banco em memória.
  > Embora não fosse necessário, a implementação de senha foi realizada utilizando arrays de 4 posições.<br>
  > 
  ##TO DO: implementar a função de atualização de senha! Colocar uma pergunta secreta, e caso todas as informações confiram, o usuário poderá modificar sua senha. Essa função só será liberada caso o usuário tenha digitado a senha de forma incorreta por 3 vezes seguidas.<br>
  
  -[X] Gerador do número de conta:
  > Ao escolher a função inserir nova conta, e após digitar os dados referidos acima, o programa gera um número de conta no seguinte formato:
  > xxxxx-x
  > O número de conta aparece para o usuário após a criação, e o mesmo é orientado a guardar esse número pois o mesmo será necessário para novas transações. Caso o usuário deseja, o número da conta aparece disponível na opção 1 - "Listar Contas".<br>
  
  O número da conta e dígito foi gerado de forma aleatória, utilizando a class Random. A ídeia é que o Número da conta + Dígito, seja utlizado para fazer transações como Transferir, Sacar e Depositar. 
  ## TO DO: implementar a função SelecionarConta() que será utilziada nas funcionalidades referidas acima. <br><br>
  
  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
  ## Outros TO DO:
  - [] Não permitir que o nome seja uma string vazia;
  - [] Tentar mudar a visibilidade da Senha após o usuário digitar esse valor; 
  - [] Fazer máscara para que quando o usuário digite fique no formato xxxxx-x;
  - [] Impressão da descrição do Enum fora da formatação CamelCase;
  - [] Limitar o ReadLine() a ler somente um caracter por vez;
  - [] Tratamento de exceções;
  - [] Criar uma nova classe ou interface para as implementações referente a Senha (conceito de responsabilidade única).
  

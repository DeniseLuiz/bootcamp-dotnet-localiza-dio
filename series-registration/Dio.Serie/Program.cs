using Dio.Serie.Classes;
using System;

namespace Dio.Serie
{
    class Program
    {
		static SerieRepositorio serieRepositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
			string opçaoUsuario = ObterOpcaoUsuario();

			while(opçaoUsuario != "X")
            {
                switch (opçaoUsuario)
                {
					case "1":
						ListarSerie();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
                        VisualizarSerie();
						break;
					case "6":
						Console.Clear();
						break;
				}

				opçaoUsuario = ObterOpcaoUsuario();
            }

			Console.WriteLine("Obrigada (o) por usar nossos serviços!");
			Console.ReadLine();
        }

        private static int CapturarId()
        {
			Console.WriteLine("Digite o id da série");
			int indiceSerie = int.Parse(Console.ReadLine());

			return indiceSerie;
		}
		
        public static Serie GerarSerie()
        {
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: serieRepositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);
			return novaSerie;

		}
      
        private static void ListarSerie()
        {
			Console.Clear();
			Console.WriteLine("Listar séries: ");

			var lista = serieRepositorio.Lista();

			if(lista.Count == 0)
            {
				Console.WriteLine("Nenhuma lista cadastrada!");
				return;
            }

            foreach  (var serie in lista)
            {
				var itemExcluido = serie.RetornaExcluido();
				Console.WriteLine($"#{serie.retornaId()} - {serie.RetonaTitulo()} - {(itemExcluido ? "Excluído" : "")}");
            }
        }

		private static void InserirSerie()
		{
			Console.Clear();

			Console.WriteLine("Inserir nova série");

			Serie novaSerie = GerarSerie();			
			serieRepositorio.Insere(novaSerie);

		}

		private static void AtualizarSerie()
		{
			Console.Clear();
			int indiceSerie = CapturarId();
			Serie atualizaSerie = GerarSerie();

			serieRepositorio.Atualizar(indiceSerie, atualizaSerie);
		}

		private static void ExcluirSerie()
		{
			Console.Clear();
			int indiceSerie = CapturarId();
			serieRepositorio.Exclui(indiceSerie);
		}

		private static void VisualizarSerie()
		{
			Console.Clear();
			int indiceSerie = CapturarId();
			var serie = serieRepositorio.RetornaPorId(indiceSerie);
			Console.WriteLine(serie);
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("6- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}

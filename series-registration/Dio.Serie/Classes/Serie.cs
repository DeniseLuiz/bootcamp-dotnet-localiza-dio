using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Serie
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {Genero}" + Environment.NewLine;
            retorno += $"Titulo: {Titulo}" + Environment.NewLine;
            retorno += $"Descrição: {Descricao}" + Environment.NewLine;
            retorno += $"Ano de Início: {Ano}" + Environment.NewLine;
            retorno += $"Excluido: {Excluido}";
            return retorno;
        }

        public string RetonaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Exclui()
        {
            Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return Excluido;
        }
    }
   
}

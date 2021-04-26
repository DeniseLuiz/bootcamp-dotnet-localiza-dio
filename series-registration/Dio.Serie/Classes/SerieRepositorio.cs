using Dio.Serie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Serie.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            listSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            //listSerie.RemoveAt(id); // a sequência dos outros vetores. Só utilizar qnd estiver usando banco de dados
            listSerie[id].Exclui();
        }

        public void Insere(Serie entidade)
        {
            listSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listSerie;
        }

        public int PromixoId()
        {
            return listSerie.Count ;
        }

        public Serie RetornaPorId(int id)
        {
            return listSerie[id];
        }
    }
}

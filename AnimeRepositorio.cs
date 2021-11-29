using Animes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animes
{
    class AnimeRepositorio : IRepositorio<Anime>
    {

        private List<Anime> listaAnime = new List<Anime>();
        public void Atualizar(int id, Anime objeto)
        {
            listaAnime[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaAnime[id].Excluir();
        }

        public void Inserir(Anime objeto)
        {
            listaAnime.Add(objeto);
        }

        public List<Anime> Lista()
        {
            return listaAnime;
        }

        public int ProximoId()
        {
            return listaAnime.Count;
        }

        public Anime RetornarPorId(int id)
        {
            return listaAnime[id];
        }
    }
}

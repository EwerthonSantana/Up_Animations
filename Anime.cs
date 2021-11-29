using Animes.Numeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animes
{
    class Anime : EntidadeBase
    {
        private Genero Genero { get; set; }
        private Publico Publico { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Produtora { get; set; }
        private int Nota { get; set; }
        private bool Excluido { get; set; }

        public Anime(int id, Genero genero, Publico publico, string titulo, string descricao, int ano, string produtora, int nota)
        {
            this.Id = id;
            this.Genero = genero;
            this.Publico = publico;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Produtora = produtora;
            this.Nota = nota;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Publico: " + this.Publico + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Produtora: " + this.Produtora + Environment.NewLine;
            retorno += "Nota: " + this.Nota + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;
namespace Models {
    public class Filme {
         public int IdFilme { get; set; }
        public string NomeFilme { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Sinopse { get; set; }
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }
        public List<Locacao> VezesLocado { get; set; }
        public Filme (int idFilme, string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque) {
            IdFilme = idFilme;
            NomeFilme = nomeFilme;
            DtLancamento = dtLancamento;
            Sinopse = sinopse;
            Valor = valor;
            QtdEstoque = qtdEstoque;
            VezesLocado = new List<Locacao>();
        }
        public static List<Filme> GetFilmes () {
            return RepositoryFilme.Filmes();
        }
        public override string ToString(){
            return $"{IdFilme} - {NomeFilme} - R$: {Valor}";
        }
    }
}
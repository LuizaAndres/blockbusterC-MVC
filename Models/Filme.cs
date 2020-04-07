using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using Repositories;
namespace Models {
    public class Filme {
        [Key]
         public int FilmeId { get; set; }
        [Required]
        public string NomeFilme { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Sinopse { get; set; }
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }
        public List<Locacao> VezesLocado { get; set; }
        public Filme(){
        }
        public Filme (int idFilme, string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque) {
            FilmeId = idFilme;
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
            return $"{FilmeId} - {NomeFilme} - R$: {Valor}";
        }
    }
}
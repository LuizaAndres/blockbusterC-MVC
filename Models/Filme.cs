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
        /// <value>Get and Set the value of nomeFilme</value>
        public string NomeFilme { get; set; }
        /// <value>Get and Set the value of dtLancamento</value>
        public DateTime DtLancamento { get; set; }
        /// <value>Get and Set the value of sinopse</value>
        public string Sinopse { get; set; }
        /// <value>Get and Set the value of valor</value>
        public double Valor { get; set; }
        /// <value>Get and Set the value of qtdEstoque</value>
        public int QtdEstoque { get; set; }
        /// <value>Get and Set the value of locacoes</value>
        public List<Locacao> VezesLocado { get; set; }
        public Filme (int idFilme, string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque) {
            IdFilme = idFilme;
            NomeFilme = nomeFilme;
            DtLancamento = dtLancamento;
            Sinopse = sinopse;
            Valor = valor;
            QtdEstoque = qtdEstoque;
            VezesLocado = new List<Locacao> ();
            
        }

        public static List<Filme> GetFilmes () {
            return RepositoryFilme.Filmes();
        }

        public override string ToString(){
            return $"{IdFilme} - {NomeFilme} - R$: {Valor}";
        }
    }
}
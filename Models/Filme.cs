using System;
using System.Collections.Generic;
using Repositories;
using System.Linq;

namespace Models {
    public class Filme {
        public int FilmeId { get; set; }
        public string NomeFilme { get; set; }
        public DateTime DtLancamento { get; set; }
        public string Sinopse { get; set; }
        public double Valor { get; set; }
        public int QtdEstoque { get; set; }
        public ICollection<FilmeLocacao> Locacoes { get; set; }
 

        public Filme(){
            Locacoes = new List<FilmeLocacao>();
        }
        public static void InserirFilme (string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque) {
            Filme filme = new Filme {
                NomeFilme = nomeFilme,
                DtLancamento = dtLancamento,
                Sinopse = sinopse,
                Valor = valor,
                QtdEstoque = qtdEstoque
            };

            var db = new Context();
            db.Filmes.Add(filme);
            db.SaveChanges();
        }
        public static Filme GetFilme(int FilmeId){
            var db = new Context();
            return (from filme in db.Filmes
                where filme.FilmeId == FilmeId
                select filme).First();
        }

        public static List<Filme> GetFilmes(){
            var db = new Context();
            return db.Filmes.ToList();
        }

        public string ToString (bool simple = false) {
            if (simple) {
                return $"Id: {FilmeId} - Nome: {NomeFilme}";
            }

            var db = new Context();
            int cnt = 
                (from filme in db.FilmeLocacao
                    where filme.FilmeId == FilmeId
                    select filme.FilmeId).Count();

            return $"Nome: {NomeFilme}\n" +
                $"Valor: {Valor:C2}\n" +
                $"Quantidade de Locações: {cnt}\n";
        }
    }
}
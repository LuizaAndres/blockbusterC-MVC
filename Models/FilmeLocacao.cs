using System;
using System.Collections.Generic;
using System.Linq;
using Repositories;
namespace Models {
    public class FilmeLocacao {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public virtual Filme Filme { get; set; }
        public int LocacaoId { get; set; }
        public virtual Locacao Locacao { get; set; }
        public static List<FilmeLocacao> GetFilmeLocacao(int LocacaoId){
            var db = new Context();
            return (from FilmeLocacao in db.FilmeLocacao
                where FilmeLocacao.LocacaoId == LocacaoId
                select FilmeLocacao).ToList();
        }
        public void setFilme(){
            var db = new Context();
            Filme = (from filme in db.Filmes
                where filme.FilmeId == FilmeId
                select filme).First();
        }
    }
}
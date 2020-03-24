using System;
using System.Collections.Generic;
using Repositories;
namespace Models {
    public class Locacao {
        public DateTime Data = DateTime.Now;
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public String DataLocacao { get; set; }
        public List<Filme> Filmes = new List<Filme>();
        // Criando construtor
        public Locacao(Cliente cliente, List<Filme> filmes){
            ID = Locacao.GetLocacoes().Count;
            Cliente = cliente;
            Filmes = filmes;
            cliente.locacoes.Add(this);
        }
        public static List<Locacao> GetLocacoes () {
            return RepositoryLocacao.Locacoes();
        }
        public override string ToString(){
             return $"Locacao: {ID}";
        }
    }
}
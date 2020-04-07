using System;
using System.Collections.Generic;
using Repositories;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models {
    public class Locacao {
        [Key]
        public int LocacaoId { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        public String DataLocacao { get; set; }
        public List<Filme> Filmes = new List<Filme>();
        public Locacao(){

        }
        // Criando construtor
        public Locacao(Cliente cliente, List<Filme> filmes){
            LocacaoId = Locacao.GetLocacoes().Count;
            Cliente = cliente;
            Filmes = filmes;
            cliente.locacoes.Add(this);
        }
        public static List<Locacao> GetLocacoes () {
            return RepositoryLocacao.Locacoes();
        }
        public override string ToString(){
             return $"Locacao: {LocacaoId}";
        }
    }
}
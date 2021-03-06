using System;
using System.Collections.Generic;
using System.Linq;
using Controllers;
using Repositories;
using System.ComponentModel.DataAnnotations;
namespace Models {
    public class Locacao {
        public int LocacaoId { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        [Required]
        public DateTime DtLocacao { get; set; }
        public ICollection<FilmeLocacao> Filmes { get; set; }
        public Locacao(){
            Filmes = new List<FilmeLocacao>();
        }
        public static Locacao InserirLocacao (Cliente cliente, DateTime dtLocacao) {
            Locacao locacao = new Locacao {
                ClienteId = cliente.ClienteId,
                DtLocacao = dtLocacao,
                Filmes = new List<FilmeLocacao> ()
            };
            cliente.InserirLocacao (locacao);
            var db = new Context();
            db.Locacoes.Add(locacao);
            db.SaveChanges();
            return locacao;
        }
        public void InserirFilme (Filme filme) {
            var db = new Context();
            FilmeLocacao filmeLocacao = new FilmeLocacao(){
                FilmeId = filme.FilmeId,
                LocacaoId = LocacaoId
            };
            db.FilmeLocacao.Add(filmeLocacao);
            db.SaveChanges();
            Filmes.Add (filmeLocacao);
            filme.Locacoes.Add(filmeLocacao);
        }
        public override string ToString () {
            var db = new Context();
            Cliente cliente = (
                    from cli in db.Clientes
                    where cli.ClienteId == ClienteId
                    select cli).First();
                string retorno = $"Cliente: {cliente.Nome}\n" +
                    $"Data da Locacao: {DtLocacao}\n" +
                    $"Data de Devolucao: {LocacaoController.GetDataDevolucao(DtLocacao, cliente)}\n";
                double valorTotal = 0;
                string strFilmes = "";
            IEnumerable<int> filmes = 
                from filme in db.FilmeLocacao
                    where filme.LocacaoId == LocacaoId
                    select filme.FilmeId;
            if (filmes.Count() > 0) {
                foreach (int id in filmes) {
                    Filme filme = Filme.GetFilme(id);
                    strFilmes += $"    Id: {filme.FilmeId} - Nome: {filme.NomeFilme}\n";
                    valorTotal += filme.Valor;
                }
            } else {
                strFilmes += "    Não há filmes";
            }
            retorno += $"Valor Total: {valorTotal:C2}\n" +
                "   Filmes:\n" +
                strFilmes;
            return retorno;
        }
        public static List<Locacao> GetLocacoes(){
            var db = new Context();
            return db.Locacoes.ToList();
        }
        public void setCliente(){
            Cliente = Cliente.GetCliente(ClienteId);
        }
        public void setLocacaoFilme(){
            Filmes = FilmeLocacao.GetFilmeLocacao(LocacaoId);
        }
    }
}
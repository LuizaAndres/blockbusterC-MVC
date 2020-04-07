using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
namespace View {
    public class FilmeView {
        public static void GetFilmes(){
            Console.WriteLine("ID - Filme - Valor"); 
            foreach (Filme filme in FilmeController.Filmes())
            {
                Console.WriteLine(filme);   
            }
        }
        public static void GetFilmeLinq(){
            Console.WriteLine("\n");
            Console.WriteLine("Digite o ID do filme: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            IEnumerable filmeQuerry = 
                from filme in FilmeController.Filmes()
                    where filme.FilmeId == id
                        select filme;
            foreach (Filme filme in filmeQuerry){
                Console.WriteLine($"ID: {filme.FilmeId} |Nome: {filme.NomeFilme} |Lancamento: {filme.DtLancamento}"); 
                Console.WriteLine($"|Sinopse: {filme.Sinopse} |Valor: {filme.Valor} |Vezes locado: {filme.VezesLocado.Count}");
                }
            }
        public static void AddFilmeView() {
            Console.WriteLine ("Informações sobre o filme: ");
            Console.WriteLine ("Informe o nome: ");
            String nomeFilme = Console.ReadLine ();
            Console.WriteLine ("Informe a data de lancamento (dd/mm/yyyy): ");
            String sdtLancamento = Console.ReadLine ();
            DateTime dtLancamento;
            try {
                dtLancamento = Convert.ToDateTime (sdtLancamento);
            } catch {
                Console.WriteLine ("Formato inválido de data, será utilizada a data atual pra cadastro");
                dtLancamento = DateTime.Now;
            }
            Console.WriteLine ("Informe a sinopse: ");
            String sinopse = Console.ReadLine ();
            Console.WriteLine ("Informe o valor de locação: ");
            double valor = Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine ("Informe a quantidade de estoque: ");
            int qtdEstoque = Convert.ToInt32 (Console.ReadLine ());

            FilmeController.AddFilme(nomeFilme, dtLancamento, sinopse, valor, qtdEstoque);
        }
          
    }
}
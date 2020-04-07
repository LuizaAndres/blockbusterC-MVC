using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;
namespace View {
    public class ClienteView {
        
        public static void AddClienteView () {

            Console.WriteLine ("Informações sobre o cliente: ");
            Console.WriteLine ("Informe o nome: ");
            String nome = Console.ReadLine ();
            Console.WriteLine ("Informe a data de nascimento (dd/mm/yyyy): ");
            String sDtNasc = Console.ReadLine ();
            DateTime dtNasc;
            try {
                dtNasc = Convert.ToDateTime (sDtNasc);
            } catch {
                Console.WriteLine ("Formato inválido de data, será utilizada a data atual pra cadastro");
                dtNasc = DateTime.Now;
            }
            Console.WriteLine ("Informe o C.P.F.: ");
            String cpf = Console.ReadLine ();
            Console.WriteLine ("Informe a quantidade de dias para devolução: ");
            int qtdDias = Convert.ToInt32 (Console.ReadLine ());

            ClienteController.AddCliente(nome, dtNasc, cpf, qtdDias );
           
        }
        public static void GetClienteLinq(){
            Console.WriteLine("\n");
            Console.WriteLine("Digite o ID do cliente: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            IEnumerable clienteQuerry = 
                from cliente in ClienteController.Clientes()
                    where cliente.ClienteId == id
                        select cliente;
            foreach (Cliente cliente in clienteQuerry){
                Console.WriteLine(cliente.Nome);
                foreach (Locacao locacao in cliente.locacoes){
                    Console.WriteLine(locacao);
                    foreach (Filme filme in locacao.Filmes){
                        Console.WriteLine(filme);
                    }
                    double valor = LocacaoController.ValorLocacao(locacao);
                Console.WriteLine($"Valor da locação R$: {valor}\n");
                }
            }
            Console.WriteLine("\n");
        }
        public static void GetClientes(){
            Console.WriteLine ("Clientes");
            Console.WriteLine ("ID - Nome\n");
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);
            }
        }
    }
}
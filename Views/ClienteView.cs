using System;
using Models;
using Controllers;
using System.Collections;
using System.Linq;

namespace View {
    public class ClienteView {
        public static void AddBasicCliente () {
        Cliente cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Amanda Carolina Giovana Araújo",
            new DateTime (1999, 08, 19),
            "628.602.153-10",
            1
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Gabriel João Caio dos Santos",
            new DateTime (1953, 12, 17),
            "800.404.403-46",
            2
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Luiza",
            new DateTime (1953, 12, 17),
            "456.654.123-80",
            3
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Ivan",
            new DateTime (1953, 12, 17),
            "987.789.987-45",
            4
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Kadu",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            5
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Ana",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            6
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Vera",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            7
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Lais",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            8
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Lucas",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            9
        );
        ClienteController.AddCliente(cliente);
        cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Acabou",
            new DateTime (1953, 12, 17),
            "654.789.321-78",
            10
        );
        ClienteController.AddCliente(cliente);
        }
        public static void AddCliente () {
            int id = Controllers.ClienteController.Clientes().Count+1;
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
            Cliente cliente = new Cliente (
                Cliente.GetClientes().Count,
                nome,
                dtNasc,
                cpf,
                qtdDias
            );
            // colocando cliente no control
            ClienteController.AddCliente(cliente);
        }
        public static void GetClientesLinq(){
            Console.WriteLine("\n");
            Console.WriteLine("Digite o ID do cliente: ");
            int id = Convert.ToInt32 (Console.ReadLine());
            IEnumerable clienteQuerry = 
                from cliente in ClienteController.Clientes()
                    where cliente.ID == id
                        select cliente;
            foreach (Cliente cliente in clienteQuerry){
                Console.WriteLine(cliente.Nome);
                foreach (Locacao locacao in cliente.locacoes){
                    Console.WriteLine(locacao);
                    foreach (Filme filme in locacao.Filmes){
                        Console.WriteLine(filme);
                    }
                    double valor = locacao.ValorLocacao();
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
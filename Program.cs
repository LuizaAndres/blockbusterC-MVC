using System;
using View;
using Models;
//deixei aqui como uma solução rapida pra importar dados da Lista
using Repositories;


namespace blockbusterC_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //import data
            ClienteView.AddBasicCliente();
            FilmeView.AddBasicFilme();
            LocacaoView.AddBasicLocacao();
            Console.WriteLine ("============ Blockbuster! ============ ");
            int opt = 0;
            do{
                // Show menu options
                Console.WriteLine ("+-------------------------+");
                Console.WriteLine ("| Digite a opção desejada |");
                Console.WriteLine ("| 1 - Cadastrar Cliente   |");
                Console.WriteLine ("| 2 - Cadastrar Filme     |");
                Console.WriteLine ("| 3 - Cadastrar Locação   |");
                Console.WriteLine ("| 4 - Listar Clientes     |");
                Console.WriteLine ("| 5 - Consultar Cliente   |");
                Console.WriteLine ("| 6 - Listar Filmes       |");
//                Console.WriteLine ("| 7 - Consultar Filme     |");
                Console.WriteLine ("| 8 - Consultar Locação   |");
                Console.WriteLine ("| 0 - Sair                |");
                Console.WriteLine ("+-------------------------+");
                try {
                    opt = Convert.ToInt32 (Console.ReadLine ());
                } catch {
                    Console.WriteLine ("Opção inválida");
                    opt = 99;
                }
                // seleçao
                switch (opt) {
                    case 1:
                        ClienteView.AddClienteView();
                        break;
                    case 2:
                        FilmeView.AddFilmeView();
                        break;
                    case 3:
                        LocacaoView.AddLocacaoView();
                        break;
                    case 4:
                        
                        ClienteView.GetClientes();
                        break;
                    case 5:
                        ClienteView.GetClientesLinq();
//                        consultarCliente ();
                        break;
                    case 6:
                        FilmeView.GetFilme();
                        break;
                    case 7:
//                        consultarFilme ();
                        break;
                    case 8:
                        LocacaoView.listarLocacoes();
                        break;
                    }
            } while (opt != 0);
        }   
    }
}
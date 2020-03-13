using System;
using View;


namespace blockbusterC_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
                Console.WriteLine ("| 7 - Consultar Filme     |");
                Console.WriteLine ("| 8 - Consultar Locação   |");
                Console.WriteLine ("| 9 - Importar Dados      |");
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
                        ClienteView.AddCliente();
                        break;
                    case 2:
//                        inserirFilme ();
                        break;
                    case 3:
//                        inserirLocacao ();
                        break;
                    case 4:
                        View.ClienteView.GetClientes ();
                        break;
                    case 5:
//                        consultarCliente ();
                        break;
                    case 6:
                        View.FilmeView.GetFilme ();
                        break;
                    case 7:
//                        consultarFilme ();
                        break;
                    case 8:
//                        consultarLocacao ();
                        break;
                    case 9:
//                        importarDados ();
                        break;
                }
            } while (opt != 0);

        }
    }
        
}


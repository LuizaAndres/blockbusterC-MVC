using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    class Program
    {
        [STAThread]
        static void Main () {
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
    }
    public class TelaInicial : Form {
        Label lblTitulo;
        Button btnCadastraCliente;
        Button btnListaClientes;
        Button btnDetalhaCliente;
        Button btnCadastraFilme;
        Button btnListaFilmes;
        Button btnDetalhaFilme;
        Button btnCadastaLocacao;
        Button btnListaLocacoes;
        Button btnSair;
        public TelaInicial(){
            this.Text = "BlockBuster";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblTitulo = new Label();
            lblTitulo.Text = "Blockbuster";
            lblTitulo.Width = 100;
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            this.Controls.Add(lblTitulo);
            
            btnCadastraCliente = new Button();
            btnCadastraCliente.Size = new Size(200, 20);
            btnCadastraCliente.Location = new Point(40, 30);
            btnCadastraCliente.Text = "Cadastrar Cliente";
            this.Controls.Add(btnCadastraCliente);
            btnCadastraCliente.Click += new EventHandler(btnCadastraClienteClick);

            btnListaClientes = new Button();
            btnListaClientes.Size = new Size(200, 20);
            btnListaClientes.Location = new Point(40, 60);
            btnListaClientes.Text = "Listar Clientes";
            this.Controls.Add(btnListaClientes);
            btnListaClientes.Click += new EventHandler(btnListaClientesClick);

            btnDetalhaCliente = new Button();
            btnDetalhaCliente.Size = new Size(200, 20);
            btnDetalhaCliente.Location = new Point(40, 90);
            btnDetalhaCliente.Text = "Detalha clientes";
            this.Controls.Add(btnDetalhaCliente);
//            btnDetalhaCliente.Click += new EventHandler(DetalhaClienteClick);

            btnCadastraFilme = new Button();
            btnCadastraFilme.Size = new Size(200, 20);
            btnCadastraFilme.Location = new Point(40, 120);
            btnCadastraFilme.Text = "Cadastra Filme";
            this.Controls.Add(btnCadastraFilme);
            btnCadastraFilme.Click += new EventHandler(CadastraFilmeClick);

            btnListaFilmes = new Button();
            btnListaFilmes.Size = new Size(200, 20);
            btnListaFilmes.Location = new Point(40, 150);
            btnListaFilmes.Text = "Lista de Filmes";
            this.Controls.Add(btnListaFilmes);
            //btnListaFilmes.Click += new EventHandler(btnListaFilmesClick);

            btnDetalhaFilme = new Button();
            btnDetalhaFilme.Size = new Size(200, 20);
            btnDetalhaFilme.Location = new Point(40, 180);
            btnDetalhaFilme.Text = "Detalha Filme";
            this.Controls.Add(btnDetalhaFilme);
            //btnDetalhaFilme.Click += new EventHandler(btnDetalhaFilmeClick);

            btnCadastaLocacao = new Button();
            btnCadastaLocacao.Size = new Size(200, 20);
            btnCadastaLocacao.Location = new Point(40, 210);
            btnCadastaLocacao.Text = "Cadastar Locação";
            this.Controls.Add(btnCadastaLocacao);
            //btnCadastaLocacao.Click += new EventHandler(btnCadastaLocacaoClick);

            btnListaLocacoes = new Button();
            btnListaLocacoes.Size = new Size(200, 20);
            btnListaLocacoes.Location = new Point(40, 240);
            btnListaLocacoes.Text = "Todas as locações";
            this.Controls.Add(btnListaLocacoes);
            //btnListaLocacoes.Click += new EventHandler(btnListaLocacoesClick);

            btnSair = new Button();
            btnSair.Size = new Size(200, 20);
            btnSair.Location = new Point(40, 270);
            btnSair.Text = "Sair";
            this.Controls.Add(btnSair);
            btnSair.Click += new EventHandler(btnSairClick);
        }
        private void btnSairClick(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
        public void btnCadastraClienteClick(object sender, EventArgs e)
        {
            CadastraCliente cadastraCliente = new CadastraCliente(this);
            cadastraCliente.Show();
            this.Hide();
            
            
        }
        private void btnListaClientesClick(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientes listaClientes = new ListaClientes(this);
            listaClientes.Show();
        }
        private void CadastraFilmeClick(object sender, EventArgs e)
        {
            
            CadastraFilme CadastraFilmeClick = new CadastraFilme(this);
            CadastraFilmeClick.Show();
            this.Hide();
        }
        /*private void DetalhaClienteClick(object sender, EventArgs e)
        {
            this.Hide();
            DetalhaCliente DetalhaClienteClick = new DetalhaCliente();
            DetalhaClienteClick.Show();
        } */
    }  
}
} 
            /*Console.WriteLine ("============ Blockbuster! ============ ");
            int opt;
            do {
                // Menu
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
                Console.WriteLine ("| 0 - Sair                |");
                Console.WriteLine ("+-------------------------+");

                try {
                    opt = Convert.ToInt32 (Console.ReadLine ());
                } catch {
                    Console.WriteLine ("Opção inválida");
                    opt = 99;
                }

                switch (opt) {
                    case 1:
                        ClienteView.InserirCliente ();
                        break;
                    case 2:
                        FilmeView.InserirFilme ();
                        break;
                    case 3:
                        LocacaoView.InserirLocacao ();
                        break;
                    case 4:
                        ClienteView.ListarClientes ();
                        break;
                    case 5:
                        ClienteView.ConsultarCliente ();
                        break;
                    case 6:
                        FilmeView.ListarFilmes ();
                        break;
                    case 7:
                        FilmeView.ConsultarFilme ();
                        break;
                    case 8:
                        LocacaoView.ConsultarLocacao ();
                        break;
                }
            } while (opt != 0);
        }
    }
}*/
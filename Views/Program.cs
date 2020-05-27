using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views
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
        public class TelaInicial : Form 
        {
            Label lblTitulo;
            Button btnCadastraCliente;
            Button btnListaClientes;
            Button btnCadastraFilme;
            Button btnListaFilmes;
            Button btnListaLocacoes;
            Button btnSair;
            public TelaInicial(){
                this.Text = "BlockBuster";
                this.BackColor = Color.Beige;
                this.Size = new Size(300,400);

                lblTitulo = new Label();
                lblTitulo.Text = "Blockbuster";
                lblTitulo.Location = new Point(110,10);
                this.Controls.Add(lblTitulo);
                
                btnCadastraCliente = new Button();
                btnCadastraCliente.Size = new Size(200, 20);
                btnCadastraCliente.Location = new Point(40, 50);
                btnCadastraCliente.Text = "Cadastrar Cliente";
                this.Controls.Add(btnCadastraCliente);
                btnCadastraCliente.Click += new EventHandler(btnCadastraClienteClick);

                btnListaClientes = new Button();
                btnListaClientes.Size = new Size(200, 20);
                btnListaClientes.Location = new Point(40, 80);
                btnListaClientes.Text = "Listar Clientes";
                this.Controls.Add(btnListaClientes);
                btnListaClientes.Click += new EventHandler(btnListaClientesClick);

                btnCadastraFilme = new Button();
                btnCadastraFilme.Size = new Size(200, 20);
                btnCadastraFilme.Location = new Point(40, 110);
                btnCadastraFilme.Text = "Cadastra Filme";
                this.Controls.Add(btnCadastraFilme);
                btnCadastraFilme.Click += new EventHandler(CadastraFilmeClick);

                btnListaFilmes = new Button();
                btnListaFilmes.Size = new Size(200, 20);
                btnListaFilmes.Location = new Point(40, 140);
                btnListaFilmes.Text = "Lista de Filmes";
                this.Controls.Add(btnListaFilmes);
                btnListaFilmes.Click += new EventHandler(btnListaFilmesClick);

                btnListaLocacoes = new Button();
                btnListaLocacoes.Size = new Size(200, 20);
                btnListaLocacoes.Location = new Point(40, 170);
                btnListaLocacoes.Text = "Todas as locações";
                this.Controls.Add(btnListaLocacoes);
                btnListaLocacoes.Click += new EventHandler(btnListaLocacoesClick);

                btnSair = new Button();
                btnSair.Size = new Size(200, 20);
                btnSair.Location = new Point(40, 300);
                btnSair.Text = "Sair";
                this.Controls.Add(btnSair);
                btnSair.Click += new EventHandler(btnSairClick);
            }
            public void btnCadastraClienteClick(object sender, EventArgs e)
            {
                CadastraCliente cadastraCliente = new CadastraCliente(this);
                cadastraCliente.Show();
                this.Hide();
            }
            private void btnListaClientesClick(object sender, EventArgs e)
            {
                ListaClientes listaClientes = new ListaClientes(this);
                listaClientes.Show();
                this.Hide();
            }
            private void CadastraFilmeClick(object sender, EventArgs e)
            {
                CadastraFilme CadastraFilmeClick = new CadastraFilme(this);
                CadastraFilmeClick.Show();
                this.Hide();
            }
            private void btnListaFilmesClick(object sender, EventArgs e)
            {
                ListaFilmes ListaFilmeClick = new ListaFilmes(this);
                ListaFilmeClick.Show();
                this.Hide();
            }
            private void btnListaLocacoesClick(object sender, EventArgs e)
            {
                TodasLocacoes ListaLocacoesClick = new TodasLocacoes(this);
                ListaLocacoesClick.Show();
                this.Hide();
            }
            private void btnSairClick(object sender, EventArgs e)
            {
                this.Hide();
                Application.Exit();
            }
        }  
    }
} 
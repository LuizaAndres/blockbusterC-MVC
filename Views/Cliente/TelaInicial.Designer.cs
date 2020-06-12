using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
namespace Views
{
    partial class TelaInicial : Form 
    {
        private IContainer components = null;
        Label lblTitulo;
        Button btnCadastraCliente;
        Button btnListaClientes;
        Button btnCadastraFilme;
        Button btnListaFilmes;
        Button btnListaLocacoes;
        Button btnSair;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
            
        private void InitializeComponent()
        {
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
    }  
}
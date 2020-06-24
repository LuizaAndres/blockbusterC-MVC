using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
namespace Views
{
    partial class TelaInicial : FormBase
    {
        private IContainer components = null;
        Label lblTitulo;
        Library.Botao btnCadastraCliente;
        Library.Botao btnListaClientes;
        Library.Botao btnCadastraFilme;
        Library.Botao btnListaFilmes;
        Library.Botao btnSair;

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
            this.Text = "BLOCKBUSTER";
            lblTitulo = new Label();
            lblTitulo.Text = "BLOCKBUSTER";
            lblTitulo.Location = new Point(110,10);
            this.Controls.Add(lblTitulo);
            
            btnCadastraCliente = new Library.Botao();
            btnCadastraCliente.Size = new Size(200, 20);
            btnCadastraCliente.Location = new Point(40, 50);
            btnCadastraCliente.Text = "Cadastrar Cliente";
            this.Controls.Add(btnCadastraCliente);
            btnCadastraCliente.Click += new EventHandler(btnCadastraClienteClick);

            btnListaClientes = new Library.Botao();
            btnListaClientes.Size = new Size(200, 20);
            btnListaClientes.Location = new Point(40, 80);
            btnListaClientes.Text = "Listar Clientes";
            this.Controls.Add(btnListaClientes);
            btnListaClientes.Click += new EventHandler(btnListaClientesClick);

            btnCadastraFilme = new Library.Botao();
            btnCadastraFilme.Location = new Point(40, 110);
            btnCadastraFilme.Size = new Size(200, 20);
            btnCadastraFilme.Text = "Cadastra Filme";
            this.Controls.Add(btnCadastraFilme);
            btnCadastraFilme.Click += new EventHandler(CadastraFilmeClick);

            btnListaFilmes = new Library.Botao();
            btnListaFilmes.Location = new Point(40, 140);
            btnListaFilmes.Size = new Size(200, 20);
            btnListaFilmes.Text = "Lista de Filmes";
            this.Controls.Add(btnListaFilmes);
            btnListaFilmes.Click += new EventHandler(btnListaFilmesClick);

            btnSair = new Library.Botao();
            btnSair.Location = new Point(40, 300);
            btnSair.Size = new Size(200, 20);
            btnSair.Text = "Sair";
            this.Controls.Add(btnSair);
            btnSair.Click += new EventHandler(btnSairClick);
        }
    }  
}
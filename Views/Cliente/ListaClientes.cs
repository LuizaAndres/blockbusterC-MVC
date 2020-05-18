using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace View
{
    public class ListaClientes : Form {
        Form parent;
        ListView lstClientes;
        Button btnSelecionar;
        Button btnCancela;
        public ListaClientes(Form parent){
            this.parent = parent;

            this.Text = "Lista Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lstClientes = new ListView();
            lstClientes.Size = new Size(200,220);
            lstClientes.Location = new Point (20,30);
            lstClientes.View = View.Details;
            ListViewItem[] itens = new ListViewItem[];
            foreach(Cliente cliente in Clientes){
                ListViewItem cliente = new ListViewItem(cliente.Nome);
                cliente.SubItems.Add(cliente.Cpf);
                itens.add(cliente);
            } 
            lstClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            this.Controls.Add(lstClientes);

            btnSelecionar = new Button();
            btnSelecionar.Size = new Size(80, 20);
            btnSelecionar.Location = new Point(20, 300);
            btnSelecionar.Text = "Selecionar";
            this.Controls.Add(btnSelecionar);
            btnSelecionar.Click += new EventHandler(btnSelecionarClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 300);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnSelecionarClick(object sender, EventArgs e)
        {
            DetalhaCliente btnSelecionarClick = new DetalhaCliente(this);
                btnSelecionarClick.Show();
                this.Hide();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            this.Close();
            this.parent.Show();
        }
    }
}
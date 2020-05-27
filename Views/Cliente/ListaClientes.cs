using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;
namespace Views
{
    public class ListaClientes : Form {
        Form parent;
        Label lblListaCliente;
        ListView lvClientes;
        Button btnSelecionar;
        Button btnVoltar;
        public ListaClientes(Form parent){
            this.parent = parent;
            this.Text = "Lista Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblListaCliente = new Label();
            lblListaCliente.Location = new Point(100,10);
            lblListaCliente.Text = "Lista de Clientes";
            this.Controls.Add(lblListaCliente);

            lvClientes = new ListView();
            lvClientes.Size = new Size(250,150);
            lvClientes.Location = new Point (20,50);
            lvClientes.View = Details;
            foreach(Cliente cliente in ClienteController.GetClientes()){
                ListViewItem lvCliente = new ListViewItem(cliente.ClienteId.ToString());
                lvCliente.SubItems.Add(cliente.Nome);
                lvCliente.SubItems.Add(cliente.Cpf);
                lvClientes.Items.Add(lvCliente);
            }
            lvClientes.FullRowSelect = true;
            lvClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lvClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            this.Controls.Add(lvClientes);

            btnSelecionar = new Button();
            btnSelecionar.Size = new Size(80, 20);
            btnSelecionar.Location = new Point(20, 300);
            btnSelecionar.Text = "Detalhar";
            this.Controls.Add(btnSelecionar);
            btnSelecionar.Click += new EventHandler(btnSelecionarClick);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(180, 300);
            btnVoltar.Text = "Voltar";
            this.Controls.Add(btnVoltar);
            btnVoltar.Click += new EventHandler(btnVoltarClick);
        }
        private void btnSelecionarClick(object sender, EventArgs e)
        {
            string clienteId = this.lvClientes.SelectedItems[0].Text;
            Cliente cliente = ClienteController.GetCliente(Int32.Parse(clienteId));
            DetalhaCliente btnSelecionarClick = new DetalhaCliente(this, cliente);
            btnSelecionarClick.Show() ;
            this.Hide();
        }
        private void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
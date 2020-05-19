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
        ListView lvClientes;
        Button btnSelecionar;
        Button btnCancela;
        public ListaClientes(Form parent){
            this.parent = parent;

            this.Text = "Lista Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lvClientes = new ListView();
            lvClientes.Size = new Size(200,220);
            lvClientes.Location = new Point (20,30);
            lvClientes.View = Details;
            ListViewItem clientes = new ListViewItem();
            foreach(Cliente cliente in ClienteController.GetClientes()){
                ListViewItem lvCliente = new ListViewItem(cliente.ClienteId.ToString());
                lvCliente.SubItems.Add(cliente.Nome);
                lvCliente.SubItems.Add(cliente.Cpf);
                lvClientes.Items.Add(lvCliente);
            } 
            lvClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lvClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            
            this.Controls.Add(lvClientes);

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
            string clienteId = this.lvClientes.SelectedItems[0].Text;
            Cliente cliente = ClienteController.GetCliente( Int32.Parse(clienteId));
            //observar forma facil no futuro
            DetalhaCliente btnSelecionarClick = new DetalhaCliente(this, cliente);
            btnSelecionarClick.Show() ;
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
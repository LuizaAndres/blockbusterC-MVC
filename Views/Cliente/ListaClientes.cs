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
        Button btnConfirma;
        Button btnCancela;
        public ListaClientes(Form parent){
            this.parent = parent;

            this.Text = "Lista Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lstClientes = new ListView();
            lstClientes.Size = new Size(200,220);
            lstClientes.Location = new Point (20,30);
           /*  lstClientes.View = View.Details;
            ListViewItem[] itens = new ListViewItem[];
            foreach(Cliente cliente in Clientes){
                ListViewItem cliente = new ListViewItem(cliente.Nome);
                cliente.SubItems.Add(cliente.Cpf);
                itens.add(cliente);

            } */
            lstClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lstClientes.Columns.Add("Cpf", -2, HorizontalAlignment.Left);
            this.Controls.Add(lstClientes);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 300);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 300);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
            this.Close();
            this.parent.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            this.Close();
            this.parent.Show();
        }
    }
}
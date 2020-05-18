using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public class CadastraLocacao : Form {
        Form parent;
        Label lblCliente;
        ComboBox cbCliente;
        Button btnConfirma;
        Button btnCancela;
        public CadastraLocacao(Form parent){
            this.parent = parent;

            this.Text = "Locacao";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblCliente = new Label();
            lblCliente.Location = new Point(20,20);
            lblCliente.Text = "Cliente: ";

            cbCliente = new ComboBox();
            cbCliente.Location = new Point(130,20);
            cbCliente.Name = "Clientes";
            cbCliente.DropDownWidth = 250;
           /*  foreach (cliente.nome in Clientes)
            {
                cbCliente.Items.Add(ClientRectangle.nome);
            } */

            this.Controls.Add(lblCliente);
            this.Controls.Add(cbCliente);
            
            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Nome: {this.cbCliente.Text}\n",
                "Cliente",
                MessageBoxButtons.OK
                );
            this.Close();
            SelecionaFilme selecionaFilme = new SelecionaFilme(this);
            selecionaFilme.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public class CadastraLocacao : Form {
        Form parent;
        Label lblCliente;
        Label lblFilme;
        ComboBox cbFilme;
        Button btnConfirma;
        Button btnCancela;
        Cliente clienteLocal;
        public CadastraLocacao(Form parent,Cliente clienteDetalhaCliente){
            this.parent = parent;

            this.clienteLocal = clienteDetalhaCliente;

            this.Text = "Locacao";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblCliente = new Label();
            lblCliente.Location = new Point(20,20);
            lblCliente.Text = clienteLocal.Nome;
            this.Controls.Add(lblCliente);

            lblFilme = new Label();
            lblFilme.Location = new Point(20,50);
            lblFilme.Text = "Filme";
            this.Controls.Add(lblFilme);

            cbFilme = new ComboBox();
            cbFilme.Location = new Point(20,80);
            cbFilme.Name = "Filmes";
            cbFilme.DropDownWidth = 250;
            this.Controls.Add(cbFilme);
            foreach (Filme filme in FilmeController.GetFilmes()){
                cbFilme.Items.Add($"Nome: {filme.NomeFilme}" +$" R$: {filme.Valor}");
            }
            
            
            
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
                $"Nome: {this.cbFilme.Text}\n",
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
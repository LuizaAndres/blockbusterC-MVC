using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public class SelecionaFilme : Form {
        Form parent;
        Label lblFilme;
        ComboBox cbFilmes;
        Button btnConfirma;
        Button btnCancela;
        
        public SelecionaFilme(Form parent){
            this.parent = parent;

            this.Text = "Filmes";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblFilme = new Label();
            lblFilme.Location = new Point(20,20);
            lblFilme.Text = "Filme: ";

            cbFilmes = new ComboBox();
            cbFilmes.Location = new Point(130,20);
            cbFilmes.Name = "Filmes";
            cbFilmes.DropDownWidth = 250;
           /*  foreach (filme in filmes)
            {
                cbFilmes.Items.Add(filme.nome);
            } */

            this.Controls.Add(lblFilme);
            this.Controls.Add(cbFilmes);
            
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
                $"Nome: {this.cbFilmes.Text}\n",
                "Filme",
                MessageBoxButtons.OK
                );
            this.Close();
            parent.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
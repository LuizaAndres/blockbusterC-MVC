using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public class ListaFilmes : Form {
        Form parent;
        ListView lstFilmes;
        Button btnConfirma;
        Button btnCancela;
        public ListaFilmes(Form parent){
            this.Text = "Lista Filmes";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lstFilmes = new ListView();
            lstFilmes.Size = new Size(200,220);
            lstFilmes.Location = new Point (20,30);
           /*  lstFilmes.View = View.Details;
            ListViewItem[] itens = new ListViewItem[];
            foreach(Filme filme in Filmes){
                ListViewItem filme = new ListViewItem(filme.Nome);
                filme.SubItems.Add(filme.valor);
                itens.add(filme);

            } */
            lstFilmes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lstFilmes.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            this.Controls.Add(lstFilmes);

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
            MessageBox.Show("Confirmado!!");
            parent.Show();
            this.Close();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            parent.Show();
            this.Close();
        }
    }
}
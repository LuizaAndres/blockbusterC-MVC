using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;
namespace Views
{
    public class ListaFilmes : FormBase
    {
        Form parent;
        Label listaDeFilmes;
        ListView lvFilmes;
        Library.Botao btnDetalhaFilme;
        Library.Botao.BtnVoltar btnCancela;
        public ListaFilmes(Form parent){
            this.parent = parent;
            this.Text = "Lista Filmes";

            listaDeFilmes = new Label();
            listaDeFilmes.Location = new Point(100,30);
            listaDeFilmes.Text = "Lista de Filmes";
            this.Controls.Add(listaDeFilmes);

            lvFilmes = new ListView();
            lvFilmes.Size = new Size(250,200);
            lvFilmes.Location = new Point(20,60);
            lvFilmes.View = Details;
            ListViewItem filmes = new ListViewItem();
            foreach (Filme filme in FilmeController.GetFilmes())
            {
                ListViewItem lvFilme = new ListViewItem(filme.FilmeId.ToString());
                lvFilme.SubItems.Add(filme.NomeFilme);
                lvFilme.SubItems.Add(filme.Valor.ToString());
                lvFilmes.Items.Add(lvFilme);
            }
            lvFilmes.FullRowSelect = true;
            lvFilmes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvFilmes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lvFilmes.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            this.Controls.Add(lvFilmes);

            btnDetalhaFilme = new Library.Botao();
            btnDetalhaFilme.Location = new Point(20, 300);
            btnDetalhaFilme.Text = "Detalha";
            this.Controls.Add(btnDetalhaFilme);
            btnDetalhaFilme.Click += new EventHandler(btnDetalhaFilmeClick);

            btnCancela = new Library.Botao.BtnVoltar(180,this,parent);
            this.Controls.Add(btnCancela);
        }
         private void btnDetalhaFilmeClick(object sender, EventArgs e)
        {
            try{
            string filmeId = this.lvFilmes.SelectedItems[0].Text;
            Filme filme = FilmeController.GetFilme(Int32.Parse(filmeId));
            DetalhaFilme btnSelecionarClick = new DetalhaFilme(this, filme);
            btnSelecionarClick.Show() ;
            this.Hide();
            }catch (Exception err){
                MessageBox.Show(err.Message, "Selecione um filme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
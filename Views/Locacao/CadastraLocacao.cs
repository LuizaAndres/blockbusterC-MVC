using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;
namespace Views
{
    public class CadastraLocacao : Form {
        Form parent;
        Label lblCadastraLocação;
        Label lblCliente;
        Label lblFilme;
        ListView lvFilmes;
        Library.Botao btnConfirma;
        Library.Botao.BtnVoltar btnCancela;
        Cliente clienteLocal;
        Locacao locacao;
        public CadastraLocacao(Form parent,Cliente clienteDetalhaCliente){
            this.parent = parent;
            this.clienteLocal = clienteDetalhaCliente;
            this.Text = "Locacao";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblCadastraLocação = new Label();
            lblCadastraLocação.Location = new Point(100,30);
            lblCadastraLocação.Text = "Cadastra Cliente";
            this.Controls.Add(lblCadastraLocação);

            lblCliente = new Label();
            lblCliente.Location = new Point(20,60);
            lblCliente.Text = clienteLocal.Nome;
            this.Controls.Add(lblCliente);

            lblFilme = new Label();
            lblFilme.Location = new Point(20,90);
            lblFilme.Text = "Filme";
            this.Controls.Add(lblFilme);

            lvFilmes = new ListView();
            lvFilmes.Size = new Size(200,100);
            lvFilmes.Location = new Point(20,120);
            lvFilmes.View = Details;
            ListViewItem filmes = new ListViewItem();
            lvFilmes.CheckBoxes = true;
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
            
            btnConfirma = new Library.Botao();
            btnConfirma.Location = new Point(20, 300);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Library.Botao.BtnVoltar(120,this,parent);
            this.Controls.Add(btnCancela);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            locacao=new Locacao();
            locacao.ClienteId=clienteLocal.ClienteId;
            locacao.Cliente=clienteLocal;
            string lstFilm = "";
            //double vl = 0;
            foreach( ListViewItem filme in lvFilmes.CheckedItems)
                {
                    lstFilm += lstFilm + filme.SubItems[1].Text.ToString();
                }
            DialogResult result = MessageBox.Show(
                $"Nome: {this.clienteLocal.Nome}\n" + 
                $"Filmes Locados: "+lstFilm+
                $"Valor da Locação: " ,
                "Confirma Locação?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
           );
            if (result == DialogResult.OK){
                Locacao locacaoLocal = Locacao.InserirLocacao(clienteLocal, DateTime.Now);
                foreach( ListViewItem filmeChecado in lvFilmes.CheckedItems)
                {
                    string sFilmeId = filmeChecado.Text;
                    int filmeId = Convert.ToInt32(sFilmeId);
                    Filme filme = FilmeController.GetFilme(filmeId);
                    LocacaoController.InserirFilme(locacaoLocal, filme);
                }
           }
            this.Close();
            parent.Show();
        }

    }
}
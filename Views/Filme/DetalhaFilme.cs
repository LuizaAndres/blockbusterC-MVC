using System;
using System.Drawing;
using System.Windows.Forms;
using Models;
namespace Views
{
    public class DetalhaFilme : FormBase
    {
        Form parent;
        Label lblNome;
        RichTextBox rtbSinopse;
        Label lblDtLancamento;
        Label lblValor;
        Label lblQtdEstoque;
        Library.Botao.BtnVoltar btnVoltar;
        int idFilme;
        Filme filmeLocal;
        public DetalhaFilme(Form parent, Filme filme){
            this.Size = new Size(300,400);
            this.parent = parent;
            this.idFilme=filme.FilmeId;
            this.filmeLocal = filme;
            this.Text = "Filme";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Location = new Point(20, 20);
            lblNome.Text = $"Nome: {filme.NomeFilme}";
            this.Controls.Add(lblNome);

            rtbSinopse = new RichTextBox();
            rtbSinopse.Size = new Size(230,100);
            rtbSinopse.Location = new Point(20,50);
            rtbSinopse.BackColor = Color.WhiteSmoke;
            rtbSinopse.Name = "Sinópse";
            rtbSinopse.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbSinopse.ReadOnly = true;
            rtbSinopse.Text = filme.Sinopse;
            this.Controls.Add(rtbSinopse);

            lblDtLancamento = new Label();
            lblDtLancamento.Location = new Point(20, 180);
            lblDtLancamento.Size = new Size (250,20);
            lblDtLancamento.Text = $"Lançamento: {filme.DtLancamento.ToShortDateString()}";
            this.Controls.Add(lblDtLancamento);

            lblValor = new Label();
            lblValor.Location = new Point(20,210);
            lblValor.Size = new Size (150,20);
            lblValor.Text = $"Valor: R$: {filme.Valor},00";
            this.Controls.Add(lblValor);

            lblQtdEstoque = new Label();
            lblQtdEstoque.Location = new Point(20,240);
            lblQtdEstoque.Size = new Size (150,20);
            lblQtdEstoque.Text = $"Estoque: {filme.QtdEstoque} unidades";
            this.Controls.Add(lblQtdEstoque);

            btnVoltar = new Library.Botao.BtnVoltar(170,this,parent);
            this.Controls.Add(btnVoltar);
        }
    }
}
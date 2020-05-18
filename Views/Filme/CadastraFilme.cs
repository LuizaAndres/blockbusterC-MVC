using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public class CadastraFilme : Form
    {
        Form parent;
        Label lblNome;
        TextBox txtNome;
        Label lblSinopse;
        TextBox txtSinopse;
        Label lblDataLanc;
        MaskedTextBox txtDataLanc;
        Label lblValor;
        NumericUpDown nudValor;
        Label lblEstoque;
        NumericUpDown nudEstoque;

        Button btnCadastra;
        Button btnVoltar;
        public CadastraFilme(Form parent)
        {
            this.parent = parent;

            int x = 20;
            this.Text = "Cadastra Filme";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x, 20);

            txtNome = new TextBox();
            txtNome.Location = new Point(130, 20);
            txtNome.Size = new Size(110, 20);

            lblSinopse = new Label();
            lblSinopse.Text = "Sinópse: ";
            lblSinopse.Location = new Point(x, 50);

            txtSinopse = new TextBox();
            txtSinopse.Location = new Point(x, 80);
            txtSinopse.Size = new Size(250, 100);
            txtSinopse.ScrollBars = ScrollBars.Vertical;
            txtSinopse.TextAlign = HorizontalAlignment.Left;
            txtSinopse.MaxLength = 500;
            txtSinopse.Multiline = true;

            lblDataLanc = new Label();
            lblDataLanc.Text = "Dt.Lançamento";
            lblDataLanc.Location = new Point(x,200);
            

            txtDataLanc = new MaskedTextBox();
            txtDataLanc.Location = new Point(130, 200);
            txtDataLanc.Mask = "00/00/0000";
            txtDataLanc.Size = new Size(110, 20);

            lblValor = new Label();
            lblValor.Text = "Valor: ";
            lblValor.Location = new Point(x, 230);

            nudValor = new NumericUpDown();
            nudValor.Location = new Point(130, 230);
            nudValor.Size = new Size(110, 20);
            nudValor.Maximum = 29;
            nudValor.Minimum = 9;
            nudValor.Increment = 10;
            nudValor.ReadOnly = true;

            lblEstoque = new Label();
            lblEstoque.Text = "Estoque: ";
            lblEstoque.Location = new Point (x, 260);

            nudEstoque = new NumericUpDown();
            nudEstoque.Location = new Point(130, 260);
            nudEstoque.Size = new Size(110, 20);
            nudEstoque.Maximum = 10;
            nudEstoque.Minimum = 3;
            nudEstoque.Increment = 1;
            nudEstoque.ReadOnly = true;
            
            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(lblSinopse);
            this.Controls.Add(txtSinopse);
            this.Controls.Add(lblDataLanc);
            this.Controls.Add(txtDataLanc);
            this.Controls.Add(lblValor);
            this.Controls.Add(nudValor);
            this.Controls.Add(lblEstoque);
            this.Controls.Add(nudEstoque);

            this.Size = new Size(300, 400);

            btnCadastra = new Button();
            btnCadastra.Size = new Size(80, 20);
            btnCadastra.Location = new Point(20, 300);
            btnCadastra.Text = "Cadastrar";
            this.Controls.Add(btnCadastra);
            btnCadastra.Click += new EventHandler(btnCadastraClick);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(120, 300);
            btnVoltar.Text = "Voltar";
            this.Controls.Add(btnVoltar);
            btnVoltar.Click += new EventHandler(btnVoltarClick);
        }
        private void btnCadastraClick(object sender, EventArgs e)
        {
            try{
                FilmeController.InserirFilme(this.txtNome.Text,this.txtDataLanc.Text, this.txtSinopse.Text, (int)this.nudValor.Value, (int)this.nudEstoque.Value);
                MessageBox.Show(
                    $"Nome: {this.txtNome.Text}\n" +
                    $"Data Lanc: {this.txtDataLanc.Text}\n" +
                    $"Valor: {this.nudValor.Value}\n" +
                    $"Estoque: {this.nudEstoque.Value}", 
                    "Cliente",
                    MessageBoxButtons.OK
                );
                this.Close();
                this.parent.Show();  
            }catch (Exception err){
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
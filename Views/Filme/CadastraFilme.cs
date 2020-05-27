using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public class CadastraFilme : Form
    {
        Form parent;
        Label lblCadastraFilme;
        Label lblNome;
        TextBox txtNome;
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
            this.Size = new Size(300, 400);
            this.Text = "Cadastra Filme";
            this.BackColor = Color.Beige;

            lblCadastraFilme = new Label();
            lblCadastraFilme.Location = new Point(90,10);
            lblCadastraFilme.Size = new Size (150,20);
            lblCadastraFilme.Text = "Cadastro de Filme";
            this.Controls.Add(lblCadastraFilme);

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(20, 50);
            this.Controls.Add(lblNome);

            txtNome = new TextBox();
            txtNome.Location = new Point(130, 40);
            txtNome.Size = new Size(110, 20);
            this.Controls.Add(txtNome);

            txtSinopse = new TextBox();
            txtSinopse.Location = new Point(20, 90);
            txtSinopse.Size = new Size(220, 100);
            txtSinopse.ScrollBars = ScrollBars.Vertical;
            txtSinopse.TextAlign = HorizontalAlignment.Left;
            txtSinopse.Text = "Digite aqui a sinópse";
            txtSinopse.MaxLength = 500;
            txtSinopse.Multiline = true;
            this.Controls.Add(txtSinopse);

            lblDataLanc = new Label();
            lblDataLanc.Text = "Dt.Lançamento:";
            lblDataLanc.Location = new Point(20,210);
            lblDataLanc.Size = new Size(110,20);
            this.Controls.Add(lblDataLanc);
            
            txtDataLanc = new MaskedTextBox();
            txtDataLanc.Location = new Point(130, 200);
            txtDataLanc.Mask = "00/00/0000";
            this.Controls.Add(txtDataLanc);

            lblValor = new Label();
            lblValor.Text = "Valor: ";
            lblValor.Location = new Point(20, 240);
            this.Controls.Add(lblValor);

            nudValor = new NumericUpDown();
            nudValor.Location = new Point(130, 230);
            nudValor.Size = new Size(100, 20);
            nudValor.Maximum = 29;
            nudValor.Minimum = 9;
            nudValor.Increment = 10;
            nudValor.ReadOnly = true;
            this.Controls.Add(nudValor);

            lblEstoque = new Label();
            lblEstoque.Text = "Estoque: ";
            lblEstoque.Location = new Point (20, 270);
            this.Controls.Add(lblEstoque);

            nudEstoque = new NumericUpDown();
            nudEstoque.Location = new Point(130, 260);
            nudEstoque.Size = new Size(100, 20);
            nudEstoque.Maximum = 10;
            nudEstoque.Minimum = 3;
            nudEstoque.Increment = 1;
            nudEstoque.ReadOnly = true;
            this.Controls.Add(nudEstoque);

            btnCadastra = new Button();
            btnCadastra.Size = new Size(80, 20);
            btnCadastra.Location = new Point(20, 310);
            btnCadastra.Text = "Cadastrar";
            this.Controls.Add(btnCadastra);
            btnCadastra.Click += new EventHandler(btnCadastraClick);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(130, 310);
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
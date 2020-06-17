using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
namespace Views
{
    public partial class CadastraCliente : FormBase
    {
        Form parent;
        public CadastraCliente(Form parent)
        {
            this.parent = parent;
            this.Text = "Cadastra Cliente";

            InitializeComponent(parent);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            try{
                ClienteController.InserirCliente(this.rtxtNome.Text,this.txtDtNasc.Text, this.txtCpf.Text, (int)this.numDiasDev.Value);
                MessageBox.Show(
                    $"Nome: {this.rtxtNome.Text}\n" +
                    $"Data Nasc: {this.txtDtNasc.Text}\n" +
                    $"CPF: {this.txtCpf.Text}\n" +
                    $"DiasDev: {this.numDiasDev.Value}",
                    "Cliente",
                    MessageBoxButtons.OK
                );
                this.Close();
                this.parent.Show();  
            }catch (Exception err){
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}
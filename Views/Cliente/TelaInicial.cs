using System;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaInicial : FormBase
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        public void btnCadastraClienteClick(object sender, EventArgs e)
        {
            CadastraCliente cadastraCliente = new CadastraCliente(this);
            cadastraCliente.Show();
            this.Hide();
        }
        private void btnListaClientesClick(object sender, EventArgs e)
            {
                ListaClientes listaClientes = new ListaClientes(this);
                listaClientes.Show();
                this.Hide();
            }
            private void CadastraFilmeClick(object sender, EventArgs e)
            {
                CadastraFilme CadastraFilmeClick = new CadastraFilme(this);
                CadastraFilmeClick.Show();
                this.Hide();
            }
            private void btnListaFilmesClick(object sender, EventArgs e)
            {
                try{
                    ListaFilmes ListaFilmeClick = new ListaFilmes(this);
                    ListaFilmeClick.Show();
                    this.Hide();
                }catch(Exception err){
                    MessageBox.Show(err.Message, "impossivel conectar ao banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private void btnSairClick(object sender, EventArgs e)
            {
                this.Hide();
                Application.Exit();
            }
    }
}
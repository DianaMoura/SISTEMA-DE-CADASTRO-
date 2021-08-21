using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

            AtualizarGrid();


        }

        private void AtualizarGrid() 
        {

            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = clienteNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = clienteColecao;


        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Informando Clientndo Não Selecionado
            if (dataGridView2.SelectedRows.Count==0)
            {


                MessageBox.Show("Nenhum Cliente Selecionado.");
                return;
            
            }
            // Informando Ao Usuario a Confirmação de Exclusão
            DialogResult resultado= MessageBox.Show("Tem Certeza?", "Pergunta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.No)

            {

                return;
            }
            Cliente clienteSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Cliente);

            ClienteNegocios clienteNegocios = new ClienteNegocios();

            string retorno = clienteNegocios.Excluir(clienteSelecionado);


            try
            {
                int IdCliente = Convert.ToInt32(retorno);

                MessageBox.Show("Cliente Excluido Com Sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir. Detalhes"+ retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frmcc = new FrmClienteCadastrar(AcaoNatela.Inserir, null);
            frmcc.ShowDialog();
            //Aualizar Grid Após O Cadastro de Clientes
            DialogResult dialogResult = frmcc.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            
            }
        }

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmClienteSelecionar_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {


                MessageBox.Show("Nenhum Cliente Selecionado.");
                return;

            }
        
            Cliente clienteSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Cliente);
            
            // Atualizar O Grid
            FrmClienteCadastrar frmcc = new FrmClienteCadastrar(AcaoNatela.Alterar,clienteSelecionado);
            DialogResult resultado = frmcc.ShowDialog();
            if (resultado == DialogResult.Yes)

            {
                AtualizarGrid();
            
            }


        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {


                MessageBox.Show("Nenhum Cliente Selecionado.");
                return;


            }

            Cliente clienteSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Cliente);





            FrmClienteCadastrar frmcc = new FrmClienteCadastrar(AcaoNatela.Consultar,clienteSelecionado);
            frmcc.ShowDialog();
        }
    }
}

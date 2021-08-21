using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;


namespace Apresentacao
{
    public partial class FrmClienteCadastrar : Form
    {
        AcaoNatela acaoNaTelaSelecionada;
        public FrmClienteCadastrar(AcaoNatela acaoNatela, Cliente cliente)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNatela;

            if (acaoNatela == AcaoNatela.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNatela == AcaoNatela.Alterar)
            {
                this.Text = "Alterar Cliente";
                textBoxCódigo.Text = cliente.IdCliente.ToString();
                textBoxNome.Text = cliente.Nome;
                dateTimePickerDataNascimento.Value = cliente.DataNascimento;
                if (cliente.Sexo == true)
                    radioButtonSexoMasculino.Checked = true;
                else
                    radioButtonSexoFeminino.Checked = true;
                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();


            }
            else if (acaoNatela == AcaoNatela.Consultar)
            {
                this.Text = "Consultar Cliente";

                textBoxCódigo.Text = cliente.IdCliente.ToString();
                textBoxNome.Text = cliente.Nome;
                dateTimePickerDataNascimento.Value = cliente.DataNascimento;
                if (cliente.Sexo == true)
                    radioButtonSexoMasculino.Checked = true;
                else
                    radioButtonSexoFeminino.Checked = true;
                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();


                // Desabilitando Os Campos Do Botão Consultar
                textBoxCódigo.Enabled = false;
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;
                dateTimePickerDataNascimento.Enabled = false;
                radioButtonSexoMasculino.Enabled = false;
                radioButtonSexoFeminino.Enabled = false;
                textBoxLimiteCompra.ReadOnly = true;
                textBoxLimiteCompra.TabStop = false;
                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";
                buttonCancelar.Focus();






            }
            else if (acaoNatela == AcaoNatela.Excluir)
            {

                this.Text = "Excluir Cliente";
            }
        }
   
        private void FrmClienteCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == AcaoNatela.Inserir)

            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateTimePickerDataNascimento.Value;

                if (radioButtonSexoMasculino.Checked == true)
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;

                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();

                string retorno = clienteNegocios.Inserir(cliente);

                try

                {
                    int IdCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente Inserido Com Sucesso. Código: " + IdCliente.ToString());
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir. Detalhes:" + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }


            else if (acaoNaTelaSelecionada == AcaoNatela.Alterar)

            {

                Cliente cliente = new Cliente();
                cliente.IdCliente = Convert.ToInt32(textBoxCódigo.Text);
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateTimePickerDataNascimento.Value;

                if (radioButtonSexoMasculino.Checked == true)
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;

                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegocios clienteNegocios = new ClienteNegocios();

                string retorno = clienteNegocios.Alterar(cliente);

                try

                {
                    int IdCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente Alterado Com Sucesso. Código: " + IdCliente.ToString());
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes:" + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }






            }
          }
        }
    } 


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_Eleitoral___Executivo
{
    public partial class CadastrarEleicao : Form
    {
        Thread t;
        public CadastrarEleicao()
        {
            InitializeComponent();
        }

        private void btnCadastrarEleicao_Click(object sender, EventArgs e)
        {
            if (txtAnoEleicao.Text.Length != 4 || cmbTipoEleicao.Text == "")
            {
                MessageBox.Show("Digite um ano com 4 digitos e preencha o tipo da eleicao corretamente.", "Erro ao cadastrar");
                return;
            }
            Eleicao.Eleicao eleicao = new Eleicao.Eleicao();
            eleicao._Tipo = cmbTipoEleicao.Text;
            eleicao._Ano = txtAnoEleicao.Text;
            bool cadastrar = Serializer.Serializer.Serializar(eleicao);
            if (!cadastrar)
            {
                MessageBox.Show("\tErro ao cadastrar.", "Erro");
                return;
            }
            MessageBox.Show("Eleicao cadastrada!", "Sucesso");
            this.Close();
            if (cmbTipoEleicao.Text == "Executivo")
                t = new Thread(abrirJanelaGerenciarExecutivo);
            else
                t = new Thread(abrirJanelaGerenciarLegislativo);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void txtAnoEleicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void abrirJanelaPrincipal()
        {
            Application.Run(new Form1());
        }

        private void abrirJanelaGerenciarExecutivo()
        {
            Application.Run(new GerenciarExecutivo());
        }

        private void abrirJanelaGerenciarLegislativo()
        {
            Application.Run(new GerenciarLegislativo());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaPrincipal);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}

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
            if (cmbTipoEleicao.Text == "Executivo"){
                t = new Thread(abrirJanelaGerenciarExecutivo);
                t.SetApartmentState(ApartmentState.STA);
                t.Start(($"{cmbTipoEleicao.Text}-{txtAnoEleicao.Text}").ToString());
            }else{
                t = new Thread(abrirJanelaGerenciarLegislativo);
                t.SetApartmentState(ApartmentState.STA);
                t.Start(($"{cmbTipoEleicao.Text}-{txtAnoEleicao.Text}").ToString());
            }
            this.Close();
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

        private void abrirJanelaGerenciarExecutivo(object tipoAno)
        {
            GerenciarExecutivo gerenciarExecutivo = new GerenciarExecutivo();
            gerenciarExecutivo.setTipoAno((string)tipoAno);
            Application.Run(gerenciarExecutivo);
        }

        private void abrirJanelaGerenciarLegislativo(object tipoAno)
        {
            GerenciarLegislativo gerenciarLegislativo = new GerenciarLegislativo();
            gerenciarLegislativo.setTipoAnoLegislativo((string)tipoAno);
            Application.Run(gerenciarLegislativo);
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

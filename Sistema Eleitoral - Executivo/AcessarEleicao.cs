using System;
using System.Threading;
using System.Windows.Forms;
using Sistema_Eleitoral___Executivo.Eleicao;

namespace Sistema_Eleitoral___Executivo
{
    public partial class AcessarEleicao : Form
    {
        private string anoEleicao;
        private string tipoEleicao;
        Thread t;
        public AcessarEleicao()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            this.anoEleicao = txtAnoEleicao.Text;
            this.tipoEleicao = cbmTipoEleicao.Text;

            if (txtAnoEleicao.Text.Length != 4 || cbmTipoEleicao.Text == "")
            {
                MessageBox.Show("Digite um ano com 4 digitos e preencha o tipo da eleicao corretamente.", "Erro ao cadastrar");
                return;
            }
            if (Serializer.Serializer.VerificarExistenciaEleicao(cbmTipoEleicao.Text, txtAnoEleicao.Text))
            {
                if (Serializer.Serializer.VerificarEleicaoVazia(cbmTipoEleicao.Text, txtAnoEleicao.Text))
                {
                    MessageBox.Show("A eleicao nao possui candidato cadastrado.\nCadastre candidatos para prosseguir para a votacao.", "Erro");
                    return;
                }
                else
                {
                    if (cbmTipoEleicao.Text == "Executivo")
                    {
                        t = new Thread(abrirJanelaVotar);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start(($"{cbmTipoEleicao.Text}-{txtAnoEleicao.Text}").ToString());
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                        t = new Thread(abrirJanelaVotarExec);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                    }
                }
                
            }
            else
                MessageBox.Show("Eleicao nao encontrada!", "Erro ao consultar");
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            if (txtAnoEleicao.Text.Length != 4 || cbmTipoEleicao.Text == "")
            {
                MessageBox.Show("Digite um ano com 4 digitos e preencha o tipo da eleicao corretamente.", "Erro ao cadastrar");
                return;
            }
            if (Serializer.Serializer.VerificarExistenciaEleicao(cbmTipoEleicao.Text, txtAnoEleicao.Text))
            {
                if (cbmTipoEleicao.Text.Equals("Executivo"))
                    t = new Thread(abrirJanelaGerenciarExecutivo);
                else
                    t = new Thread(abrirJanelaGerenciarLegislativo);
                
                t.SetApartmentState(ApartmentState.STA);
                t.Start(($"{cbmTipoEleicao.Text}-{txtAnoEleicao.Text}").ToString());
                this.Close();

            }
            else
                MessageBox.Show("Eleicao nao encontrada!", "Erro ao consultar");
        }
        private void abrirJanelaVotar(object tipoAno)
        {
            VotarExecutivo votarExecutivo = new VotarExecutivo();
            votarExecutivo.setTipoAno(this.tipoEleicao, this.anoEleicao);
            Application.Run(votarExecutivo);
        }
        private void abrirJanelaVotarExec()
        {
            Application.Run(new VotarLegislativo());
        }

        private void abrirJanelaRelatorio(object tipoAno)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.setTipoAno((string)tipoAno);
            Application.Run(relatorio);
        }
        private void abrirJanelaGerenciarExecutivo(object tipoAno)
        {
            GerenciarExecutivo gerenciarExecutivo = new GerenciarExecutivo();
            gerenciarExecutivo.setTipoAno((string)tipoAno);
            Application.Run(gerenciarExecutivo);
        }

        private void abrirJanelaGerenciarLegislativo(object tipoAno)
        {
            GerenciarLegislativo gerenciarExecutivo = new GerenciarLegislativo();
            gerenciarExecutivo.setTipoAnoLegislativo((string)tipoAno);
            Application.Run(new GerenciarLegislativo());
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaPrincipal);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            t = new Thread(abrirJanelaRelatorio);
            t.SetApartmentState(ApartmentState.STA);
            t.Start(($"{cbmTipoEleicao.Text}-{txtAnoEleicao.Text}").ToString());
            this.Close();
        }
    }
}

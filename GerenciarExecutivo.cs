using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_Eleitoral___Executivo
{
    public partial class GerenciarExecutivo : Form
    {
        private string tipo;
        private string ano;
        private Thread t;
        public GerenciarExecutivo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo, ano);

            if (!eleicao.validarExistenciaNumCandidato(txtNumero.Text))
            {
                // ajustar idade ultimo parametro, criar campo e enviar
                Pessoa.Candidato candidato = new Pessoa.Candidato(txtNomeCompleto.Text, txtPartido.Text.ToLower(), int.Parse(txtNumero.Text), cmbTipoCandidato.Text, int.Parse(txtIdade.Text));
                eleicao.CadastrarCandidato(candidato);
                Serializer.Serializer.Serializar(eleicao);
                MessageBox.Show("Candidato cadastrado com sucesso.", "Sucesso");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Numero de candidato ja cadastrado", "Erro ao cadastrar");
                limpaCampos();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaAcessasrEleicao);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void abrirJanelaAcessasrEleicao()
        {
            Application.Run(new AcessarEleicao());
        }

        public void setTipoAno(string tipoAno)
        {
            this.tipo = tipoAno.Split("-")[0];
            this.ano = tipoAno.Split("-")[1];
        }

        private void limpaCampos()
        {
            cmbTipoCandidato.ResetText();
            cmbTipoCandidato.Refresh();
            txtNomeCompleto.Clear();
            txtIdade.Clear();
            txtPartido.Clear();
            txtNumero.Clear();
        }

        private void cmbTipoCandidato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

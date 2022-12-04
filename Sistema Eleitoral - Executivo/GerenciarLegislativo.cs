using Sistema_Eleitoral___Executivo.Eleicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema_Eleitoral___Executivo
{
    public partial class GerenciarLegislativo : Form
    {
        private string tipo;
        private string ano;
        private Thread t;
        public GerenciarLegislativo()
        {
            InitializeComponent();
        }

        private void GerenciarLegislativo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo, ano);
            if (!eleicao.validarExistenciaNumCandidato(txtNumero.Text))
            {
                // ajustar idade ultimo parametro, criar campo e enviar
                Pessoa.Candidato candidato = new Pessoa.Candidato(txtNomeCompleto.Text, txtPartido.Text, int.Parse(txtNumero.Text), cmbTipoCandidato.Text, 0);
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

        private void limpaCampos()
        {
            cmbTipoCandidato.ResetText();
            cmbTipoCandidato.Refresh();
            txtNomeCompleto.Clear();
            txtPartido.Clear();
            txtNumero.Clear();
        }
        public void setTipoAnoLegislativo(string tipoAno)
        {
            this.tipo = tipoAno.Split("-")[0];
            this.ano = tipoAno.Split("-")[1];
        }
        private void abrirJanelaAcessasrEleicao()
        {
            Application.Run(new AcessarEleicao());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaAcessasrEleicao);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}

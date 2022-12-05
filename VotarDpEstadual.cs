using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Sistema_Eleitoral___Executivo.Pessoa;

namespace Sistema_Eleitoral___Executivo
{
    public partial class VotarDpEstadual : Form
    {
        private string ano;
        private string tipo;
         Thread t;
        public VotarDpEstadual()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaDepEstadual_Click(object sender, EventArgs e)
        {
            //validar existencia de partido metodo no eleicao
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo, ano);
            if (eleicao.validarExistenciaNumCandidato(txtDepEst.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtDepEst.Text)
                    {
                        int num = (int)candidato._Votos;
                        candidato._Votos = num + 1;
                        //eleicao.adicionarVotoPartido(candidato.partido);
                    }
                }
                if (Serializer.Serializer.Serializar(eleicao))
                {
                    MessageBox.Show("Voto computado com sucesso.", "Sucesso");
                    this.Close();
                    t = new Thread(abrirJanelaVotarDpFederal);
                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                }
                else
                {
                    MessageBox.Show("Não foi possível computar o voto.", "Erro");
                }

                limpaCampos();
            }
            else
            {
                MessageBox.Show("Numero de candidato não existe", "Erro ao registrar voto");
                limpaCampos();
            }

        }
        private void limpaCampos()
        {
            txtDepEst.Clear();
        }

        private void abrirJanelaVotarDpFederal(object tipoAno)
        {
            VotarDpFederal votarDepFederal = new VotarDpFederal();
            votarDepFederal.setTipoAno(this.tipo, this.ano);
            Application.Run(votarDepFederal);
        }
        public void setTipoAno(string tipo, string ano)
        {
            this.tipo = tipo;
            this.ano = ano;
        }
        private void btnNuloDepEstadual_Click(object sender, EventArgs e)
        {
            
            lblDepEstadual.Text = "Nulo";
        }
    }
}

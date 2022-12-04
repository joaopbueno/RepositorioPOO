using Sistema_Eleitoral___Executivo.Pessoa;
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
    public partial class VotarExecPrefeito : Form
    {
        public Thread t;
        public VotarExecPrefeito()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            t = new Thread(abrirJanelaAcessarEleicao);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Close();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
        private void limpaCampos()
        {
            txtVoto.Clear();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao("Executivo", "2022");

            if (eleicao.validarExistenciaNumCandidato(txtVoto.Text) & eleicao.validarTipoCandidato("Prefeito", txtVoto.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtVoto.Text)
                    {
                        int num = (int)candidato._Votos;
                        candidato._Votos = num + 1;
                    }
                }
                if (Serializer.Serializer.Serializar(eleicao))
                {
                    MessageBox.Show("Voto computado com sucesso.", "Sucesso");
                    this.Close();
                    t = new Thread(abrirJanelaAcessarEleicao);
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

        private void btnNulo_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaAcessarEleicao);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void abrirJanelaAcessarEleicao()
        {
            Application.Run(new AcessarEleicao());
        }
    }
}

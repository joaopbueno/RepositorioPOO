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
    public partial class VotarGovernador : Form
    {

        private string tipo;
        private string ano;
        private Thread t;
        public VotarGovernador()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaGovernador_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao("Executivo", "2022");

            if (eleicao.validarExistenciaNumCandidato(txtGovernador.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtGovernador.Text)
                    {
                        int num = (int)candidato._Votos;
                        candidato._Votos = num + 1;
                        //eleicao.adicionarVotoPartido(candidato.partido);
                    }
                }
                if (Serializer.Serializer.Serializar(eleicao))
                {
                    MessageBox.Show("Voto computado com sucesso.", "Sucesso");
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
            txtGovernador.Clear();
        }
        public void setTipoAno(string tipo, string ano)
        {
            this.tipo = tipo;
            this.ano = ano;
        }

        private void btnCorrigeGovernador_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
    }
}

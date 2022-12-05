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
    public partial class VotarPrefeito : Form
    {
        private string tipo;
        private string ano;
        private Thread t;
        public VotarPrefeito()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaPrefeito_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao("Executivo", "2022");

            if (eleicao.validarExistenciaNumCandidato(txtPrefeito.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtPrefeito.Text)
                    {
                        int num = (int)candidato._Votos;
                        candidato._Votos = num + 1;
                        // eleicao.adicionarVotoPartido(candidato.partido);
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
            txtPrefeito.Clear();
        }
        public void setTipoAno(string tipo, string ano)
        {
            this.tipo = tipo;
            this.ano = ano;
        }

        private void btnCorrigePrefeito_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnNuloPrefeito_Click(object sender, EventArgs e)
        {
            lblNomePrefeito.Text = "Nulo";
            txtPrefeito.Text = "0000";
        }
    }
}

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
    public partial class VotarVereador : Form
    {
        
        private string ano;
        private string tipo;
        Thread t;
        public VotarVereador()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNomeVereador.Text = "Nulo";
            txtVereador.Text = "0000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo, ano);
            if (eleicao.validarExistenciaNumCandidato(txtVereador.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtVereador.Text)
                    {
                        int num = (int)candidato._Votos;
                        candidato._Votos = num + 1;
                       // eleicao.adicionarVotoPartido(candidato.partido);
                    }
                }
                if (Serializer.Serializer.Serializar(eleicao))
                {
                    MessageBox.Show("Voto computado com sucesso.", "Sucesso");
                    this.Close();
                    t = new Thread(abrirJanelaVotarDpEstadual);
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
            }//validar existencia de partido metodo no eleicao
        }

        private void limpaCampos()
        {
            txtVereador.Clear();
        }

        private void btnCorrigeVereador_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void lblNomeVereador_Click(object sender, EventArgs e)
        {
           
        }

        private void abrirJanelaVotarDpEstadual(object tipoAno)
        {
            VotarDpEstadual votarDepEstadual = new VotarDpEstadual();
            votarDepEstadual.setTipoAno(this.tipo, this.ano);
            Application.Run(votarDepEstadual);
        }
        public void setTipoAno(string tipo, string ano)
        {
            this.tipo = tipo;
            this.ano = ano;
        }

      
    }
}

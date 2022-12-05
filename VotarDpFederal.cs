using Sistema_Eleitoral___Executivo.Pessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sistema_Eleitoral___Executivo
{
    public partial class VotarDpFederal : Form
    {
        private string ano;
        private string tipo;
        Thread t;
        public VotarDpFederal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaDepFederal_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo,ano);
            if (eleicao.validarExistenciaNumCandidato(txtDepFed.Text))
            {
                foreach (Candidato candidato in eleicao._Candidatos)
                {
                    if (candidato._NumeroCandidato.ToString() == txtDepFed.Text)
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
                    t = new Thread(abrirAcessarEleicao);
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
            txtDepFed.Clear();
        }

        private void btnCorrigeDepFederal_Click(object sender, EventArgs e)
        {
            limpaCampos();

        }

        public void setTipoAno(string tipo, string ano)
        {
            this.tipo = tipo;
            this.ano = ano;

        }

        private void abrirAcessarEleicao()
        {
            
            Application.Run(new AcessarEleicao());
        }
    }
}

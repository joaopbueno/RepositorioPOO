using Sistema_Eleitoral___Executivo.Eleicao;
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
    public partial class Relatorio : Form
    {
        private string tipo;
        private string ano;
        private List<Candidato> candidatosPresidente = new List<Candidato>();
        private List<Candidato> candidatosPrefeito = new List<Candidato>();
        private List<Candidato> candidatosGovernador = new List<Candidato>();
        private Thread t;
        public Relatorio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setTipoAno(string tipoAno)
        {
            this.tipo = tipoAno.Split("-")[0];
            this.ano = tipoAno.Split("-")[1];
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            Eleicao.Eleicao eleicao = (Eleicao.Eleicao)Serializer.Deserializer.RecuperarEleicao(tipo, ano);
            //PRESIDENTE
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if(candidato._Tipo.ToString() == "Presidente")
                {
                    candidatosPresidente.Add(candidato);
                }
            }
            presidenteEleito(candidatosPresidente);

            //GOVERNADOR
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if (candidato._Tipo.ToString() == "Governador Estadual")
                {
                    candidatosGovernador.Add(candidato);
                }
            }
            governadorEleito(candidatosGovernador);

            //PREFEITO
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if (candidato._Tipo.ToString() == "Prefeito")
                {
                    candidatosPrefeito.Add(candidato);
                }
            }
            prefeitoEleito(candidatosPrefeito);

        }

        private void presidenteEleito(List<Candidato> presidente)
        {
            Candidato aux = new Candidato();
            Candidato aux2 = new Candidato();
            foreach(Candidato cand in presidente)
            {
                if (cand._Votos >= aux._Votos)
                {
                    if (cand._Votos == aux._Votos)
                        aux2 = cand;
                    else
                        aux = cand;
                }
            }

            if (aux2._Votos != 0)
                lbPreseidente.Text = aux._Nome + " VOTOS:(" + aux._Votos + ") e " + aux2._Nome + " VOTOS:(" + aux2._Votos + ")";
            else
                lbPreseidente.Text = aux._Nome + " VOTOS:(" + aux._Votos + ")";
        }

        private void governadorEleito(List<Candidato> governador)
        {
            Candidato aux = new Candidato();
            Candidato aux2 = new Candidato();
            foreach (Candidato cand in governador)
            {
                if (cand._Votos >= aux._Votos)
                {
                    if (cand._Votos == aux._Votos)
                        aux2 = cand;
                    else
                        aux = cand;
                }
            }

            if (aux2._Votos != 0)
                lbGovernador.Text = aux._Nome + " VOTOS:(" + aux._Votos + ") e " + aux2._Nome + " VOTOS:(" + aux2._Votos + ")";
            else
                lbGovernador.Text = aux._Nome + " VOTOS:(" + aux._Votos + ")";
        }

        private void prefeitoEleito(List<Candidato> prefeito)
        {
            Candidato aux = new Candidato();
            Candidato aux2 = new Candidato();
            foreach (Candidato cand in prefeito)
            {
                if (cand._Votos >= aux._Votos)
                {
                    if (cand._Votos == aux._Votos)
                        aux2 = cand;
                    else
                        aux = cand;
                }
            }

            if (aux2._Votos != 0)
                lbPrefeito.Text = aux._Nome + " VOTOS:(" + aux._Votos + ") e " + aux2._Nome + " VOTOS:(" + aux2._Votos + ")";
            else
                lbPrefeito.Text = aux._Nome + " VOTOS:(" + aux._Votos + ")";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}

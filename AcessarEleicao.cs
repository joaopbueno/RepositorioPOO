﻿using System;
using System.Threading;
using System.Windows.Forms;
using Sistema_Eleitoral___Executivo.Eleicao;

namespace Sistema_Eleitoral___Executivo
{
    public partial class AcessarEleicao : Form
    {
        string tipo;
        string ano;
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
                //Serializer.Serializer.VerificarEleicaoVazia(cbmTipoEleicao.Text, txtAnoEleicao.Text
                if (false)
                {
                    MessageBox.Show("A eleicao nao possui candidato cadastrado.\nCadastre candidatos para prosseguir para a votacao.", "Erro");
                    return;
                }
                else
                {
                    if (cbmTipoEleicao.Text == "Executivo")
                    {
                        this.Close();
                        t = new Thread(abrirJanelaVotar);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                    }
                    else
                    {
                        this.Close();
                        t = new Thread(abrirJanelaVotarVereador);
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
            /*VotarVereador votarVereador = new VotarVereador();
            votarVereador.setTipoAno(this.tipoEleicao, this.anoEleicao);
            Application.Run(votarVereador);*/
        }
        private void abrirJanelaVotarP()
        {
            Application.Run(new VotarPrefeito());
        }

        private void abrirJanelaRelatorio()
        {
            Application.Run(new Relatorio());
        }
        private void abrirJanelaGerenciarExecutivo(object tipoAno)
        {
            GerenciarExecutivo gerenciarExecutivo = new GerenciarExecutivo();
            gerenciarExecutivo.setTipoAno((string)tipoAno);
            Application.Run(gerenciarExecutivo);
        }

        private void abrirJanelaGerenciarLegislativo(object tipoAno)
        {
            GerenciarLegislativo gerenciarLegislativo = new GerenciarLegislativo();
            gerenciarLegislativo.setTipoAnoLegislativo((string)tipoAno);
            Application.Run(gerenciarLegislativo);
        }

        private void abrirJanelaVotarVereador()
        {
            VotarVereador votarVereador = new VotarVereador();
            votarVereador.setTipoAno(this.tipoEleicao, this.anoEleicao);
            Application.Run(votarVereador);
            
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
            this.Close();
            t = new Thread(abrirJanelaRelatorio);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        public void setTipoAnoLegislativo(string tipoAno)
        {
            this.tipo = tipoAno.Split("-")[0];
            this.ano = tipoAno.Split("-")[1];
        }
    }
}

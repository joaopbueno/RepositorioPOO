using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sistema_Eleitoral___Executivo
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarEleicao_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaCadastrar);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btnAcessarEleicao_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(abrirJanelaAcessar);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void abrirJanelaCadastrar()
        {
            Application.Run(new CadastrarEleicao());
        }
        private void abrirJanelaAcessar()
        {
            Application.Run(new AcessarEleicao());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Eleitoral___Executivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }


        static void criaDados()
        {
            Eleicao.Eleicao eleicao = new Eleicao.Eleicao();
            eleicao.CadastrarCandidato(new Pessoa.Candidato("a", "a", 5, "Prefeito", 22));
            eleicao.CadastrarCandidato(new Pessoa.Candidato("b", "b", 1, "Prefeito", 34));
            eleicao.CadastrarCandidato(new Pessoa.Candidato("c", "c", 3, "Prefeito", 2));
            eleicao.CadastrarCandidato(new Pessoa.Candidato("d", "d", 6, "Prefeito", 55));
            eleicao.CadastrarCandidato(new Pessoa.Candidato("e", "e", 22, "Prefeito", 32));
            eleicao.CadastrarCandidato(new Pessoa.Candidato("f", "f", 92, "Prefeito", 29));
        }
    }
}

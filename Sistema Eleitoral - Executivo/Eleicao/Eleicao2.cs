using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using Sistema_Eleitoral___Executivo.Pessoa;

namespace Sistema_Eleitoral___Executivo.Eleicao
{
    internal class Eleicao2
    {
        public bool _Concluido = false;
        public bool _SegundoTurno = false;
        public string _Tipo { get; set; }
        public string _Ano { get; set; }

        public string _Candidatos;

        public List<Candidato> candidatos;

        public Eleicao2()
        {
            candidatos = new List<Candidato>();
        }

        public void ConcluirEleicao()
        {
            this._Concluido = true;
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            candidatos.Add(candidato);
        }

        public bool validarExistenciaNumCandidato(string num)
        {
            foreach (Candidato candidato in candidatos)
            {
                if (candidato._NumeroCandidato.Equals(num))
                    return true;
            }
            return false;
        }
    }
}

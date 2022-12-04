using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using Sistema_Eleitoral___Executivo.Pessoa;

namespace Sistema_Eleitoral___Executivo.Eleicao
{
    internal class Eleicao
    {
        public bool _Concluido = false;
        public bool _SegundoTurno = false;
        public string _Tipo {get; set;}
        public string _Ano { get; set;}
        public List<Candidato> _Candidatos { get; set; }

        public Eleicao()
        {
            _Candidatos = new List<Candidato>();
        }

        public void ConcluirEleicao()
        {
            this._Concluido = true;
        }

        public void CadastrarCandidato(Candidato candidato)
        {
            _Candidatos.Add(candidato);
        }

        public bool validarExistenciaNumCandidato(string num)
        {
            foreach (Candidato candidato in _Candidatos)
            {
                if (candidato._NumeroCandidato.Equals(num))
                    return true;
            }
            return false;
        }
    }
}

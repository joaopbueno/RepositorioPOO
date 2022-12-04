using System;
using System.Collections.Generic;
using System.Text;
using Sistema_Eleitoral___Executivo.Pessoa;
using Sistema_Eleitoral___Executivo.Serializer;

namespace Sistema_Eleitoral___Executivo.Eleicao
{
    internal class Executivo
    {
        private string _Prefeito;
        private string _Vereador;
        Eleicao eleicao;
        Dictionary<int, Candidato> candidatos;

        public Executivo(string tipo, string ano)
        {
            eleicao = (Eleicao)Deserializer.RecuperarEleicao(tipo, ano);
        }

        private void primeiroTurno()
        {

        }

        public Candidato ElegePresidente()
        {
            candidatos = new Dictionary<int, Candidato>();
            List<int> votos = new List<int>();
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if (candidato._Tipo == "Presidente")
                {
                    candidatos.Add(candidato._NumeroCandidato, candidato);
                    votos.Add(candidato._Votos);
                }
            }
            Candidato presidente = candidatos[0];
            votos.Sort();
            if (votos[0] != votos[1])
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0])
                    {
                        presidente = candidato;
                    }
                }
            }
            else
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0] && candidato._Idade > presidente._Idade)
                    {
                        presidente = candidato;
                    }
                }
            }
            return presidente;
        }

        public Candidato ElegeGovernador()
        {
            candidatos = new Dictionary<int, Candidato>();
            List<int> votos = new List<int>();
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if (candidato._Tipo == "Governador")
                {
                    candidatos.Add(candidato._NumeroCandidato, candidato);
                    votos.Add(candidato._Votos);
                }
            }
            Candidato governador = candidatos[0];
            votos.Sort();
            if (votos[0] != votos[1])
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0])
                    {
                        governador = candidato;
                    }
                }
            }
            else
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0] && candidato._Idade > governador._Idade)
                    {
                        governador = candidato;
                    }
                }
            }
            return governador;
        }

        public Candidato ElegePrefeito()
        {
            candidatos = new Dictionary<int, Candidato>();
            List<int> votos = new List<int>();
            foreach (Candidato candidato in eleicao._Candidatos)
            {
                if (candidato._Tipo == "Prefeito")
                {
                    candidatos.Add(candidato._NumeroCandidato, candidato);
                    votos.Add(candidato._Votos);
                }
            }
            Candidato prefeito = candidatos[0];
            votos.Sort();
            if (votos[0] != votos[1])
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0])
                    {
                        prefeito = candidato;
                    }
                }
            }
            else
            {
                foreach (Candidato candidato in candidatos.Values)
                {
                    if (candidato._Votos == votos[0] && candidato._Idade > prefeito._Idade)
                    {
                        prefeito = candidato;
                    }
                }
            }
            return prefeito;
        }
    }
}


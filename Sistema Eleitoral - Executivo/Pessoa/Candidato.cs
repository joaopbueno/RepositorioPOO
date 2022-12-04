using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Eleitoral___Executivo.Pessoa
{
    internal sealed class Candidato : Pessoa
    {
        public string _Nome;
        public int _Votos=0;
        public string _Partido;
        public int _NumeroCandidato;
        public string _Tipo;
        public int _Idade;

        public Candidato(string nome, string partido, int numero, string tipo, int idade)
        {
            _Nome = nome;
            _Partido = partido;
            _NumeroCandidato = numero;
            _Tipo = tipo;
            _Idade = idade;
        }

        public void ReceberVoto()
        {
            _Votos++;
        }
    }
}

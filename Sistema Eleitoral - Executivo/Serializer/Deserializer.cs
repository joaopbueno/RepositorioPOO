using System.Text.Json;
using Sistema_Eleitoral___Executivo.Eleicao;
using System.IO;
using System.Text.Json;
using Sistema_Eleitoral___Executivo.Pessoa;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sistema_Eleitoral___Executivo.Serializer
{
    internal static class Deserializer
    {
        private static string _Path = Directory.GetCurrentDirectory() + @"\Eleicoes";

        public static object RecuperarEleicao(string tipo, string ano)
        {
            string txt = File.ReadAllText($"{_Path}\\{tipo}-{ano}").ToString();
            //string candidato = File.ReadAllText($"{_Path}\\{tipo}-{ano}")._Candidatos.ToString();
            //Eleicao.Eleicao2 eleicao = JsonSerializer.Deserialize<Eleicao.Eleicao2>(txt);
            Eleicao.Eleicao eleicao = JsonConvert.DeserializeObject<Eleicao.Eleicao>(txt);
            //List<Candidato> candidatos = JsonSerializer.Deserialize<Candidato>(txt)._Candidatos;
            //eleicao._Candidatos = candidatos;
            return eleicao;
        }

    }
}
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Sistema_Eleitoral___Executivo.Pessoa;
using Sistema_Eleitoral___Executivo.Eleicao;

namespace Sistema_Eleitoral___Executivo.Serializer
{
    internal static class Serializer
    {
        private static string _path = Directory.GetCurrentDirectory() + @"\Eleicoes";

        public static bool Serializar(Eleicao.Eleicao eleicao)
        {
            CriarDir();
            try
            {
                string json = JsonConvert.SerializeObject(eleicao);
                string file = $"{_path}\\{eleicao._Tipo}-{eleicao._Ano}";
                File.WriteAllText(file, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool VerificarExistenciaEleicao(string tipo, string ano)
        {
            if (File.Exists($"{_path}\\{tipo}-{ano}"))
                return true;
            return false;
        }

        public static bool VerificarEleicaoVazia(string tipo, string ano)
        {
            return ((Eleicao.Eleicao)Deserializer.RecuperarEleicao(tipo, ano))._Candidatos.Count == 0;
        }

        //public static bool VerificarExistenciaCandidato(string tipo, string ano, string num)
        //{
        //    int cont = ((Eleicao.Eleicao)Deserializer.RecuperarEleicao(tipo, ano))._Candidatos.Count;
        //    Eleicao.Eleicao eleicao = ((Eleicao.Eleicao)Deserializer.RecuperarEleicao(tipo, ano));
        //    List<Candidato> candidatos = eleicao._Candidatos;


        //    for (int i =0; i < cont; i++)
        //    {
        //        if (candidatos[i]._NumeroCandidato.ToString() == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        private static void CriarDir()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
                DirectoryInfo d = new DirectoryInfo(_path);
                d.Attributes = FileAttributes.Hidden;
            }
        }
    }
}

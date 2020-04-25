using System;

namespace GestorOcorrencias
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ocorrencias ocorrencias = new Ocorrencias();
            Catastrofes catastrofes = new Catastrofes();
            Distritos distritos = new Distritos();

            #region DUMMIE_DATA

            DateTime auxDate = new DateTime(2018, 12, 02, 8, 0, 0);
            ocorrencias.InsereOcorrencia(auxDate, "Incêncido que consumiu 10 hectares", 1, 12);
            Console.WriteLine("descricao -> {0}", ocorrencias.ProcuraOcorrencia(1).Descricao);
            ocorrencias.ProcuraOcorrencia(1).InsereObito(492883123, auxDate);

            auxDate = new DateTime(2019, 05, 08, 13, 37, 23);
            ocorrencias.InsereOcorrencia(auxDate, "Sismo de magnitude 3", 2, 7);
            Console.WriteLine("descricao -> {0}", ocorrencias.ProcuraOcorrencia(2).Descricao);
            ocorrencias.ProcuraOcorrencia(2).InsereFerido(437982738);
            ocorrencias.ProcuraOcorrencia(2).InsereFerido(482888123);

            #endregion

        }
    }
}

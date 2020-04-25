using System;

namespace GestorOcorrencias
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ocorrencias ocorrencias = new Ocorrencias();
            DateTime auxDate = new DateTime(2018, 12, 02, 8, 0, 0);
            Ocorrencias.InsereOcorrencia(auxDate, "Incêncido que consumiu 10 hectares", 1, 12);
            Ocorrencias.InsereOcorrencia(auxDate, "Sismo de magnitude 3", 2, 7);

            Console.WriteLine("ENTROU");

            Console.WriteLine("descricao -> {0}", Ocorrencias.ProcuraOcorrencia(2).Descricao);
            Console.WriteLine("FIM");
        }
    }
}

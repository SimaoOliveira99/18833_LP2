using System;
using BR;
using BO;

namespace GestorOcorrencias
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region LOAD_DATA

            //load distritos
            //load catastrofes

            try
            {
                //DistritosA.Load("ocorrenciasFile");
                Console.WriteLine("teste");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao carregar ficheiro: " + e);
            }

            #endregion

            //NEW
            Distrito distrito;
            Catastrofe catastrofe;
            Obito obito;
            DateTime data;
            //ENDNEW

            #region DUMMIE_DATA

            //NEW
            try
            {
                distrito = new Distrito("Braga");
                DistritosBR.InsereDistrito(distrito);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //IMPORTANT criar funcoes no CatastrofesBR
            //try
            //{
            //    catastrofe = new Catastrofe("Sismo");
            //    CatastrofesBR.
            //    DistritosBR.InsereDistrito(distrito);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try {
                data = new DateTime(2018, 12, 02, 8, 0, 0);
                obito = new Obito(2412312, data);
                //OcorrenciaBR.ProcuraOcorrencia(1).InsereObito(obito);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //ENDNEW

            //DateTime auxDate = new DateTime(2018, 12, 02, 8, 0, 0);
            //ocorrencias.InsereOcorrencia(auxDate, "Incêncido que consumiu 10 hectares", 1, 12);
            //Console.WriteLine("descricao -> {0}", ocorrencias.ProcuraOcorrencia(1).Descricao);
            //ocorrencias.ProcuraOcorrencia(1).InsereObito(492883123, auxDate);
            //Console.WriteLine("Ferido -> {0}", ocorrencias.ProcuraOcorrencia(1).ProcuraObito(492883123).Cc);
            //ocorrencias.ProcuraOcorrencia(1).InsereObito(492883123, auxDate);

            //auxDate = new DateTime(2019, 05, 08, 13, 37, 23);
            //ocorrencias.InsereOcorrencia(auxDate, "Sismo de magnitude 3", 2, 7);
            //Console.WriteLine("descricao -> {0}", ocorrencias.ProcuraOcorrencia(2).Descricao);
            //ocorrencias.ProcuraOcorrencia(2).InsereFerido(437982738);
            //ocorrencias.ProcuraOcorrencia(2).InsereFerido(482888123);

            //suportado pela camada de negocio
            //testar
            //if (distritos.ProcuraDistrito(1))
            //Console.WriteLine("Distrito-> {0}", distritos.ProcuraDistrito(1).Nome);

            //distritos.InsereDistrito("Braga");

            //DistritosA.Save("ocorrenciasFile");

            //Console.WriteLine("Ferido -> {0}", ocorrencias.ProcuraOcorrencia(2).ProcuraFerido(437982738).Cc);

            #endregion

            #region SAVE_DATA

            //save distritos
            //save catastrofes
            //save ocorrencias


            #endregion


            Console.ReadKey();

        }
    }
}

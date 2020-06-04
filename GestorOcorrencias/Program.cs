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

            try
            {
                DistritosBR.CarregaDistritos("fDistritos");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CatastrofesBR.CarregaCatastrofes("fCatastrofes");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                OcorrenciasBR.CarregaOcorrencias("fOcorrencias");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region DUMMIE_DATA

 
            Distrito distrito;
            Catastrofe catastrofe;
            Ocorrencia ocorrencia;
            Obito obito;
            Ferido ferido;
            DateTime data;

            #region DISTRITOS

            try
            {
                distrito = new Distrito("Braga");
                if (DistritosBR.InsereDistrito(distrito) > 0)
                    Console.WriteLine("Distrito: {0}\n", DistritosBR.ProcuraDistrito(1).Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                distrito = new Distrito("Porto");
                if (DistritosBR.InsereDistrito(distrito) > 0)
                    Console.WriteLine("Distrito: {0}\n", DistritosBR.ProcuraDistrito(2).Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region CATASTROFES

            try
            {
                catastrofe = new Catastrofe("Sismo");
                if (CatastrofesBR.InsereCatastrofe(catastrofe) > 0)
                    Console.WriteLine("Catastrofe: {0}\n", CatastrofesBR.ProcuraCatastrofe(1).Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                catastrofe = new Catastrofe("Tsunami");
                if (CatastrofesBR.InsereCatastrofe(catastrofe) > 0)
                    Console.WriteLine("Catastrofe: {0}\n", CatastrofesBR.ProcuraCatastrofe(2).Nome);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region OCORRÊNCIAS

            try
            {
                data = new DateTime(2018, 12, 02, 8, 0, 0);
                ocorrencia = new Ocorrencia(data, 1, 2);
                OcorrenciasBR.InsereOcorrencia(ocorrencia);
                Console.WriteLine("Ocorrencia distrito {0}\n", OcorrenciasBR.ProcuraOcorrencia(1).IdDistrito);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                data = new DateTime(2020, 01, 02, 16, 30, 13);
                ocorrencia = new Ocorrencia(data, 2, 1);
                OcorrenciasBR.InsereOcorrencia(ocorrencia);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #region FERIDOS

            try
            {
                ferido = new Ferido(5125125);
                if (OcorrenciasBR.InsereFerido(1, ferido) > 0)
                    Console.WriteLine("Ferido: {0}\n", OcorrenciasBR.ProcuraOcorrencia(1).ProcuraFerido(5125125).Cc);
                else
                    Console.WriteLine("O ferido já está inserido nesta ocorrencia");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                ferido = new Ferido(9123872);
                if (OcorrenciasBR.InsereFerido(1, ferido) > 0)
                    Console.WriteLine("Ferido: {0}\n", OcorrenciasBR.ProcuraOcorrencia(1).ProcuraFerido(9123872).Cc);
                else
                    Console.WriteLine("O ferido já está inserido nesta ocorrencia");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region OBITOS

            try
            {
                data = new DateTime(2020, 01, 02, 16, 40, 0);
                obito = new Obito(7123632, data);
                if (OcorrenciasBR.InsereObito(2, obito) > 0)
                    Console.WriteLine("Obito: {0}\n", OcorrenciasBR.ProcuraOcorrencia(2).ProcuraObito(7123632).Cc);
                else
                    Console.WriteLine("O Obito já está inserido nesta ocorrencia");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #endregion

            #endregion

            #region SAVE_DATA

            try
            {
                DistritosBR.GuardaDistritos("fDistritos");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CatastrofesBR.GuardaCatastrofes("fCatastrofes");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                OcorrenciasBR.GuardaOcorrencias("fOcorrencias");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            #endregion

            Console.ReadKey();

        }
    }
}

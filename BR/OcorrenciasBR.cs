using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dados;
using BO;

namespace BR
{
    public class OcorrenciasBR
    {

        #region METODOS

        #region METODOS_DE_CLASSE

        public static int InsereObito(int ocoId, Obito o)
        {
            try
            {
                return ProcuraOcorrencia(ocoId).InsereObito(o);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir obito: " + e.Message);
            }
        }

        public static bool ApagaObito(int ocoId, Obito o)
        {
            try
            {
                return ProcuraOcorrencia(ocoId).ApagaObito(o);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao apagar obito: " + e.Message);
            }
        }

        public static int InsereFerido(int ocoId, Ferido f)
        {
            try
            {
                return ProcuraOcorrencia(ocoId).InsereFerido(f);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir ferido: " + e.Message);
            }
        }
        public static bool ApagaFerido(int ocoId, Ferido f)
        {
            try
            {
                return ProcuraOcorrencia(ocoId).ApagaFerido(f);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao apagar ferido: " + e.Message);
            }
        }

        public static int InsereOcorrencia(Ocorrencia o)
        {
            try
            {
                return Ocorrencias.InsereOcorrencia(o);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir ocorrencia: " + e.Message);
            }
        }

        public static bool ApagaOcorrencia(int id)
        {
            try
            {
                return Ocorrencias.ApagaOcorrencia(ProcuraOcorrencia(id));
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao apagar ocorrencia: " + e.Message);
            }
        }

        public static OcorrenciaDB ProcuraOcorrencia(int id)
        {
            try
            {
                return Ocorrencias.ProcuraOcorrencia(id);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao procurar ocorrencia: " + e.Message);
            }
        }

        public static bool GuardaOcorrencias(string nomeFicheiro)
        {
            try
            {
                return Ocorrencias.Save(nomeFicheiro);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao guardar dados no ficheiro de ocorrencias " + e.Message);
            }
        }

        public static bool CarregaOcorrencias(string nomeFicheiro)
        {
            try
            {
                if (File.Exists(nomeFicheiro))
                    return Ocorrencias.Load(nomeFicheiro);
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao carregar dados do ficheiro de ocorrencias " + e.Message);
            }
        }

        #endregion

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using BO;

namespace BR
{
    public class OcorrenciaBR
    {
        #region ESTADO 

        //public OcorrenciaDB ocorrencia;

        #endregion

        #region METODOS

        //#region PROPRIEDADES

        //public int this[int i]
        //{
        //    public int Id
        //    {
        //        return 0;
        //    }
        //    //get { return ocorrencia.Id; }
        //    //set
        //    //{
        //    //    try
        //    //    {
        //    //        ocorrencia.Id = value;
        //    //    }
        //    //    catch (Exception e)
        //    //    {
        //    //        throw e;
        //    //    }
        //    //}
        //}

        //public DateTime Data
        //{
        //    get { return ocorrencia.Data; }
        //    set
        //    {
        //        try
        //        {
        //            ocorrencia.Data = value;
        //        }
        //        catch (Exception e)
        //        {
        //            throw e;
        //        }
        //    }
        //}

        //public string Descricao
        //{
        //    get { return ocorrencia.Descricao; }
        //    set
        //    {
        //        try
        //        {
        //            ocorrencia.Descricao = value;
        //        }
        //        catch (Exception e)
        //        {
        //            throw e;
        //        }
        //    }
        //}

        //public int IdCatastrofe
        //{
        //    get { return ocorrencia.IdCatastrofe; }
        //    set
        //    {
        //        try
        //        {
        //            ocorrencia.IdCatastrofe = value;
        //        }
        //        catch (Exception e)
        //        {
        //            throw e;
        //        }
        //    }
        //}

        //public int IdDistrito
        //{
        //    get { return ocorrencia.IdDistrito; }
        //    set
        //    {
        //        try
        //        {
        //            ocorrencia.IdDistrito = value;
        //        }
        //        catch (Exception e)
        //        {
        //            throw e;
        //        }
        //    }
        //}

        //public int TotalObitos
        //{
        //    get { return ocorrencia.TotalObitos; }
        //}

        //public int TotalFeridos
        //{
        //    get { return ocorrencia.TotalFeridos; }
        //}

        //#endregion

        #region METODOS_DE_CLASSE

        public int InsereObito(int ocoId, Obito o)
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

        public bool ApagaObito(int ocoId, Obito o)
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

        public int InsereFerido(int ocoId, Ferido f)
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
                return Ocorrencias.Load(nomeFicheiro);
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

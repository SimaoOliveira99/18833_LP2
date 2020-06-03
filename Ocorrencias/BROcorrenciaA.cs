using GestorOcorrencias;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencias
{
    class BROcorrenciaA
    {
        #region ESTADO 

        public static Ocorrencia ocorrencia;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public BROcorrenciaA(int idOc, DateTime dt, int idCat, int idDis)
        {
            try
            {
                ocorrencia = new Ocorrencia(idOc, dt, idCat, idDis);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BROcorrenciaA(int idOc, DateTime dt, string desc, int idCat, int idDis)
        {
            try
            {
                ocorrencia = new Ocorrencia(idOc, dt, desc, idCat, idDis);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return ocorrencia.Id; }
        }

        public DateTime Data
        {
            get { return ocorrencia.Data; }
            set
            {
                try
                {
                    ocorrencia.Data = value;
                }
                catch (FormatException e)
                {
                    throw e;
                }
            }
        }

        public string Descricao
        {
            get { return ocorrencia.Descricao; }
            set
            {
                try
                {
                    ocorrencia.Descricao = value;
                }
                catch (FormatException e)
                {
                    throw e;
                }
            }
        }

        public int IdCatastrofe
        {
            get { return ocorrencia.IdCatastrofe; }
            set
            {
                try
                {
                    ocorrencia.IdCatastrofe = value;
                }
                catch (FormatException e)
                {
                    throw e;
                }
            }
        }

        public int IdDistrito
        {
            get { return ocorrencia.IdDistrito; }
            set
            {
                try
                {
                    ocorrencia.IdDistrito = value;
                }
                catch (FormatException e)
                {
                    throw e;
                }
            }
        }

        public int TotalObitos
        {
            get { return ocorrencia.TotalObitos; }
        }

        public int TotalFeridos
        {
            get { return ocorrencia.TotalFeridos; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        public bool EqualsId(int idToCompare)
        {
            try
            {
                return ocorrencia.EqualsId(idToCompare);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int InsereObito(int ccParam, DateTime dataObi)
        {

            try
            {
                return ocorrencia.InsereObito(ccParam, dataObi);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #endregion
    }
}

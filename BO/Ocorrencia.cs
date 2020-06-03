using System;
using System.Collections.Generic;

namespace BO
{
    [Serializable]

    public class Ocorrencia
    {
        #region ESTADO

        int id;
        DateTime data;
        string descricao;
        int idCatastrofe;
        int idDistrito;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Ocorrencia(DateTime dt, int idCat, int idDis)
        {
            data = dt;
            idCatastrofe = idCat;
            idDistrito = idDis;
        }
        public Ocorrencia(int idOc, DateTime dt, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            idCatastrofe = idCat;
            idDistrito = idDis;
        }

        public Ocorrencia(int idOc, DateTime dt, string desc, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            descricao = desc;
            idCatastrofe = idCat;
            idDistrito = idDis;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                    data = value;
            }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int IdCatastrofe
        {
            get { return idCatastrofe; }
            set { idCatastrofe = value; }
        }

        public int IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        #endregion

        #endregion

    }
}

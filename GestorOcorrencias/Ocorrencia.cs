using System;
namespace GestorOcorrencias
{
    public class Ocorrencia
    {
        #region ESTADO

        static int id;
        static DateTime data;
        static string descricao;
        static int idCatastrofe;
        static int idDistrito;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Ocorrencia(int idOc, DateTime dt, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            //verificar se existe o idCat e idDis na lista de catastrofes e de distritos respetivamente
            idCatastrofe = idCat;
            idDistrito = idDis;
        }

        public Ocorrencia(int idOc, DateTime dt, string desc, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            descricao = desc;
            //verificar se existe o idCat e idDis na lista de catastrofes e de distritos respetivamente
            idCatastrofe = idCat;
            idDistrito = idDis;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
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
            //verificar se existe o id vindo do value na lista de catastrofes
            set { idCatastrofe = value; }
        }

        public int IdDistrito
        {
            get { return idDistrito; }
            //verificar se existe o id vindo do value na lista de distritos
            set { idDistrito = value; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Compara id recebido com id da ocorrencia.
        /// </summary>
        /// <returns><c>true</c>, if identifier was equalsed, <c>false</c> otherwise.</returns>
        /// <param name="idToCompare">Identifier to compare.</param>
        public bool EqualsId(int idToCompare)
        {
            return id == idToCompare;
        }

        #endregion

        #endregion

    }
}

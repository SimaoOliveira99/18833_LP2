using System;
namespace GestorOcorrencias
{
    [Serializable]
    public class Distrito
    {

        #region ESTADO

        int id;
        string nome;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Distrito (string nomeParam)
        {
            nome = nomeParam;
        }

        public Distrito (int idParam, string nomeParam)
        {
            id = idParam;
            nome = nomeParam;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Verifica se o id do distrito é igual ao id recebido no parametro
        /// </summary>
        /// <param name="idToCompare"></param>
        /// <returns></returns>
        public bool EqualsId(int idToCompare)
        {
            return id == idToCompare;
        }

        #endregion

        #endregion
    }
}

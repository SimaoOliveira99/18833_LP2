using System;
namespace BO
{
    [Serializable]
    public class Catastrofe
    {
        #region ESTADO

        int id;
        string nome;
        string descricao;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Catastrofe(string nomePararm)
        {
            nome = nomePararm;
        }

        public Catastrofe(int idParam, string nomeParam)
        {
            id = idParam;
            nome = nomeParam;
        }

        public Catastrofe(int idParam, string nomeParam, string desc)
        {
            id = idParam;
            nome = nomeParam;
            descricao = desc;
        }

        #endregion

        #region PROPERTIES

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
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Verifica se o id da catastrofe é igual ao id recebido no parametro
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

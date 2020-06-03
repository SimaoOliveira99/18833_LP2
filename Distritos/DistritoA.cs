using System;
namespace GestorOcorrencias
{
    [Serializable]
    public class DistritoA
    {

        #region ESTADO

        static int id;
        static string nome;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public DistritoA(int idParam, string nomeParam)
        {
            id = idParam;
            nome = nomeParam;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        public bool EqualsId(int idToCompare)
        {
            return id == idToCompare;
        }

        #endregion

        #endregion
    }
}

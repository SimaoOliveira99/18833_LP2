using System;
namespace GestorOcorrencias
{
    public class Distrito
    {

        #region ESTADO

        static int id;
        static string nome;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Distrito(int idParam, string nomeParam)
        {
            id = idParam;
            nome = nomeParam;
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

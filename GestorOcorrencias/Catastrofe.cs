using System;
namespace GestorOcorrencias
{
    public class Catastrofe
    {
        #region ESTADO

        static int id;
        static string nome;
        static string descricao;

        #endregion

        #region METODOS

        #region CONSTRUTORES

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

        #region METODOS_DE_CLASSE

        public bool EqualsId(int idToCompare)
        {
            return id == idToCompare;
        }

        #region

        #endregion
    }
}

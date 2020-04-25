using System;
namespace GestorOcorrencias
{
    public class Pessoa
    {
        #region ESTADOS

        protected int id;
        protected string nome;
        protected int idade;
        protected int cc;
        protected DateTime dataNasc;
        protected int idDistrito;

        #endregion

        #region METODOS

        #region PROPRIEDADES

        public int Cc
        {
            get { return cc; }
        }

        #endregion

        #region CONSTRUTORES

        public Pessoa(int idParam, int ccParam)
        {
            id = idParam;
            cc = ccParam;
        }
        public Pessoa(int idParam, string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam)
        {
            id = idParam;
            nome = nomeParam;
            idade = idadeParam;
            cc = ccParam;
            dataNasc = dataNascParam;
            idDistrito = idDistritoParam;
        }

        #endregion

        #region METODOS_DE_CLASSE

        public bool EqualsCc(int ccToCompare)
        {
            return cc == ccToCompare;
        }

        #endregion

        #endregion
    }
}

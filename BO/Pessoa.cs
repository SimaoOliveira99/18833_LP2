using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace BO
{
    [Serializable]
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

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int Cc
        {
            get { return cc; }
            set { cc = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public int IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        #endregion

        #region CONSTRUTORES
        public Pessoa(int ccParam)
        {
            cc = ccParam;
        }
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

using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace BO
{
    [Serializable]
    public class Obito : Pessoa
    {
        #region ESTADO

        DateTime dataObito;
        string causa;
        string descricaoFerimentos;

        #endregion

        #region METODOS

        #region PROPRIEDADES

        public DateTime DataObito
        {
            get { return dataObito; }
            set { dataObito = value; }
        }

        public string Causa
        {
            get { return causa; }
            set { causa = value; }
        }

        public string DescricaoFerimentos
        {
            get { return descricaoFerimentos; }
            set { descricaoFerimentos = value; }
        }

        #endregion

        #region CONSTRUTORES

        public Obito(int ccParam, DateTime dataObi) : base (ccParam)
        {
            dataObito = dataObi;
        }

        public Obito(int idParam, int ccParam, DateTime dataObi) : base (idParam, ccParam)
        {
            dataObito = dataObi;
        }

        public Obito(int idParam, string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, DateTime dataObi, string caus, string desc) : base (idParam, 
            nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam)
        {
            dataObito = dataObi;
            causa = caus;
            descricaoFerimentos = desc;
        }

        #endregion

        #endregion
    }
}

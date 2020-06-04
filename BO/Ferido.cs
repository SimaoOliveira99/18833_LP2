using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace BO
{
    [Serializable]
    public class Ferido : Pessoa
    {
        #region ESTADO

        string descricaoFerimentos;

        #endregion

        #region METODOS

        #region PROPRIEDADES

        public string DescricaoFerimentos
        {
            get { return descricaoFerimentos; }
            set { descricaoFerimentos = value; }
        }

        #endregion

        #region CONSTRUTORES
        public Ferido(int ccParam) : base(ccParam) { }
        public Ferido(int idParam, int ccParam) : base(idParam, ccParam) {}

        public Ferido(int idParam, int ccParam, string desc) : base(idParam, ccParam)
        {
            descricaoFerimentos = desc;
        }

        public Ferido(int idParam, string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, string desc) : base(idParam, 
            nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam)
        {
            descricaoFerimentos = desc;
        }

        #endregion

        #endregion
    }
}

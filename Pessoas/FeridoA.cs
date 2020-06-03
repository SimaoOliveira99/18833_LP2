using System;
using System.Runtime.Serialization.Formatters.Binary;
namespace GestorOcorrencias
{
    [Serializable]
    public class FeridoA : PessoaA
    {
        #region ESTADO

        string descricaoFerimentos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public FeridoA(int idParam, int ccParam) : base(idParam, ccParam) {}

        public FeridoA(int idParam, int ccParam, string desc) : base(idParam, ccParam)
        {
            descricaoFerimentos = desc;
        }

        public FeridoA(int idParam, string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, string desc) : base(idParam, 
            nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam)
        {
            descricaoFerimentos = desc;
        }

        #endregion

        #endregion
    }
}

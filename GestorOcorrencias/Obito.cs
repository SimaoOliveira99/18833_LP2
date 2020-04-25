using System;
namespace GestorOcorrencias
{
    public class Obito : Pessoa
    {
        #region ESTADO

        DateTime dataObito;
        string causa;
        string descricaoFerimentos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

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

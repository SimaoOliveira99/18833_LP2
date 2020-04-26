using System;
namespace GestorOcorrencias
{
    public class Distritos
    {
        #region ESTADOS

        static int totalDistritos;
        const int MAX = 10;
        static Distrito[] distritos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Distritos()
        {
            totalDistritos = 0;
            distritos = new Distrito[MAX];
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereDistrito(string nome)
        {
            if (totalDistritos < MAX)
            {
                distritos[totalDistritos] = new Distrito(totalDistritos++, nome);
                totalDistritos++;
                return totalDistritos;
            }
            return 0;
        }

        public Distrito ProcuraDistrito(int id)
        {
            for (int i = 0; i < totalDistritos; i++)
            {
                if (distritos[i].EqualsId(id))
                {
                    return distritos[i];
                }
            }

            return null;
        }

        #endregion

        #endregion
    }
}

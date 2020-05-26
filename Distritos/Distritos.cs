using System;
using System.Collections.Generic;

namespace GestorOcorrencias
{
    public class Distritos
    {
        #region ESTADOS

        static int totalDistritos;
        private static List<Distrito> distritos;
        private static Distrito auxDistritos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Distritos()
        {
            totalDistritos = 0;
            distritos = new List<Distrito>();
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereDistrito(string nome)
        {
            auxDistritos = new Distrito(totalDistritos++, nome);
            distritos.Add(auxDistritos);
            totalDistritos++;
            return totalDistritos;
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

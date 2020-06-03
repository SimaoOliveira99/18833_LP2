using System;
using System.Collections.Generic;

namespace GestorOcorrencias
{
    public class CatastrofesA
    {

        #region ESTADOS

        static int totalCatastrofes;
        private static List<CatastrofeA> catastrofes;
        static CatastrofeA auxCatastrofes;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public CatastrofesA()
        {
            totalCatastrofes = 0;
            catastrofes = new List<CatastrofeA>();
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereCatastrofe (string nome)
        {
            catastrofes[totalCatastrofes] = new CatastrofeA(totalCatastrofes++, nome);
            totalCatastrofes++;
            return totalCatastrofes;
        }

        public int InsereCatastrofe (string nome, string desc)
        {
            catastrofes[totalCatastrofes] = new CatastrofeA(totalCatastrofes++, nome, desc);
            totalCatastrofes++;
            return totalCatastrofes;
        }

        public CatastrofeA ProcuraCatastrofe(int id)
        {
            for (int i = 0; i < totalCatastrofes; i++)
            {
                if (catastrofes[i].EqualsId(id))
                {
                    return catastrofes[i];
                }
            }

            return null;
        }

        #endregion

        #endregion
    }
}

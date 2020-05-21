using System;
using System.Collections.Generic;

namespace GestorOcorrencias
{
    public class Catastrofes
    {

        #region ESTADOS

        static int totalCatastrofes;
        private static List<Catastrofe> catastrofes;
        static Catastrofe auxCatastrofes;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Catastrofes()
        {
            totalCatastrofes = 0;
            catastrofes = new List<Catastrofe>();
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereCatastrofe (string nome)
        {
            catastrofes[totalCatastrofes] = new Catastrofe(totalCatastrofes++, nome);
            totalCatastrofes++;
            return totalCatastrofes;
        }

        public int InsereCatastrofe (string nome, string desc)
        {
            catastrofes[totalCatastrofes] = new Catastrofe(totalCatastrofes++, nome, desc);
            totalCatastrofes++;
            return totalCatastrofes;
        }

        public Catastrofe ProcuraCatastrofe(int id)
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

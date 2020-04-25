using System;
namespace GestorOcorrencias
{
    public class Catastrofes
    {

        #region ESTADOS

        static int totalCatastrofes;
        const int MAX = 10;
        static Catastrofe[] catastrofes;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Catastrofes()
        {
            totalCatastrofes = 0;
            catastrofes = new Catastrofe[MAX];
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereCatastrofe (string nome)
        {
            if (totalCatastrofes < MAX)
            {
                catastrofes[totalCatastrofes] = new Catastrofe(totalCatastrofes, nome);
                totalCatastrofes++;
                return totalCatastrofes;
            }
            return 0;
        }

        public int InsereCatastrofe (string nome, string desc)
        {
            if (totalCatastrofes < MAX)
            {
                catastrofes[totalCatastrofes] = new Catastrofe(totalCatastrofes, nome, desc);
                totalCatastrofes++;
                return totalCatastrofes;
            }
            return 0;
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

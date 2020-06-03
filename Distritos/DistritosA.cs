using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestorOcorrencias
{
    [Serializable]
    public class DistritosA
    {
        #region ESTADOS

        static int totalDistritos;
        static List<DistritoA> distritos;
        private static DistritoA auxDistritos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public DistritosA()
        {
            totalDistritos = 0;
            distritos = new List<DistritoA>();
        }

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereDistrito(string nome)
        //public int InsereDistrito(Distrito d)
        {
            auxDistritos = new DistritoA(totalDistritos++, nome);
            distritos.Add(auxDistritos);
            //totalDistritos++;
            return totalDistritos;
        }

        public DistritoA ProcuraDistrito(int id)
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

        public static bool Save(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, distritos);
                s.Flush();
                s.Close();
                s.Dispose();
            }
            catch (Exception e)
            {
                throw e; //algo se passou
            }
            return true;
        }

        public static bool Load(string fileName)
        {
            try
            {
                //distritos.Clear();
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                distritos = (List<DistritoA>)b.Deserialize(s);
                s.Flush();
                s.Close();
                s.Dispose();
                return true;
            }
            catch
            {
                throw new Exception("Erro");
            }
        }

        #endregion

        #endregion
    }
}

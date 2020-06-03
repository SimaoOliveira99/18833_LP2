using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestorOcorrencias
{
    [Serializable]
    public class Distritos
    {
        #region ESTADOS

        static int totalDistritos;
        static List<Distrito> distritos;

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

        /// <summary>
        /// Insere distrito na lista de distritos
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int InsereDistrito(Distrito d)
        {
            try
            {
                totalDistritos++;
                d.Id = totalDistritos;
                distritos.Add(d);
                return totalDistritos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procura distrito na lista de distritos pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Distrito ProcuraDistrito(int id)
        {
            try
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
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Verifica se já existe um distrito com aquele nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteDistrito(string nome)
        {
            try
            {
                for (int i = 0; i < totalDistritos; i++)
                {
                    if (distritos[i].Nome == nome)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Apaga distrito da lista de distritos
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool ApagaDistrito(Distrito d)
        {
            try
            {
                return distritos.Remove(d);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Guarda lista de distritos num ficheiro binario
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
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
                throw e;
            }
            return true;
        }

        /// <summary>
        /// Carrega os dados de um ficheiro binario para uma lista de distritos
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                distritos = (List<Distrito>)b.Deserialize(s);
                totalDistritos = distritos.Count;
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

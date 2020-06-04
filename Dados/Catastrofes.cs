using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;

namespace Dados
{
    [Serializable]
    public class Catastrofes
    {

        #region ESTADOS

        static int totalCatastrofes;
        private static List<Catastrofe> catastrofes;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        static Catastrofes()
        {
            catastrofes = new List<Catastrofe>();
        }
        public Catastrofes()
        {
            totalCatastrofes = 0;
        }

        #endregion

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Insere catastrofe na lista de catastrofes
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int InsereCatastrofe (Catastrofe c)
        {
            totalCatastrofes++;
            c.Id = totalCatastrofes;
            catastrofes.Add(c);
            return totalCatastrofes;
        }

        /// <summary>
        /// Procura catastrofe na lista de catastrofes pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Catastrofe ProcuraCatastrofe(int id)
        {
            try
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
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Verifica se ja existe uma catastrofe com aquele nome
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExisteCatastrofe(string nome)
        {
            try
            {
                for (int i = 0; i < totalCatastrofes; i++)
                {
                    if (catastrofes[i].Nome == nome)
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
        /// Apaga catastrofe da lista de catastrofes
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool ApagaCatastrofe(Catastrofe c)
        {
            try
            {
                return catastrofes.Remove(c);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Guarda lista de catastrofes num ficheiro binario
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Save(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, catastrofes);
                s.Flush();
                s.Close();
                s.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Carrega os dados de um ficheiro binario para uma lista de catastrofes
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                catastrofes = (List<Catastrofe>)b.Deserialize(s);
                totalCatastrofes = catastrofes.Count;
                s.Flush();
                s.Close();
                s.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #endregion
    }
}

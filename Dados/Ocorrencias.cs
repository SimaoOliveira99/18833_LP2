using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;   //serialização
using System.Xml.Serialization;
using BO;
using GestorOcorrencias;

namespace Dados
{
    [Serializable]
    public class OcorrenciaDB
    {
        #region ESTADO

        int id;
        DateTime data;
        string descricao;
        int idCatastrofe;
        int idDistrito;
        private List<Obito> obitos;
        private Obito auxObito;
        int totalObitos;
        private List<Ferido> feridos;
        private Ferido auxFerido;
        int totalFeridos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public OcorrenciaDB(int idOc, DateTime dt, string desc, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            descricao = desc;
            idCatastrofe = idCat;
            idDistrito = idDis;
            obitos = new List<Obito>();
            totalObitos = 0;
            feridos = new List<Ferido>();
            totalFeridos = 0;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                    data = value;
            }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int IdCatastrofe
        {
            get { return idCatastrofe; }
            //verificar se existe o id vindo do value na lista de catastrofes
            set { idCatastrofe = value; }
        }

        public int IdDistrito
        {
            get { return idDistrito; }
            //verificar se existe o id vindo do value na lista de distritos
            set { idDistrito = value; }
        }

        public int TotalObitos
        {
            get { return totalObitos; }
        }

        public int TotalFeridos
        {
            get { return totalFeridos; }
        }

        #endregion

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Compara id recebido com id da ocorrencia.
        /// </summary>
        /// <returns><c>true</c>, if identifier was equalsed, <c>false</c> otherwise.</returns>
        /// <param name="idToCompare">Identifier to compare.</param>
        public bool EqualsId(int idToCompare)
        {
            return id == idToCompare;
        }

        /// <summary>
        /// Verifica se a pessoa já existe, se sim retorna 0 senão insere o obito e retorna o id 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int InsereObito(Obito o)
        {
            try
            {
                if (!ExistePessoa(o.Cc))
                {
                    totalObitos++;
                    o.Id = totalObitos;
                    obitos.Add(o);
                    return totalObitos;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procura obito na lista de obitos
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public Obito ProcuraObito(int cc)
        {
            for (int i = 0; i < totalObitos; i++)
            {
                if (obitos[i].EqualsCc(cc))
                    return obitos[i];
            }
            return null;
        }

        /// <summary>
        /// Remove obito da lista de obitos
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool ApagaObito(Obito o)
        {
            try
            {
                return obitos.Remove(o);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Insere ferido na lista de feridos
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public int InsereFerido(Ferido f)
        {
            try
            {
                if (!ExistePessoa(f.Cc))
                {
                    totalFeridos++;
                    f.Id = totalFeridos;
                    feridos.Add(f);
                    return totalFeridos;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procura ferido na lista de feridos
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public Ferido ProcuraFerido(int cc)
        {
            for (int i = 0; i < totalFeridos; i++)
            {
                if (feridos[i].EqualsCc(cc))
                    return feridos[i];
            }
            return null;
        }

        /// <summary>
        /// Remove ferido da lista de feridos
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool ApagaFerido(Ferido f)
        {
            try
            {
                return feridos.Remove(f);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Verifica se pessoa existe
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public bool ExistePessoa(int cc)
        {
            if (ProcuraObito(cc) != null || ProcuraFerido(cc) != null)
            {
                if (ProcuraObito(cc) != null)
                    Console.WriteLine("existe obito");
                if (ProcuraFerido(cc) != null)
                    Console.WriteLine("existe ferido");
                return true;
            }
            Console.WriteLine("Não existe pessoa");
            return false;
        }

        #endregion

        #endregion

    }
    public class Ocorrencias
    {
        #region ESTADO

        static int totalOcorrencias;
        private static List<OcorrenciaDB> ocorrencias;
        private static OcorrenciaDB auxOcorrencia;

        public static List<int> teste = new List<int>();

        public Ocorrencias()
        {
            totalOcorrencias = 0;
            ocorrencias = new List<OcorrenciaDB>();
        }

        #endregion

        #region METODOS

        #region METODOS_DE_CLASSE

        /// <summary>
        /// Insere ocorrencia na lista de ocorrencias
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int InsereOcorrencia(Ocorrencia o)
        {
            try
            {
                if (Distritos.ProcuraDistrito(o.IdDistrito) == null)
                    o.IdDistrito = 0;
                if (Catastrofes.ProcuraCatastrofe(o.IdCatastrofe) == null)
                    o.IdCatastrofe = 0;
                totalOcorrencias++;
                auxOcorrencia = new OcorrenciaDB(totalOcorrencias, o.Data, o.Descricao, o.IdCatastrofe, o.IdDistrito);
                ocorrencias.Add(auxOcorrencia);
                return totalOcorrencias;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Apaga ocorrencia da lista de ocorrencias
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool ApagaOcorrencia(OcorrenciaDB o)
        {
            try
            {
                return ocorrencias.Remove(o);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procura ocorrencia através do Id.
        /// </summary>
        /// <returns>Se encontrar retorna a ocorrência senão retorna null.</returns>
        /// <param name="id">Identifier.</param>
        public static OcorrenciaDB ProcuraOcorrencia(int id)
        {
            try
            {
                for (int i = 0; i < totalOcorrencias; i++)
                {
                    if (ocorrencias[i].EqualsId(id))
                    {
                        return ocorrencias[i];
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
        /// Guarda num ficheiro binario a lista de ocorrencias
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Save(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, ocorrencias);
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
        /// Carrega os dados de um ficheiro binario para uma lista de ocorrencias
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                ocorrencias = (List<OcorrenciaDB>)b.Deserialize(s);
                totalOcorrencias = ocorrencias.Count;
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

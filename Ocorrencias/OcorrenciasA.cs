using Ocorrencias;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;   //serialização
using System.Xml.Serialization;
namespace GestorOcorrencias
{
    [Serializable]
    public class OcorrenciaDB
    {
        #region ESTADO

        static int id;
        static DateTime data;
        static string descricao;
        static int idCatastrofe;
        static int idDistrito;
        const int MAX = 10;
        private static List<ObitoA> obitos;
        private static ObitoA auxObito;
        static int totalObitos;
        private static List<FeridoA> feridos;
        private static FeridoA auxFerido;
        static int totalFeridos;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        public Ocorrencia(int idOc, DateTime dt, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            //verificar se existe o idCat e idDis na lista de catastrofes e de distritos respetivamente
            idCatastrofe = idCat;
            idDistrito = idDis;
            obitos = new List<ObitoA>();
            totalObitos = 0;
            feridos = new List<FeridoA>();
            totalFeridos = 0;
        }

        public Ocorrencia(int idOc, DateTime dt, string desc, int idCat, int idDis)
        {
            id = idOc;
            data = dt;
            descricao = desc;
            //verificar se existe o idCat e idDis na lista de catastrofes e de distritos respetivamente
            idCatastrofe = idCat;
            idDistrito = idDis;
            obitos = new List<ObitoA>();
            totalObitos = 0;
            feridos = new List<FeridoA>();
            totalFeridos = 0;
        }

        #endregion

        #region PROPRIEDADES

        public int Id
        {
            get { return id; }
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

        public int InsereObito(int ccParam, DateTime dataObi)
        {
            if (!ExistePessoa(ccParam))
            {
                auxObito = new ObitoA(totalObitos++, ccParam, dataObi);
                obitos.Add(auxObito);
                totalObitos++;
                return totalObitos;
            }
            else
            {
                Console.WriteLine("Já existe");
                return 0;
            }
        }

        public int InsereObito(string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, DateTime dataObi, string caus, string desc)
        {
            auxObito = new ObitoA(totalObitos++, nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam, dataObi, caus, desc);
            obitos.Add(auxObito);
            totalObitos++;
            return totalObitos;
        }

        public ObitoA ProcuraObito(int cc)
        {
            for (int i = 0; i < totalObitos; i++)
            {
                if (obitos[0].EqualsCc(cc))
                    return obitos[i];
            }
            return null;
        }

        public int InsereFerido(int ccParam)
        {
            auxFerido = new FeridoA(totalFeridos++, ccParam);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

        public int InsereFerido(int ccParam, string desc)
        {
            auxFerido = new FeridoA(totalFeridos++, ccParam, desc);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

        public int InsereFerido(string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, string desc)
        {
            auxFerido = new FeridoA(totalFeridos++, nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam, desc);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

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

        public FeridoA ProcuraFerido(int cc)
        {
            for (int i = 0; i < totalFeridos; i++)
            {
                if (feridos[i].EqualsCc(cc))
                    return feridos[i];
            }
            return null;
        }

        #endregion

        #endregion

    }
    public class OcorrenciasA
    {
        #region ESTADO

        static int totalOcorrencias;
        private static List<OcorrenciaDB> ocorrencias;
        private static OcorrenciaDB auxOcorrencia;

        public static List<int> teste = new List<int>();

        public OcorrenciasA()
        {
            totalOcorrencias = 0;
            ocorrencias = new List<OcorrenciaDB>();
            //teste.Add(1);
            //teste.Add(2);
        }

        #endregion

        #region METODOS

        #region METODOS_DE_CLASSE

        public int InsereOcorrencia(DateTime data, int idCatastrofe, int idDistrito)
        {
            auxOcorrencia = new OcorrenciaDB(totalOcorrencias, data, idCatastrofe, idDistrito);
            ocorrencias.Add(auxOcorrencia);
            totalOcorrencias++;
            return totalOcorrencias;
        }

        public int InsereOcorrencia(DateTime data, string descricao, int idCatastrofe, int idDistrito)
        {

            auxOcorrencia = new OcorrenciaDB(totalOcorrencias + 1, data, descricao, idCatastrofe, idDistrito);
            ocorrencias.Add(auxOcorrencia);
            totalOcorrencias++;
            return totalOcorrencias;

        }

        /// <summary>
        /// Procura ocorrencia através do Id.
        /// </summary>
        /// <returns>Se encontrar retorna a ocorrência senão retorna null.</returns>
        /// <param name="id">Identifier.</param>
        public OcorrenciaDB ProcuraOcorrencia(int id)
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

        public bool Save(string fileName)
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
                throw e; //algo se passou
            }
            return true;
        }

        public bool Load(string fileName)
        {
            try
            {
                //Hashtable aux = null;
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter b = new BinaryFormatter();
                ocorrencias = (List<Ocorrencia>)b.Deserialize(s);
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

using System;
using System.Collections.Generic;

namespace GestorOcorrencias
{
    public class Ocorrencia
    {
        #region ESTADO

        static int id;
        static DateTime data;
        static string descricao;
        static int idCatastrofe;
        static int idDistrito;
        const int MAX = 10;
        private static List<Obito> obitos;
        private static Obito auxObito;
        static int totalObitos;
        private static List<Ferido> feridos;
        private static Ferido auxFerido;
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
            obitos = new List<Obito>();
            totalObitos = 0;
            feridos = new List<Ferido>();
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
        public bool EqualsId (int idToCompare)
        {
            return id == idToCompare;
        }

        public int InsereObito (int ccParam, DateTime dataObi)
        {
            auxObito = new Obito(totalObitos++, ccParam, dataObi);
            obitos.Add(auxObito);
            totalObitos++;
            return totalObitos;
        }

        public int InsereObito(string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, DateTime dataObi, string caus, string desc)
        {
            auxObito = new Obito(totalObitos++, nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam, dataObi, caus, desc);
            obitos.Add(auxObito);
            totalObitos++;
            return totalObitos;
        }

        public Obito ProcuraObito(int cc)
        {
            for (int i = 0; i < totalObitos; i++)
            {
                if (obitos[0].EqualsCc(cc))
                    return obitos[i];
            }
            return null;
        }

        public int InsereFerido (int ccParam)
        {
            auxFerido = new Ferido(totalFeridos++, ccParam);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

        public int InsereFerido(int ccParam, string desc)
        {
            auxFerido = new Ferido(totalFeridos++, ccParam, desc);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

        public int InsereFerido (string nomeParam, int idadeParam, int ccParam, DateTime dataNascParam, int idDistritoParam, string desc)
        {
            auxFerido = new Ferido(totalFeridos++, nomeParam, idadeParam, ccParam, dataNascParam, idDistritoParam, desc);
            feridos.Add(auxFerido);
            totalFeridos++;
            return totalFeridos;
        }

        public bool ExistePessoa (int cc)
        {
            if ( ProcuraObito(cc) != null || ProcuraFerido(cc) != null)
                return true;
            return false;
        }

        public Ferido ProcuraFerido (int cc)
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
}

using System;
using System.Collections.Generic;
namespace GestorOcorrencias
{
    public class Ocorrencias
    {
        #region ESTADO

        static int totalOcorrencias;
        private static List<Ocorrencia> ocorrencias;
        private static Ocorrencia auxOcorrencia;

        public Ocorrencias()
        {
            totalOcorrencias = 0;
            ocorrencias = new List<Ocorrencia>();
        }

        #endregion

        #region METODOS

        #region METODOS_DE_CLASSE

        public int InsereOcorrencia(DateTime data, int idCatastrofe, int idDistrito)
        {
            
            auxOcorrencia = new Ocorrencia(totalOcorrencias, data, idCatastrofe, idDistrito);
            ocorrencias.Add(auxOcorrencia);
            totalOcorrencias++;
            return totalOcorrencias;
        }

        public int InsereOcorrencia(DateTime data, string descricao, int idCatastrofe, int idDistrito)
        {

            auxOcorrencia = new Ocorrencia(totalOcorrencias + 1, data, descricao, idCatastrofe, idDistrito);
            ocorrencias.Add(auxOcorrencia);
            totalOcorrencias++;
            return totalOcorrencias;

        }

        /// <summary>
        /// Procura ocorrencia através do Id.
        /// </summary>
        /// <returns>Se encontrar retorna a ocorrência senão retorna null.</returns>
        /// <param name="id">Identifier.</param>
        public Ocorrencia ProcuraOcorrencia(int id)
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

        #endregion

        #endregion
    }
}

using System;
namespace GestorOcorrencias
{
    public class Ocorrencias
    {
        #region ESTADO

        static int totalOcorrencias;
        static Ocorrencia[] ocorrencias;
        const int MAX = 10;

        public Ocorrencias()
        {
            totalOcorrencias = 0;
            ocorrencias = new Ocorrencia[MAX];
        }

        #endregion

        #region METODOS

        #region INDEXADORES

        /*public Ocorrencias this[int i]
        {
            get { return ocorrencias[i]; }
            //FIXME validar se a posição já n está ocupada, se nao estiver alterar senao nao alterar
            set { ocorrencias[i] = new Ocorrencia(value); totalOcorrencias++; }     //Validações
        }*/

        #endregion

        #region METODOS_DE_CLASSE

        public int InsereOcorrencia(DateTime data, int idCatastrofe, int idDistrito)
        {
            if (totalOcorrencias < MAX)
            {
                ocorrencias[totalOcorrencias] = new Ocorrencia(totalOcorrencias, data, idCatastrofe, idDistrito);
                totalOcorrencias++;
                return totalOcorrencias;
            }
            return 0;
        }

        public int InsereOcorrencia(DateTime data, string descricao, int idCatastrofe, int idDistrito)
        {

            if (totalOcorrencias < MAX)
            {
                //Ocorrencia newOcorr = new Ocorrencia(totalOcorrencias++, data, descricao, idCatastrofe, idDistrito);
                ocorrencias[totalOcorrencias] = new Ocorrencia(totalOcorrencias + 1, data, descricao, idCatastrofe, idDistrito);
                totalOcorrencias++;
                return totalOcorrencias;
            }

            return 0;
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

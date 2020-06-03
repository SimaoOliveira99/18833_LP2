using GestorOcorrencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR
{
    public class CatastrofesBR
    {
        #region METODOS

        #region METODOS_DE_CLASSE

        public int InsereCatastrofe (Catastrofe c)
        {
            try
            {
                if (ExisteCatastrofe(c.Nome))
                    return Catastrofes.InsereCatastrofe(c);
                else
                    return 0;
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao inserir catástrofe " + e.Message);
            }
        }

        public static Catastrofe ProcuraCatastrofe(int id)
        {
            try
            {
                return Catastrofes.ProcuraCatastrofe(id);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao procurar catástrofe " + e.Message);
            }
        }

        public static bool ExisteCatastrofe(string nome)
        {
            try
            {
                return Catastrofes.ExisteCatastrofe(nome);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao verificar se existe catástrofe " + e.Message);
            }
        }

        public static bool ApagaCatastrofe(Catastrofe c)
        {
            try
            {
                return Catastrofes.ApagaCatastrofe(c);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao apagar catástrofe " + e.Message);
            }
        }

        public static bool GuardaCatastrofes(string nomeFicheiro)
        {
            try
            {
                return Catastrofes.Save(nomeFicheiro);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao guardar dados no ficheiro de catastrofes " + e.Message);
            }
        }

        public static bool CarregaCatastrofes(string nomeFicheiro)
        {
            try
            {
                return Catastrofes.Load(nomeFicheiro);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao carregar dados do ficheiro de catastrofes " + e.Message);
            }
        }

        #endregion

        #endregion
    }
}

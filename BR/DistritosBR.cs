using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BO;
using Dados;

namespace BR
{
    public class DistritosBR
    {

        #region METODOS

        #region METODOS_DA_CLASSE

        public static int InsereDistrito (Distrito d)
        {
            try
            {
                if (!ExisteDistrito(d.Nome))
                    return Distritos.InsereDistrito(d);
                else
                    return 0;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir distrito " + e.Message);
            }
        }

        public static Distrito ProcuraDistrito (int id)
        {
            try
            {
                return Distritos.ProcuraDistrito(id);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao procurar distrito " + e.Message);
            }
        }

        public static bool ExisteDistrito(string nome)
        {
            try
            {
                return Distritos.ExisteDistrito(nome);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao verificar se existe distrito " + e.Message);
            }
        }

        public static bool ApagaDistrito(Distrito d)
        {
            try
            {
                return Distritos.ApagaDistrito(d);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao apagar distrito " + e.Message);
            }
        }

        public static bool GuardaDistritos(string nomeFicheiro)
        {
            try
            {
                return Distritos.Save(nomeFicheiro);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao guardar dados no ficheiro de distritos " + e.Message);
            }
        }

        public static bool CarregaDistritos(string nomeFicheiro)
        {
            try
            {
                if (File.Exists(nomeFicheiro))
                    return Distritos.Load(nomeFicheiro);
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao carregar dados do ficheiro de distritos " + e.Message);
            }
        }

        #endregion

        #endregion
    }
}

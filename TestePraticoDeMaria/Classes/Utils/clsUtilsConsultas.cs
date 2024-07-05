using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes.Utils
{
    public class clsUtilsConsultas
    {
        clsComandosSQL cmdSQL = new clsComandosSQL();

        public DataTable ObterListaCompletaClientes()
        {
            DataTable dt = new DataTable();

            dt = cmdSQL.ObterListaClientes();

            return dt;

        }
        public DataTable ObterListaCompletaProdutos()
        {
            DataTable dt = new DataTable();

            dt = cmdSQL.ObterListaProdutos();

            return dt;

        }

        
    }
}

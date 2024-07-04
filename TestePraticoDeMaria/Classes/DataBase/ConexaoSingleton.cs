using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDeMaria.Classes.DataBase
{
   public class ConexaoSingleton
    {
        private static readonly Lazy<clsConexaoDB> lazy = new Lazy<clsConexaoDB>(() =>
        {
            var conexao = new clsConexaoDB();
            return conexao.CarregarConfiguracao();
        });

        public static clsConexaoDB Instance => lazy.Value;

        private ConexaoSingleton() { }
    }

}

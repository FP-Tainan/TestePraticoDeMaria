using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDeMaria.Classes.DataBase.Espelho_das_tabelas
{
    public class tb_produtos
    {
        public int id { get; set; }
        public string produto { get; set; }
        public int quantidadeEstoque { get; set; }
        public decimal precoUnitario { get; set; }
        public string descricao { get; set; }
    }
}

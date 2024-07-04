using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePraticoDeMaria.Classes.DataBase;
using TestePraticoDeMaria.Forms;

namespace TestePraticoDeMaria
{
    internal static class Program
    {



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Validando a conexão
            if (!ConexaoSingleton.Instance.TestarConexaoTipoBool())
            {
                frmConfiguracao config = new frmConfiguracao();
                config.ShowDialog();
            }

            Application.Run(new frmMenuPrincipal());

        }
    }
}

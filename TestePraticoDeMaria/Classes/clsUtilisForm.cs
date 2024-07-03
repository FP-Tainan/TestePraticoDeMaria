using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TestePraticoDeMaria.Classes
{
    internal class clsUtilisForm
    {
        /// <summary>
        /// Limpa as TextBox padrão do WindowsForms
        /// </summary>
        public void LimparTextBoxes(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        /// <summary>
        /// Limpa as TextBox da Biblioteca Krypton
        /// </summary>
        public void LimparTextBoxes(params KryptonTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

    }
}

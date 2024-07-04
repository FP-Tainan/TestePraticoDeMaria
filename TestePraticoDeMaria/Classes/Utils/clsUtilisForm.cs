using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TestePraticoDeMaria.Classes.Utils
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

        /// <summary>
        /// Remove do texto caracteres não permitidos
        /// </summary>
        public string ValidarTextoNumerosComSimbolo(string texto)
        {
            // Lista de caracteres permitidos
            char[] allowedChars = { '.', ',', '/', '-', '(',')','0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // Filtra o texto mantendo apenas os caracteres permitidos
            string result = new string(texto.Where(c => allowedChars.Contains(c)).ToArray());

            return result;
        }

        /// <summary>
        /// Remove do texto caracteres não permitidos
        /// </summary>
        public string ValidarTextoNumeros(string texto)
        {
            // Lista de caracteres permitidos
            char[] allowedChars = { '.', ',', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // Filtra o texto mantendo apenas os caracteres permitidos
            string result = new string(texto.Where(c => allowedChars.Contains(c)).ToArray());

            return result;
        }


        public string ValidarEFormatarTelefones(string texto)
        {
            string numero = ValidarTextoNumerosComSimbolo(texto);
           return FormatarTelefone(numero);
        }

        private string FormatarTelefone(string numero)
        {
            // Remover quaisquer caracteres não numéricos
            string digitos = Regex.Replace(numero, @"\D", "");

            if (digitos.Length == 10) // Telefone fixo
            {
                return String.Format("({0})  {1}-{2}",
                    digitos.Substring(0, 2),
                    digitos.Substring(2, 4),
                    digitos.Substring(6, 4));
            }
            else if (digitos.Length == 11) // Celular
            {
                return String.Format("({0})  {1}-{2}",
                    digitos.Substring(0, 2),
                    digitos.Substring(2, 5),
                    digitos.Substring(7, 4));
            }

            else { return numero; }
        }

    }
}

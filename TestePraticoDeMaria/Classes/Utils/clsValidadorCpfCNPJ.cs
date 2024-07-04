using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TestePraticoDeMaria.Classes.Utils
{
    public class clsValidadorCpfCNPJ
    {
        public bool ValidaCPFCNPJ(string documento)
        {
            documento = Regex.Replace(documento, "[^0-9]", "");

            if (documento.Length == 11)
                return VerificaCPF(documento);
            else if (documento.Length == 14)
                return VerificaCNPJ(documento);

            return false;
        }

        public string CalcularDigitoVerificadorCPFCNPJ(string documento)
        {
            documento = Regex.Replace(documento, "[^0-9]", "");

            if (documento.Length == 11)
                return CalcularDigitoVerificadorCPF(documento);
            else if (documento.Length == 14)
                return CalcularDigitoVerificadorCNPJ(documento);

            return string.Empty;
        }

        public string FormatarCPFCNPJ(string documento)
        {
            documento = Regex.Replace(documento, "[^0-9]", "");

            if (documento.Length <= 11)
                return FormatarCPF(documento);
            else if (documento.Length <= 14)
                return FormatarCNPJ(documento);

            return documento;
        }

        private bool VerificaCPF(string cpf)
        {
            if (cpf.Length != 11)
                return false;

            if (new string(cpf[0], 11) == cpf)
                return false;

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(digitoVerificador1.ToString() + digitoVerificador2.ToString());
        }

        private bool VerificaCNPJ(string cnpj)
        {
            if (cnpj.Length != 14)
                return false;

            if (new string(cnpj[0], 14) == cnpj)
                return false;

            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return cnpj.EndsWith(digitoVerificador1.ToString() + digitoVerificador2.ToString());
        }

        private string CalcularDigitoVerificadorCPF(string cpf)
        {
            if (cpf.Length != 9)
                throw new ArgumentException("O CPF deve ter 9 dígitos para calcular os dígitos verificadores.");

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicadores2[i];
            soma += digitoVerificador1 * multiplicadores2[9];

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return digitoVerificador1.ToString() + digitoVerificador2.ToString();
        }

        private string CalcularDigitoVerificadorCNPJ(string cnpj)
        {
            if (cnpj.Length != 12)
                throw new ArgumentException("O CNPJ deve ter 12 dígitos para calcular os dígitos verificadores.");

            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];
            soma += digitoVerificador1 * multiplicadores2[12];

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            return digitoVerificador1.ToString() + digitoVerificador2.ToString();
        }

        private string FormatarCPF(string text)
        {
            if (text.Length > 9)
            {
                return text.Insert(9, "-").Insert(6, ".").Insert(3, ".");
            }
            else if (text.Length > 6)
            {
                return text.Insert(6, ".").Insert(3, ".");
            }
            else if (text.Length > 3)
            {
                return text.Insert(3, ".");
            }
            return text;
        }

        private string FormatarCNPJ(string text)
        {
            if (text.Length > 12)
            {
                return text.Insert(12, "-").Insert(8, "/").Insert(5, ".").Insert(2, ".");
            }
            else if (text.Length > 8)
            {
                return text.Insert(8, "/").Insert(5, ".").Insert(2, ".");
            }
            else if (text.Length > 5)
            {
                return text.Insert(5, ".").Insert(2, ".");
            }
            else if (text.Length > 2)
            {
                return text.Insert(2, ".");
            }
            return text;
        }

    }
}

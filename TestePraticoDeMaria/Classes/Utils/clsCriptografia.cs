using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TestePraticoDeMaria.Classes.Utils
{
    internal class clsCriptografia
    {
        public clsCriptografia() { }

        private static readonly string chave = "C623FDFE811471A94D12C8CEC3FC69B5";
        private static readonly string vetorInicializacao = "7045A2C3C0AF421D";

        public string Criptografar(string texto)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(chave);
                aesAlg.IV = Encoding.UTF8.GetBytes(vetorInicializacao);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(texto);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public string Descriptografar(string textoCriptografado)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(chave);
                aesAlg.IV = Encoding.UTF8.GetBytes(vetorInicializacao);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textoCriptografado)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }

    }
}

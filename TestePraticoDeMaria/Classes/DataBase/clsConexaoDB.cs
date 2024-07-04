using System;
using System.IO;
using Newtonsoft.Json;
using Npgsql;
using TestePraticoDeMaria.Classes.Utils;

namespace TestePraticoDeMaria.Classes.DataBase
{
    public class clsConexaoDB
    {
        public string Servidor { get;  set; }
        public string BancoDeDados { get;  set; }
        public string Usuario { get;  set; }
        public string Senha { get;  set; }
        public int Porta { get;  set; } = 5432; // Porta padrão do PostgreSQL

        private static readonly string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configuracao.json");
        clsCriptografia criptografia = new clsCriptografia();

        public clsConexaoDB() { }

        public clsConexaoDB(string servidor, string bancoDeDados, string usuario, string senha, int porta = 5432)
        {
            Servidor = servidor;
            BancoDeDados = bancoDeDados;
            Usuario = usuario;
            Senha = senha;
            Porta = porta;
        }

        public clsConexaoDB CarregarConfiguracao()
        {
            if (!File.Exists(caminhoArquivo))
            {
                return new clsConexaoDB("localhost", "meuBanco", "meuUsuario", "minhaSenha"); // Valores padrão
            }

            string jsonString = File.ReadAllText(caminhoArquivo);
            var config = JsonConvert.DeserializeObject<clsConexaoDB>(jsonString);

            if (config != null)
            {
                config.Servidor = criptografia.Descriptografar(config.Servidor);
                config.BancoDeDados = criptografia.Descriptografar(config.BancoDeDados);
                config.Usuario = criptografia.Descriptografar(config.Usuario);
                config.Senha = criptografia.Descriptografar(config.Senha);
            }

            return config;
        }

        public void SalvarConfiguracao()
        {
            var configCriptografada = new clsConexaoDB(
                criptografia.Criptografar(Servidor),
                criptografia.Criptografar(BancoDeDados),
                criptografia.Criptografar(Usuario),
                criptografia.Criptografar(Senha),
                Porta
            );

            string jsonString = JsonConvert.SerializeObject(configCriptografada, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, jsonString);
        }

        public NpgsqlConnection ObterConexao()
        {
            string connectionString = $"Host={Servidor};Port={Porta};Username={Usuario};Password={Senha};Database={BancoDeDados}";
            return new NpgsqlConnection(connectionString);
        }

        public bool TestarConexaoTipoBool()
        {
            try
            {
                using (var conn = ObterConexao())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string TestarConexao()
        {
            try
            {
                using (var conn = ObterConexao())
                {
                    conn.Open();
                   return "Conexão bem-sucedida!";
                }
            }
            catch (Exception ex)
            {
                return $"Erro ao conectar: {ex.Message}";
            }
        }
    }
}

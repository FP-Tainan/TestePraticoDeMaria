using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoDeMaria.Classes.DataBase
{

    public class clsComandosSQL
    {
        public clsComandosSQL() { }

        #region Cliente
        public DataTable ObterListaClientes()
        {
            string query = "SELECT * FROM vwClientes ORDER BY nome";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    DataTable dataTable = new DataTable();

                    try
                    {
                        conexao.Open();
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção apropriadamente aqui
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }

        public DataTable ObterCliente(string filtro, bool cpfCnpj)
        {
            string query = $"SELECT * FROM vwClientes ";

            if (cpfCnpj) { query += $"WHERE cpfcnpj = {filtro} ORDER BY nome"; }
            else { query += $"WHERE nome ILIKE '%{filtro}%'"; }


            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    DataTable dataTable = new DataTable();

                    try
                    {
                        conexao.Open();
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção apropriadamente aqui
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }

        public int AdicionarNovoCliente(string nome, string cpfcnpj, string telefone, string email, bool pessoaJuridica)
        {
            string query = $"INSERT INTO tb_clientes (nome, cpfcnpj, telefone, email, pessoajuridica) " +
                           $"VALUES ('{nome}', '{cpfcnpj}', '{telefone}', '{email}', {pessoaJuridica}) RETURNING id";

            int newClientId = 0;

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        newClientId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return newClientId;
        }

        public bool AtualizarCliente(int id, string nome, string cpfcnpj, string telefone, string email, bool pessoaJuridica)
        {
            string query = $"UPDATE tb_clientes set nome = '{nome}', cpfcnpj = '{cpfcnpj}', telefone = '{telefone}', email = '{email}', pessoajuridica =  '{pessoaJuridica}' WHERE id = {id} ";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

        }

        public bool RemoverCliente(int id)
        {
            string query = $"DELETE FROM tb_clientes WHERE id = {id} ";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

        }

        #endregion

        public int AdicionarNovoEndereco(int cliente_id, string cep, string logradouro, int numero, string numerocomplemento, string bairro, string localidade, string uf)
        {
            string query = $"INSERT INTO tb_enderecos (cep, logradouro, numero, numerocomplemento, bairro, localidade, uf, cliente_id) " +
                           $"VALUES ('{cep}', '{logradouro}', {numero}, '{numerocomplemento}', '{bairro}', '{localidade}', '{uf}',{cliente_id}) RETURNING id";

            int enderecoId = 0;

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        enderecoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return enderecoId;
        }
        public bool AtualizarEndereco(int id, string cep, string logradouro, int numero, string numerocomplemento, string bairro, string localidade, string uf)
        {
            string query = $"UPDATE tb_enderecos set cep = '{cep}', logradouro = '{logradouro}', numero = {numero}, numerocomplemento = '{numerocomplemento}', bairro = '{bairro}', localidade = '{localidade}', uf = '{uf}' WHERE id = {id} ";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }

        }
        public bool RemoverEndereco(int id)
        {
            string query = $"DELETE FROM tb_Enderecos WHERE id = {id} ";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

            if (cpfCnpj) { query += $"WHERE cpfcnpj = '{filtro}' ORDER BY nome"; }
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
        public DataTable ObterClientePeloId(int id)
        {
            string query = $"SELECT * FROM tb_clientes WHERE id = {id}";

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

        #region Endereco
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

        #endregion

        #region Produto

        public DataTable ObterProduto(string filtro)
        {
            string query = $"SELECT * FROM tb_produtos WHERE produto ILIKE '%{filtro}%'";

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
        public DataTable ObterListaProdutos()
        {
            string query = "SELECT * FROM tb_produtos ORDER BY produto";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }
        public int AdicionarNovoProduto(string nome, int quantidadeEstoque, decimal precoUnitario, string descricao)
        {
            string query = $"INSERT INTO tb_produtos (produto, quantidadeEstoque, precoUnitario, descricao) " +
                           $"VALUES ('{nome}', {quantidadeEstoque}, {precoUnitario.ToString(CultureInfo.InvariantCulture)}, '{descricao}') RETURNING id";

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
        public bool AtualizarProduto(int id, string nome, int quantidadeEstoque, decimal precoUnitario, string descricao)
        {
            string query = $"UPDATE tb_produtos SET produto = '{nome}', quantidadeEstoque = {quantidadeEstoque}, precoUnitario = {precoUnitario.ToString(CultureInfo.InvariantCulture)}, descricao = '{descricao}' WHERE id = {id} ";

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
        public bool RemoverProduto(int id)
        {
            string query = $"DELETE FROM tb_produtos WHERE id = {id} ";

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
        public DataTable ObterProdutoPeloId(int id)
        {
            string query = $"SELECT * FROM tb_produtos WHERE id = {id}";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }

        #endregion

        #region Vendas
        public int AdicionarNovoPedido(int cliente_id, string dataPedido, string observacao, decimal valorTotalPedido)
        {
            string query = $"INSERT INTO tb_pedidos (cliente_id, dataPedido,observacao,valorTotalPedido) " +
                           $"VALUES ({cliente_id},'{dataPedido}','{observacao}',{valorTotalPedido.ToString(CultureInfo.InvariantCulture)}) RETURNING id";

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
        public bool AtualizarPedido(int id, int cliente_id, string dataConcluido, string dataCancelado, bool cancelado, bool finalizado, string observacao, decimal valorTotalPedido)
        {
            string query = $"UPDATE tb_pedidos SET cliente_id = {cliente_id}, observacao = '{observacao}',valortotalpedido = {valorTotalPedido.ToString(CultureInfo.InvariantCulture)}";
            
            if (cancelado)
            {
                query += $", datacancelado = '{dataCancelado}', cancelado = '{cancelado}'";
            }
            if (finalizado)
            {
                query += $", dataconcluido = '{dataConcluido}', finalizado = '{finalizado}'";
            }

            query += $" WHERE id = {id}";
           
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
        public DataTable ObterPedidoPeloId(int id)
        {
            string query = $"SELECT * FROM tb_pedidos WHERE id = {id}";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }
        public DataTable ObterListaProdutosPedido(int pedido_id)
        {
            string query = $"SELECT * FROM vwPedidoListaProdutos WHERE pedidos_id = {pedido_id}";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }
        public bool AdicionarProdutoNoPedido(int pedido_id, int produto_id, int quantidade, decimal valorUnitario, decimal valorTotal)
        {
            string query = $"INSERT INTO tb_pedidosItens (pedidos_id, produtos_id,Quantidade,ValorUnitario,valorTotal) " +
                         $"VALUES ({pedido_id},{produto_id},{quantidade},{valorUnitario.ToString(CultureInfo.InvariantCulture)},{valorTotal.ToString(CultureInfo.InvariantCulture)})";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteScalar();
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
        public bool AtualizarProdutoNoPedido(int pedido_id, int produto_id, int quantidade, decimal valorUnitario, decimal valorTotal)
        {
            string query = $"UPDATE tb_pedidosItens SET Quantidade = {quantidade},ValorUnitario = {valorUnitario.ToString(CultureInfo.InvariantCulture)},valorTotal = {valorTotal.ToString(CultureInfo.InvariantCulture)} WHERE pedidos_id = {pedido_id} AND produtos_id = {produto_id}";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteScalar();
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
        public bool RemoverProdutoNoPedido(int pedido_id, int produto_id)
        {
            string query = $"DELETE FROM tb_pedidosItens WHERE pedidos_id = {pedido_id} AND produtos_id = {produto_id}";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteScalar();
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
        public bool removerPedidosDoCliente(int id)
        {
            string query = $"DELETE FROM tb_pedidos WHERE cliente_id = {id} ";

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
        public bool removerItensPedidosDoCliente(int id)
        {
            string query = $"DELETE FROM tb_pedidositens WHERE pedidos_id IN (SELECT id FROM tb_pedidos WHERE cliente_id = {id}) ";

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

        #region Caixa

        public bool SalvarMovimentacaoCaixa(int pedidos_id, bool entrada, bool saida,decimal valorMovimentacao, string formaPagamento)
        {
            string query = $"INSERT INTO tb_pedidosCaixa (pedidos_id,Entrada,Saida,ValorMovimentacao,FormaPagamento) " +
                         $"VALUES ({pedidos_id}, '{entrada}', '{saida}', {valorMovimentacao.ToString(CultureInfo.InvariantCulture)}, '{formaPagamento}')";

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        cmd.ExecuteScalar();
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
        public DataTable ObterMovimentacoesPedido(int pedido_id)
        {
            string query = $"SELECT * FROM tb_pedidosCaixa WHERE pedidos_id = {pedido_id}";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }       
        public decimal caixaValorEntradaTotal(int pedidos_id)
        {
            string query = $"SELECT SUM(valormovimentacao) FROM tb_pedidosCaixa WHERE pedidos_id = {pedidos_id} AND entrada = true";
            decimal entrada = 0;

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            entrada = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return entrada;
        }
        public decimal caixaValorSaidaTotal(int pedidos_id)
        {
            string query = $"SELECT SUM(valormovimentacao) FROM tb_pedidosCaixa WHERE pedidos_id = {pedidos_id} AND saida = true";
            decimal entrada = 0;

            using (var conexao = ConexaoSingleton.Instance.ObterConexao())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            entrada = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return entrada;
        }
        public bool removerCaixaPedidosDoCliente(int id)
        {
            string query = $"DELETE FROM tb_pedidoscaixa WHERE pedidos_id IN (SELECT id FROM tb_pedidos WHERE cliente_id = {id})";

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

        #region relatorios

        public DataTable ObterRelatorioVendasFinalizadasPorPeriodo(string dataInicial, string datafinal)
        {
            string query = $"SELECT * FROM vwVendasFinalizadas WHERE finalizado = true and dataconcluido between '{dataInicial}' and '{datafinal} 23:59'";

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
                        Console.WriteLine(ex.Message);
                    }

                    return dataTable;
                }
            }
        }

        #endregion

    }

}

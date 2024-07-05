using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    public class clsRelatorios
    {
        public clsRelatorios() { }

        clsComandosSQL cmdSQL = new clsComandosSQL();

        public void CarregarRelatorio(ReportViewer reportViewer, string relatorio,string dataInicial, string datafinal)
        {
            try
            {
                // Carregando dados do relatório
                ReportDataSource rds = new ReportDataSource();
                DataTable dtDados = ObterDadosParaRelatorio(relatorio,dataInicial,datafinal);

                if (dtDados == null || dtDados.Rows.Count == 0)
                {
                    MessageBox.Show("Não há dados para exibir no relatório.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtém o diretório da aplicação em execução
                string applicationDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Constrói o caminho para a pasta "relatorios"
                string reportsDirectory = Path.Combine(applicationDirectory, "relatorios");

                // Verifica se a pasta "relatorios" existe
                if (!Directory.Exists(reportsDirectory))
                {
                    MessageBox.Show("A pasta 'relatorios' não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Carrega o arquivo rdlc
                string reportName = string.Empty;

                if (relatorio.ToLower() == "produtos estoque")
                {
                    reportName = "rptProdutosEstoque.rdlc";
                    rds = new ReportDataSource("dtsProdutos", dtDados);
                }
                else if (relatorio.ToLower() == "clientes")
                {
                    reportName = "rptClientesCadastrados.rdlc";
                    rds = new ReportDataSource("dtsClientes", dtDados);
                }
                else if (relatorio.ToLower() == "vendas finalizadas")
                {
                    reportName = "rptVendasFinalizadas.rdlc";
                    rds = new ReportDataSource("dtsVendas", dtDados);
                }

                // Constrói o caminho completo para o relatório
                string reportPath = Path.Combine(reportsDirectory, reportName);

                // Verifica se o arquivo base do relatório existe
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"O arquivo base para o relatório '{reportName}' não foi encontrado na pasta relatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Configura o ReportViewer para carregar o relatório
                reportViewer.Reset();
                reportViewer.ProcessingMode = ProcessingMode.Local;
                reportViewer.LocalReport.ReportPath = reportPath;

                // Adiciona os dados ao ReportViewer
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(rds);

                // Atualiza o ReportViewer
                reportViewer.RefreshReport();
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                // Define o zoom em 100%
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                // Configurações de layout para remover margens
                reportViewer.Padding = new Padding(0);
                reportViewer.Margin = new Padding(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObterDadosParaRelatorio(string relatorio, string dataInicial, string datafinal)
        {
            DataTable dt = new DataTable();

            if (relatorio.ToLower() == "produtos estoque")
            {
                dt = cmdSQL.ObterListaProdutos();
            }
            else if (relatorio.ToLower() == "clientes")
            {
                dt = cmdSQL.ObterListaClientes();
            }
            else if(relatorio.ToLower() == "vendas finalizadas")
            {
                dt = cmdSQL.ObterRelatorioVendasFinalizadasPorPeriodo(dataInicial,datafinal);
            }

            return dt;
        }
    }
}

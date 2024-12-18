using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testecrudfiscalio
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Pegando a conexão com o banco
            var conn = DbConnect.GetConnection();
            try
            {
                //  Preenchendo os dados
                var notaFiscal = new NotaFiscal
                {
                    IdNota = 1,
                    Emissor = "Teste",
                    Data = DateTime.Now
                };
                // query de inserção de de dados
                string sql = "insert into notafiscal (idnota, emissor, data) values (@IdNota,@Emissor, @Data)";
                // passando qual a query e qual a model
                conn.Execute(sql, notaFiscal);
            }
            finally
            {
                // independente de qualquer coisa, sempre fechar a conexão com o banco de dados
                conn.Close();
            }
        }
    }
}

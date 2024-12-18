using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testecrudfiscalio.View;

namespace testecrudfiscalio
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        // Essa função será usada na inicialização do formulario, ela vai consultar os dados ao iniciar.
        // No desing do formulario, ela é chamada.
        private void FormInicio_Load(object sender, EventArgs e)
        {
            LoadNotas();
        }

        private void LoadNotas()
        {
            //consulta o banco de dados, monta uma lista com os documentos e devolve para o DataGrid
            var conn = DbConnect.GetConnection();
            try
            {
                conn.Open();
                var notas = conn.Query<NotaFiscal>("Select * from NotaFiscal").ToList();
                dataGridViewNotas.DataSource = notas;

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnNovaNF_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var conn = DbConnect.GetConnection();
            try
            {
                if (dataGridViewNotas.SelectedRows.Count > 0)
                {
                    // pega a coluna selecionada
                    DataGridViewRow row = dataGridViewNotas.SelectedRows[0];

                    int idNota = Convert.ToInt32(row.Cells["IdNota"].Value);

                    string sql = "DELETE FROM notafiscal WHERE idnota = @IdNota";

                    conn.Execute(sql, new { IdNota = idNota });
                    
                     sql = "DELETE FROM item WHERE idnota = @IdNota";

                    conn.Execute(sql, new { IdNota = idNota });
                }
            }
            finally { 
                conn.Close();
                MessageBox.Show("Nota e itens apagados");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadNotas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotas.SelectedRows.Count > 0)
            {
                // pega a coluna selecionada
                DataGridViewRow row = dataGridViewNotas.SelectedRows[0];

                int idNota = Convert.ToInt32(row.Cells["IdNota"].Value);
                FormCadastro formCadastro = new FormCadastro(idNota);
                formCadastro.Show();
            }

        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testecrudfiscalio.Models;

namespace testecrudfiscalio.View
{
    public partial class FormCadastro : Form
    {
        private int idNota;
        public FormCadastro() {
            InitializeComponent();
            dataGridViewItem.Columns.Add("IdNota", "IdNota");
            dataGridViewItem.Columns.Add("IdItem", "IdItem");
            dataGridViewItem.Columns.Add("Produto", "Produto");
            dataGridViewItem.Columns.Add("Valor", "Valor");
        }
        public FormCadastro(int idNota)
        {
            InitializeComponent();
            this.idNota = idNota;
            LoadItem(idNota);
        }
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            LoadItem(idNota);
        }

        private void LoadItem(int idnota)
        {
            FormInicio formInicio = new FormInicio();
            
            //consulta o banco de dados, monta uma lista com os documentos e devolve para o DataGrid
            var conn = DbConnect.GetConnection();

            try
            {
                conn.Open();

                var notas = conn.Query<NotaFiscal>("Select * from NotaFiscal where idnota = @idnota", new { idnota = idNota }).ToList();
                var nota = notas[0];

                textBoxIdNota.Text = nota.IdNota.ToString();
                textBoxEmissor.Text = nota.Emissor.ToString();
                textBoxData.Text = nota.Data.ToString();


                var items = conn.Query<Item>("Select * from item where idnota = @idnota", new { idnota = idNota }).ToList();
                dataGridViewItem.DataSource = items;
                

                
                

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e){
            var conn = DbConnect.GetConnection();
            try
            {
                int idnotaConvertido = int.Parse(textBoxIdNota.Text);
                var notaFiscal = new NotaFiscal
                {
                    IdNota = idnotaConvertido,
                    Emissor = textBoxEmissor.Text,
                    Data = DateTime.Now
                };

                string sql = "insert into notafiscal (idnota, emissor, data) values (@IdNota,@Emissor, @Data)";
                conn.Execute(sql, notaFiscal);

                foreach (DataGridViewRow row in dataGridViewItem.Rows)
                {
                    // Ignorar linha vazia no final
                    if (row.IsNewRow) continue;

                    // Capturar valores das células
                    //int idnota = int.TryParse(row.Cells["IdNota"].Value?.ToString(), out int idnf) ? idnf : 0;
                    int idnota = idnotaConvertido;
                    int iditem = int.TryParse(row.Cells["IdItem"].Value?.ToString(), out int idit) ? idit : 0;
                    string produto = row.Cells["Produto"].Value?.ToString();
                    decimal valor = decimal.TryParse(row.Cells["Valor"].Value?.ToString(), out decimal value) ? value : 0;

                    // Inserir no banco de dados
                    sql = "INSERT INTO item (idnota, iditem, produto, valor) " +
                        "VALUES (@IdNota, @IdItem, @Produto, @Valor)";
                    var itemNota = new Item
                    {
                        IdNota = idnota,
                        IdItem = iditem,
                        Produto = produto,
                        Valor = valor,
                    };
                    conn.Execute(sql, itemNota);
                }
            }
            finally
            {
                textBoxIdNota.Clear();
                textBoxEmissor.Clear();
                textBoxData.Clear();
                dataGridViewItem.Rows.Clear();
                conn.Close();
                this.Close();
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            var conn = DbConnect.GetConnection();
            try
            {
                if (dataGridViewItem.SelectedRows.Count > 0)
                {
                    // pega a coluna selecionada
                    DataGridViewRow row = dataGridViewItem.SelectedRows[0];

                    int idNota = Convert.ToInt32(row.Cells["IdNota"].Value);
                    int iditem = int.TryParse(row.Cells["IdItem"].Value?.ToString(), out int idit) ? idit : 0;
                    var itemDocumento = new Item() { IdNota = idNota, IdItem = iditem };

                    string sql = "DELETE FROM item WHERE idnota = @IdNota  and iditem = @IdItem";


                    conn.Execute(sql, itemDocumento);
                }
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Item apagados");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var conn = DbConnect.GetConnection();
            try
            {
                int idnotaConvertido = int.Parse(textBoxIdNota.Text);
                var notaFiscal = new NotaFiscal
                {
                    IdNota = idnotaConvertido,
                    Emissor = textBoxEmissor.Text,
                    Data = DateTime.Now
                };

                string sql = "update notafiscal set emissor = @Emissor, data = @Data WHERE idnota = @IdNota ";
                conn.Execute(sql, notaFiscal);

                foreach (DataGridViewRow row in dataGridViewItem.Rows)
                {
                    // Ignorar linha vazia no final
                    if (row.IsNewRow) continue;

                    // Capturar valores das células
                    //int idnota = int.TryParse(row.Cells["IdNota"].Value?.ToString(), out int idnf) ? idnf : 0;
                    int idnota = idnotaConvertido;
                    int iditem = int.TryParse(row.Cells["IdItem"].Value?.ToString(), out int idit) ? idit : 0;
                    string produto = row.Cells["Produto"].Value?.ToString();
                    decimal valor = decimal.TryParse(row.Cells["Valor"].Value?.ToString(), out decimal value) ? value : 0;

                    // Inserir no banco de dados
                    sql = "update item set produto = @Produto, valor = @Valor " +
                        "WHERE idnota = @IdNota and iditem = @IdItem";
                    var itemNota = new Item
                    {
                        IdNota = idnota,
                        IdItem = iditem,
                        Produto = produto,
                        Valor = valor,
                    };
                    conn.Execute(sql, itemNota);
                }
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }
    }
}

﻿namespace testecrudfiscalio
{
    partial class FormInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaNF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaNF
            // 
            this.btnNovaNF.Location = new System.Drawing.Point(12, 12);
            this.btnNovaNF.Name = "btnNovaNF";
            this.btnNovaNF.Size = new System.Drawing.Size(99, 41);
            this.btnNovaNF.TabIndex = 0;
            this.btnNovaNF.Text = "Nova Nota Fiscal";
            this.btnNovaNF.UseVisualStyleBackColor = true;
            this.btnNovaNF.Click += new System.EventHandler(this.btnNovaNF_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recarregar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exportar TXT";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(473, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exportar JSON";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.Size = new System.Drawing.Size(560, 178);
            this.dataGridViewNotas.TabIndex = 6;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNovaNF);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Inicial";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);

        }

        private void FormInicio_Load1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnNovaNF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
    }
}


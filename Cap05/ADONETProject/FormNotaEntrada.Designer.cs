namespace ViewProject
{
    partial class FormNotaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDNotaEntrada = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.BtnNovoNota = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnCancelarNota = new System.Windows.Forms.Button();
            this.BtnRemoverNota = new System.Windows.Forms.Button();
            this.dgvNotasEntrada = new System.Windows.Forms.DataGridView();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.BtnRemoverProduto = new System.Windows.Forms.Button();
            this.BtnCancelarProduto = new System.Windows.Forms.Button();
            this.BtnGravarProduto = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corpo da Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produtos Comprados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDNotaEntrada
            // 
            this.txtIDNotaEntrada.Enabled = false;
            this.txtIDNotaEntrada.Location = new System.Drawing.Point(82, 37);
            this.txtIDNotaEntrada.Name = "txtIDNotaEntrada";
            this.txtIDNotaEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtIDNotaEntrada.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(82, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(82, 115);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(100, 20);
            this.dtpEmissao.TabIndex = 5;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(82, 141);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(100, 20);
            this.dtpEntrada.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fornecedor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Emissão:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Entrada:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(82, 62);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(318, 21);
            this.cbxFornecedor.TabIndex = 12;
            // 
            // BtnNovoNota
            // 
            this.BtnNovoNota.Location = new System.Drawing.Point(17, 167);
            this.BtnNovoNota.Name = "BtnNovoNota";
            this.BtnNovoNota.Size = new System.Drawing.Size(75, 23);
            this.BtnNovoNota.TabIndex = 13;
            this.BtnNovoNota.Text = "Novo";
            this.BtnNovoNota.UseVisualStyleBackColor = true;
            this.BtnNovoNota.Click += new System.EventHandler(this.BtnNovoNota_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(98, 167);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 14;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnCancelarNota
            // 
            this.BtnCancelarNota.Location = new System.Drawing.Point(179, 167);
            this.BtnCancelarNota.Name = "BtnCancelarNota";
            this.BtnCancelarNota.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarNota.TabIndex = 15;
            this.BtnCancelarNota.Text = "Cancelar";
            this.BtnCancelarNota.UseVisualStyleBackColor = true;
            this.BtnCancelarNota.Click += new System.EventHandler(this.BtnCancelarNota_Click);
            // 
            // BtnRemoverNota
            // 
            this.BtnRemoverNota.Location = new System.Drawing.Point(261, 166);
            this.BtnRemoverNota.Name = "BtnRemoverNota";
            this.BtnRemoverNota.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverNota.TabIndex = 16;
            this.BtnRemoverNota.Text = "Remover";
            this.BtnRemoverNota.UseVisualStyleBackColor = true;
            this.BtnRemoverNota.Click += new System.EventHandler(this.BtnRemoverNota_Click);
            // 
            // dgvNotasEntrada
            // 
            this.dgvNotasEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasEntrada.Location = new System.Drawing.Point(17, 196);
            this.dgvNotasEntrada.Name = "dgvNotasEntrada";
            this.dgvNotasEntrada.Size = new System.Drawing.Size(383, 163);
            this.dgvNotasEntrada.TabIndex = 17;
            this.dgvNotasEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotasEntrada_CellClick);
            this.dgvNotasEntrada.SelectionChanged += new System.EventHandler(this.dgvNotasEntrada_SelectionChanged);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(411, 171);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(383, 188);
            this.dgvProdutos.TabIndex = 32;
            // 
            // BtnRemoverProduto
            // 
            this.BtnRemoverProduto.Location = new System.Drawing.Point(663, 142);
            this.BtnRemoverProduto.Name = "BtnRemoverProduto";
            this.BtnRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverProduto.TabIndex = 31;
            this.BtnRemoverProduto.Text = "Remover";
            this.BtnRemoverProduto.UseVisualStyleBackColor = true;
            this.BtnRemoverProduto.Click += new System.EventHandler(this.BtnRemoverProduto_Click);
            // 
            // BtnCancelarProduto
            // 
            this.BtnCancelarProduto.Location = new System.Drawing.Point(582, 141);
            this.BtnCancelarProduto.Name = "BtnCancelarProduto";
            this.BtnCancelarProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarProduto.TabIndex = 30;
            this.BtnCancelarProduto.Text = "Cancelar";
            this.BtnCancelarProduto.UseVisualStyleBackColor = true;
            this.BtnCancelarProduto.Click += new System.EventHandler(this.BtnCancelarProduto_Click);
            // 
            // BtnGravarProduto
            // 
            this.BtnGravarProduto.Location = new System.Drawing.Point(501, 141);
            this.BtnGravarProduto.Name = "BtnGravarProduto";
            this.BtnGravarProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnGravarProduto.TabIndex = 29;
            this.BtnGravarProduto.Text = "Gravar";
            this.BtnGravarProduto.UseVisualStyleBackColor = true;
            this.BtnGravarProduto.Click += new System.EventHandler(this.BtnGravarProduto_Click);
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.Location = new System.Drawing.Point(420, 141);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(75, 23);
            this.BtnNovoProduto.TabIndex = 28;
            this.BtnNovoProduto.Text = "Novo";
            this.BtnNovoProduto.UseVisualStyleBackColor = true;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.Enabled = false;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(476, 62);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(318, 21);
            this.cbxProduto.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Quantidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Custo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Produto:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Id:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCusto
            // 
            this.txtCusto.Enabled = false;
            this.txtCusto.Location = new System.Drawing.Point(476, 89);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 19;
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Enabled = false;
            this.txtIDProduto.Location = new System.Drawing.Point(476, 37);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 18;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(476, 115);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 33;
            // 
            // FormNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 371);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.BtnRemoverProduto);
            this.Controls.Add(this.BtnCancelarProduto);
            this.Controls.Add(this.BtnGravarProduto);
            this.Controls.Add(this.BtnNovoProduto);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.dgvNotasEntrada);
            this.Controls.Add(this.BtnRemoverNota);
            this.Controls.Add(this.BtnCancelarNota);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovoNota);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtIDNotaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNotaEntrada";
            this.Text = "Registro de notas de entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDNotaEntrada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Button BtnNovoNota;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnCancelarNota;
        private System.Windows.Forms.Button BtnRemoverNota;
        private System.Windows.Forms.DataGridView dgvNotasEntrada;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button BtnRemoverProduto;
        private System.Windows.Forms.Button BtnCancelarProduto;
        private System.Windows.Forms.Button BtnGravarProduto;
        private System.Windows.Forms.Button BtnNovoProduto;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}
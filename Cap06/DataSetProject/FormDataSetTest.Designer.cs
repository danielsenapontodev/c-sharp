namespace DataSetProject
{
    partial class FormDataSetTest
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
            this.btnCriarDataSet = new System.Windows.Forms.Button();
            this.btnInserirDados = new System.Windows.Forms.Button();
            this.btnVisualizarXML = new System.Windows.Forms.Button();
            this.btnVisualizarControes = new System.Windows.Forms.Button();
            this.tcResultados = new System.Windows.Forms.TabControl();
            this.tpXML = new System.Windows.Forms.TabPage();
            this.tpComboEGrid = new System.Windows.Forms.TabPage();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.dgCidades = new System.Windows.Forms.DataGridView();
            this.tcResultados.SuspendLayout();
            this.tpXML.SuspendLayout();
            this.tpComboEGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarDataSet
            // 
            this.btnCriarDataSet.Location = new System.Drawing.Point(12, 12);
            this.btnCriarDataSet.Name = "btnCriarDataSet";
            this.btnCriarDataSet.Size = new System.Drawing.Size(100, 23);
            this.btnCriarDataSet.TabIndex = 0;
            this.btnCriarDataSet.Text = "Criar DataSet";
            this.btnCriarDataSet.UseVisualStyleBackColor = true;
            this.btnCriarDataSet.Click += new System.EventHandler(this.btnCriarDataSet_Click);
            // 
            // btnInserirDados
            // 
            this.btnInserirDados.Location = new System.Drawing.Point(118, 12);
            this.btnInserirDados.Name = "btnInserirDados";
            this.btnInserirDados.Size = new System.Drawing.Size(100, 23);
            this.btnInserirDados.TabIndex = 1;
            this.btnInserirDados.Text = "Inserir dados";
            this.btnInserirDados.UseVisualStyleBackColor = true;
            this.btnInserirDados.Click += new System.EventHandler(this.btnInserirDados_Click);
            // 
            // btnVisualizarXML
            // 
            this.btnVisualizarXML.Location = new System.Drawing.Point(224, 12);
            this.btnVisualizarXML.Name = "btnVisualizarXML";
            this.btnVisualizarXML.Size = new System.Drawing.Size(100, 23);
            this.btnVisualizarXML.TabIndex = 2;
            this.btnVisualizarXML.Text = "Visualizar XML";
            this.btnVisualizarXML.UseVisualStyleBackColor = true;
            this.btnVisualizarXML.Click += new System.EventHandler(this.btnVisualizarXML_Click);
            // 
            // btnVisualizarControes
            // 
            this.btnVisualizarControes.Location = new System.Drawing.Point(330, 12);
            this.btnVisualizarControes.Name = "btnVisualizarControes";
            this.btnVisualizarControes.Size = new System.Drawing.Size(100, 23);
            this.btnVisualizarControes.TabIndex = 3;
            this.btnVisualizarControes.Text = "Controles visuais";
            this.btnVisualizarControes.UseVisualStyleBackColor = true;
            this.btnVisualizarControes.Click += new System.EventHandler(this.btnVisualizarControes_Click);
            // 
            // tcResultados
            // 
            this.tcResultados.Controls.Add(this.tpXML);
            this.tcResultados.Controls.Add(this.tpComboEGrid);
            this.tcResultados.Location = new System.Drawing.Point(12, 41);
            this.tcResultados.Name = "tcResultados";
            this.tcResultados.SelectedIndex = 0;
            this.tcResultados.Size = new System.Drawing.Size(776, 397);
            this.tcResultados.TabIndex = 4;
            // 
            // tpXML
            // 
            this.tpXML.Controls.Add(this.txtXML);
            this.tpXML.Location = new System.Drawing.Point(4, 22);
            this.tpXML.Name = "tpXML";
            this.tpXML.Padding = new System.Windows.Forms.Padding(3);
            this.tpXML.Size = new System.Drawing.Size(768, 371);
            this.tpXML.TabIndex = 0;
            this.tpXML.Text = "Dados em XML";
            this.tpXML.UseVisualStyleBackColor = true;
            // 
            // tpComboEGrid
            // 
            this.tpComboEGrid.Controls.Add(this.dgCidades);
            this.tpComboEGrid.Controls.Add(this.cbEstados);
            this.tpComboEGrid.Controls.Add(this.label1);
            this.tpComboEGrid.Location = new System.Drawing.Point(4, 22);
            this.tpComboEGrid.Name = "tpComboEGrid";
            this.tpComboEGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpComboEGrid.Size = new System.Drawing.Size(768, 371);
            this.tpComboEGrid.TabIndex = 1;
            this.tpComboEGrid.Text = "Dados em controles";
            this.tpComboEGrid.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(6, 6);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(756, 359);
            this.txtXML.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(55, 6);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(707, 21);
            this.cbEstados.TabIndex = 1;
            // 
            // dgCidades
            // 
            this.dgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCidades.Location = new System.Drawing.Point(9, 33);
            this.dgCidades.Name = "dgCidades";
            this.dgCidades.Size = new System.Drawing.Size(753, 332);
            this.dgCidades.TabIndex = 2;
            // 
            // FormDataSetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcResultados);
            this.Controls.Add(this.btnVisualizarControes);
            this.Controls.Add(this.btnVisualizarXML);
            this.Controls.Add(this.btnInserirDados);
            this.Controls.Add(this.btnCriarDataSet);
            this.Name = "FormDataSetTest";
            this.Text = "Testes com DataSet e seus componentes";
            this.tcResultados.ResumeLayout(false);
            this.tpXML.ResumeLayout(false);
            this.tpXML.PerformLayout();
            this.tpComboEGrid.ResumeLayout(false);
            this.tpComboEGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarDataSet;
        private System.Windows.Forms.Button btnInserirDados;
        private System.Windows.Forms.Button btnVisualizarXML;
        private System.Windows.Forms.Button btnVisualizarControes;
        private System.Windows.Forms.TabControl tcResultados;
        private System.Windows.Forms.TabPage tpXML;
        private System.Windows.Forms.TabPage tpComboEGrid;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCidades;
    }
}


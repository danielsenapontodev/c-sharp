using System;
using System.Windows.Forms;
using ADONETProject;

namespace ViewProject
{
    public partial class FormNotaEntrada : Form
    {
        private DAL_NotaEntrada dal = new DAL_NotaEntrada();
        private DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
        private DAL_Produto dalProduto = new DAL_Produto();
        private NotaEntrada notaAtual;

        public FormNotaEntrada()
        {
            InitializeComponent();
            InicializaComboBoxs();
            GetAllNotas();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();
            foreach (Fornecedor fornecedor in this.dalFornecedor.GetAllAsIList())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }
            foreach (Produto produto in this.dalProduto.GetAllAsIList())
            {
                cbxProduto.Items.Add(produto);
            }
        }

        private void GetAllNotas()
        {
            dgvNotasEntrada.DataSource = dal.GetAllAsDataTable();
        }

        private void BtnNovoNota_Click(object sender, System.EventArgs e)
        {
            ClearControlsNota();
        }

        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void BtnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void BtnRemoverNota_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.Produtos;
            }
        }

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA, que terá inserção de produtos, no  GRID");
            }
            else
            {
                ChangeStatusOfControls(true);
            }
        }

        private void ClearControlsProduto()
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbxProduto.Focus();
        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cbxProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtQuantidade.Enabled = newStatus;
            BtnNovoProduto.Enabled = !newStatus;
            BtnGravarProduto.Enabled = newStatus;
            BtnCancelarProduto.Enabled = newStatus;
            BtnRemoverProduto.Enabled = newStatus;
        }

        private void BtnGravarProduto_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void BtnCancelarProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            ChangeStatusOfControls(false);
        }

        private void BtnRemoverProduto_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void dgvNotasEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.notaAtual = dal.GetById(Convert.ToInt64(dgvNotasEntrada.Rows[e.RowIndex].Cells[0].Value));
            txtIDNotaEntrada.Text = notaAtual.Id.ToString();
            txtNumero.Text = notaAtual.Numero;
            dtpEmissao.Value = notaAtual.DataEmissao;
            dtpEntrada.Value = notaAtual.DataEntrada;
            cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;
        }
    }
}

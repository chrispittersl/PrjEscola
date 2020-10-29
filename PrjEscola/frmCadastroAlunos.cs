using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrjEscola
{
    public partial class frmCadastroAlunos : Form
    {
        public frmCadastroAlunos()
        {
            InitializeComponent();
        }
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_escola;
        BindingSource bs_escola = new BindingSource();
        String _query;
        private void carregar_grid()
        {

            _query = "Select * from Alunos";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_escola = _dataCommand.ExecuteReader();

            if (dr_escola.HasRows == true)
            {
                bs_escola.DataSource = dr_escola;
                dgvAlunos.DataSource = bs_escola;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos Alunos cadastrados !!!!", "Atenção",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void igualar_text()
        {
            lblCodMat.DataBindings.Add("Text", bs_escola, "Matricula");
            lblCodMat.DataBindings.Clear();
            txtNome.DataBindings.Add("Text", bs_escola, "Nome");
            txtNome.DataBindings.Clear();
            dtpNasc.DataBindings.Add("Text", bs_escola, "Nasc");
            dtpNasc.DataBindings.Clear();
            txtEndereco.DataBindings.Add("Text", bs_escola, "Endereco");
            txtEndereco.DataBindings.Clear();
            txtNumero.DataBindings.Add("Text", bs_escola, "numero");
            txtNumero.DataBindings.Clear();
            txtBairro.DataBindings.Add("Text", bs_escola, "bairro");
            txtBairro.DataBindings.Clear();
            txtCidade.DataBindings.Add("Text", bs_escola, "cidade");
            txtCidade.DataBindings.Clear();
            txtCEP.DataBindings.Add("Text", bs_escola, "cep");
            txtCEP.DataBindings.Clear();
            txtRG.DataBindings.Add("Text", bs_escola, "RG");
            txtRG.DataBindings.Clear();
            txtTel.DataBindings.Add("Text", bs_escola, "telefone");
            txtTel.DataBindings.Clear();
        }

        private void frmCadastroAlunos_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            igualar_text();
        }

        private void dgvAlunos_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            igualar_text();
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Alunos where Nome like '" + txtPesq.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_escola = _dataCommand.ExecuteReader();

            if (dr_escola.HasRows == true)
            {
                bs_escola.DataSource = dr_escola;
            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas com este nome !!!!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesq.Text = "";
            }
        }
        private bool valida()
        {
            bool erro = true;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Endereço inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEndereco.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Número inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Bairro inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Cidade inválida. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
            }
            else if (txtCEP.Text == "")
            {
                MessageBox.Show("CEP inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCEP.Focus();
            }
            else if (txtRG.Text == "")
            {
                MessageBox.Show("RG inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRG.Focus();
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Telefone inválido. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTel.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bs_escola.MoveFirst();
            igualar_text();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (bs_escola.Count == bs_escola.Position + 1)
            {
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_escola.MoveNext();
                igualar_text();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (bs_escola.Position == 0)
            {
                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_escola.MovePrevious();
                igualar_text();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bs_escola.MoveLast();
            igualar_text();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Insert into Alunos (Nome,Nasc,Endereco,numero,bairro,cidade,cep,RG,telefone) Values ";
                _query += "('" + txtNome.Text + "','" + dtpNasc.Text + "','" + txtEndereco.Text + "','" + txtNumero.Text +
                    "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtCEP.Text + "','" + txtRG.Text + "','" +
                    txtTel.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluido com sucesso !!!!", "Inclusão", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Inclusão !!!!", "Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Alunos where Matricula like '" + lblCodMat.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso !!!!", "Exclusão", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão !!!!", "Exclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();

            if (teste == false)
            {
                _query = "Update Disciplinas set Nome ='" + txtNome.Text + "',";
                _query += "Nasc = '" + dtpNasc.Text + "',";
                _query += "Endereco = '" + txtEndereco.Text + "',";
                _query += "numero = '" + txtNumero.Text + "',";
                _query += "bairro = '" + txtBairro.Text + "',";
                _query += "cidade = '" + txtCidade.Text + "',";
                _query += "cep = '" + txtCEP.Text + "',";
                _query += "RG = '" + txtRG.Text + "',";
                _query += "telefone = '" + txtTel.Text + "',";
                _query += "where Cod like '" + lblCodMat.Text + "'";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso !!!!", "Alteração",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Alteração !!!!", "Alteração",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txtNome.Focus();
        }
        private void limpar()
        {
            lblCodMat.Text = "0";
            txtNome.Clear();
            txtPesq.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtRG.Clear();
            txtTel.Clear();
        }

    }
}

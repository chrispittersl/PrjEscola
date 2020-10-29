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
    public partial class frmCadDisc : Form
    {
        public frmCadDisc()
        {
            InitializeComponent();
        }
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_escola;
        BindingSource bs_escola = new BindingSource();
        String _query;

        private void carregar_grid()
        {

            _query = "Select * from Disciplinas";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_escola = _dataCommand.ExecuteReader();

            if (dr_escola.HasRows == true)
            {
                bs_escola.DataSource = dr_escola;
                dgvDisciplinas.DataSource = bs_escola;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos Disiciplinas cadastradas !!!!", "Atenção",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void igualar_text()
        {
            lblCodDisc.DataBindings.Add("Text", bs_escola, "cod_disciplina");
            lblCodDisc.DataBindings.Clear();
            txtDesc.DataBindings.Add("Text", bs_escola, "descricao");
            txtDesc.DataBindings.Clear();
            txtSigla.DataBindings.Add("Text", bs_escola, "sigla");
            txtSigla.DataBindings.Clear();
        }

        private void frmCadDisc_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregar_grid();
        }

        private void dgvDisciplinas_Click(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvDisciplinas_KeyUp(object sender, KeyEventArgs e)
        {
            carregar_grid();
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Disciplinas where sigla like '" + txtPesq.Text + "%'";
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

            if (txtDesc.Text == "")
            {
                MessageBox.Show("Descrição inválida. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesc.Focus();
            }
            else if (txtSigla.Text == "")
            {
                MessageBox.Show("Sigla inválida. Redigite !!", "Atenção!!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSigla.Focus();
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
                _query = "Insert into Disciplinas (descricao,sigla) Values ";
                _query += "('" + txtDesc.Text + "','" + txtSigla.Text + "')";
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
            _query = "delete from Disciplinas where cod_disciplina like '" + lblCodDisc.Text + "'";
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
                _query = "Update Disciplinas set descricao ='" + txtDesc.Text + "',";
                _query += "sigla = '" + txtSigla.Text + "'";
                _query += "where cod_disciplina like '" + lblCodDisc.Text + "'";
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
            txtDesc.Focus();
        }
        private void limpar()
        {
            lblCodDisc.Text = "0";
            txtDesc.Clear();
            txtPesq.Clear();
            txtSigla.Clear();
        }
    }
}

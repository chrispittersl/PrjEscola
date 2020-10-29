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
    public partial class frmConAlunos : Form
    {
        public frmConAlunos()
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
                dgvConAlunos.DataSource = bs_escola;
            }
            else
            {
                MessageBox.Show("Não temos Alunos cadastrados !!!!", "Atenção",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if (cmbEscolha.Text == "Matrícula")
                _query = "Select * from Alunos where Matricula like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Nome")
                _query = "Select * from Alunos where Nome like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Endereço")
                _query = "Select * from Alunos where Endereco like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Número")
                _query = "Select * from Alunos where numero like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Bairro")
                _query = "Select * from Alunos where bairro like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Cidade")
                _query = "Select * from Alunos where cidade like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "CEP")
                _query = "Select * from Alunos where cep like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "RG")
                _query = "Select * from Alunos where RG like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Telefone")
                _query = "Select * from Alunos where telefone like '" + txtPesq.Text + "%'";
            else
            {
                MessageBox.Show("Escolha um campo para pesquisar !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEscolha.Focus();
            }
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_escola = _dataCommand.ExecuteReader();

            if (dr_escola.HasRows == true)
                bs_escola.DataSource = dr_escola;
            else
            {
                MessageBox.Show("Não temos nenhuma Disciplina cadastrada com este parametro!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesq.Clear();
            }
        }

        private void btnQuant_Click(object sender, EventArgs e)
        {
            int a = bs_escola.Count; 
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmConAlunos_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvConAlunos.CurrentRow;

            //e.Graphics.DrawImage(Image.FromFile("Eteczada.bmp"), 50, 20);
            // texto = objimpressao.DrawString(String,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE DISCIPLINA", new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);
            //linha - cor, espessura, posição x - ponto inicial(colua e linha), posição y - ponto final(coluna e linha);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);
            // matricula
            e.Graphics.DrawString("MATRÍCULA: " + linha.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);
            // nome
            e.Graphics.DrawString("NOME: " + linha.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);
            // nascimento
            e.Graphics.DrawString("NASCIMENTO: " + linha.Cells["Nasc"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);
            // endereço
            e.Graphics.DrawString("ENDEREÇO: " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 180);
            // bairro
            e.Graphics.DrawString("BAIRRO: " + linha.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);
            // cidade
            e.Graphics.DrawString("CIDADE: " + linha.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 220);
            // cep
            e.Graphics.DrawString("CEP: " + linha.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 240);
            // rg
            e.Graphics.DrawString("RG: " + linha.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 260);
            // telefone
            e.Graphics.DrawString("TELEFONE: " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 280);
            // inferior
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Text = "Visualizando a impressão";
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.PrintPreviewControl.Columns = 2;
            printPreviewDialog.PrintPreviewControl.Zoom = 0.6;
            printPreviewDialog.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
            printDocument.Print();
        }

    }
}

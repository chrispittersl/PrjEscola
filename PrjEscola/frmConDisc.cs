using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace PrjEscola
{
    public partial class frmConDisc : Form
    {
        public frmConDisc()
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
                dgvConDisc.DataSource = bs_escola;
            }
            else
            {
                MessageBox.Show("Não temos Alunos cadastrados !!!!", "Atenção",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if (cmbEscolha.Text == "Descrição")
                _query = "Select * from Disciplinas where descricao like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Código")
                _query = "Select * from Disciplinas where cod_disciplina like '" + txtPesq.Text + "%'";
            else if (cmbEscolha.Text == "Sigla")
                _query = "Select * from Disciplinas where Sigla like '" + txtPesq.Text + "%'";
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

        private void frmConDisc_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvConDisc.CurrentRow;

            //e.Graphics.DrawImage(Image.FromFile("Eteczada.bmp"), 50, 20);
            // texto = objimpressao.DrawString(String,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE DISCIPLINA", new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 400, 50);
            //linha - cor, espessura, posição x - ponto inicial(colua e linha), posição y - ponto final(coluna e linha);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 75, 800, 75);
            //código
            e.Graphics.DrawString("CÓDIGO DA DISCIPLINA: " + linha.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 120);
            //  descrição
            e.Graphics.DrawString("DESCRIÇÃO: " + linha.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 140);
            // sigla
            e.Graphics.DrawString("SIGLA: " + linha.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 160);
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

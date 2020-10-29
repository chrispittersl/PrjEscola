using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEscola
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data : " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "|  Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroAlunos form = new frmCadastroAlunos();
            form.MdiParent = this; 
            form.Show();
        }

        private void smiSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair??", "Título ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexao.fecharConexao();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadAlunos_Click(object sender, EventArgs e)
        {
            frmCadastroAlunos form = new frmCadastroAlunos();
            form.MdiParent = this;
            form.Show();
        }

        private void smiCadDisc_Click(object sender, EventArgs e)
        {
            frmCadDisc formCadDisc = new frmCadDisc();
            formCadDisc.MdiParent = this;
            formCadDisc.Show();
        }

        private void btnCadDisc_Click(object sender, EventArgs e)
        {
            frmCadDisc form = new frmCadDisc();
            form.MdiParent = this;
            form.Show();
        }

        private void smiConAlunos_Click(object sender, EventArgs e)
        {
            frmConAlunos form = new frmConAlunos();
            form.MdiParent = this;
            form.Show();
        }

        private void smiConDisc_Click(object sender, EventArgs e)
        {
            frmConDisc form = new frmConDisc();
            form.MdiParent = this;
            form.Show();
        }

    }
}

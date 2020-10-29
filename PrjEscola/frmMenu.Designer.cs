namespace PrjEscola
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDev = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.smiCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCadAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCadDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.smiConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.smiConAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiConDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRelAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRelDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnCadAlunos = new System.Windows.Forms.ToolStripButton();
            this.btnCadDisc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusBar.SuspendLayout();
            this.menu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora,
            this.lblDev});
            this.statusBar.Location = new System.Drawing.Point(0, 529);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(454, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 17);
            this.lblData.Text = "Data: ";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(39, 17);
            this.lblHora.Text = "Hora: ";
            // 
            // lblDev
            // 
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(153, 17);
            this.lblDev.Text = "|  Christopher Pitter Da Silva";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiCadastro,
            this.smiConsulta,
            this.smiRelatorio,
            this.smiSobre,
            this.smiSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(454, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // smiCadastro
            // 
            this.smiCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiCadAlunos,
            this.smiCadDisc});
            this.smiCadastro.Name = "smiCadastro";
            this.smiCadastro.Size = new System.Drawing.Size(66, 20);
            this.smiCadastro.Text = "Cadastro";
            // 
            // smiCadAlunos
            // 
            this.smiCadAlunos.Name = "smiCadAlunos";
            this.smiCadAlunos.Size = new System.Drawing.Size(130, 22);
            this.smiCadAlunos.Text = "Alunos";
            this.smiCadAlunos.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // smiCadDisc
            // 
            this.smiCadDisc.Name = "smiCadDisc";
            this.smiCadDisc.Size = new System.Drawing.Size(130, 22);
            this.smiCadDisc.Text = "Disciplinas";
            this.smiCadDisc.Click += new System.EventHandler(this.smiCadDisc_Click);
            // 
            // smiConsulta
            // 
            this.smiConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiConAlunos,
            this.smiConDisc});
            this.smiConsulta.Name = "smiConsulta";
            this.smiConsulta.Size = new System.Drawing.Size(66, 20);
            this.smiConsulta.Text = "Consulta";
            // 
            // smiConAlunos
            // 
            this.smiConAlunos.Name = "smiConAlunos";
            this.smiConAlunos.Size = new System.Drawing.Size(152, 22);
            this.smiConAlunos.Text = "Alunos";
            this.smiConAlunos.Click += new System.EventHandler(this.smiConAlunos_Click);
            // 
            // smiConDisc
            // 
            this.smiConDisc.Name = "smiConDisc";
            this.smiConDisc.Size = new System.Drawing.Size(152, 22);
            this.smiConDisc.Text = "Disciplinas";
            this.smiConDisc.Click += new System.EventHandler(this.smiConDisc_Click);
            // 
            // smiRelatorio
            // 
            this.smiRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiRelAlunos,
            this.smiRelDisc});
            this.smiRelatorio.Name = "smiRelatorio";
            this.smiRelatorio.Size = new System.Drawing.Size(66, 20);
            this.smiRelatorio.Text = "Relatório";
            // 
            // smiRelAlunos
            // 
            this.smiRelAlunos.Name = "smiRelAlunos";
            this.smiRelAlunos.Size = new System.Drawing.Size(130, 22);
            this.smiRelAlunos.Text = "Alunos";
            // 
            // smiRelDisc
            // 
            this.smiRelDisc.Name = "smiRelDisc";
            this.smiRelDisc.Size = new System.Drawing.Size(130, 22);
            this.smiRelDisc.Text = "Disciplinas";
            // 
            // smiSobre
            // 
            this.smiSobre.Name = "smiSobre";
            this.smiSobre.Size = new System.Drawing.Size(49, 20);
            this.smiSobre.Text = "Sobre";
            // 
            // smiSair
            // 
            this.smiSair.Name = "smiSair";
            this.smiSair.Size = new System.Drawing.Size(38, 20);
            this.smiSair.Text = "Sair";
            this.smiSair.Click += new System.EventHandler(this.smiSair_Click);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.Silver;
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadAlunos,
            this.btnCadDisc,
            this.toolStripButton3});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(454, 39);
            this.toolBar.TabIndex = 5;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnCadAlunos
            // 
            this.btnCadAlunos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadAlunos.Image = global::PrjEscola.Properties.Resources._10207manstudentlightskintone_110568;
            this.btnCadAlunos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadAlunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadAlunos.Name = "btnCadAlunos";
            this.btnCadAlunos.Size = new System.Drawing.Size(36, 36);
            this.btnCadAlunos.Text = "toolStripButton1";
            this.btnCadAlunos.Click += new System.EventHandler(this.btnCadAlunos_Click);
            // 
            // btnCadDisc
            // 
            this.btnCadDisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadDisc.Image = global::PrjEscola.Properties.Resources.book_bookmark_icon_34486;
            this.btnCadDisc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadDisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadDisc.Name = "btnCadDisc";
            this.btnCadDisc.Size = new System.Drawing.Size(36, 36);
            this.btnCadDisc.Text = "toolStripButton2";
            this.btnCadDisc.Click += new System.EventHandler(this.btnCadDisc_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::PrjEscola.Properties.Resources.Error_36910;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PrjEscola.Properties.Resources.Eteczada;
            this.ClientSize = new System.Drawing.Size(454, 551);
            this.ControlBox = false;
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Opções";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblDev;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem smiCadastro;
        private System.Windows.Forms.ToolStripMenuItem smiCadAlunos;
        private System.Windows.Forms.ToolStripMenuItem smiCadDisc;
        private System.Windows.Forms.ToolStripMenuItem smiConsulta;
        private System.Windows.Forms.ToolStripMenuItem smiConAlunos;
        private System.Windows.Forms.ToolStripMenuItem smiConDisc;
        private System.Windows.Forms.ToolStripMenuItem smiRelatorio;
        private System.Windows.Forms.ToolStripMenuItem smiRelAlunos;
        private System.Windows.Forms.ToolStripMenuItem smiSobre;
        private System.Windows.Forms.ToolStripMenuItem smiSair;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton btnCadAlunos;
        private System.Windows.Forms.ToolStripButton btnCadDisc;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem smiRelDisc;
    }
}


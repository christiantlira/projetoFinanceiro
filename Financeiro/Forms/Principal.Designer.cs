namespace Financeiro
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnInformacoes = new Button();
            txtBoxDescricao = new TextBox();
            btnCategorias = new Button();
            cbCategorias = new ComboBox();
            lblCategorias = new Label();
            lblDescricao = new Label();
            label1 = new Label();
            txtBoxValor = new TextBox();
            dtpData = new DateTimePicker();
            label2 = new Label();
            lista = new ListView();
            btnAdicionar = new Button();
            cmsBotaoDireito = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            btnAtualizar = new Button();
            cmsBotaoDireito.SuspendLayout();
            SuspendLayout();
            // 
            // btnInformacoes
            // 
            btnInformacoes.Location = new Point(12, 12);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(145, 23);
            btnInformacoes.TabIndex = 0;
            btnInformacoes.TabStop = false;
            btnInformacoes.Text = "Registrar Informações";
            btnInformacoes.UseVisualStyleBackColor = true;
            // 
            // txtBoxDescricao
            // 
            txtBoxDescricao.Location = new Point(278, 48);
            txtBoxDescricao.Name = "txtBoxDescricao";
            txtBoxDescricao.Size = new Size(170, 23);
            txtBoxDescricao.TabIndex = 1;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(163, 12);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(71, 23);
            btnCategorias.TabIndex = 2;
            btnCategorias.TabStop = false;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(84, 48);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(121, 23);
            cbCategorias.TabIndex = 0;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(12, 51);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 4;
            lblCategorias.Text = "Categorias:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(211, 51);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 51);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor:";
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(496, 48);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(80, 23);
            txtBoxValor.TabIndex = 2;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(622, 48);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 51);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 9;
            label2.Text = "Data:";
            // 
            // lista
            // 
            lista.Location = new Point(12, 108);
            lista.Name = "lista";
            lista.Size = new Size(808, 330);
            lista.TabIndex = 10;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(753, 79);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(67, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmsBotaoDireito
            // 
            cmsBotaoDireito.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, excluirToolStripMenuItem });
            cmsBotaoDireito.Name = "contextMenuStrip1";
            cmsBotaoDireito.Size = new Size(110, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Image = Properties.Resources.Editar;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(109, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Image = Properties.Resources.Deletar;
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // btnAtualizar
            // 
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(11, 444);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 11;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 476);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(lista);
            Controls.Add(label2);
            Controls.Add(dtpData);
            Controls.Add(txtBoxValor);
            Controls.Add(label1);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategorias);
            Controls.Add(cbCategorias);
            Controls.Add(btnCategorias);
            Controls.Add(txtBoxDescricao);
            Controls.Add(btnInformacoes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "Menu principal";
            TopMost = true;
            Load += Principal_Load;
            cmsBotaoDireito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInformacoes;
        private TextBox txtBoxDescricao;
        private Button btnCategorias;
        private ComboBox cbCategorias;
        private Label lblCategorias;
        private Label lblDescricao;
        private Label label1;
        private TextBox txtBoxValor;
        private DateTimePicker dtpData;
        private Label label2;
        private ListView lista;
        private Button btnAdicionar;
        private ContextMenuStrip cmsBotaoDireito;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private Button btnAtualizar;
    }
}
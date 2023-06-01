namespace Financeiro.Forms
{
    partial class FRM_Ganhos
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
            components = new System.ComponentModel.Container();
            btnCategorias = new Button();
            lblItens = new Label();
            lblValor = new Label();
            lblValorTotal = new Label();
            lblNumeroItens = new Label();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            lista = new ListView();
            label2 = new Label();
            dtpData = new DateTimePicker();
            txtBoxValor = new TextBox();
            label1 = new Label();
            lblDescricao = new Label();
            lblCategorias = new Label();
            cbCategorias = new ComboBox();
            txtBoxDescricao = new TextBox();
            cmsBotaoDireito = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            cmsBotaoDireito.SuspendLayout();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.White;
            btnCategorias.Location = new Point(11, 40);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(148, 23);
            btnCategorias.TabIndex = 47;
            btnCategorias.TabStop = false;
            btnCategorias.Text = "Registrar Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Location = new Point(773, 413);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(16, 15);
            lblItens.TabIndex = 46;
            lblItens.Text = "...";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(607, 413);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(16, 15);
            lblValor.TabIndex = 45;
            lblValor.Text = "...";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(538, 413);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(63, 15);
            lblValorTotal.TabIndex = 44;
            lblValorTotal.Text = "Valor total:";
            // 
            // lblNumeroItens
            // 
            lblNumeroItens.AutoSize = true;
            lblNumeroItens.Location = new Point(732, 413);
            lblNumeroItens.Name = "lblNumeroItens";
            lblNumeroItens.Size = new Size(35, 15);
            lblNumeroItens.TabIndex = 43;
            lblNumeroItens.Text = "Itens:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(11, 405);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 42;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(753, 40);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(67, 23);
            btnAdicionar.TabIndex = 36;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lista
            // 
            lista.Location = new Point(12, 69);
            lista.Name = "lista";
            lista.Size = new Size(808, 330);
            lista.TabIndex = 41;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 12);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 40;
            label2.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(622, 9);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 35;
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(496, 9);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(80, 23);
            txtBoxValor.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 39;
            label1.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(211, 12);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 38;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(12, 12);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 37;
            lblCategorias.Text = "Categorias:";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(84, 9);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(121, 23);
            cbCategorias.TabIndex = 32;
            // 
            // txtBoxDescricao
            // 
            txtBoxDescricao.Location = new Point(278, 9);
            txtBoxDescricao.Name = "txtBoxDescricao";
            txtBoxDescricao.Size = new Size(170, 23);
            txtBoxDescricao.TabIndex = 33;
            // 
            // cmsBotaoDireito
            // 
            cmsBotaoDireito.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, excluirToolStripMenuItem });
            cmsBotaoDireito.Name = "contextMenuStrip1";
            cmsBotaoDireito.Size = new Size(181, 70);
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
            excluirToolStripMenuItem.Size = new Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // FRM_Ganhos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(832, 432);
            Controls.Add(btnCategorias);
            Controls.Add(lblItens);
            Controls.Add(lblValor);
            Controls.Add(lblValorTotal);
            Controls.Add(lblNumeroItens);
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
            Controls.Add(txtBoxDescricao);
            Name = "FRM_Ganhos";
            Text = "FRM_Ganhos";
            Load += FRM_Ganhos_Load;
            cmsBotaoDireito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCategorias;
        private Label lblItens;
        private Label lblValor;
        private Label lblValorTotal;
        private Label lblNumeroItens;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private ListView lista;
        private Label label2;
        private DateTimePicker dtpData;
        private TextBox txtBoxValor;
        private Label label1;
        private Label lblDescricao;
        private Label lblCategorias;
        private ComboBox cbCategorias;
        private TextBox txtBoxDescricao;
        private ContextMenuStrip cmsBotaoDireito;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
    }
}
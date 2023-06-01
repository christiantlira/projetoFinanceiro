namespace Financeiro.Forms
{
    partial class FRM_Gastos
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
            lblValor = new Label();
            lblItens = new Label();
            btnCategorias = new Button();
            cmsBotaoDireito.SuspendLayout();
            SuspendLayout();
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(539, 408);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(63, 15);
            lblValorTotal.TabIndex = 28;
            lblValorTotal.Text = "Valor total:";
            // 
            // lblNumeroItens
            // 
            lblNumeroItens.AutoSize = true;
            lblNumeroItens.Location = new Point(733, 408);
            lblNumeroItens.Name = "lblNumeroItens";
            lblNumeroItens.Size = new Size(35, 15);
            lblNumeroItens.TabIndex = 27;
            lblNumeroItens.Text = "Itens:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(12, 400);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 26;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(754, 35);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(67, 23);
            btnAdicionar.TabIndex = 20;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lista
            // 
            lista.Location = new Point(13, 64);
            lista.Name = "lista";
            lista.Size = new Size(808, 330);
            lista.TabIndex = 25;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 7);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 24;
            label2.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(623, 4);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 19;
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(497, 4);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(80, 23);
            txtBoxValor.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 7);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 23;
            label1.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(212, 7);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 22;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(13, 7);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 21;
            lblCategorias.Text = "Categorias:";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(85, 4);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(121, 23);
            cbCategorias.TabIndex = 16;
            // 
            // txtBoxDescricao
            // 
            txtBoxDescricao.Location = new Point(279, 4);
            txtBoxDescricao.Name = "txtBoxDescricao";
            txtBoxDescricao.Size = new Size(170, 23);
            txtBoxDescricao.TabIndex = 17;
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
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Image = Properties.Resources.Deletar;
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(608, 408);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(16, 15);
            lblValor.TabIndex = 29;
            lblValor.Text = "...";
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Location = new Point(774, 408);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(16, 15);
            lblItens.TabIndex = 30;
            lblItens.Text = "...";
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.White;
            btnCategorias.Location = new Point(12, 35);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(148, 23);
            btnCategorias.TabIndex = 31;
            btnCategorias.TabStop = false;
            btnCategorias.Text = "Registrar Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // FRM_Gastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "FRM_Gastos";
            Text = "FRM_Gastos";
            Load += FRM_Gastos_Load;
            cmsBotaoDireito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label lblValor;
        private Label lblItens;
        private Button btnCategorias;
    }
}
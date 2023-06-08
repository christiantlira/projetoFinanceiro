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
            groupBox1 = new GroupBox();
            lblAte = new Label();
            dtpGAte = new DateTimePicker();
            btnFiltrar = new Button();
            lblDe = new Label();
            dtpGDe = new DateTimePicker();
            tbGVal = new TextBox();
            lblVal = new Label();
            lblDesc = new Label();
            lblCat = new Label();
            cbGCat = new ComboBox();
            tbGDesc = new TextBox();
            cmsBotaoDireito.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Top;
            btnCategorias.BackColor = Color.White;
            btnCategorias.Location = new Point(23, 171);
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
            lblItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblItens.AutoSize = true;
            lblItens.Location = new Point(828, 525);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(16, 15);
            lblItens.TabIndex = 46;
            lblItens.Text = "...";
            // 
            // lblValor
            // 
            lblValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblValor.AutoSize = true;
            lblValor.Location = new Point(662, 525);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(16, 15);
            lblValor.TabIndex = 45;
            lblValor.Text = "...";
            // 
            // lblValorTotal
            // 
            lblValorTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(593, 525);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(63, 15);
            lblValorTotal.TabIndex = 44;
            lblValorTotal.Text = "Valor total:";
            // 
            // lblNumeroItens
            // 
            lblNumeroItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNumeroItens.AutoSize = true;
            lblNumeroItens.Location = new Point(787, 525);
            lblNumeroItens.Name = "lblNumeroItens";
            lblNumeroItens.Size = new Size(35, 15);
            lblNumeroItens.TabIndex = 43;
            lblNumeroItens.Text = "Itens:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(11, 517);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 42;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top;
            btnAdicionar.Location = new Point(808, 171);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(67, 23);
            btnAdicionar.TabIndex = 36;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.Location = new Point(12, 200);
            lista.Name = "lista";
            lista.Size = new Size(863, 311);
            lista.TabIndex = 41;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(635, 143);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 40;
            label2.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Anchor = AnchorStyles.Top;
            dtpData.Location = new Point(675, 140);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 35;
            // 
            // txtBoxValor
            // 
            txtBoxValor.Anchor = AnchorStyles.Top;
            txtBoxValor.Location = new Point(535, 140);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(80, 23);
            txtBoxValor.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(493, 143);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 39;
            label1.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top;
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(236, 143);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 38;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategorias
            // 
            lblCategorias.Anchor = AnchorStyles.Top;
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(23, 143);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 37;
            lblCategorias.Text = "Categorias:";
            // 
            // cbCategorias
            // 
            cbCategorias.Anchor = AnchorStyles.Top;
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(95, 140);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(121, 23);
            cbCategorias.TabIndex = 32;
            // 
            // txtBoxDescricao
            // 
            txtBoxDescricao.Anchor = AnchorStyles.Top;
            txtBoxDescricao.Location = new Point(303, 140);
            txtBoxDescricao.Name = "txtBoxDescricao";
            txtBoxDescricao.Size = new Size(170, 23);
            txtBoxDescricao.TabIndex = 33;
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
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAte);
            groupBox1.Controls.Add(dtpGAte);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(lblDe);
            groupBox1.Controls.Add(dtpGDe);
            groupBox1.Controls.Add(tbGVal);
            groupBox1.Controls.Add(lblVal);
            groupBox1.Controls.Add(lblDesc);
            groupBox1.Controls.Add(lblCat);
            groupBox1.Controls.Add(cbGCat);
            groupBox1.Controls.Add(tbGDesc);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 122);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtragem";
            // 
            // lblAte
            // 
            lblAte.Anchor = AnchorStyles.Top;
            lblAte.AutoSize = true;
            lblAte.Location = new Point(623, 69);
            lblAte.Name = "lblAte";
            lblAte.Size = new Size(28, 15);
            lblAte.TabIndex = 51;
            lblAte.Text = "Até:";
            // 
            // dtpGAte
            // 
            dtpGAte.Anchor = AnchorStyles.Top;
            dtpGAte.Location = new Point(657, 63);
            dtpGAte.Name = "dtpGAte";
            dtpGAte.Size = new Size(200, 23);
            dtpGAte.TabIndex = 50;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top;
            btnFiltrar.Location = new Point(790, 93);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(67, 23);
            btnFiltrar.TabIndex = 45;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblDe
            // 
            lblDe.Anchor = AnchorStyles.Top;
            lblDe.AutoSize = true;
            lblDe.Location = new Point(627, 35);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(24, 15);
            lblDe.TabIndex = 49;
            lblDe.Text = "De:";
            // 
            // dtpGDe
            // 
            dtpGDe.Anchor = AnchorStyles.Top;
            dtpGDe.Location = new Point(657, 29);
            dtpGDe.Name = "dtpGDe";
            dtpGDe.Size = new Size(200, 23);
            dtpGDe.TabIndex = 44;
            // 
            // tbGVal
            // 
            tbGVal.Anchor = AnchorStyles.Top;
            tbGVal.Location = new Point(523, 29);
            tbGVal.Name = "tbGVal";
            tbGVal.Size = new Size(80, 23);
            tbGVal.TabIndex = 43;
            // 
            // lblVal
            // 
            lblVal.Anchor = AnchorStyles.Top;
            lblVal.AutoSize = true;
            lblVal.Location = new Point(481, 32);
            lblVal.Name = "lblVal";
            lblVal.Size = new Size(36, 15);
            lblVal.TabIndex = 48;
            lblVal.Text = "Valor:";
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top;
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(224, 32);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(61, 15);
            lblDesc.TabIndex = 47;
            lblDesc.Text = "Descrição:";
            // 
            // lblCat
            // 
            lblCat.Anchor = AnchorStyles.Top;
            lblCat.AutoSize = true;
            lblCat.Location = new Point(11, 32);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(61, 15);
            lblCat.TabIndex = 46;
            lblCat.Text = "Categoria:";
            // 
            // cbGCat
            // 
            cbGCat.Anchor = AnchorStyles.Top;
            cbGCat.FormattingEnabled = true;
            cbGCat.Items.AddRange(new object[] { "", "TODOS" });
            cbGCat.Location = new Point(83, 29);
            cbGCat.Name = "cbGCat";
            cbGCat.Size = new Size(121, 23);
            cbGCat.TabIndex = 41;
            // 
            // tbGDesc
            // 
            tbGDesc.Anchor = AnchorStyles.Top;
            tbGDesc.Location = new Point(291, 29);
            tbGDesc.Name = "tbGDesc";
            tbGDesc.Size = new Size(170, 23);
            tbGDesc.TabIndex = 42;
            // 
            // FRM_Ganhos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(887, 544);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label lblAte;
        private DateTimePicker dtpGAte;
        private Button btnFiltrar;
        private Label lblDe;
        private DateTimePicker dtpGDe;
        private TextBox tbGVal;
        private Label lblVal;
        private Label lblDesc;
        private Label lblCat;
        private ComboBox cbGCat;
        private TextBox tbGDesc;
    }
}
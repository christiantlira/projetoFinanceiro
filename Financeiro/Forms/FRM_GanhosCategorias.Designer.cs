namespace Financeiro.Forms
{
    partial class FRM_GanhosCategorias
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
            lista = new ListView();
            btnCadastrar = new Button();
            lblCor = new Label();
            cbCor = new ComboBox();
            tbCategoria = new TextBox();
            lblCategoria = new Label();
            cbSalario = new CheckBox();
            cmsBotaoDireito = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            cmsBotaoDireito.SuspendLayout();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.Location = new Point(11, 41);
            lista.Name = "lista";
            lista.Size = new Size(699, 243);
            lista.TabIndex = 14;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top;
            btnCadastrar.Location = new Point(636, 12);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCor
            // 
            lblCor.Anchor = AnchorStyles.Top;
            lblCor.AutoSize = true;
            lblCor.Location = new Point(464, 15);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(29, 15);
            lblCor.TabIndex = 13;
            lblCor.Text = "Cor:";
            // 
            // cbCor
            // 
            cbCor.Anchor = AnchorStyles.Top;
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(499, 12);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(121, 23);
            cbCor.TabIndex = 2;
            // 
            // tbCategoria
            // 
            tbCategoria.Anchor = AnchorStyles.Top;
            tbCategoria.Location = new Point(78, 12);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(313, 23);
            tbCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(11, 15);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // cbSalario
            // 
            cbSalario.Anchor = AnchorStyles.Top;
            cbSalario.AutoSize = true;
            cbSalario.Location = new Point(397, 14);
            cbSalario.Name = "cbSalario";
            cbSalario.Size = new Size(61, 19);
            cbSalario.TabIndex = 1;
            cbSalario.Text = "Salário";
            cbSalario.UseVisualStyleBackColor = true;
            // 
            // cmsBotaoDireito
            // 
            cmsBotaoDireito.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem });
            cmsBotaoDireito.Name = "cmsBotaoDireito";
            cmsBotaoDireito.Size = new Size(105, 26);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Image = Properties.Resources.Editar;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(104, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // FRM_CategoriasGanhos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 297);
            Controls.Add(cbSalario);
            Controls.Add(lista);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCor);
            Controls.Add(cbCor);
            Controls.Add(tbCategoria);
            Controls.Add(lblCategoria);
            Name = "FRM_CategoriasGanhos";
            Text = "FRM_CategoriasGanhos";
            Load += FRM_CategoriasGanhos_Load;
            cmsBotaoDireito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lista;
        private Button btnCadastrar;
        private Label lblCor;
        private ComboBox cbCor;
        private TextBox tbCategoria;
        private Label lblCategoria;
        private CheckBox cbSalario;
        private ContextMenuStrip cmsBotaoDireito;
        private ToolStripMenuItem editarToolStripMenuItem;
    }
}
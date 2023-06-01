namespace Financeiro.Forms
{
    partial class FRM_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Categorias));
            lblCategoria = new Label();
            tbCategoria = new TextBox();
            cbCor = new ComboBox();
            lblCor = new Label();
            btnCadastrar = new Button();
            lista = new ListView();
            cmsBotaoDireito = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            cbEssencial = new ComboBox();
            label1 = new Label();
            cmsBotaoDireito.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 16);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria:";
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(79, 13);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(161, 23);
            tbCategoria.TabIndex = 0;
            // 
            // cbCor
            // 
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(500, 13);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(121, 23);
            cbCor.TabIndex = 2;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(465, 16);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(29, 15);
            lblCor.TabIndex = 3;
            lblCor.Text = "Cor:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(637, 13);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lista
            // 
            lista.Location = new Point(12, 42);
            lista.Name = "lista";
            lista.Size = new Size(699, 243);
            lista.TabIndex = 5;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            lista.MouseClick += lista_MouseClick_1;
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
            // cbEssencial
            // 
            cbEssencial.FormattingEnabled = true;
            cbEssencial.Location = new Point(338, 13);
            cbEssencial.Name = "cbEssencial";
            cbEssencial.Size = new Size(121, 23);
            cbEssencial.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 17);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 7;
            label1.Text = "Essencialidade:";
            // 
            // FRM_Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 297);
            Controls.Add(label1);
            Controls.Add(cbEssencial);
            Controls.Add(lista);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCor);
            Controls.Add(cbCor);
            Controls.Add(tbCategoria);
            Controls.Add(lblCategoria);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_Categorias";
            Text = "Categorias";
            Load += FRM_Categorias_Load;
            cmsBotaoDireito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private TextBox tbCategoria;
        private ComboBox cbCor;
        private Label lblCor;
        private Button btnCadastrar;
        private ListView lista;
        private ContextMenuStrip cmsBotaoDireito;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ComboBox cbEssencial;
        private Label label1;
    }
}
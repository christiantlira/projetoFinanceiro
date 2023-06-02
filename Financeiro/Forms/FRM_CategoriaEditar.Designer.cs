namespace Financeiro.Forms
{
    partial class FRM_CategoriaEditar
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
            label1 = new Label();
            cbEssencial = new ComboBox();
            btnAtualizar = new Button();
            lblCor = new Label();
            cbCor = new ComboBox();
            tbCategoria = new TextBox();
            lblCategoria = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(246, 10);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 14;
            label1.Text = "Essencialidade:";
            // 
            // cbEssencial
            // 
            cbEssencial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbEssencial.FormattingEnabled = true;
            cbEssencial.Location = new Point(338, 6);
            cbEssencial.Name = "cbEssencial";
            cbEssencial.Size = new Size(121, 23);
            cbEssencial.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.Location = new Point(635, 6);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblCor
            // 
            lblCor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCor.AutoSize = true;
            lblCor.Location = new Point(465, 9);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(29, 15);
            lblCor.TabIndex = 13;
            lblCor.Text = "Cor:";
            // 
            // cbCor
            // 
            cbCor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(500, 6);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(121, 23);
            cbCor.TabIndex = 2;
            // 
            // tbCategoria
            // 
            tbCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCategoria.Location = new Point(79, 6);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(161, 23);
            tbCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // FRM_EditarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 35);
            Controls.Add(label1);
            Controls.Add(cbEssencial);
            Controls.Add(btnAtualizar);
            Controls.Add(lblCor);
            Controls.Add(cbCor);
            Controls.Add(tbCategoria);
            Controls.Add(lblCategoria);
            Name = "FRM_EditarCategoria";
            Text = "FRM_EditarCategoria";
            Load += FRM_EditarCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbEssencial;
        private Button btnAtualizar;
        private Label lblCor;
        private ComboBox cbCor;
        private TextBox tbCategoria;
        private Label lblCategoria;
    }
}
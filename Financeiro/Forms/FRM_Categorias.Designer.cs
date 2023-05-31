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
            lblCategoria = new Label();
            tbCategoria = new TextBox();
            cbCor = new ComboBox();
            lblCor = new Label();
            btnCadastrar = new Button();
            lista = new ListView();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria:";
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(79, 6);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(380, 23);
            tbCategoria.TabIndex = 0;
            // 
            // cbCor
            // 
            cbCor.FormattingEnabled = true;
            cbCor.Location = new Point(500, 6);
            cbCor.Name = "cbCor";
            cbCor.Size = new Size(121, 23);
            cbCor.TabIndex = 1;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(465, 9);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(29, 15);
            lblCor.TabIndex = 3;
            lblCor.Text = "Cor:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(637, 6);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lista
            // 
            lista.Location = new Point(12, 35);
            lista.Name = "lista";
            lista.Size = new Size(699, 163);
            lista.TabIndex = 5;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // FRM_Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 210);
            Controls.Add(lista);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCor);
            Controls.Add(cbCor);
            Controls.Add(tbCategoria);
            Controls.Add(lblCategoria);
            Name = "FRM_Categorias";
            Text = "Categorias";
            Load += FRM_Categorias_Load;
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
    }
}
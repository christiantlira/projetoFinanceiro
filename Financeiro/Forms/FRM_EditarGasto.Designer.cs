namespace Financeiro.Forms
{
    partial class FRM_EditarGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditarGasto));
            btnAtualizar = new Button();
            label2 = new Label();
            dtpData = new DateTimePicker();
            tbValor = new TextBox();
            label1 = new Label();
            lblDescricao = new Label();
            lblCategorias = new Label();
            cbCategorias = new ComboBox();
            tbDescricao = new TextBox();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(830, 12);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 15);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 18;
            label2.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(620, 12);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 13;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(492, 12);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(80, 23);
            tbValor.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 15);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 17;
            label1.Text = "Valor:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(207, 15);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 16;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(8, 15);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(66, 15);
            lblCategorias.TabIndex = 15;
            lblCategorias.Text = "Categorias:";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(80, 12);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(121, 23);
            cbCategorias.TabIndex = 10;
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(274, 12);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(170, 23);
            tbDescricao.TabIndex = 11;
            // 
            // FRM_EditarGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 48);
            Controls.Add(btnAtualizar);
            Controls.Add(label2);
            Controls.Add(dtpData);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategorias);
            Controls.Add(cbCategorias);
            Controls.Add(tbDescricao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_EditarGasto";
            Text = "FRM_EditarGasto";
            Load += FRM_EditarGasto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtualizar;
        private Label label2;
        private DateTimePicker dtpData;
        private TextBox tbValor;
        private Label label1;
        private Label lblDescricao;
        private Label lblCategorias;
        private ComboBox cbCategorias;
        private TextBox tbDescricao;
    }
}
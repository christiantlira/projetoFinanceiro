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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnInformacoes = new Button();
            btnGastos = new Button();
            btnGanhos = new Button();
            btnGeral = new Button();
            SuspendLayout();
            // 
            // btnInformacoes
            // 
            btnInformacoes.BackColor = Color.FromArgb(80, 168, 37);
            btnInformacoes.Location = new Point(303, 34);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(106, 43);
            btnInformacoes.TabIndex = 0;
            btnInformacoes.TabStop = false;
            btnInformacoes.Text = "REGISTRAR INFORMAÇÕES";
            btnInformacoes.UseVisualStyleBackColor = false;
            // 
            // btnGastos
            // 
            btnGastos.BackColor = Color.FromArgb(80, 168, 37);
            btnGastos.Location = new Point(12, 12);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(91, 89);
            btnGastos.TabIndex = 3;
            btnGastos.TabStop = false;
            btnGastos.Text = "GASTOS";
            btnGastos.UseVisualStyleBackColor = false;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnGanhos
            // 
            btnGanhos.BackColor = Color.FromArgb(80, 168, 37);
            btnGanhos.Location = new Point(109, 12);
            btnGanhos.Name = "btnGanhos";
            btnGanhos.Size = new Size(91, 89);
            btnGanhos.TabIndex = 4;
            btnGanhos.TabStop = false;
            btnGanhos.Text = "GANHOS";
            btnGanhos.UseVisualStyleBackColor = false;
            btnGanhos.Click += btnGanhos_Click;
            // 
            // btnGeral
            // 
            btnGeral.BackColor = Color.FromArgb(80, 168, 37);
            btnGeral.Location = new Point(206, 11);
            btnGeral.Name = "btnGeral";
            btnGeral.Size = new Size(91, 89);
            btnGeral.TabIndex = 5;
            btnGeral.TabStop = false;
            btnGeral.Text = "GERAL";
            btnGeral.UseVisualStyleBackColor = false;
            btnGeral.Click += btnGeral_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 155, 207);
            ClientSize = new Size(416, 112);
            Controls.Add(btnGeral);
            Controls.Add(btnGanhos);
            Controls.Add(btnGastos);
            Controls.Add(btnInformacoes);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "Menu principal";
            TopMost = true;
            TransparencyKey = Color.Transparent;
            Load += Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInformacoes;
        private Button btnGastos;
        private Button btnGanhos;
        private Button btnGeral;
    }
}
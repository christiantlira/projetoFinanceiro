namespace Financeiro.Forms
{
    partial class FRM_Informacoes
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
            lblGastosEssenciais = new Label();
            lblGastosNaoEssenciais = new Label();
            tbGastosEssenciais = new TextBox();
            tbGastosNaoEssenciais = new TextBox();
            tbReserva = new TextBox();
            label1 = new Label();
            tbNaoEssenPMes = new TextBox();
            tbEssenPMes = new TextBox();
            lblNaoEssePMes = new Label();
            lblEssenPMes = new Label();
            SuspendLayout();
            // 
            // lblGastosEssenciais
            // 
            lblGastosEssenciais.AutoSize = true;
            lblGastosEssenciais.Location = new Point(12, 9);
            lblGastosEssenciais.Name = "lblGastosEssenciais";
            lblGastosEssenciais.Size = new Size(128, 15);
            lblGastosEssenciais.TabIndex = 0;
            lblGastosEssenciais.Text = "Gastos Essenciais Total:";
            // 
            // lblGastosNaoEssenciais
            // 
            lblGastosNaoEssenciais.AutoSize = true;
            lblGastosNaoEssenciais.Location = new Point(12, 53);
            lblGastosNaoEssenciais.Name = "lblGastosNaoEssenciais";
            lblGastosNaoEssenciais.Size = new Size(155, 15);
            lblGastosNaoEssenciais.TabIndex = 1;
            lblGastosNaoEssenciais.Text = "Gastos Não-Essenciais Total:";
            // 
            // tbGastosEssenciais
            // 
            tbGastosEssenciais.Enabled = false;
            tbGastosEssenciais.Location = new Point(12, 27);
            tbGastosEssenciais.Name = "tbGastosEssenciais";
            tbGastosEssenciais.Size = new Size(155, 23);
            tbGastosEssenciais.TabIndex = 2;
            // 
            // tbGastosNaoEssenciais
            // 
            tbGastosNaoEssenciais.Enabled = false;
            tbGastosNaoEssenciais.Location = new Point(12, 71);
            tbGastosNaoEssenciais.Name = "tbGastosNaoEssenciais";
            tbGastosNaoEssenciais.Size = new Size(155, 23);
            tbGastosNaoEssenciais.TabIndex = 3;
            // 
            // tbReserva
            // 
            tbReserva.Enabled = false;
            tbReserva.Location = new Point(99, 115);
            tbReserva.Name = "tbReserva";
            tbReserva.Size = new Size(155, 23);
            tbReserva.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 97);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 4;
            label1.Text = "Reserva de emergência ideal:";
            // 
            // tbNaoEssenPMes
            // 
            tbNaoEssenPMes.Enabled = false;
            tbNaoEssenPMes.Location = new Point(173, 71);
            tbNaoEssenPMes.Name = "tbNaoEssenPMes";
            tbNaoEssenPMes.Size = new Size(155, 23);
            tbNaoEssenPMes.TabIndex = 9;
            // 
            // tbEssenPMes
            // 
            tbEssenPMes.Enabled = false;
            tbEssenPMes.Location = new Point(173, 27);
            tbEssenPMes.Name = "tbEssenPMes";
            tbEssenPMes.Size = new Size(155, 23);
            tbEssenPMes.TabIndex = 8;
            // 
            // lblNaoEssePMes
            // 
            lblNaoEssePMes.AutoSize = true;
            lblNaoEssePMes.Location = new Point(173, 53);
            lblNaoEssePMes.Name = "lblNaoEssePMes";
            lblNaoEssePMes.Size = new Size(154, 15);
            lblNaoEssePMes.TabIndex = 7;
            lblNaoEssePMes.Text = "Gastos Não-Essenciais/mês:";
            // 
            // lblEssenPMes
            // 
            lblEssenPMes.AutoSize = true;
            lblEssenPMes.Location = new Point(173, 9);
            lblEssenPMes.Name = "lblEssenPMes";
            lblEssenPMes.Size = new Size(124, 15);
            lblEssenPMes.TabIndex = 6;
            lblEssenPMes.Text = "Gastos Essenciais/mês";
            // 
            // FRM_Informacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 150);
            Controls.Add(tbNaoEssenPMes);
            Controls.Add(tbEssenPMes);
            Controls.Add(lblNaoEssePMes);
            Controls.Add(lblEssenPMes);
            Controls.Add(tbReserva);
            Controls.Add(label1);
            Controls.Add(tbGastosNaoEssenciais);
            Controls.Add(tbGastosEssenciais);
            Controls.Add(lblGastosNaoEssenciais);
            Controls.Add(lblGastosEssenciais);
            Name = "FRM_Informacoes";
            Text = "FRM_Informacoes";
            Load += FRM_Informacoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGastosEssenciais;
        private Label lblGastosNaoEssenciais;
        private TextBox tbGastosEssenciais;
        private TextBox tbGastosNaoEssenciais;
        private TextBox tbReserva;
        private Label label1;
        private TextBox tbNaoEssenPMes;
        private TextBox tbEssenPMes;
        private Label lblNaoEssePMes;
        private Label lblEssenPMes;
    }
}
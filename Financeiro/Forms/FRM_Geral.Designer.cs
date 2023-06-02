namespace Financeiro.Forms
{
    partial class FRM_Geral
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
            btnAtualizar = new Button();
            lista = new ListView();
            tbGanho = new TextBox();
            tbGasto = new TextBox();
            tbResta = new TextBox();
            tbItens = new TextBox();
            lblGanho = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tcGanhos = new TabControl();
            tpGastos = new TabPage();
            tpGanhos = new TabPage();
            tcGanhos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizar.Location = new Point(1098, 223);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(67, 23);
            btnAtualizar.TabIndex = 58;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.Location = new Point(12, 12);
            lista.Name = "lista";
            lista.Size = new Size(877, 539);
            lista.TabIndex = 57;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // tbGanho
            // 
            tbGanho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbGanho.Enabled = false;
            tbGanho.Location = new Point(1074, 30);
            tbGanho.Name = "tbGanho";
            tbGanho.Size = new Size(100, 23);
            tbGanho.TabIndex = 59;
            // 
            // tbGasto
            // 
            tbGasto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbGasto.Enabled = false;
            tbGasto.Location = new Point(1074, 86);
            tbGasto.Name = "tbGasto";
            tbGasto.Size = new Size(100, 23);
            tbGasto.TabIndex = 60;
            // 
            // tbResta
            // 
            tbResta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbResta.Enabled = false;
            tbResta.Location = new Point(1074, 139);
            tbResta.Name = "tbResta";
            tbResta.Size = new Size(100, 23);
            tbResta.TabIndex = 61;
            // 
            // tbItens
            // 
            tbItens.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbItens.Enabled = false;
            tbItens.Location = new Point(1074, 194);
            tbItens.Name = "tbItens";
            tbItens.Size = new Size(100, 23);
            tbItens.TabIndex = 62;
            // 
            // lblGanho
            // 
            lblGanho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGanho.AutoSize = true;
            lblGanho.Location = new Point(1074, 12);
            lblGanho.Name = "lblGanho";
            lblGanho.Size = new Size(45, 15);
            lblGanho.TabIndex = 63;
            lblGanho.Text = "Ganho:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1074, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 64;
            label1.Text = "Gasto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1074, 121);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 65;
            label2.Text = "Resta:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1074, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 66;
            label3.Text = "Total de Itens:";
            // 
            // tcGanhos
            // 
            tcGanhos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tcGanhos.Controls.Add(tpGastos);
            tcGanhos.Controls.Add(tpGanhos);
            tcGanhos.Location = new Point(895, 12);
            tcGanhos.Name = "tcGanhos";
            tcGanhos.SelectedIndex = 0;
            tcGanhos.Size = new Size(166, 539);
            tcGanhos.TabIndex = 0;
            // 
            // tpGastos
            // 
            tpGastos.Location = new Point(4, 24);
            tpGastos.Name = "tpGastos";
            tpGastos.Padding = new Padding(3);
            tpGastos.Size = new Size(158, 511);
            tpGastos.TabIndex = 0;
            tpGastos.Text = "Gastos";
            tpGastos.UseVisualStyleBackColor = true;
            // 
            // tpGanhos
            // 
            tpGanhos.Location = new Point(4, 24);
            tpGanhos.Name = "tpGanhos";
            tpGanhos.Padding = new Padding(3);
            tpGanhos.Size = new Size(158, 511);
            tpGanhos.TabIndex = 1;
            tpGanhos.Text = "Ganhos";
            tpGanhos.UseVisualStyleBackColor = true;
            // 
            // FRM_Geral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 563);
            Controls.Add(tcGanhos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGanho);
            Controls.Add(tbItens);
            Controls.Add(tbResta);
            Controls.Add(tbGasto);
            Controls.Add(tbGanho);
            Controls.Add(btnAtualizar);
            Controls.Add(lista);
            Name = "FRM_Geral";
            Text = "FRM_Geral";
            Load += FRM_Geral_Load;
            tcGanhos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtualizar;
        private ListView lista;
        private TextBox tbGanho;
        private TextBox tbGasto;
        private TextBox tbResta;
        private TextBox tbItens;
        private Label lblGanho;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tcGanhos;
        private TabPage tpGastos;
        private TabPage tpGanhos;
    }
}
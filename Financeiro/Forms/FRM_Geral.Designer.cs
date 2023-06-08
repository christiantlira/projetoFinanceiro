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
            btnFiltrar = new Button();
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
            vScrollBar1 = new VScrollBar();
            tpGanhos = new TabPage();
            vScrollBar2 = new VScrollBar();
            dtpDe = new DateTimePicker();
            dtpAte = new DateTimePicker();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbNaoEssenciais = new TextBox();
            tbEssenciais = new TextBox();
            tcGanhos.SuspendLayout();
            tpGastos.SuspendLayout();
            tpGanhos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(169, 85);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(67, 23);
            btnFiltrar.TabIndex = 58;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnAtualizar_Click;
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.Location = new Point(12, 139);
            lista.Name = "lista";
            lista.Size = new Size(879, 412);
            lista.TabIndex = 57;
            lista.TabStop = false;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // tbGanho
            // 
            tbGanho.Enabled = false;
            tbGanho.Location = new Point(275, 40);
            tbGanho.Name = "tbGanho";
            tbGanho.Size = new Size(100, 23);
            tbGanho.TabIndex = 59;
            // 
            // tbGasto
            // 
            tbGasto.Enabled = false;
            tbGasto.Location = new Point(275, 100);
            tbGasto.Name = "tbGasto";
            tbGasto.Size = new Size(100, 23);
            tbGasto.TabIndex = 60;
            // 
            // tbResta
            // 
            tbResta.Enabled = false;
            tbResta.Location = new Point(487, 40);
            tbResta.Name = "tbResta";
            tbResta.Size = new Size(100, 23);
            tbResta.TabIndex = 61;
            // 
            // tbItens
            // 
            tbItens.Enabled = false;
            tbItens.Location = new Point(487, 101);
            tbItens.Name = "tbItens";
            tbItens.Size = new Size(100, 23);
            tbItens.TabIndex = 62;
            // 
            // lblGanho
            // 
            lblGanho.AutoSize = true;
            lblGanho.Location = new Point(275, 22);
            lblGanho.Name = "lblGanho";
            lblGanho.Size = new Size(45, 15);
            lblGanho.TabIndex = 63;
            lblGanho.Text = "Ganho:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 82);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 64;
            label1.Text = "Gasto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 22);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 65;
            label2.Text = "Resta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 83);
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
            tcGanhos.Location = new Point(897, 114);
            tcGanhos.Name = "tcGanhos";
            tcGanhos.SelectedIndex = 0;
            tcGanhos.Size = new Size(166, 437);
            tcGanhos.TabIndex = 0;
            // 
            // tpGastos
            // 
            tpGastos.Controls.Add(vScrollBar1);
            tpGastos.Location = new Point(4, 24);
            tpGastos.Name = "tpGastos";
            tpGastos.Padding = new Padding(3);
            tpGastos.Size = new Size(158, 409);
            tpGastos.TabIndex = 0;
            tpGastos.Text = "Gastos";
            tpGastos.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vScrollBar1.Location = new Point(141, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 508);
            vScrollBar1.TabIndex = 0;
            // 
            // tpGanhos
            // 
            tpGanhos.Controls.Add(vScrollBar2);
            tpGanhos.Location = new Point(4, 24);
            tpGanhos.Name = "tpGanhos";
            tpGanhos.Padding = new Padding(3);
            tpGanhos.Size = new Size(158, 384);
            tpGanhos.TabIndex = 1;
            tpGanhos.Text = "Ganhos";
            tpGanhos.UseVisualStyleBackColor = true;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            vScrollBar2.Location = new Point(141, 0);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 508);
            vScrollBar2.TabIndex = 1;
            // 
            // dtpDe
            // 
            dtpDe.Location = new Point(36, 22);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(200, 23);
            dtpDe.TabIndex = 67;
            // 
            // dtpAte
            // 
            dtpAte.Location = new Point(36, 56);
            dtpAte.Name = "dtpAte";
            dtpAte.Size = new Size(200, 23);
            dtpAte.TabIndex = 68;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpDe);
            groupBox1.Controls.Add(dtpAte);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 114);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtragem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 71;
            label5.Text = "Até:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 70;
            label4.Text = "De:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 82);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 73;
            label6.Text = "Não Essenciais";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 22);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 72;
            label7.Text = "Essenciais";
            // 
            // tbNaoEssenciais
            // 
            tbNaoEssenciais.Enabled = false;
            tbNaoEssenciais.Location = new Point(381, 100);
            tbNaoEssenciais.Name = "tbNaoEssenciais";
            tbNaoEssenciais.Size = new Size(100, 23);
            tbNaoEssenciais.TabIndex = 71;
            // 
            // tbEssenciais
            // 
            tbEssenciais.Enabled = false;
            tbEssenciais.Location = new Point(381, 40);
            tbEssenciais.Name = "tbEssenciais";
            tbEssenciais.Size = new Size(100, 23);
            tbEssenciais.TabIndex = 70;
            // 
            // FRM_Geral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 563);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(tbNaoEssenciais);
            Controls.Add(tbEssenciais);
            Controls.Add(groupBox1);
            Controls.Add(tcGanhos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGanho);
            Controls.Add(tbItens);
            Controls.Add(tbResta);
            Controls.Add(tbGasto);
            Controls.Add(tbGanho);
            Controls.Add(lista);
            Name = "FRM_Geral";
            Text = "FRM_Geral";
            Load += FRM_Geral_Load;
            tcGanhos.ResumeLayout(false);
            tpGastos.ResumeLayout(false);
            tpGanhos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
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
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private DateTimePicker dtpDe;
        private DateTimePicker dtpAte;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox tbNaoEssenciais;
        private TextBox tbEssenciais;
    }
}
namespace jogo_da_velha_c_sharp_murilo_nata_nogueira
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.campo1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.campo2 = new System.Windows.Forms.Button();
            this.campo3 = new System.Windows.Forms.Button();
            this.campo4 = new System.Windows.Forms.Button();
            this.campo5 = new System.Windows.Forms.Button();
            this.campo6 = new System.Windows.Forms.Button();
            this.campo7 = new System.Windows.Forms.Button();
            this.campo8 = new System.Windows.Forms.Button();
            this.campo9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.figuraAtual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.textPontoX = new System.Windows.Forms.Label();
            this.textPontoO = new System.Windows.Forms.Label();
            this.textEmpates = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // campo1
            // 
            this.campo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo1.Location = new System.Drawing.Point(3, 3);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(164, 131);
            this.campo1.TabIndex = 0;
            this.campo1.UseVisualStyleBackColor = true;
            this.campo1.Click += new System.EventHandler(this.campo1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.campo1);
            this.flowLayoutPanel1.Controls.Add(this.campo2);
            this.flowLayoutPanel1.Controls.Add(this.campo3);
            this.flowLayoutPanel1.Controls.Add(this.campo4);
            this.flowLayoutPanel1.Controls.Add(this.campo5);
            this.flowLayoutPanel1.Controls.Add(this.campo6);
            this.flowLayoutPanel1.Controls.Add(this.campo7);
            this.flowLayoutPanel1.Controls.Add(this.campo8);
            this.flowLayoutPanel1.Controls.Add(this.campo9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(193, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 410);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // campo2
            // 
            this.campo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo2.Location = new System.Drawing.Point(173, 3);
            this.campo2.Name = "campo2";
            this.campo2.Size = new System.Drawing.Size(164, 131);
            this.campo2.TabIndex = 1;
            this.campo2.UseVisualStyleBackColor = true;
            this.campo2.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo3
            // 
            this.campo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo3.Location = new System.Drawing.Point(343, 3);
            this.campo3.Name = "campo3";
            this.campo3.Size = new System.Drawing.Size(164, 131);
            this.campo3.TabIndex = 2;
            this.campo3.UseVisualStyleBackColor = true;
            this.campo3.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo4
            // 
            this.campo4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo4.Location = new System.Drawing.Point(3, 140);
            this.campo4.Name = "campo4";
            this.campo4.Size = new System.Drawing.Size(164, 131);
            this.campo4.TabIndex = 3;
            this.campo4.UseVisualStyleBackColor = true;
            this.campo4.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo5
            // 
            this.campo5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo5.Location = new System.Drawing.Point(173, 140);
            this.campo5.Name = "campo5";
            this.campo5.Size = new System.Drawing.Size(164, 131);
            this.campo5.TabIndex = 4;
            this.campo5.UseVisualStyleBackColor = true;
            this.campo5.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo6
            // 
            this.campo6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo6.Location = new System.Drawing.Point(343, 140);
            this.campo6.Name = "campo6";
            this.campo6.Size = new System.Drawing.Size(164, 131);
            this.campo6.TabIndex = 5;
            this.campo6.UseVisualStyleBackColor = true;
            this.campo6.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo7
            // 
            this.campo7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo7.Location = new System.Drawing.Point(3, 277);
            this.campo7.Name = "campo7";
            this.campo7.Size = new System.Drawing.Size(164, 131);
            this.campo7.TabIndex = 6;
            this.campo7.UseVisualStyleBackColor = true;
            this.campo7.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo8
            // 
            this.campo8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo8.Location = new System.Drawing.Point(173, 277);
            this.campo8.Name = "campo8";
            this.campo8.Size = new System.Drawing.Size(164, 131);
            this.campo8.TabIndex = 7;
            this.campo8.UseVisualStyleBackColor = true;
            this.campo8.Click += new System.EventHandler(this.campo1_Click);
            // 
            // campo9
            // 
            this.campo9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campo9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.campo9.Location = new System.Drawing.Point(343, 277);
            this.campo9.Name = "campo9";
            this.campo9.Size = new System.Drawing.Size(164, 131);
            this.campo9.TabIndex = 8;
            this.campo9.UseVisualStyleBackColor = true;
            this.campo9.Click += new System.EventHandler(this.campo1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.figuraAtual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 439);
            this.panel1.TabIndex = 2;
            // 
            // figuraAtual
            // 
            this.figuraAtual.AutoSize = true;
            this.figuraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figuraAtual.Location = new System.Drawing.Point(25, 221);
            this.figuraAtual.Name = "figuraAtual";
            this.figuraAtual.Size = new System.Drawing.Size(138, 135);
            this.figuraAtual.TabIndex = 3;
            this.figuraAtual.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jogador:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textEmpates);
            this.panel2.Controls.Add(this.textPontoO);
            this.panel2.Controls.Add(this.textPontoX);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(724, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 439);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vitórias jogador 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status do jogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vitórias jogador 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Empates:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(191, 474);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(515, 109);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // textPontoX
            // 
            this.textPontoX.AutoSize = true;
            this.textPontoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPontoX.Location = new System.Drawing.Point(3, 93);
            this.textPontoX.Name = "textPontoX";
            this.textPontoX.Size = new System.Drawing.Size(33, 36);
            this.textPontoX.TabIndex = 4;
            this.textPontoX.Text = "0";
            // 
            // textPontoO
            // 
            this.textPontoO.AutoSize = true;
            this.textPontoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPontoO.Location = new System.Drawing.Point(3, 209);
            this.textPontoO.Name = "textPontoO";
            this.textPontoO.Size = new System.Drawing.Size(31, 32);
            this.textPontoO.TabIndex = 5;
            this.textPontoO.Text = "0";
            // 
            // textEmpates
            // 
            this.textEmpates.AutoSize = true;
            this.textEmpates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpates.Location = new System.Drawing.Point(3, 323);
            this.textEmpates.Name = "textEmpates";
            this.textEmpates.Size = new System.Drawing.Size(33, 36);
            this.textEmpates.TabIndex = 6;
            this.textEmpates.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 595);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Jogo da Velha";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button campo1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button campo2;
        private System.Windows.Forms.Button campo3;
        private System.Windows.Forms.Button campo4;
        private System.Windows.Forms.Button campo5;
        private System.Windows.Forms.Button campo6;
        private System.Windows.Forms.Button campo7;
        private System.Windows.Forms.Button campo8;
        private System.Windows.Forms.Button campo9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label figuraAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label textPontoO;
        private System.Windows.Forms.Label textPontoX;
        private System.Windows.Forms.Label textEmpates;
    }
}


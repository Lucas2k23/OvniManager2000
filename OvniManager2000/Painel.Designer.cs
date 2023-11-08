namespace OvniManager2000
{
    partial class Painel
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
            this.GrbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbuzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnTripulante = new System.Windows.Forms.Button();
            this.btnTripulante2 = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.GrbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDados
            // 
            this.GrbDados.Controls.Add(this.lblPlaneta);
            this.GrbDados.Controls.Add(this.lblTripulantes);
            this.GrbDados.Controls.Add(this.lblAbuzidos);
            this.GrbDados.Controls.Add(this.lblSituacao);
            this.GrbDados.Location = new System.Drawing.Point(12, 12);
            this.GrbDados.Name = "GrbDados";
            this.GrbDados.Size = new System.Drawing.Size(161, 144);
            this.GrbDados.TabIndex = 0;
            this.GrbDados.TabStop = false;
            this.GrbDados.Text = "Dados";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 28);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação";
            // 
            // lblAbuzidos
            // 
            this.lblAbuzidos.AutoSize = true;
            this.lblAbuzidos.Location = new System.Drawing.Point(6, 54);
            this.lblAbuzidos.Name = "lblAbuzidos";
            this.lblAbuzidos.Size = new System.Drawing.Size(56, 13);
            this.lblAbuzidos.TabIndex = 1;
            this.lblAbuzidos.Text = "Abduzidos";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 82);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(59, 13);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(12, 156);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(161, 34);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(12, 196);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(161, 33);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnTripulante
            // 
            this.btnTripulante.Location = new System.Drawing.Point(179, 12);
            this.btnTripulante.Name = "btnTripulante";
            this.btnTripulante.Size = new System.Drawing.Size(178, 32);
            this.btnTripulante.TabIndex = 3;
            this.btnTripulante.Text = "adicionar Tripulante";
            this.btnTripulante.UseVisualStyleBackColor = true;
            this.btnTripulante.Click += new System.EventHandler(this.btnTripulante_Click);
            // 
            // btnTripulante2
            // 
            this.btnTripulante2.Location = new System.Drawing.Point(179, 50);
            this.btnTripulante2.Name = "btnTripulante2";
            this.btnTripulante2.Size = new System.Drawing.Size(178, 29);
            this.btnTripulante2.TabIndex = 4;
            this.btnTripulante2.Text = "Remover Tripulante";
            this.btnTripulante2.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Location = new System.Drawing.Point(179, 85);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(178, 31);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(6, 107);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(94, 13);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta de Origem";
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Location = new System.Drawing.Point(179, 122);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(178, 28);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(179, 156);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(178, 34);
            this.btnRetornar.TabIndex = 7;
            this.btnRetornar.Text = "Retornar a Origem";
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(179, 196);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(97, 32);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // btnMudar
            // 
            this.btnMudar.Location = new System.Drawing.Point(282, 196);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(76, 33);
            this.btnMudar.TabIndex = 9;
            this.btnMudar.Text = "Mudar";
            this.btnMudar.UseVisualStyleBackColor = true;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 237);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnTripulante2);
            this.Controls.Add(this.btnTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.GrbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.GrbDados.ResumeLayout(false);
            this.GrbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbuzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnTripulante;
        private System.Windows.Forms.Button btnTripulante2;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnMudar;
    }
}
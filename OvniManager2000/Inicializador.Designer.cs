namespace OvniManager2000
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.NudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.NudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.CmbPlaneta = new System.Windows.Forms.ComboBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ovni manager 2000";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(218, 168);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(82, 13);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Max. Abduzidos";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(215, 194);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(85, 13);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max. Tripulantes";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(206, 217);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(94, 13);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta de Origem";
            // 
            // NudAbduzidos
            // 
            this.NudAbduzidos.Location = new System.Drawing.Point(306, 161);
            this.NudAbduzidos.Name = "NudAbduzidos";
            this.NudAbduzidos.ReadOnly = true;
            this.NudAbduzidos.Size = new System.Drawing.Size(120, 20);
            this.NudAbduzidos.TabIndex = 5;
            // 
            // NudTripulantes
            // 
            this.NudTripulantes.Location = new System.Drawing.Point(307, 187);
            this.NudTripulantes.Name = "NudTripulantes";
            this.NudTripulantes.ReadOnly = true;
            this.NudTripulantes.Size = new System.Drawing.Size(120, 20);
            this.NudTripulantes.TabIndex = 6;
            // 
            // CmbPlaneta
            // 
            this.CmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPlaneta.FormattingEnabled = true;
            this.CmbPlaneta.Location = new System.Drawing.Point(306, 214);
            this.CmbPlaneta.Name = "CmbPlaneta";
            this.CmbPlaneta.Size = new System.Drawing.Size(121, 21);
            this.CmbPlaneta.TabIndex = 7;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(221, 267);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(151, 43);
            this.BtnIniciar.TabIndex = 8;
            this.BtnIniciar.Text = "INICIAR";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OvniManager2000.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 334);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.CmbPlaneta);
            this.Controls.Add(this.NudTripulantes);
            this.Controls.Add(this.NudAbduzidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Activated += new System.EventHandler(this.Inicializador_Activated);
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NudAbduzidos;
        private System.Windows.Forms.NumericUpDown NudTripulantes;
        private System.Windows.Forms.ComboBox CmbPlaneta;
        private System.Windows.Forms.Button BtnIniciar;
    }
}
namespace Validador_AFD
{
    partial class LoadForm
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
            this.bProgresso = new System.Windows.Forms.ProgressBar();
            this.lbLoad = new System.Windows.Forms.Label();
            this.lbLendo = new System.Windows.Forms.Label();
            this.lbLinhaAtual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotLinhas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bProgresso
            // 
            this.bProgresso.Location = new System.Drawing.Point(12, 117);
            this.bProgresso.Name = "bProgresso";
            this.bProgresso.Size = new System.Drawing.Size(457, 23);
            this.bProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.bProgresso.TabIndex = 0;
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.Location = new System.Drawing.Point(161, 29);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(154, 13);
            this.lbLoad.TabIndex = 1;
            this.lbLoad.Text = "Aguarde. Carregando arquivos.";
            // 
            // lbLendo
            // 
            this.lbLendo.AutoSize = true;
            this.lbLendo.Location = new System.Drawing.Point(125, 72);
            this.lbLendo.Name = "lbLendo";
            this.lbLendo.Size = new System.Drawing.Size(62, 13);
            this.lbLendo.TabIndex = 1;
            this.lbLendo.Text = "Lendo linha";
            // 
            // lbLinhaAtual
            // 
            this.lbLinhaAtual.AutoSize = true;
            this.lbLinhaAtual.ForeColor = System.Drawing.Color.Maroon;
            this.lbLinhaAtual.Location = new System.Drawing.Point(193, 72);
            this.lbLinhaAtual.Name = "lbLinhaAtual";
            this.lbLinhaAtual.Size = new System.Drawing.Size(62, 13);
            this.lbLinhaAtual.TabIndex = 1;
            this.lbLinhaAtual.Text = "Lendo linha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "de";
            // 
            // lbTotLinhas
            // 
            this.lbTotLinhas.AutoSize = true;
            this.lbTotLinhas.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotLinhas.Location = new System.Drawing.Point(286, 72);
            this.lbTotLinhas.Name = "lbTotLinhas";
            this.lbTotLinhas.Size = new System.Drawing.Size(62, 13);
            this.lbTotLinhas.TabIndex = 1;
            this.lbTotLinhas.Text = "Lendo linha";
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 152);
            this.ControlBox = false;
            this.Controls.Add(this.lbTotLinhas);
            this.Controls.Add(this.lbLinhaAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLendo);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.bProgresso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLoad;
        public System.Windows.Forms.ProgressBar bProgresso;
        private System.Windows.Forms.Label lbLendo;
        public System.Windows.Forms.Label lbLinhaAtual;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbTotLinhas;
    }
}
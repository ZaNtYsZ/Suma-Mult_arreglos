namespace Ejercicio_1
{
    partial class PrincipalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstResultadoSuma;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label lblPrimerDado;
        private System.Windows.Forms.Label lblSegundoDado;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.lstResultadoSuma = new System.Windows.Forms.ListBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lblPrimerDado = new System.Windows.Forms.Label();
            this.lblSegundoDado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstResultadoSuma
            // 
            this.lstResultadoSuma.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstResultadoSuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstResultadoSuma.FormattingEnabled = true;
            this.lstResultadoSuma.Location = new System.Drawing.Point(163, 12);
            this.lstResultadoSuma.Name = "lstResultadoSuma";
            this.lstResultadoSuma.Size = new System.Drawing.Size(222, 212);
            this.lstResultadoSuma.TabIndex = 1;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Image = ((System.Drawing.Image)(resources.GetObject("btnLanzar.Image")));
            this.btnLanzar.Location = new System.Drawing.Point(12, 33);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(101, 57);
            this.btnLanzar.TabIndex = 2;
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // lblPrimerDado
            // 
            this.lblPrimerDado.AutoSize = true;
            this.lblPrimerDado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerDado.Location = new System.Drawing.Point(9, 116);
            this.lblPrimerDado.Name = "lblPrimerDado";
            this.lblPrimerDado.Size = new System.Drawing.Size(98, 15);
            this.lblPrimerDado.TabIndex = 3;
            this.lblPrimerDado.Text = "Primer dado: ";
            // 
            // lblSegundoDado
            // 
            this.lblSegundoDado.AutoSize = true;
            this.lblSegundoDado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoDado.Location = new System.Drawing.Point(8, 158);
            this.lblSegundoDado.Name = "lblSegundoDado";
            this.lblSegundoDado.Size = new System.Drawing.Size(105, 15);
            this.lblSegundoDado.TabIndex = 4;
            this.lblSegundoDado.Text = "Segundo dado: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(9, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(127, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Suma de dados: ";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tirar Dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrincipalForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundoDado);
            this.Controls.Add(this.lblPrimerDado);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstResultadoSuma);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.Text = "Lanzador  de Dados";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
namespace Balburdia
{
    partial class Form1
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
            this.labelNomes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonAddNome = new System.Windows.Forms.Button();
            this.buttonBaralhar = new System.Windows.Forms.Button();
            this.numericUpDownIteracoes = new System.Windows.Forms.NumericUpDown();
            this.listBoxBalburdia = new System.Windows.Forms.ListBox();
            this.labelBalburdia = new System.Windows.Forms.Label();
            this.buttonAddValues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteracoes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomes
            // 
            this.labelNomes.AutoSize = true;
            this.labelNomes.Location = new System.Drawing.Point(12, 9);
            this.labelNomes.Name = "labelNomes";
            this.labelNomes.Size = new System.Drawing.Size(40, 13);
            this.labelNomes.TabIndex = 0;
            this.labelNomes.Text = "Nomes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de iterações";
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.Location = new System.Drawing.Point(12, 25);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(198, 251);
            this.listBoxNomes.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 294);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(123, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // buttonAddNome
            // 
            this.buttonAddNome.Location = new System.Drawing.Point(135, 292);
            this.buttonAddNome.Name = "buttonAddNome";
            this.buttonAddNome.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNome.TabIndex = 4;
            this.buttonAddNome.Text = "Adicionar";
            this.buttonAddNome.UseVisualStyleBackColor = true;
            this.buttonAddNome.Click += new System.EventHandler(this.buttonAddNome_Click);
            // 
            // buttonBaralhar
            // 
            this.buttonBaralhar.Location = new System.Drawing.Point(216, 178);
            this.buttonBaralhar.Name = "buttonBaralhar";
            this.buttonBaralhar.Size = new System.Drawing.Size(184, 82);
            this.buttonBaralhar.TabIndex = 5;
            this.buttonBaralhar.Text = "Baralhar >>";
            this.buttonBaralhar.UseVisualStyleBackColor = true;
            this.buttonBaralhar.Click += new System.EventHandler(this.buttonBaralhar_Click);
            // 
            // numericUpDownIteracoes
            // 
            this.numericUpDownIteracoes.Location = new System.Drawing.Point(216, 152);
            this.numericUpDownIteracoes.Name = "numericUpDownIteracoes";
            this.numericUpDownIteracoes.Size = new System.Drawing.Size(184, 20);
            this.numericUpDownIteracoes.TabIndex = 6;
            // 
            // listBoxBalburdia
            // 
            this.listBoxBalburdia.FormattingEnabled = true;
            this.listBoxBalburdia.Location = new System.Drawing.Point(406, 25);
            this.listBoxBalburdia.Name = "listBoxBalburdia";
            this.listBoxBalburdia.Size = new System.Drawing.Size(382, 251);
            this.listBoxBalburdia.TabIndex = 7;
            // 
            // labelBalburdia
            // 
            this.labelBalburdia.AutoSize = true;
            this.labelBalburdia.Location = new System.Drawing.Point(403, 9);
            this.labelBalburdia.Name = "labelBalburdia";
            this.labelBalburdia.Size = new System.Drawing.Size(51, 13);
            this.labelBalburdia.TabIndex = 8;
            this.labelBalburdia.Text = "Balburdia";
            // 
            // buttonAddValues
            // 
            this.buttonAddValues.Location = new System.Drawing.Point(406, 290);
            this.buttonAddValues.Name = "buttonAddValues";
            this.buttonAddValues.Size = new System.Drawing.Size(382, 23);
            this.buttonAddValues.TabIndex = 9;
            this.buttonAddValues.Text = "Dar Valores";
            this.buttonAddValues.UseVisualStyleBackColor = true;
            this.buttonAddValues.Click += new System.EventHandler(this.buttonAddValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddValues);
            this.Controls.Add(this.labelBalburdia);
            this.Controls.Add(this.listBoxBalburdia);
            this.Controls.Add(this.numericUpDownIteracoes);
            this.Controls.Add(this.buttonBaralhar);
            this.Controls.Add(this.buttonAddNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listBoxNomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteracoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonAddNome;
        private System.Windows.Forms.Button buttonBaralhar;
        private System.Windows.Forms.NumericUpDown numericUpDownIteracoes;
        private System.Windows.Forms.ListBox listBoxBalburdia;
        private System.Windows.Forms.Label labelBalburdia;
        private System.Windows.Forms.Button buttonAddValues;
    }
}


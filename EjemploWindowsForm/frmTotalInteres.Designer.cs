namespace EjemploWindowsForm
{
    partial class frmTotalInteres
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
            this.txtCapital = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCapital
            // 
            this.txtCapital.AutoSize = true;
            this.txtCapital.Location = new System.Drawing.Point(43, 42);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(44, 15);
            this.txtCapital.TabIndex = 0;
            this.txtCapital.Text = "Capital";
            // 
            // txtRazon
            // 
            this.txtRazon.AutoSize = true;
            this.txtRazon.Location = new System.Drawing.Point(43, 81);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(55, 15);
            this.txtRazon.TabIndex = 1;
            this.txtRazon.Text = "Inversion";
            // 
            // txtTiempo
            // 
            this.txtTiempo.AutoSize = true;
            this.txtTiempo.Location = new System.Drawing.Point(43, 126);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(47, 15);
            this.txtTiempo.TabIndex = 2;
            this.txtTiempo.Text = "Tiempo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 23);
            this.textBox3.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(346, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmTotalInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 295);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.txtCapital);
            this.Name = "frmTotalInteres";
            this.Text = "frmTotalInteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtCapital;
        private Label txtRazon;
        private Label txtTiempo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnCalcular;
    }
}
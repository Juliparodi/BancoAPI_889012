namespace BancoAPIConsole
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
            this.btnApiClientes = new System.Windows.Forms.Button();
            this.btnAPICuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApiClientes
            // 
            this.btnApiClientes.Location = new System.Drawing.Point(441, 283);
            this.btnApiClientes.Name = "btnApiClientes";
            this.btnApiClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnApiClientes.Size = new System.Drawing.Size(119, 61);
            this.btnApiClientes.TabIndex = 1;
            this.btnApiClientes.Text = "API Clientes";
            this.btnApiClientes.UseVisualStyleBackColor = true;
            this.btnApiClientes.Click += new System.EventHandler(this.btnAPIClientes_Click);
            // 
            // btnAPICuentas
            // 
            this.btnAPICuentas.Location = new System.Drawing.Point(147, 283);
            this.btnAPICuentas.Name = "btnAPICuentas";
            this.btnAPICuentas.Size = new System.Drawing.Size(123, 61);
            this.btnAPICuentas.TabIndex = 2;
            this.btnAPICuentas.Text = "API Cuentas";
            this.btnAPICuentas.UseVisualStyleBackColor = true;
            this.btnAPICuentas.Click += new System.EventHandler(this.btnAPICuentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAPICuentas);
            this.Controls.Add(this.btnApiClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApiClientes;
        private System.Windows.Forms.Button btnAPICuentas;
    }
}


namespace BancoAPIConsole
{
    partial class ApiCuentas
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
            this.cmbClientesCtasActivas = new System.Windows.Forms.ComboBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnClientesCtasActivas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbClientesCtasActivas
            // 
            this.cmbClientesCtasActivas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesCtasActivas.FormattingEnabled = true;
            this.cmbClientesCtasActivas.Location = new System.Drawing.Point(33, 85);
            this.cmbClientesCtasActivas.Name = "cmbClientesCtasActivas";
            this.cmbClientesCtasActivas.Size = new System.Drawing.Size(121, 21);
            this.cmbClientesCtasActivas.TabIndex = 0;
            this.cmbClientesCtasActivas.SelectedIndexChanged += new System.EventHandler(this.cmbClientesCtasActivas_SelectedIndexChanged);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(89, 23);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(35, 13);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "label1";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "saldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "idCliente";
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Location = new System.Drawing.Point(109, 150);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(98, 20);
            this.txtNroCuenta.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 213);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(109, 260);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 10;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(109, 318);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(100, 20);
            this.txtActivo.TabIndex = 11;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(109, 368);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 12;
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Location = new System.Drawing.Point(109, 415);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarCuenta.TabIndex = 13;
            this.btnAgregarCuenta.Text = "Agregar cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // btnClientesCtasActivas
            // 
            this.btnClientesCtasActivas.Location = new System.Drawing.Point(245, 415);
            this.btnClientesCtasActivas.Name = "btnClientesCtasActivas";
            this.btnClientesCtasActivas.Size = new System.Drawing.Size(147, 23);
            this.btnClientesCtasActivas.TabIndex = 14;
            this.btnClientesCtasActivas.Text = "Filtrar Clientes Ctas Activas";
            this.btnClientesCtasActivas.UseVisualStyleBackColor = true;
            this.btnClientesCtasActivas.Click += new System.EventHandler(this.btnClientesCtasActivas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(449, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ApiCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnClientesCtasActivas);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNroCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.cmbClientesCtasActivas);
            this.Name = "ApiCuentas";
            this.Text = "ApiCuentas";
            this.Load += new System.EventHandler(this.ApiCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientesCtasActivas;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroCuenta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnClientesCtasActivas;
        private System.Windows.Forms.Button btnVolver;
    }
}
namespace BancoAPIConsole
{
    partial class APIClientes
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.traerTodos = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnTraerXTelefono = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(12, 69);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(218, 264);
            this.lstClientes.TabIndex = 0;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(535, 299);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar cliente";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(375, 299);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(37, 357);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(359, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(359, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(359, 156);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(359, 203);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DNI";
            // 
            // traerTodos
            // 
            this.traerTodos.Location = new System.Drawing.Point(375, 357);
            this.traerTodos.Name = "traerTodos";
            this.traerTodos.Size = new System.Drawing.Size(75, 23);
            this.traerTodos.TabIndex = 13;
            this.traerTodos.Text = "Traer Todos";
            this.traerTodos.UseMnemonic = false;
            this.traerTodos.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(535, 356);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 24);
            this.eliminar.TabIndex = 14;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "fecha nacimiento: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(508, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 20;
            // 
            // btnTraerXTelefono
            // 
            this.btnTraerXTelefono.Location = new System.Drawing.Point(641, 348);
            this.btnTraerXTelefono.Name = "btnTraerXTelefono";
            this.btnTraerXTelefono.Size = new System.Drawing.Size(93, 31);
            this.btnTraerXTelefono.TabIndex = 21;
            this.btnTraerXTelefono.Text = "Traer x telefono";
            this.btnTraerXTelefono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTraerXTelefono.UseVisualStyleBackColor = true;
            this.btnTraerXTelefono.Click += new System.EventHandler(this.btnTraerXTelefono_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(567, 105);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(665, 299);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // APIClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTraerXTelefono);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.traerTodos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClientes);
            this.Name = "APIClientes";
            this.Text = "APIClientes";
            this.Load += new System.EventHandler(this.APIClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button traerTodos;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnTraerXTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnVolver;
    }
}
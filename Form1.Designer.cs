namespace consultora2_0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNovedad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtNovedad = new System.Windows.Forms.TextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.lstEmpresas = new System.Windows.Forms.ListBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstNovedades = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(18, 58);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(62, 16);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(153, 58);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(70, 16);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblNovedad
            // 
            this.lblNovedad.AutoSize = true;
            this.lblNovedad.Location = new System.Drawing.Point(305, 58);
            this.lblNovedad.Name = "lblNovedad";
            this.lblNovedad.Size = new System.Drawing.Size(50, 16);
            this.lblNovedad.TabIndex = 2;
            this.lblNovedad.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(12, 96);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 22);
            this.txtEmpresa.TabIndex = 4;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(156, 96);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtEmpleado.TabIndex = 5;
            // 
            // txtNovedad
            // 
            this.txtNovedad.Location = new System.Drawing.Point(308, 96);
            this.txtNovedad.Name = "txtNovedad";
            this.txtNovedad.Size = new System.Drawing.Size(100, 22);
            this.txtNovedad.TabIndex = 6;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(527, 90);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(136, 34);
            this.btnEmpresa.TabIndex = 7;
            this.btnEmpresa.Text = "Agregar Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(528, 149);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(135, 32);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.Text = "Agregar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(527, 208);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(135, 35);
            this.btnEstado.TabIndex = 9;
            this.btnEstado.Text = "Agrgar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnNovedad_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(528, 262);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(135, 36);
            this.btnResumen.TabIndex = 10;
            this.btnResumen.Text = "Ver Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.FormattingEnabled = true;
            this.lstEmpresas.ItemHeight = 16;
            this.lstEmpresas.Location = new System.Drawing.Point(12, 174);
            this.lstEmpresas.Name = "lstEmpresas";
            this.lstEmpresas.Size = new System.Drawing.Size(120, 84);
            this.lstEmpresas.TabIndex = 11;
            this.lstEmpresas.SelectedIndexChanged += new System.EventHandler(this.lstEmpresa_SelectedIndexChanged);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 16;
            this.lstEmpleados.Location = new System.Drawing.Point(156, 174);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(120, 84);
            this.lstEmpleados.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 16);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Consultora";
            // 
            // lstNovedades
            // 
            this.lstNovedades.FormattingEnabled = true;
            this.lstNovedades.ItemHeight = 16;
            this.lstNovedades.Location = new System.Drawing.Point(308, 174);
            this.lstNovedades.Name = "lstNovedades";
            this.lstNovedades.Size = new System.Drawing.Size(174, 84);
            this.lstNovedades.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(529, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 35);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstEmpresas);
            this.Controls.Add(this.lstNovedades);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.txtNovedad);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNovedad);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNovedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtNovedad;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.ListBox lstEmpresas;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstNovedades;
        private System.Windows.Forms.Button btnEliminar;
    }
}


namespace pryVillagraAppRegistroVenta
{
    partial class Ventas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            dtpFecha = new DateTimePicker();
            txtproducto = new TextBox();
            btnRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            txtPrecioUnitario = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(36, 101);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F);
            lblProducto.Location = new Point(36, 164);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 21);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            lblProducto.Click += lblProducto_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(37, 244);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lblPrecioUnitario.Location = new Point(36, 309);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(113, 21);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            lblPrecioUnitario.Click += label4_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(154, 95);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 4;
            // 
            // txtproducto
            // 
            txtproducto.Font = new Font("Segoe UI", 12F);
            txtproducto.Location = new Point(154, 163);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(113, 29);
            txtproducto.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.WhiteSmoke;
            btnRegistrar.Location = new Point(331, 371);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 41);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 12F);
            nudCantidad.Location = new Point(154, 231);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 29);
            nudCantidad.TabIndex = 7;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 12F);
            txtPrecioUnitario.Location = new Point(155, 301);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(77, 29);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(191, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 41);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(508, 450);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnRegistrar);
            Controls.Add(txtproducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "Ventas";
            Text = "Cantidad";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private DateTimePicker dtpFecha;
        private TextBox txtproducto;
        private Button btnRegistrar;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecioUnitario;
        private Button btnCancelar;
    }
}

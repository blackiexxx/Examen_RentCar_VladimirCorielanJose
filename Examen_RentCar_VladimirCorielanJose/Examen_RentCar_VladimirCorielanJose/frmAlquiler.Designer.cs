namespace Examen_RentCar_VladimirCorielanJose
{
    partial class frmAlquiler
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkCorporativo = new System.Windows.Forms.CheckBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.grpSeguro = new System.Windows.Forms.GroupBox();
            this.rbtCompleto = new System.Windows.Forms.RadioButton();
            this.rbtBasico = new System.Windows.Forms.RadioButton();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.rbtDomicilio = new System.Windows.Forms.RadioButton();
            this.rbtSucursal = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lstAlquileres = new System.Windows.Forms.ListBox();
            this.lblTitSubtotal = new System.Windows.Forms.Label();
            this.lblTitDescuento = new System.Windows.Forms.Label();
            this.lblTitDomicilio = new System.Windows.Forms.Label();
            this.lblTitItbis = new System.Windows.Forms.Label();
            this.lblTitTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.grpSeguro.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.SuspendLayout();

            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.Text = "Cliente:";

            // txtCliente
            this.txtCliente.Location = new System.Drawing.Point(95, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(185, 23);
            this.txtCliente.TabIndex = 0;

            // chkCorporativo
            this.chkCorporativo.AutoSize = true;
            this.chkCorporativo.Location = new System.Drawing.Point(290, 21);
            this.chkCorporativo.Name = "chkCorporativo";
            this.chkCorporativo.Size = new System.Drawing.Size(134, 19);
            this.chkCorporativo.TabIndex = 1;
            this.chkCorporativo.Text = "Cliente corporativo";
            this.chkCorporativo.UseVisualStyleBackColor = true;

            // lblSalida
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(20, 56);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(41, 15);
            this.lblSalida.Text = "Salida:";

            // dtpSalida
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(95, 52);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(185, 23);
            this.dtpSalida.TabIndex = 2;

            // lblVehiculo
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(20, 90);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(55, 15);
            this.lblVehiculo.Text = "Vehículo:";

            // txtVehiculo
            this.txtVehiculo.Location = new System.Drawing.Point(95, 87);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(185, 23);
            this.txtVehiculo.TabIndex = 3;

            // lblTarifa
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(20, 124);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(40, 15);
            this.lblTarifa.Text = "Tarifa:";

            // txtTarifa
            this.txtTarifa.Location = new System.Drawing.Point(95, 121);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(120, 23);
            this.txtTarifa.TabIndex = 4;

            // lblDias
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(20, 158);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(33, 15);
            this.lblDias.Text = "Días:";

            // nudDias
            this.nudDias.Location = new System.Drawing.Point(95, 155);
            this.nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(75, 23);
            this.nudDias.TabIndex = 5;
            this.nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // grpSeguro
            this.grpSeguro.Controls.Add(this.rbtCompleto);
            this.grpSeguro.Controls.Add(this.rbtBasico);
            this.grpSeguro.Location = new System.Drawing.Point(20, 192);
            this.grpSeguro.Name = "grpSeguro";
            this.grpSeguro.Size = new System.Drawing.Size(195, 84);
            this.grpSeguro.TabIndex = 6;
            this.grpSeguro.TabStop = false;
            this.grpSeguro.Text = "Seguro";

            // rbtBasico
            this.rbtBasico.AutoSize = true;
            this.rbtBasico.Checked = true;
            this.rbtBasico.Location = new System.Drawing.Point(12, 24);
            this.rbtBasico.Name = "rbtBasico";
            this.rbtBasico.Size = new System.Drawing.Size(64, 19);
            this.rbtBasico.TabIndex = 0;
            this.rbtBasico.TabStop = true;
            this.rbtBasico.Text = "Básico";
            this.rbtBasico.UseVisualStyleBackColor = true;

            // rbtCompleto
            this.rbtCompleto.AutoSize = true;
            this.rbtCompleto.Location = new System.Drawing.Point(12, 50);
            this.rbtCompleto.Name = "rbtCompleto";
            this.rbtCompleto.Size = new System.Drawing.Size(147, 19);
            this.rbtCompleto.TabIndex = 1;
            this.rbtCompleto.Text = "Completo (+RD$300)";
            this.rbtCompleto.UseVisualStyleBackColor = true;

            // grpEntrega
            this.grpEntrega.Controls.Add(this.rbtDomicilio);
            this.grpEntrega.Controls.Add(this.rbtSucursal);
            this.grpEntrega.Location = new System.Drawing.Point(225, 192);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(210, 84);
            this.grpEntrega.TabIndex = 7;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Entrega";

            // rbtSucursal
            this.rbtSucursal.AutoSize = true;
            this.rbtSucursal.Checked = true;
            this.rbtSucursal.Location = new System.Drawing.Point(12, 24);
            this.rbtSucursal.Name = "rbtSucursal";
            this.rbtSucursal.Size = new System.Drawing.Size(96, 19);
            this.rbtSucursal.TabIndex = 0;
            this.rbtSucursal.TabStop = true;
            this.rbtSucursal.Text = "En sucursal";
            this.rbtSucursal.UseVisualStyleBackColor = true;

            // rbtDomicilio
            this.rbtDomicilio.AutoSize = true;
            this.rbtDomicilio.Location = new System.Drawing.Point(12, 50);
            this.rbtDomicilio.Name = "rbtDomicilio";
            this.rbtDomicilio.Size = new System.Drawing.Size(145, 19);
            this.rbtDomicilio.TabIndex = 1;
            this.rbtDomicilio.Text = "Domicilio (+RD$500)";
            this.rbtDomicilio.UseVisualStyleBackColor = true;

            // chkGps
            this.chkGps.AutoSize = true;
            this.chkGps.Location = new System.Drawing.Point(20, 288);
            this.chkGps.Name = "chkGps";
            this.chkGps.Size = new System.Drawing.Size(166, 19);
            this.chkGps.TabIndex = 8;
            this.chkGps.Text = "GPS (+RD$100 por día)";
            this.chkGps.UseVisualStyleBackColor = true;

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(20, 332);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 34);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(145, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 34);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Nuevo alquiler";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(270, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 34);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(705, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar al alquiler";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // lblEncabezado
            this.lblEncabezado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.Location = new System.Drawing.Point(460, 62);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(415, 20);

            // lstAlquileres
            this.lstAlquileres.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.ItemHeight = 14;
            this.lstAlquileres.Location = new System.Drawing.Point(460, 84);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(415, 144);
            this.lstAlquileres.TabIndex = 13;

            // lblTitSubtotal
            this.lblTitSubtotal.AutoSize = true;
            this.lblTitSubtotal.Location = new System.Drawing.Point(575, 244);
            this.lblTitSubtotal.Name = "lblTitSubtotal";
            this.lblTitSubtotal.Size = new System.Drawing.Size(55, 15);
            this.lblTitSubtotal.Text = "Subtotal";

            // lblTitDescuento
            this.lblTitDescuento.AutoSize = true;
            this.lblTitDescuento.Location = new System.Drawing.Point(575, 272);
            this.lblTitDescuento.Name = "lblTitDescuento";
            this.lblTitDescuento.Size = new System.Drawing.Size(65, 15);
            this.lblTitDescuento.Text = "Descuento";

            // lblTitDomicilio
            this.lblTitDomicilio.AutoSize = true;
            this.lblTitDomicilio.Location = new System.Drawing.Point(575, 300);
            this.lblTitDomicilio.Name = "lblTitDomicilio";
            this.lblTitDomicilio.Size = new System.Drawing.Size(61, 15);
            this.lblTitDomicilio.Text = "Domicilio";

            // lblTitItbis
            this.lblTitItbis.AutoSize = true;
            this.lblTitItbis.Location = new System.Drawing.Point(575, 328);
            this.lblTitItbis.Name = "lblTitItbis";
            this.lblTitItbis.Size = new System.Drawing.Size(72, 15);
            this.lblTitItbis.Text = "ITBIS (18 %)";

            // lblTitTotal
            this.lblTitTotal.AutoSize = true;
            this.lblTitTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitTotal.Location = new System.Drawing.Point(575, 358);
            this.lblTitTotal.Name = "lblTitTotal";
            this.lblTitTotal.Size = new System.Drawing.Size(102, 15);
            this.lblTitTotal.Text = "TOTAL A PAGAR";

            // lblSubtotal
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(740, 241);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(135, 22);
            this.lblSubtotal.Text = "RD$ 0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblDescuento
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Location = new System.Drawing.Point(740, 269);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(135, 22);
            this.lblDescuento.Text = "RD$ 0.00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblDomicilio
            this.lblDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDomicilio.Location = new System.Drawing.Point(740, 297);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(135, 22);
            this.lblDomicilio.Text = "RD$ 0.00";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblItbis
            this.lblItbis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItbis.Location = new System.Drawing.Point(740, 325);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(135, 22);
            this.lblItbis.Text = "RD$ 0.00";
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTotal
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(740, 355);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 22);
            this.lblTotal.Text = "RD$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // frmAlquiler
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 400);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTitTotal);
            this.Controls.Add(this.lblTitItbis);
            this.Controls.Add(this.lblTitDomicilio);
            this.Controls.Add(this.lblTitDescuento);
            this.Controls.Add(this.lblTitSubtotal);
            this.Controls.Add(this.lstAlquileres);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkGps);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.grpSeguro);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.chkCorporativo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaCar Express - Alquileres";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.grpSeguro.ResumeLayout(false);
            this.grpSeguro.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkCorporativo;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.GroupBox grpSeguro;
        private System.Windows.Forms.RadioButton rbtBasico;
        private System.Windows.Forms.RadioButton rbtCompleto;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.RadioButton rbtSucursal;
        private System.Windows.Forms.RadioButton rbtDomicilio;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstAlquileres;
        private System.Windows.Forms.Label lblTitSubtotal;
        private System.Windows.Forms.Label lblTitDescuento;
        private System.Windows.Forms.Label lblTitDomicilio;
        private System.Windows.Forms.Label lblTitItbis;
        private System.Windows.Forms.Label lblTitTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
    }
}
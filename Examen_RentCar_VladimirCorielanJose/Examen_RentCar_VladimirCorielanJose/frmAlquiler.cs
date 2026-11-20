using System;
using System.Globalization;
using System.Windows.Forms;

namespace Examen_RentCar_VladimirCorielanJose
{
    public partial class frmAlquiler : Form
    {
        private const decimal RECARGO_SEGURO_COMPLETO = 300m;
        private const decimal RECARGO_GPS_DIA = 100m;
        private const decimal DESCUENTO_CORPORATIVO = 0.15m;
        private const decimal CARGO_DOMICILIO = 500m;
        private const decimal TASA_ITBIS = 0.18m;

        private decimal subtotalAcumulado = 0m;
        private readonly CultureInfo rd = CultureInfo.GetCultureInfo("es-DO");

        public frmAlquiler()
        {
            InitializeComponent();
        }

        private string FormatoRD(decimal monto)
        {
            return "RD$ " + monto.ToString("N2", rd);
        }

        private string FormatoColumna(decimal monto)
        {
            return monto.ToString("N2", rd);
        }

        private string ObtenerEncabezado()
        {
            return "Días".PadRight(6) +
                   "Vehículo".PadRight(24) +
                   "Tarifa".PadLeft(10) +
                   "Total".PadLeft(12);
        }

        private string ArmarVehiculo(string nombre, bool seguroCompleto, bool llevaGps)
        {
            if (seguroCompleto && llevaGps)
                return $"{nombre} (Completo, GPS)";
            if (seguroCompleto)
                return $"{nombre} (Completo)";
            if (llevaGps)
                return $"{nombre} (GPS)";

            return $"{nombre} (Básico)";
        }

        private string ArmarLinea(int dias, string vehiculoDetalle, decimal tarifaDiaria, decimal totalLinea)
        {
            string cDias = dias.ToString().PadRight(6);
            string cVehiculo = vehiculoDetalle.Length > 24
                ? vehiculoDetalle.Substring(0, 24)
                : vehiculoDetalle.PadRight(24);
            string cTarifa = FormatoColumna(tarifaDiaria).PadLeft(10);
            string cTotal = FormatoColumna(totalLinea).PadLeft(12);

            return cDias + cVehiculo + cTarifa + cTotal;
        }

        private void LimpiarControlesVehiculo()
        {
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void LimpiarTotales()
        {
            lblSubtotal.Text = FormatoRD(0m);
            lblDescuento.Text = FormatoRD(0m);
            lblDomicilio.Text = FormatoRD(0m);
            lblItbis.Text = FormatoRD(0m);
            lblTotal.Text = FormatoRD(0m);
        }

        private void NuevoAlquiler()
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Today;
            rbtSucursal.Checked = true;

            lstAlquileres.Items.Clear();
            lblEncabezado.Text = ObtenerEncabezado();

            subtotalAcumulado = 0m;
            LimpiarTotales();
            LimpiarControlesVehiculo();
            txtCliente.Focus();
        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            NuevoAlquiler();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vehiculo = txtVehiculo.Text.Trim();
            if (string.IsNullOrWhiteSpace(vehiculo))
            {
                MessageBox.Show("Debe digitar el nombre del vehículo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehiculo.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal tarifaBase) &&
                !decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out tarifaBase))
            {
                MessageBox.Show("Debe digitar una tarifa válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                return;
            }

            if (tarifaBase <= 0m)
            {
                MessageBox.Show("La tarifa debe ser mayor que cero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                return;
            }

            decimal tarifaDiaria = tarifaBase;
            if (rbtCompleto.Checked)
                tarifaDiaria += RECARGO_SEGURO_COMPLETO;

            if (chkGps.Checked)
                tarifaDiaria += RECARGO_GPS_DIA;

            int dias = (int)nudDias.Value;
            decimal totalLinea = tarifaDiaria * dias;

            string detalle = ArmarVehiculo(vehiculo, rbtCompleto.Checked, chkGps.Checked);
            lstAlquileres.Items.Add(ArmarLinea(dias, detalle, tarifaDiaria, totalLinea));

            subtotalAcumulado += totalLinea;
            lblSubtotal.Text = FormatoRD(subtotalAcumulado);

            LimpiarControlesVehiculo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("No hay vehículos agregados en el alquiler.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVehiculo.Focus();
                return;
            }

            decimal subtotal = subtotalAcumulado;
            decimal descuento = chkCorporativo.Checked ? subtotal * DESCUENTO_CORPORATIVO : 0m;
            decimal domicilio = rbtDomicilio.Checked ? CARGO_DOMICILIO : 0m;
            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = FormatoRD(subtotal);
            lblDescuento.Text = FormatoRD(descuento);
            lblDomicilio.Text = FormatoRD(domicilio);
            lblItbis.Text = FormatoRD(itbis);
            lblTotal.Text = FormatoRD(total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NuevoAlquiler();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
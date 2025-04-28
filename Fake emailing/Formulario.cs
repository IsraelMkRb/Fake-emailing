using Microsoft.Win32;

namespace Fake_emailing
{
    public partial class Formulario : Form
    {
        private int CantidadCorreosPendientes = 0;
        private int ultimoIdPedidoFalso = 0;
        private DateTime TiempoFormulario = new(1001, 1, 1);
        private Dictionary<int, DateTime> ColaEnvioEmail = new Dictionary<int, DateTime>();

        public Formulario()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string textoAMostrar = $"# Pedido: {(++ultimoIdPedidoFalso).ToString().PadLeft(4, '0')} -- Producto añadido:";
            int indiceAleatorio = GenerarIndiceAleatorio();
            int cantidadAleatoria = GenerarCantidadAleatoria();

            ListaProductos productos = new();
            Producto productoSeleccionado = productos[indiceAleatorio];

            textoAMostrar += $" {productoSeleccionado.Nombre} - {cantidadAleatoria} pz. - {productoSeleccionado.Precio * cantidadAleatoria:C2}";
            contenedor_listaproductos.Text += $"{textoAMostrar}\r\n";
            this.CantidadCorreosPendientes++;
            etiqueta_correospendientes.Text = this.CantidadCorreosPendientes.ToString();
            this.ColaEnvioEmail.Add(ultimoIdPedidoFalso, this.TiempoFormulario.AddMinutes(productoSeleccionado.DiasEnvioEmail));
        }

        private int GenerarIndiceAleatorio() => new Random().Next(0, 49);

        private int GenerarCantidadAleatoria() => new Random().Next(1, 6);

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            this.TiempoFormulario = TiempoFormulario.AddSeconds(1);
            KeyValuePair<int, DateTime> registro = this.ColaEnvioEmail.FirstOrDefault(registro => registro.Value <= this.TiempoFormulario);
            if (registro.Key > 0)
            {
                this.ColaEnvioEmail.Remove(registro.Key);
                --this.CantidadCorreosPendientes;
                etiqueta_correospendientes.Text = this.CantidadCorreosPendientes.ToString();
                contenedor_falsoemail.Text += $"Correo enviado para el pedido  #{registro.Key.ToString().PadLeft(4,'0')}\r\n";
            }

            etiqueta_tiempo.Text = $"{TiempoFormulario:m.s} día(s)";
        }
    }
}

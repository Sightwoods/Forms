using IPagos.Models;
using System.Globalization;
using System.Net.Http.Json;
using System.Security.Cryptography;

namespace IPagos
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            this.cbTipoPago.SelectedItem = "Efectivo";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try{
                Pagos pagos = new Pagos()
                {
                    //Id = "",
                    NumeroMatricula = this.txtMatricula.Text,
                    TipoPago = this.cbTipoPago.SelectedItem.ToString(),
                    Institucion = this.txtInstitucion.Text,
                    Nombre = this.txtNombre.Text,
                    Apellidos = this.txtApellidos.Text,
                    Fecha = this.DTPFecha.Value.ToString("MMMM,yyyy"),
                    Descripcion = this.txtDescripcion.Text
                };
                if (this.txtMatricula.Text != "" && this.cbTipoPago.ToString() != null && this.txtInstitucion.Text != ""
                    && this.txtNombre.Text != "" && this.txtApellidos.Text != "" && this.txtDescripcion.Text != "")
                {

                    CreateAsync(pagos);
                    MessageBox.Show("Registro Creado.");
                    this.txtMatricula.Clear();
                    this.txtMatricula.Clear();
                    this.txtInstitucion.Clear();
                    this.txtNombre.Clear();
                    this.txtApellidos.Clear();
                    this.txtDescripcion.Clear();
                    this.DTPFecha.Refresh();
                }
                else
                {
                    MessageBox.Show("No puede dejar espacios en blanco");
                }
            }
            catch (Exception error) { 
                MessageBox.Show(e.ToString());
            }
            
        }
        static async Task<Uri> CreateAsync(Pagos pago)
        {
            
            HttpResponseMessage response = await client.PostAsJsonAsync("http://localhost:5070/api/Pagos", pago);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }
        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
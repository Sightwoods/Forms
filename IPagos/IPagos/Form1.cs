using IPagos.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try{
                Pagos pagos = new Pagos()
                {
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

                    HttpResponseMessage response = await client.PostAsJsonAsync("https://project-sd.onrender.com/api/pagos", pagos);
                    if (response.IsSuccessStatusCode)
                    {
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
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                 
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
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
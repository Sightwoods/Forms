using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using EstadoCuentas.Models;
using Newtonsoft.Json;
using System.Net;

namespace EstadoCuentas
{
    public partial class Inicio : Form
    {
        static HttpClient cliente = new HttpClient();
        public Inicio()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        static async Task<string> GetHttp(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_Id.Text == "")
                {
                    MessageBox.Show("Rellena el campo para continuar");
                }
                else
                {
                    var consulta = "https://project-sd.onrender.com/api/pagos/" + this.txt_Id.Text;
                    var response = await cliente.GetAsync(consulta);
                    if (response.IsSuccessStatusCode)
                    {
                        string respuesta = await GetHttp(consulta);
                        List<Pagos> lst = JsonConvert.DeserializeObject<List<Pagos>>(respuesta);
                        this.DGVDatos.DataSource = lst;
                        this.txt_Id.Clear();
                    }
                    else
                    {
                        this.txt_Id.Clear();
                        this.DGVDatos.DataSource = null;
                        MessageBox.Show("El Numero de Matricula No Encontrado, intente uno nuevo");
                    }
                }
            }
            catch(Exception error) { 
                MessageBox.Show(error.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

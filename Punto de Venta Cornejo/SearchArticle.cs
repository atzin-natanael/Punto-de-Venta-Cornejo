using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Punto_de_Venta_Cornejo
{
    public partial class SearchArticle : Form
    {
        // Propiedades que contendrán los datos a retornar
        public string? ArticuloSelectedClave { get; private set; }
        public string? NombreSelected { get; private set; }
        public decimal PrecioSelected { get; private set; }
        public SearchArticle()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CargarDatos()
        {
            dataCodigos.DataSource = null;
            dataCodigos.Rows.Clear();
            if (txtCodigo.Text != string.Empty)
            {
                DataTable dataTable = new DataTable();
                dataTable = GetFireBirdValue.BuscarArticulosByClave(txtCodigo.Text);
                dataCodigos.AutoGenerateColumns = false;
                dataCodigos.DataSource = dataTable;
                Column1.DataPropertyName = "CLAVE_ARTICULO";
                Column2.DataPropertyName = "NOMBRE";
                Column3.DataPropertyName = "PRECIO";
            }
            else if (txtDescripcion.Text != string.Empty)
            {
                DataTable dataTable = new DataTable();
                dataTable = GetFireBirdValue.BuscarArticulosByDesc(txtDescripcion.Text);
                dataCodigos.AutoGenerateColumns = false;
                dataCodigos.DataSource = dataTable;
                Column1.DataPropertyName = "CLAVE_ARTICULO";
                Column2.DataPropertyName = "NOMBRE";
                Column3.DataPropertyName = "PRECIO";

            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void SearchArticle_Load(object sender, EventArgs e)
        {
            dataCodigos.RowTemplate.Height = 40;
            if (txtDescripcion.Text != string.Empty || txtCodigo.Text != string.Empty)
            {
                CargarDatos();
                dataCodigos.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDescripcion.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    CargarDatos();
                    e.SuppressKeyPress = true; // Evita el sonido de "ding"
                    dataCodigos.Focus();
                }

            }
        }

        private void dataCodigos_KeyDown(object sender, KeyEventArgs e)
        {
            if(dataCodigos.RowCount > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Evita el sonido de "ding"
                    ArticuloSelectedClave = dataCodigos.CurrentRow.Cells[0].Value.ToString();
                    NombreSelected = dataCodigos.CurrentRow.Cells[1].Value.ToString();
                    PrecioSelected = Convert.ToDecimal(dataCodigos.CurrentRow.Cells[2].Value);
                    this.Close();
                }
            }
        }
    }
}

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
        public SearchArticle()
        {
            InitializeComponent();
            if (txtDescripcion.Text != string.Empty)
                CargarDatos();
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
        }
    }
}

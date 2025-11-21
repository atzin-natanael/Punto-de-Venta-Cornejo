using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto_de_Venta_Cornejo
{
    public partial class Form1 : Form
    {
        int idCodigos = 0;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataCodigos.RowTemplate.Height = 40;
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dataCodigos.AutoGenerateColumns = false;
            dataCodigos.DataSource = dt;

            Column1.DataPropertyName = "Id";
            Column2.DataPropertyName = "Codigo";
            Column3.DataPropertyName = "Descripcion";
            Column4.DataPropertyName = "Cantidad";
            Column5.DataPropertyName = "Precio";
            Column6.DataPropertyName = "Descuento";

        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFolio.Text != string.Empty)
                {
                    cbCajero.Focus();
                }
            }
        }

        private void cbCajero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbCajero.Text != string.Empty)
                {
                    txtCodigo.Focus();
                }
            }
        }
        public void AgregarFila(decimal Precio, decimal Descuento)
        {

            idCodigos++;
            DataRow row = dt.NewRow();
            row["Id"] = idCodigos;
            row["Codigo"] = txtCodigo.Text;
            row["Descripcion"] = txtDescripcion.Text;
            row["Cantidad"] = int.Parse(txtUnidades.Text);
            row["Precio"] = Precio;
            row["Descuento"] = Descuento;
            //row["Total"] = int.Parse(txtUnidades.Text) * Precio;
            dt.Rows.Add(row);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            decimal precio = 0;
            decimal descuento = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text != string.Empty)
                {
                    txtUnidades.Focus();
                }
            }
        }

        private void txtUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUnidades.Text != string.Empty)
                {
                    decimal precio = 0;
                    decimal descuento = 0;
                    AgregarFila(precio, descuento);
                    txtCodigo.Clear();
                    txtDescripcion.Clear();
                    txtUnidades.Clear();
                    txtCodigo.Focus();
                }
            }
        }
    }
}

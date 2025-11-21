using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto_de_Venta_Cornejo
{
    public partial class MainView : Form
    {
        int idCodigos = 0;
        DataTable dt = new DataTable();
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolio.Text = "FOLIO001";
            cbDescuento.SelectedIndex = 0;
            cbCajero.SelectedIndex = 0;
            dataCodigos.RowTemplate.Height = 40;
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Unidades", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dataCodigos.AutoGenerateColumns = false;
            dataCodigos.DataSource = dt;

            Column1.DataPropertyName = "Id";
            Column2.DataPropertyName = "Codigo";
            Column3.DataPropertyName = "Descripcion";
            Column4.DataPropertyName = "Unidades";
            Column5.DataPropertyName = "Precio";
            Column6.DataPropertyName = "Descuento";

        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFolio.Text != string.Empty)
                {
                    e.SuppressKeyPress = true;
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
                    e.SuppressKeyPress = true;
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
            row["Unidades"] = int.Parse(txtUnidades.Text);
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
                    e.SuppressKeyPress = true;
                    txtUnidades.Focus();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    txtDescripcion.Focus();
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
                    UpdateLocalDB(precio, descuento);
                    dataCodigos.ClearSelection();
                    dataCodigos.Rows[dataCodigos.RowCount - 1].Cells[1].Selected = true;
                    dataCodigos.Rows[dataCodigos.RowCount - 1].Cells[3].Selected = true;
                    txtCodigo.Clear();
                    txtDescripcion.Clear();
                    txtUnidades.Clear();
                    e.SuppressKeyPress = true;
                    txtCodigo.Focus();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        public void UpdateLocalDB(decimal Precio, decimal Descuento)
        {
            SQLitePCL.Batteries.Init();
            using (SqliteConnection conect = new SqliteConnection(GlobalSettings.Instance.ConnectionLocalDb + txtFolio.Text + ".db;"))
            {
                conect.Open();
                string crearTablaQuery = $"CREATE TABLE IF NOT EXISTS {txtFolio.Text} (Id INTEGER, Codigo TEXT, Descripcion TEXT, Unidades INTEGER, Precio DECIMAL, Descuento DECIMAL, Importe DECIMAL)";
                SqliteCommand crearTablaCommand = new SqliteCommand(crearTablaQuery, conect);
                crearTablaCommand.ExecuteNonQuery();
                string query = $@"
                INSERT INTO {txtFolio.Text} (Id, Codigo, Descripcion, Unidades, Precio, Descuento, Importe)
                VALUES (@Id, @Codigo, @Descripcion, @Unidades, @Precio, @Descuento, @Importe)
                ";
                using (SqliteCommand cmd = new SqliteCommand(query, conect))
                {
                    cmd.Parameters.AddWithValue("@Folio", txtFolio.Text);
                    cmd.Parameters.AddWithValue("@Id", idCodigos);
                    cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Unidades", int.Parse(txtUnidades.Text));
                    cmd.Parameters.AddWithValue("@Precio", Precio);
                    cmd.Parameters.AddWithValue("@Descuento", Descuento);
                    cmd.Parameters.AddWithValue("@Importe", Precio * int.Parse(txtUnidades.Text));
                    cmd.ExecuteNonQuery();
                }
                conect.Close();
            }
        }

        private void dataCodigos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                if (dataCodigos.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    return;
                }
                dataCodigos.ClearSelection();
                dataCodigos.Rows[e.RowIndex].Cells[1].Selected = true;
                dataCodigos.Rows[e.RowIndex].Cells[3].Selected = true;
                int fila = e.RowIndex;
                int id = Convert.ToInt32(dataCodigos.Rows[e.RowIndex].Cells[0].Value);
                ContextMenuStrip menu = new ContextMenuStrip();
                // Agregar opciones al menú
                ToolStripMenuItem modificarUnidades = new ToolStripMenuItem("Modificar Unidades");
                ToolStripMenuItem eliminarCodigo = new ToolStripMenuItem("Eliminar");
                menu.Items.Add(modificarUnidades);
                menu.Items.Add(eliminarCodigo);
                menu.ItemClicked += (s, args) =>
                {
                    // Verificar la opción seleccionada
                    if (args.ClickedItem == modificarUnidades)
                    {
                        menu.Close();
                        dataCodigos.Focus();
                        // 🔥 Habilitar la celda correcta
                        dataCodigos.Rows[e.RowIndex].Cells[3].ReadOnly = false;

                        // 🔥 Ponerle el foco para que empiece a editar
                        dataCodigos.CurrentCell = dataCodigos.Rows[fila].Cells[3];
                        dataCodigos.BeginEdit(true);
                    }
                    if (args.ClickedItem == eliminarCodigo)
                    {
                        menu.Close();
                        dataCodigos.Rows.RemoveAt(fila);
                    }
                };
                menu.Show(Cursor.Position);
            }
        }

        private void dataCodigos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (SqliteConnection conect = new SqliteConnection(GlobalSettings.Instance.ConnectionLocalDb + txtFolio.Text+ ".db;"))
            {
                conect.Open();
                string query = $"UPDATE {txtFolio.Text} SET Unidades = @valor WHERE Id = '" + dataCodigos.Rows[e.RowIndex].Cells[0].Value + "';";
                SqliteCommand command = new SqliteCommand(query, conect);
                command.Parameters.AddWithValue("@valor", dataCodigos.Rows[e.RowIndex].Cells[3].Value);
                command.ExecuteNonQuery();
                conect.Close();
            }
            txtCodigo.Focus();
            dataCodigos.CurrentCell = null;
            dataCodigos.ClearSelection();

        }

        private void dataCodigos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("entra");
        }

        private void dataCodigos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string valor = e.FormattedValue?.ToString();

                // Si está vacío, no permitir
                if (string.IsNullOrWhiteSpace(valor))
                {
                    MessageBox.Show("Ingrese unidades.");
                    e.Cancel = true; // No deja salir de la celda
                    return;
                }

                // Validar que sea número
                if (!int.TryParse(valor, out int numero))
                {
                    MessageBox.Show("Las unidades deben ser un número.");
                    e.Cancel = true; // 🔥 SE QUEDA en la celda
                    return;
                }
            }
        }
    }
}

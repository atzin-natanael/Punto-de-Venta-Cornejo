using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.Data.Sqlite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto_de_Venta_Cornejo
{
    public partial class MainView : Form
    {
        int idCodigos = 0;
        bool editando = false;
        DataTable dt = new DataTable();
        decimal descuentoCliente = 20.0m;
        bool completedUpdate = false;
        public MainView()
        {
            InitializeComponent();
            LoadConfig();
            tableLayoutPanel1.Padding = new Padding(0);
        }
        public void LoadConfig()
        {
            string filePath = GlobalSettings.Instance.PathConfig + "DB.txt"; // Ruta de tu archivo de texto
            List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string linea;
                    GlobalSettings.Instance.Config = new List<string>();
                    while ((linea = sr.ReadLine()) != null)
                    {
                        GlobalSettings.Instance.Config.Add(linea);
                    }

                }
                GlobalSettings.Instance.Ip = GlobalSettings.Instance.Config[0];
                GlobalSettings.Instance.Puerto = GlobalSettings.Instance.Config[1];
                GlobalSettings.Instance.Direccion = GlobalSettings.Instance.Config[2];
                GlobalSettings.Instance.User = GlobalSettings.Instance.Config[3];
                GlobalSettings.Instance.Pw = GlobalSettings.Instance.Config[4];
                GlobalSettings.Instance.StringConnection =
                    "User=" + GlobalSettings.Instance.User + ";" +
                    "Password=" + GlobalSettings.Instance.Pw + ";" +
                    "Database=" + GlobalSettings.Instance.Direccion + ";" +
                    "DataSource=" + GlobalSettings.Instance.Ip + ";" +
                    "Port=" + GlobalSettings.Instance.Puerto + ";" +
                    "Dialect=3;" +
                    "Charset=UTF8;";
            }
            else
            {
                MessageBox.Show("Archivo de Configuracion no encontrado", "DB.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolio.Text = "A01";
            cbDescuento.SelectedIndex = 1;
            cbCajero.SelectedIndex = 0;
            cbCajero.Text = "ATZIN PACHECO";
            dataCodigos.RowTemplate.Height = 40;
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Unidades", typeof(decimal));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Importe", typeof(decimal));
            dataCodigos.AutoGenerateColumns = false;
            dataCodigos.DataSource = dt;

            Column1.DataPropertyName = "Id";
            Column2.DataPropertyName = "Codigo";
            Column3.DataPropertyName = "Descripcion";
            Column4.DataPropertyName = "Unidades";
            Column5.DataPropertyName = "Precio";
            Column6.DataPropertyName = "Descuento";
            Column7.DataPropertyName = "Importe";

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
            if (dataCodigos.RowCount > 0)
            {
                DataGridViewRow fila = dataCodigos.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[1].Value?.ToString() == txtCodigo.Text);
                if (fila != null)
                {
                    decimal unidadesExistentes = Convert.ToDecimal(fila.Cells[3].Value);
                    decimal nuevasUnidades = decimal.Parse(txtUnidades.Text);
                    fila.Cells[3].Value = unidadesExistentes + nuevasUnidades;
                    fila.Cells[6].Value = Precio * (unidadesExistentes + nuevasUnidades);
                    CalcularTotales();
                    int index = fila.Index;
                    dataCodigos.FirstDisplayedScrollingRowIndex = index;
                    dataCodigos.ClearSelection();
                    dataCodigos.Rows[index].Cells[1].Selected = true;
                    dataCodigos.Rows[index].Cells[3].Selected = true;
                    // Actualizar la base de datos local

                    var valor = dataCodigos.Rows[index].Cells[0].Value?.ToString();
                    var valorUnidad = dataCodigos.Rows[index].Cells[3].Value?.ToString();
                    if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(valorUnidad))
                    {
                        MessageBox.Show("La celda está vacía.");
                        return;
                    }
                    using (SqliteConnection conect = new SqliteConnection(GlobalSettings.Instance.ConnectionLocalDb + txtFolio.Text + ".db;"))
                    {
                        conect.Open();
                        string query = $"UPDATE {txtFolio.Text} SET Unidades = @Unidades, Importe = @Importe WHERE Id = '" + dataCodigos.Rows[index].Cells[0].Value + "';";
                        SqliteCommand command = new SqliteCommand(query, conect);
                        command.Parameters.AddWithValue("@Unidades", dataCodigos.Rows[index].Cells[3].Value);
                        command.Parameters.AddWithValue("@Importe", Precio * (unidadesExistentes + nuevasUnidades));
                        command.ExecuteNonQuery();
                        conect.Close();
                    }
                    completedUpdate = true;
                    return; // Salir del método para evitar agregar una nueva fila
                }
            }
            idCodigos++;
            DataRow row = dt.NewRow();
            row["Id"] = idCodigos;
            row["Codigo"] = txtCodigo.Text;
            row["Descripcion"] = txtDescripcion.Text;
            row["Unidades"] = decimal.Parse(txtUnidades.Text);
            row["Precio"] = Precio;
            row["Descuento"] = Descuento;
            row["Importe"] = Precio * decimal.Parse(txtUnidades.Text);
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
                    string query = $"SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '{txtCodigo.Text}';";
                    string articuloId = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    if (articuloId == null)
                    {
                        MessageBox.Show("Código no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodigo.Select(0, txtCodigo.TextLength);
                        txtCodigo.Focus();
                        return;
                    }
                    query = $"SELECT NOMBRE FROM ARTICULOS WHERE ARTICULO_ID = '{articuloId}';";
                    string descripcion = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    txtDescripcion.Text = descripcion;

                    query = $"SELECT CONTENIDO_EMPAQUE FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '{txtCodigo.Text}';";
                    string contenidoEmpaque = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    txtUnidades.Text = contenidoEmpaque;
                    query = $"SELECT CLAVE_ARTICULO FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '{articuloId}' AND ROL_CLAVE_ART_ID = '17';";
                    string clavePrincipal = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    txtCodigo.Text = clavePrincipal;
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
                    string query = $"SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '{txtCodigo.Text}';";
                    string articuloId = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    if (articuloId == null) return;
                    query = $"SELECT PRECIO FROM PRECIOS_ARTICULOS WHERE ARTICULO_ID = '{articuloId}' AND PRECIO_EMPRESA_ID = '42';";
                    decimal preciolista = decimal.Parse(GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query));
                    query = $"SELECT IMPUESTO_ID FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '{articuloId}';";
                    string impuestoId = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    query = $"SELECT PCTJE_IMPUESTO FROM IMPUESTOS WHERE IMPUESTO_ID = '{impuestoId}';";
                    int impuesto = int.Parse(GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query));
                    decimal precio = preciolista;
                    decimal descuentoArticulo = decimal.Parse(GetFireBirdValue.GetDiscountByArticle(articuloId) ?? "-1");
                    if (descuentoArticulo == -1)
                    {
                        descuentoArticulo = decimal.Parse(descuentoCliente.ToString("0.##"));
                    }
                    else
                    {
                        decimal clienteDescDecimal = (descuentoCliente != decimal.MinusOne) ? descuentoCliente / 100m : 0m;
                        decimal articuloDescDecimal = (descuentoArticulo != decimal.MinusOne) ? descuentoArticulo / 100m : 0m;

                        decimal _descuentoTotal = 1 - ((1 - clienteDescDecimal) * (1 - articuloDescDecimal));
                        descuentoArticulo = decimal.Parse((_descuentoTotal * 100m).ToString("0.##")); // Devuelve en porcentaje
                    }
                    AgregarFila(precio, descuentoArticulo);
                    if (!completedUpdate)
                        UpdateLocalDB(precio, descuentoArticulo);
                    completedUpdate = false;
                    dataCodigos.ClearSelection();
                    dataCodigos.Rows[dataCodigos.RowCount - 1].Cells[1].Selected = true;
                    dataCodigos.Rows[dataCodigos.RowCount - 1].Cells[3].Selected = true;
                    dataCodigos.FirstDisplayedScrollingRowIndex = dataCodigos.RowCount - 1;
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
                    cmd.Parameters.AddWithValue("@Unidades", decimal.Parse(txtUnidades.Text));
                    cmd.Parameters.AddWithValue("@Precio", Precio);
                    cmd.Parameters.AddWithValue("@Descuento", Descuento);
                    cmd.Parameters.AddWithValue("@Importe", Precio * decimal.Parse(txtUnidades.Text));
                    cmd.ExecuteNonQuery();
                }
                conect.Close();
            }
        }

        private void dataCodigos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                var valor = dataCodigos.Rows[e.RowIndex].Cells[0].Value?.ToString();
                var valorUnidad = dataCodigos.Rows[e.RowIndex].Cells[3].Value?.ToString();
                if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(valorUnidad))
                {
                    MessageBox.Show("La celda está vacía.");
                    return;
                }
                if (editando)
                {
                    MessageBox.Show("Ya estás editando una celda. Termina la edición antes de continuar.");
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
                        editando = true;
                        dataCodigos.Focus();
                        // 🔥 Habilitar la celda correcta
                        dataCodigos.ClearSelection();
                        dataCodigos.Rows[e.RowIndex].Cells[1].Style.BackColor = System.Drawing.Color.Pink;
                        dataCodigos.Rows[e.RowIndex].Cells[2].Style.BackColor = System.Drawing.Color.Pink;
                        dataCodigos.Rows[e.RowIndex].Cells[3].Style.BackColor = System.Drawing.Color.Pink;
                        dataCodigos.Rows[e.RowIndex].Cells[3].ReadOnly = false;

                        // 🔥 Ponerle el foco para que empiece a editar
                        dataCodigos.CurrentCell = dataCodigos.Rows[fila].Cells[3];
                        dataCodigos.BeginEdit(true);
                    }
                    if (args.ClickedItem == eliminarCodigo)
                    {
                        menu.Close();
                        dataCodigos.Rows.RemoveAt(fila);
                        CalcularTotales();
                        using (SqliteConnection conect = new SqliteConnection(GlobalSettings.Instance.ConnectionLocalDb + txtFolio.Text + ".db;"))
                        {
                            conect.Open();
                            string query = $"DELETE FROM {txtFolio.Text} WHERE Id = @Id;";
                            SqliteCommand command = new SqliteCommand(query, conect);
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                            conect.Close();
                        }
                    }
                };
                menu.Show(Cursor.Position);
            }
        }

        private void dataCodigos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar la base de datos local

            var valor = dataCodigos.Rows[e.RowIndex].Cells[0].Value?.ToString();
            var valorUnidad = dataCodigos.Rows[e.RowIndex].Cells[3].Value?.ToString();
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(valorUnidad))
            {
                MessageBox.Show("La celda está vacía.");
                return;
            }
            dataCodigos.Rows[e.RowIndex].Cells[6].Value = Convert.ToDecimal(dataCodigos.Rows[e.RowIndex].Cells[3].Value) * Convert.ToDecimal(dataCodigos.Rows[e.RowIndex].Cells[4].Value);
            CalcularTotales();
            using (SqliteConnection conect = new SqliteConnection(GlobalSettings.Instance.ConnectionLocalDb + txtFolio.Text + ".db;"))
            {
                conect.Open();
                string query = $"UPDATE {txtFolio.Text} SET Unidades = @Unidades, Importe = @Importe WHERE Id = '" + dataCodigos.Rows[e.RowIndex].Cells[0].Value + "';";
                SqliteCommand command = new SqliteCommand(query, conect);
                command.Parameters.AddWithValue("@Unidades", dataCodigos.Rows[e.RowIndex].Cells[3].Value);
                command.Parameters.AddWithValue("@Importe", Convert.ToDecimal(dataCodigos.Rows[e.RowIndex].Cells[3].Value) * Convert.ToDecimal(dataCodigos.Rows[e.RowIndex].Cells[4].Value));
                command.ExecuteNonQuery();
                conect.Close();
            }
            dataCodigos.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Empty;
            dataCodigos.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Empty;
            dataCodigos.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Empty;
            editando = false;
            txtCodigo.Focus();
            // Evita errores
            this.BeginInvoke(new Action(() =>
            {
                dataCodigos.ClearSelection();
            }));

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
                if (!decimal.TryParse(valor, out decimal numero))
                {
                    MessageBox.Show("Las unidades deben ser un número.");
                    e.Cancel = true; // 🔥 SE QUEDA en la celda
                    return;
                }
            }
        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar) &&
            e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evitar dos puntos decimales
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private decimal CalcularDescuentoArticulo(string _articulo_id)
        {
            decimal _descuentoPorArticulo = decimal.Parse(GetFireBirdValue.GetDiscountByArticle(_articulo_id) ?? "-1");

            // Calcular el descuento total efectivo usando la fórmula
            //decimal _descuentoTotal =
            //1 - (
            //    (1 - (descuentoPorCliente != decimal.MinusOne ? descuentoPorCliente / 100m : 0m))//Si hay descuento por cliente, se aplica
            //    *
            //    (1 - (_descuentoPorArticulo != decimal.MinusOne ? _descuentoPorArticulo : 0m))//Si hay descuento por articulo, se aplica
            //    );
            ////Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Descuento].Value = _descuentoTotal;
            //return _descuentoTotal *= 100; // Convertir a porcentaje y mostrar el resultado
            decimal cliente = (descuentoCliente != decimal.MinusOne) ? descuentoCliente / 100m : 0m;
            decimal articulo = (_descuentoPorArticulo != decimal.MinusOne) ? _descuentoPorArticulo / 100m : 0m;

            decimal _descuentoTotal = 1 - ((1 - cliente) * (1 - articulo));
            return _descuentoTotal * 100m; // Devuelve en porcentaje


        }

        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = $"SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = {cbDescuento.Text};";
            //string cliente_id = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
            //////Obtiene el descuento por cliente una sola vez
            //descuentoCliente = decimal.Parse(GetFireBirdValue.GetDiscountByClient(cliente_id) ?? "-1");
        }

        private void cbDescuento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = $"SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = '{cbDescuento.Text}';";
            string cliente_id = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
            //Obtiene el descuento por cliente una sola vez
            descuentoCliente = decimal.Parse(GetFireBirdValue.GetDiscountByClient(cliente_id) ?? "-1");
        }

        private void dataCodigos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (dataCodigos.CurrentRow != null)
                {
                    MessageBoxExistencia existencia = new MessageBoxExistencia();
                    string query = $"SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '{dataCodigos.CurrentRow.Cells[1].Value.ToString()}';";
                    string articuloid = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                    string Exalmacen = GetFireBirdValue.GetExistencia(articuloid, "108401") ?? "Not Found";
                    string Extienda = GetFireBirdValue.GetExistencia(articuloid, "108403") ?? "Not Found";
                    existencia.richText.Text = dataCodigos.CurrentRow?.Cells[1]?.Value?.ToString() ?? "No encontrado";
                    existencia.richText.Text += $"\n{dataCodigos.CurrentRow?.Cells[2]?.Value?.ToString() ?? "No encontrado"}";
                    existencia.richText.Text += $"\n\nExistencia Almacén: {Exalmacen}";
                    existencia.richText.Text += $"\nExistencia Tienda: {Extienda}";
                    existencia.richText.SelectAll();
                    existencia.richText.SelectionAlignment = HorizontalAlignment.Center;
                    existencia.ShowDialog();
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
        }

        private void dataCodigos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbContadorArticulos.Text = dataCodigos.RowCount.ToString();
            CalcularTotales();
        }

        private void dataCodigos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbContadorArticulos.Text = dataCodigos.RowCount.ToString();
            CalcularTotales();
        }
        public void CalcularTotales()
        {
            decimal sumatoria = 0, descuentoMonto = 0, impuestoMonto = 0, subtotal = 0, descuentoArticulo = 0;
            for (int i = 0; i < dataCodigos.RowCount; ++i)
            {
                subtotal = Convert.ToDecimal(dataCodigos.Rows[i].Cells[6].Value);
                sumatoria += subtotal;
                descuentoArticulo = subtotal * (Convert.ToDecimal(dataCodigos.Rows[i].Cells[5].Value) / 100m);
                descuentoMonto += descuentoArticulo;
                string query = $"SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '{dataCodigos.Rows[i].Cells[1].Value.ToString()}';";
                string articuloid = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                decimal impuesto = GetFireBirdValue.GetImpuesto(articuloid) != null ? decimal.Parse(GetFireBirdValue.GetImpuesto(articuloid)!) : 0m;
                decimal impuestoDecimal = (impuesto != decimal.MinusOne) ? impuesto / 100m : 0m;
                impuestoMonto += (subtotal - descuentoArticulo) * impuestoDecimal;
            }
            lbSubtotal.Text = sumatoria.ToString("C2");
            lbDescuento.Text = descuentoMonto.ToString("C2");
            lbImpuesto.Text = (impuestoMonto).ToString("C2");
            lbTotal.Text = (sumatoria - descuentoMonto + impuestoMonto).ToString("C2");
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (txtDescripcion.Text != string.Empty)
                {
                    Form overlay = new Form();

                    // Configuración del Overlay:
                    overlay.StartPosition = FormStartPosition.Manual;
                    overlay.FormBorderStyle = FormBorderStyle.None;
                    overlay.Opacity = 0.70;           // 70% de opacidad (oscuro)
                    overlay.BackColor = Color.Black;
                    overlay.Size = this.Size;          // Mismo tamaño que el Formulario Padre
                    overlay.Location = this.Location;  // Misma posición que el Formulario Padre

                    // 2. Mostrar el Overlay
                    overlay.Show();
                    SearchArticle searchArticle = new SearchArticle();
                    searchArticle.txtDescripcion.Text = txtDescripcion.Text;
                    searchArticle.ShowDialog(overlay);
                    overlay.Close();

                }
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}

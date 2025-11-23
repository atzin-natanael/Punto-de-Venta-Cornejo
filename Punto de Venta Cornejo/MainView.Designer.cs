namespace Punto_de_Venta_Cornejo
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            cbDescuento = new ComboBox();
            lbCliente = new Label();
            lbUnidades = new Label();
            lbDescripcion = new Label();
            lbCodigo = new Label();
            txtUnidades = new TextBox();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            cbCajero = new ComboBox();
            lbCajero = new Label();
            lbFolio = new Label();
            txtFolio = new TextBox();
            label1 = new Label();
            tittle = new Label();
            btnGuardar = new Button();
            panelLateral = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbContadorArticulos = new Label();
            label10 = new Label();
            lbTotal = new Label();
            lbImpuesto = new Label();
            lbDescuento = new Label();
            lbSubtotal = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelBody = new Panel();
            dataCodigos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panelTop = new Panel();
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            panelHeader.SuspendLayout();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCodigos).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(240, 242, 245);
            panelHeader.Controls.Add(cbDescuento);
            panelHeader.Controls.Add(lbCliente);
            panelHeader.Controls.Add(lbUnidades);
            panelHeader.Controls.Add(lbDescripcion);
            panelHeader.Controls.Add(lbCodigo);
            panelHeader.Controls.Add(txtUnidades);
            panelHeader.Controls.Add(txtDescripcion);
            panelHeader.Controls.Add(txtCodigo);
            panelHeader.Controls.Add(cbCajero);
            panelHeader.Controls.Add(lbCajero);
            panelHeader.Controls.Add(lbFolio);
            panelHeader.Controls.Add(txtFolio);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(tittle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Font = new Font("Microsoft Sans Serif", 14.25F);
            panelHeader.Location = new Point(0, 40);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1048, 204);
            panelHeader.TabIndex = 1;
            // 
            // cbDescuento
            // 
            cbDescuento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbDescuento.FormattingEnabled = true;
            cbDescuento.Items.AddRange(new object[] { "Seleccione una opción...", "VARIOS", "V30", "V37", "V40" });
            cbDescuento.Location = new Point(156, 96);
            cbDescuento.Margin = new Padding(0);
            cbDescuento.Name = "cbDescuento";
            cbDescuento.RightToLeft = RightToLeft.No;
            cbDescuento.Size = new Size(278, 28);
            cbDescuento.TabIndex = 8;
            cbDescuento.SelectedIndexChanged += cbDescuento_SelectedIndexChanged;
            cbDescuento.SelectionChangeCommitted += cbDescuento_SelectionChangeCommitted;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbCliente.Location = new Point(77, 99);
            lbCliente.Margin = new Padding(0);
            lbCliente.Name = "lbCliente";
            lbCliente.RightToLeft = RightToLeft.No;
            lbCliente.Size = new Size(78, 25);
            lbCliente.TabIndex = 7;
            lbCliente.Text = "Cliente:";
            lbCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbUnidades
            // 
            lbUnidades.AutoSize = true;
            lbUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbUnidades.Location = new Point(713, 132);
            lbUnidades.Name = "lbUnidades";
            lbUnidades.Size = new Size(100, 25);
            lbUnidades.TabIndex = 0;
            lbUnidades.Text = "Unidades:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbDescripcion.Location = new Point(215, 132);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(121, 25);
            lbDescripcion.TabIndex = 0;
            lbDescripcion.Text = "Descripción:";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbCodigo.Location = new Point(12, 132);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(82, 25);
            lbCodigo.TabIndex = 0;
            lbCodigo.Text = "Código:";
            // 
            // txtUnidades
            // 
            txtUnidades.BorderStyle = BorderStyle.FixedSingle;
            txtUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUnidades.Location = new Point(713, 160);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(188, 33);
            txtUnidades.TabIndex = 5;
            txtUnidades.KeyDown += txtUnidades_KeyDown;
            txtUnidades.KeyPress += txtUnidades_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Segoe UI", 14.25F);
            txtDescripcion.Location = new Point(215, 160);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(482, 33);
            txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 14.25F);
            txtCodigo.Location = new Point(12, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 33);
            txtCodigo.TabIndex = 3;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // cbCajero
            // 
            cbCajero.DrawMode = DrawMode.OwnerDrawFixed;
            cbCajero.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbCajero.FormattingEnabled = true;
            cbCajero.Items.AddRange(new object[] { "Seleccione una opción..." });
            cbCajero.Location = new Point(156, 52);
            cbCajero.Margin = new Padding(0);
            cbCajero.Name = "cbCajero";
            cbCajero.RightToLeft = RightToLeft.No;
            cbCajero.Size = new Size(278, 28);
            cbCajero.TabIndex = 2;
            cbCajero.KeyDown += cbCajero_KeyDown;
            // 
            // lbCajero
            // 
            lbCajero.AutoSize = true;
            lbCajero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbCajero.Location = new Point(81, 55);
            lbCajero.Margin = new Padding(0);
            lbCajero.Name = "lbCajero";
            lbCajero.RightToLeft = RightToLeft.No;
            lbCajero.Size = new Size(74, 25);
            lbCajero.TabIndex = 0;
            lbCajero.Text = "Cajero:";
            lbCajero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbFolio
            // 
            lbFolio.AutoSize = true;
            lbFolio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbFolio.Location = new Point(12, 13);
            lbFolio.Margin = new Padding(0);
            lbFolio.Name = "lbFolio";
            lbFolio.RightToLeft = RightToLeft.No;
            lbFolio.Size = new Size(144, 25);
            lbFolio.TabIndex = 0;
            lbFolio.Text = "Folio de Venta:";
            lbFolio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            txtFolio.BorderStyle = BorderStyle.FixedSingle;
            txtFolio.CharacterCasing = CharacterCasing.Upper;
            txtFolio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtFolio.Location = new Point(156, 11);
            txtFolio.Margin = new Padding(0);
            txtFolio.Name = "txtFolio";
            txtFolio.RightToLeft = RightToLeft.No;
            txtFolio.Size = new Size(278, 27);
            txtFolio.TabIndex = 1;
            txtFolio.KeyDown += txtFolio_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(671, 11);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(102, 46);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tittle
            // 
            tittle.Anchor = AnchorStyles.None;
            tittle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            tittle.ForeColor = Color.SlateGray;
            tittle.Location = new Point(499, 11);
            tittle.Margin = new Padding(0);
            tittle.Name = "tittle";
            tittle.Size = new Size(219, 46);
            tittle.TabIndex = 0;
            tittle.Text = "Punto de";
            tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(0, 591);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(317, 137);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Finalizar Venta";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(240, 242, 245);
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Controls.Add(tableLayoutPanel1);
            panelLateral.Controls.Add(btnGuardar);
            panelLateral.Dock = DockStyle.Right;
            panelLateral.Location = new Point(1049, 40);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(317, 728);
            panelLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 242, 245);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LogoCornejo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(240, 242, 245);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.80126F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.19874F));
            tableLayoutPanel1.Controls.Add(lbContadorArticulos, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Controls.Add(lbTotal, 1, 4);
            tableLayoutPanel1.Controls.Add(lbImpuesto, 1, 3);
            tableLayoutPanel1.Controls.Add(lbDescuento, 1, 2);
            tableLayoutPanel1.Controls.Add(lbSubtotal, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 363);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.Size = new Size(317, 228);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // lbContadorArticulos
            // 
            lbContadorArticulos.Dock = DockStyle.Fill;
            lbContadorArticulos.FlatStyle = FlatStyle.Flat;
            lbContadorArticulos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbContadorArticulos.Location = new Point(123, 0);
            lbContadorArticulos.Margin = new Padding(0);
            lbContadorArticulos.Name = "lbContadorArticulos";
            lbContadorArticulos.Size = new Size(194, 41);
            lbContadorArticulos.TabIndex = 9;
            lbContadorArticulos.Text = "0";
            lbContadorArticulos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(123, 41);
            label10.TabIndex = 8;
            label10.Text = "Articulos:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            lbTotal.BackColor = Color.FromArgb(45, 60, 80);
            lbTotal.Dock = DockStyle.Fill;
            lbTotal.FlatStyle = FlatStyle.Flat;
            lbTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.White;
            lbTotal.Location = new Point(123, 164);
            lbTotal.Margin = new Padding(0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(194, 64);
            lbTotal.TabIndex = 7;
            lbTotal.Text = "$ 0";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbImpuesto
            // 
            lbImpuesto.Dock = DockStyle.Fill;
            lbImpuesto.FlatStyle = FlatStyle.Flat;
            lbImpuesto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbImpuesto.Location = new Point(123, 123);
            lbImpuesto.Margin = new Padding(0);
            lbImpuesto.Name = "lbImpuesto";
            lbImpuesto.Size = new Size(194, 41);
            lbImpuesto.TabIndex = 6;
            lbImpuesto.Text = "$ 0";
            lbImpuesto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbDescuento
            // 
            lbDescuento.Dock = DockStyle.Fill;
            lbDescuento.FlatStyle = FlatStyle.Flat;
            lbDescuento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbDescuento.Location = new Point(123, 82);
            lbDescuento.Margin = new Padding(0);
            lbDescuento.Name = "lbDescuento";
            lbDescuento.Size = new Size(194, 41);
            lbDescuento.TabIndex = 5;
            lbDescuento.Text = "$ 0";
            lbDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSubtotal
            // 
            lbSubtotal.Dock = DockStyle.Fill;
            lbSubtotal.FlatStyle = FlatStyle.Flat;
            lbSubtotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbSubtotal.Location = new Point(123, 41);
            lbSubtotal.Margin = new Padding(0);
            lbSubtotal.Name = "lbSubtotal";
            lbSubtotal.Size = new Size(194, 41);
            lbSubtotal.TabIndex = 4;
            lbSubtotal.Text = "$ 0";
            lbSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(0, 41);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(123, 41);
            label2.TabIndex = 0;
            label2.Text = "SubTotal:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(0, 82);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 1;
            label3.Text = "Descuento:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(0, 123);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(123, 41);
            label4.TabIndex = 2;
            label4.Text = "Iva:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(45, 60, 80);
            label5.Dock = DockStyle.Fill;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 164);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(123, 64);
            label5.TabIndex = 3;
            label5.Text = "Total:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Beige;
            panelBody.Controls.Add(dataCodigos);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 244);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1048, 524);
            panelBody.TabIndex = 2;
            // 
            // dataCodigos
            // 
            dataCodigos.AllowUserToAddRows = false;
            dataCodigos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataCodigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataCodigos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dataCodigos.BorderStyle = BorderStyle.None;
            dataCodigos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataCodigos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.SteelBlue;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataCodigos.ColumnHeadersHeight = 50;
            dataCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataCodigos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataCodigos.DefaultCellStyle = dataGridViewCellStyle16;
            dataCodigos.Dock = DockStyle.Fill;
            dataCodigos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataCodigos.EnableHeadersVisualStyles = false;
            dataCodigos.GridColor = Color.Beige;
            dataCodigos.Location = new Point(0, 0);
            dataCodigos.Name = "dataCodigos";
            dataCodigos.RowHeadersVisible = false;
            dataCodigos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCodigos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataCodigos.Size = new Size(1048, 524);
            dataCodigos.TabIndex = 0;
            dataCodigos.CellEndEdit += dataCodigos_CellEndEdit;
            dataCodigos.CellMouseDown += dataCodigos_CellMouseDown;
            dataCodigos.CellValidating += dataCodigos_CellValidating;
            dataCodigos.RowsAdded += dataCodigos_RowsAdded;
            dataCodigos.RowsRemoved += dataCodigos_RowsRemoved;
            dataCodigos.KeyDown += dataCodigos_KeyDown;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle11;
            Column2.Frozen = true;
            Column2.HeaderText = "Código";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripción";
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column4.DefaultCellStyle = dataGridViewCellStyle12;
            Column4.HeaderText = "Unidades";
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle13;
            Column5.HeaderText = "Precio";
            Column5.Name = "Column5";
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 120;
            // 
            // Column6
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle14;
            Column6.HeaderText = "(%) Des";
            Column6.Name = "Column6";
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle15;
            Column7.HeaderText = "Importe";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightSlateGray;
            panelTop.Controls.Add(btnMin);
            panelTop.Controls.Add(btnMax);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1366, 40);
            panelTop.TabIndex = 10;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Dock = DockStyle.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.redimensionar;
            btnMin.Location = new Point(1141, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(75, 40);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Transparent;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Dock = DockStyle.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = Properties.Resources.maximizar;
            btnMax.Location = new Point(1216, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(75, 40);
            btnMax.TabIndex = 1;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.cerrar;
            btnExit.Location = new Point(1291, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 40);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1048, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 728);
            panel1.TabIndex = 11;
            // 
            // MainView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1366, 768);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Controls.Add(panelLateral);
            Controls.Add(panelTop);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(1366, 768);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataCodigos).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelLateral;
        private Panel panelBody;
        private Label label1;
        private Label tittle;
        private Label lbFolio;
        private TextBox txtFolio;
        private PictureBox pictureBox1;
        private Label lbCajero;
        private ComboBox cbCajero;
        private DataGridView dataCodigos;
        private Label lbUnidades;
        private Label lbDescripcion;
        private Label lbCodigo;
        private TextBox txtUnidades;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Button btnGuardar;
        private Panel panelTop;
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
        private ComboBox cbDescuento;
        private Label lbCliente;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbTotal;
        private Label lbImpuesto;
        private Label lbDescuento;
        private Label lbSubtotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbContadorArticulos;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel1;
    }
}

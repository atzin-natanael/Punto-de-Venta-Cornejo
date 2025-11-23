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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            cbDescuento = new ComboBox();
            lbDescuento = new Label();
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
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
            panelHeader.Controls.Add(lbDescuento);
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
            panelHeader.Location = new Point(0, 55);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1049, 204);
            panelHeader.TabIndex = 1;
            // 
            // cbDescuento
            // 
            cbDescuento.Font = new Font("Arial", 15.75F);
            cbDescuento.FormattingEnabled = true;
            cbDescuento.Items.AddRange(new object[] { "Seleccione una opción...", "VARIOS", "V30", "V37", "V40" });
            cbDescuento.Location = new Point(181, 94);
            cbDescuento.Name = "cbDescuento";
            cbDescuento.Size = new Size(278, 32);
            cbDescuento.TabIndex = 8;
            cbDescuento.SelectedIndexChanged += cbDescuento_SelectedIndexChanged;
            cbDescuento.SelectionChangeCommitted += cbDescuento_SelectionChangeCommitted;
            // 
            // lbDescuento
            // 
            lbDescuento.AutoSize = true;
            lbDescuento.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbDescuento.Location = new Point(94, 97);
            lbDescuento.Name = "lbDescuento";
            lbDescuento.RightToLeft = RightToLeft.Yes;
            lbDescuento.Size = new Size(75, 24);
            lbDescuento.TabIndex = 7;
            lbDescuento.Text = "Cliente";
            // 
            // lbUnidades
            // 
            lbUnidades.AutoSize = true;
            lbUnidades.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbUnidades.Location = new Point(713, 133);
            lbUnidades.Name = "lbUnidades";
            lbUnidades.Size = new Size(104, 24);
            lbUnidades.TabIndex = 0;
            lbUnidades.Text = "Unidades:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbDescripcion.Location = new Point(215, 133);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(127, 24);
            lbDescripcion.TabIndex = 0;
            lbDescripcion.Text = "Descripción:";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbCodigo.Location = new Point(12, 133);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(83, 24);
            lbCodigo.TabIndex = 0;
            lbCodigo.Text = "Código:";
            // 
            // txtUnidades
            // 
            txtUnidades.BorderStyle = BorderStyle.FixedSingle;
            txtUnidades.Font = new Font("Arial", 15.75F);
            txtUnidades.Location = new Point(713, 160);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(188, 32);
            txtUnidades.TabIndex = 5;
            txtUnidades.KeyDown += txtUnidades_KeyDown;
            txtUnidades.KeyPress += txtUnidades_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Arial", 15.75F);
            txtDescripcion.Location = new Point(215, 160);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(482, 32);
            txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Arial", 15.75F);
            txtCodigo.Location = new Point(12, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 32);
            txtCodigo.TabIndex = 3;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // cbCajero
            // 
            cbCajero.DrawMode = DrawMode.OwnerDrawFixed;
            cbCajero.Font = new Font("Arial", 15.75F);
            cbCajero.FormattingEnabled = true;
            cbCajero.Items.AddRange(new object[] { "Seleccione una opción..." });
            cbCajero.Location = new Point(181, 50);
            cbCajero.Name = "cbCajero";
            cbCajero.Size = new Size(278, 33);
            cbCajero.TabIndex = 2;
            cbCajero.KeyDown += cbCajero_KeyDown;
            // 
            // lbCajero
            // 
            lbCajero.AutoSize = true;
            lbCajero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbCajero.Location = new Point(98, 50);
            lbCajero.Name = "lbCajero";
            lbCajero.RightToLeft = RightToLeft.Yes;
            lbCajero.Size = new Size(71, 24);
            lbCajero.TabIndex = 0;
            lbCajero.Text = "Cajero";
            // 
            // lbFolio
            // 
            lbFolio.AutoSize = true;
            lbFolio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbFolio.Location = new Point(22, 11);
            lbFolio.Name = "lbFolio";
            lbFolio.RightToLeft = RightToLeft.Yes;
            lbFolio.Size = new Size(147, 24);
            lbFolio.TabIndex = 0;
            lbFolio.Text = "Folio de Venta";
            // 
            // txtFolio
            // 
            txtFolio.BorderStyle = BorderStyle.FixedSingle;
            txtFolio.CharacterCasing = CharacterCasing.Upper;
            txtFolio.Font = new Font("Arial", 15.75F);
            txtFolio.Location = new Point(181, 9);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(278, 32);
            txtFolio.TabIndex = 1;
            txtFolio.KeyDown += txtFolio_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(658, 11);
            label1.Name = "label1";
            label1.Size = new Size(102, 46);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tittle
            // 
            tittle.Anchor = AnchorStyles.None;
            tittle.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittle.ForeColor = Color.SlateGray;
            tittle.Location = new Point(478, 11);
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
            btnGuardar.Location = new Point(0, 574);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(315, 137);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Finalizar Venta";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(240, 242, 245);
            panelLateral.BorderStyle = BorderStyle.FixedSingle;
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Controls.Add(tableLayoutPanel1);
            panelLateral.Controls.Add(btnGuardar);
            panelLateral.Dock = DockStyle.Right;
            panelLateral.Location = new Point(1049, 55);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(317, 713);
            panelLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 242, 245);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LogoCornejo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 226);
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
            tableLayoutPanel1.Controls.Add(label11, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 346);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel1.Size = new Size(315, 228);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Arial", 14.25F);
            label11.Location = new Point(122, 0);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(193, 41);
            label11.TabIndex = 9;
            label11.Text = "0";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Arial", 14.25F);
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(122, 41);
            label10.TabIndex = 8;
            label10.Text = "Articulos:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(45, 60, 80);
            label9.Dock = DockStyle.Fill;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(122, 164);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(193, 64);
            label9.TabIndex = 7;
            label9.Text = "$ 0";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Arial", 14.25F);
            label8.Location = new Point(122, 123);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(193, 41);
            label8.TabIndex = 6;
            label8.Text = "$ 0";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Arial", 14.25F);
            label7.Location = new Point(122, 82);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(193, 41);
            label7.TabIndex = 5;
            label7.Text = "$ 0";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Arial", 14.25F);
            label6.Location = new Point(122, 41);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(193, 41);
            label6.TabIndex = 4;
            label6.Text = "$ 0";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 14.25F);
            label2.Location = new Point(0, 41);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(122, 41);
            label2.TabIndex = 0;
            label2.Text = "SubTotal:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial", 14.25F);
            label3.Location = new Point(0, 82);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(122, 41);
            label3.TabIndex = 1;
            label3.Text = "Descuento:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Arial", 14.25F);
            label4.Location = new Point(0, 123);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(122, 41);
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
            label5.Size = new Size(122, 64);
            label5.TabIndex = 3;
            label5.Text = "Total:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Beige;
            panelBody.Controls.Add(dataCodigos);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 259);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1049, 509);
            panelBody.TabIndex = 2;
            // 
            // dataCodigos
            // 
            dataCodigos.AllowUserToAddRows = false;
            dataCodigos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataCodigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataCodigos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dataCodigos.BorderStyle = BorderStyle.None;
            dataCodigos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCodigos.ColumnHeadersHeight = 50;
            dataCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataCodigos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataCodigos.DefaultCellStyle = dataGridViewCellStyle8;
            dataCodigos.Dock = DockStyle.Fill;
            dataCodigos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataCodigos.EnableHeadersVisualStyles = false;
            dataCodigos.GridColor = Color.Beige;
            dataCodigos.Location = new Point(0, 0);
            dataCodigos.Name = "dataCodigos";
            dataCodigos.RowHeadersVisible = false;
            dataCodigos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCodigos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataCodigos.Size = new Size(1049, 509);
            dataCodigos.TabIndex = 0;
            dataCodigos.CellEndEdit += dataCodigos_CellEndEdit;
            dataCodigos.CellMouseDown += dataCodigos_CellMouseDown;
            dataCodigos.CellValidating += dataCodigos_CellValidating;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Unidades";
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.HeaderText = "Precio";
            Column5.Name = "Column5";
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle6;
            Column6.HeaderText = "(%) Des";
            Column6.Name = "Column6";
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle7;
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
            panelTop.Size = new Size(1366, 55);
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
            btnMin.Size = new Size(75, 55);
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
            btnMax.Size = new Size(75, 55);
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
            btnExit.Size = new Size(75, 55);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1366, 768);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
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
        private Label lbDescuento;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label11;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}

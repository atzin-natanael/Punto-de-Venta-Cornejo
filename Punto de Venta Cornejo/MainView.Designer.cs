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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            panelBody = new Panel();
            dataCodigos = new DataGridView();
            panelTop = new Panel();
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCodigos).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Beige;
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
            panelHeader.Location = new Point(0, 38);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1366, 204);
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
            lbDescuento.Location = new Point(59, 97);
            lbDescuento.Name = "lbDescuento";
            lbDescuento.Size = new Size(116, 24);
            lbDescuento.TabIndex = 7;
            lbDescuento.Text = "Descuento:";
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
            lbDescripcion.Location = new Point(215, 129);
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
            lbCajero.Size = new Size(77, 24);
            lbCajero.TabIndex = 0;
            lbCajero.Text = "Cajero:";
            // 
            // lbFolio
            // 
            lbFolio.AutoSize = true;
            lbFolio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbFolio.Location = new Point(22, 11);
            lbFolio.Name = "lbFolio";
            lbFolio.Size = new Size(153, 24);
            lbFolio.TabIndex = 0;
            lbFolio.Text = "Folio de Venta:";
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
            label1.Location = new Point(713, 11);
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
            tittle.Location = new Point(536, 11);
            tittle.Name = "tittle";
            tittle.Size = new Size(219, 46);
            tittle.TabIndex = 0;
            tittle.Text = "Punto de";
            tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Dock = DockStyle.Top;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(0, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(261, 70);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.Beige;
            panelLateral.Controls.Add(btnGuardar);
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Dock = DockStyle.Right;
            panelLateral.Location = new Point(1105, 242);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(261, 526);
            panelLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LogoCornejo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Beige;
            panelBody.Controls.Add(dataCodigos);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 242);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1105, 526);
            panelBody.TabIndex = 2;
            // 
            // dataCodigos
            // 
            dataCodigos.AllowUserToAddRows = false;
            dataCodigos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataCodigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataCodigos.BackgroundColor = Color.Beige;
            dataCodigos.BorderStyle = BorderStyle.None;
            dataCodigos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCodigos.ColumnHeadersHeight = 50;
            dataCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataCodigos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataCodigos.DefaultCellStyle = dataGridViewCellStyle7;
            dataCodigos.Dock = DockStyle.Fill;
            dataCodigos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataCodigos.EnableHeadersVisualStyles = false;
            dataCodigos.GridColor = Color.Beige;
            dataCodigos.Location = new Point(0, 0);
            dataCodigos.Name = "dataCodigos";
            dataCodigos.RowHeadersVisible = false;
            dataCodigos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCodigos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataCodigos.Size = new Size(1105, 526);
            dataCodigos.TabIndex = 0;
            dataCodigos.CellEndEdit += dataCodigos_CellEndEdit;
            dataCodigos.CellMouseDown += dataCodigos_CellMouseDown;
            dataCodigos.CellValidating += dataCodigos_CellValidating;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Controls.Add(btnMin);
            panelTop.Controls.Add(btnMax);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1366, 38);
            panelTop.TabIndex = 10;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Blue;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Dock = DockStyle.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(1141, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(75, 38);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Green;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Dock = DockStyle.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Location = new Point(1216, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(75, 38);
            btnMax.TabIndex = 1;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1291, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 38);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column4.DefaultCellStyle = dataGridViewCellStyle3;
            Column4.HeaderText = "Unidades";
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.HeaderText = "Precio";
            Column5.Name = "Column5";
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column6.DefaultCellStyle = dataGridViewCellStyle5;
            Column6.HeaderText = "(%) Des";
            Column6.Name = "Column6";
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column6.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle6;
            Column7.HeaderText = "Importe";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // MainView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1366, 768);
            Controls.Add(panelBody);
            Controls.Add(panelLateral);
            Controls.Add(panelHeader);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}

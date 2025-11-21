namespace Punto_de_Venta_Cornejo
{
    partial class Form1
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
            panelHeader = new Panel();
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
            panelLateral = new Panel();
            pictureBox1 = new PictureBox();
            panelBody = new Panel();
            dataCodigos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCodigos).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Beige;
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
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1350, 204);
            panelHeader.TabIndex = 0;
            // 
            // lbUnidades
            // 
            lbUnidades.AutoSize = true;
            lbUnidades.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUnidades.Location = new Point(713, 138);
            lbUnidades.Name = "lbUnidades";
            lbUnidades.Size = new Size(88, 19);
            lbUnidades.TabIndex = 8;
            lbUnidades.Text = "Unidades:";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDescripcion.Location = new Point(215, 138);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(107, 19);
            lbDescripcion.TabIndex = 7;
            lbDescripcion.Text = "Descripción:";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCodigo.Location = new Point(12, 138);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(71, 19);
            lbCodigo.TabIndex = 6;
            lbCodigo.Text = "Código:";
            // 
            // txtUnidades
            // 
            txtUnidades.BorderStyle = BorderStyle.FixedSingle;
            txtUnidades.Location = new Point(713, 160);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(188, 26);
            txtUnidades.TabIndex = 5;
            txtUnidades.KeyDown += txtUnidades_KeyDown;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(215, 160);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(482, 26);
            txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(12, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(188, 26);
            txtCodigo.TabIndex = 3;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // cbCajero
            // 
            cbCajero.FormattingEnabled = true;
            cbCajero.Location = new Point(161, 69);
            cbCajero.Name = "cbCajero";
            cbCajero.Size = new Size(188, 26);
            cbCajero.TabIndex = 2;
            cbCajero.KeyDown += cbCajero_KeyDown;
            // 
            // lbCajero
            // 
            lbCajero.AutoSize = true;
            lbCajero.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCajero.Location = new Point(90, 76);
            lbCajero.Name = "lbCajero";
            lbCajero.Size = new Size(65, 19);
            lbCajero.TabIndex = 0;
            lbCajero.Text = "Cajero:";
            // 
            // lbFolio
            // 
            lbFolio.AutoSize = true;
            lbFolio.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFolio.Location = new Point(32, 28);
            lbFolio.Name = "lbFolio";
            lbFolio.Size = new Size(123, 19);
            lbFolio.TabIndex = 0;
            lbFolio.Text = "Folio de Venta:";
            // 
            // txtFolio
            // 
            txtFolio.BorderStyle = BorderStyle.FixedSingle;
            txtFolio.Location = new Point(161, 25);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(188, 26);
            txtFolio.TabIndex = 1;
            txtFolio.KeyDown += txtFolio_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(690, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 46);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tittle
            // 
            tittle.Anchor = AnchorStyles.None;
            tittle.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittle.Location = new Point(522, 40);
            tittle.Name = "tittle";
            tittle.Size = new Size(219, 46);
            tittle.TabIndex = 0;
            tittle.Text = "Punto de";
            tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.Beige;
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Dock = DockStyle.Right;
            panelLateral.Location = new Point(1089, 204);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(261, 525);
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
            panelBody.Location = new Point(0, 204);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1089, 525);
            panelBody.TabIndex = 2;
            // 
            // dataCodigos
            // 
            dataCodigos.AllowUserToAddRows = false;
            dataCodigos.AllowUserToResizeRows = false;
            dataCodigos.BackgroundColor = Color.Beige;
            dataCodigos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataCodigos.ColumnHeadersHeight = 30;
            dataCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataCodigos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataCodigos.DefaultCellStyle = dataGridViewCellStyle2;
            dataCodigos.Dock = DockStyle.Fill;
            dataCodigos.EnableHeadersVisualStyles = false;
            dataCodigos.GridColor = Color.Beige;
            dataCodigos.Location = new Point(0, 0);
            dataCodigos.Name = "dataCodigos";
            dataCodigos.ReadOnly = true;
            dataCodigos.RowHeadersVisible = false;
            dataCodigos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCodigos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataCodigos.Size = new Size(1089, 525);
            dataCodigos.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Código";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripción";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Unidades";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Precio";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Descuento";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelBody);
            Controls.Add(panelLateral);
            Controls.Add(panelHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lbUnidades;
        private Label lbDescripcion;
        private Label lbCodigo;
        private TextBox txtUnidades;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
    }
}

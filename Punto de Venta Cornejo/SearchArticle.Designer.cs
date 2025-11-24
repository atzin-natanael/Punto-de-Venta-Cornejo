namespace Punto_de_Venta_Cornejo
{
    partial class SearchArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelTop = new Panel();
            panelBottom = new Panel();
            btnClose = new Button();
            btnAceptar = new Button();
            dataCodigos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lbDescripcion = new Label();
            lbCodigo = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCodigos).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(240, 242, 245);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1068, 40);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(240, 242, 245);
            panelBottom.Controls.Add(btnClose);
            panelBottom.Controls.Add(btnAceptar);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 695);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1068, 73);
            panelBottom.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.SteelBlue;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(592, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cancelar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.BackColor = Color.SteelBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(349, 21);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 40);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dataCodigos
            // 
            dataCodigos.AllowUserToAddRows = false;
            dataCodigos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataCodigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataCodigos.BackgroundColor = Color.FromArgb(240, 242, 245);
            dataCodigos.BorderStyle = BorderStyle.None;
            dataCodigos.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataCodigos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCodigos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCodigos.ColumnHeadersHeight = 40;
            dataCodigos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataCodigos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataCodigos.DefaultCellStyle = dataGridViewCellStyle6;
            dataCodigos.Dock = DockStyle.Bottom;
            dataCodigos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataCodigos.EnableHeadersVisualStyles = false;
            dataCodigos.GridColor = Color.Beige;
            dataCodigos.Location = new Point(0, 127);
            dataCodigos.Name = "dataCodigos";
            dataCodigos.RowHeadersVisible = false;
            dataCodigos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataCodigos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataCodigos.Size = new Size(1068, 568);
            dataCodigos.TabIndex = 1;
            dataCodigos.KeyDown += dataCodigos_KeyDown;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.Frozen = true;
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Descripción";
            Column2.Name = "Column2";
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 120;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column4.DefaultCellStyle = dataGridViewCellStyle5;
            Column4.HeaderText = "Existencia";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbDescripcion.Location = new Point(180, 48);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(94, 20);
            lbDescripcion.TabIndex = 5;
            lbDescripcion.Text = "Descripción:";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbCodigo.Location = new Point(12, 48);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(62, 20);
            lbCodigo.TabIndex = 6;
            lbCodigo.Text = "Código:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(180, 71);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(397, 29);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.KeyDown += txtDescripcion_KeyDown;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(12, 71);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(148, 29);
            txtCodigo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(598, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 37);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // SearchArticle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1068, 768);
            Controls.Add(btnBuscar);
            Controls.Add(lbDescripcion);
            Controls.Add(lbCodigo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(dataCodigos);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SearchArticle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchArticle";
            Load += SearchArticle_Load;
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataCodigos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Button btnAceptar;
        private DataGridView dataCodigos;
        private Label lbDescripcion;
        private Label lbCodigo;
        private Button btnClose;
        public TextBox txtDescripcion;
        public TextBox txtCodigo;
        public Button btnBuscar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
namespace Punto_de_Venta_Cornejo
{
    partial class MessageBoxExistencia
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
            btnAceptar = new Button();
            richText = new RichTextBox();
            panelFull = new Panel();
            panelTop = new Panel();
            panelFull.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SteelBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(190, 223);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 40);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // richText
            // 
            richText.BackColor = Color.FromArgb(240, 242, 245);
            richText.BorderStyle = BorderStyle.None;
            richText.Cursor = Cursors.Hand;
            richText.Dock = DockStyle.Top;
            richText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richText.Location = new Point(0, 26);
            richText.Name = "richText";
            richText.ReadOnly = true;
            richText.Size = new Size(527, 180);
            richText.TabIndex = 2;
            richText.Text = "";
            richText.MouseDown += richText_MouseDown;
            // 
            // panelFull
            // 
            panelFull.BackColor = Color.FromArgb(240, 242, 245);
            panelFull.BorderStyle = BorderStyle.FixedSingle;
            panelFull.Controls.Add(richText);
            panelFull.Controls.Add(panelTop);
            panelFull.Controls.Add(btnAceptar);
            panelFull.Dock = DockStyle.Fill;
            panelFull.Location = new Point(0, 0);
            panelFull.Name = "panelFull";
            panelFull.Size = new Size(529, 268);
            panelFull.TabIndex = 2;
            // 
            // panelTop
            // 
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(527, 26);
            panelTop.TabIndex = 3;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // MessageBoxExistencia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Beige;
            ClientSize = new Size(529, 268);
            Controls.Add(panelFull);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MessageBoxExistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxExistencia";
            panelFull.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        public RichTextBox richText;
        private Panel panelFull;
        private Panel panelTop;
    }
}
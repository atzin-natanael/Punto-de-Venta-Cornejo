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
            panelMessage = new Panel();
            btnAceptar = new Button();
            richText = new RichTextBox();
            panelFull = new Panel();
            panelFull.SuspendLayout();
            SuspendLayout();
            // 
            // panelMessage
            // 
            panelMessage.BackColor = SystemColors.ActiveCaption;
            panelMessage.Cursor = Cursors.Hand;
            panelMessage.Dock = DockStyle.Top;
            panelMessage.Location = new Point(0, 0);
            panelMessage.Name = "panelMessage";
            panelMessage.Size = new Size(529, 38);
            panelMessage.TabIndex = 0;
            panelMessage.MouseDown += panelMessage_MouseDown;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(190, 148);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 40);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // richText
            // 
            richText.BackColor = Color.Beige;
            richText.BorderStyle = BorderStyle.None;
            richText.Dock = DockStyle.Top;
            richText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richText.Location = new Point(0, 0);
            richText.Name = "richText";
            richText.Size = new Size(527, 142);
            richText.TabIndex = 2;
            richText.Text = "";
            // 
            // panelFull
            // 
            panelFull.BorderStyle = BorderStyle.FixedSingle;
            panelFull.Controls.Add(richText);
            panelFull.Controls.Add(btnAceptar);
            panelFull.Dock = DockStyle.Fill;
            panelFull.Location = new Point(0, 38);
            panelFull.Name = "panelFull";
            panelFull.Size = new Size(529, 201);
            panelFull.TabIndex = 2;
            // 
            // MessageBoxExistencia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Beige;
            ClientSize = new Size(529, 239);
            Controls.Add(panelFull);
            Controls.Add(panelMessage);
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

        private Panel panelMessage;
        private Button btnAceptar;
        public RichTextBox richText;
        private Panel panelFull;
    }
}
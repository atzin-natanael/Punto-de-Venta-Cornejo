using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punto_de_Venta_Cornejo
{
    public partial class MensajeError : Form
    {
        public MensajeError()
        {
            InitializeComponent();
        }

        private void MensajeError_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.Close();
            }
        }
    }
}

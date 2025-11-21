using System;
using System.Collections.Generic;
using System.Text;

namespace Punto_de_Venta_Cornejo
{
    public class GlobalSettings
    {
        private static GlobalSettings instance;
        public string ConnectionLocalDb { get; set; } = "Data Source=C:\\CapturaDeVentas\\";
        public string Ip { get; set; }
        public string Puerto { get; set; }
        public string Direccion { get; set; }
        public int posicion { get; set; }
        public string User { get; set; }
        public string Pw { get; set; }
        public string Ruta { get; set; }
        public List<string> Config { get; set; }
        public int Bd { get; set; }
        public int Trn { get; set; }
        private GlobalSettings()
        {
            Config = new List<string>();

        }
        public static GlobalSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalSettings();
                }
                return instance;
            }
        }
    }
}

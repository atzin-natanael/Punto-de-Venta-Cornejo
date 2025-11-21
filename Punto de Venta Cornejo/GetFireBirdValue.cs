using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Punto_de_Venta_Cornejo
{
    public class GetFireBirdValue
    {
        public static string GetValue(string connection, string query)
        {
            try
            {
                using (FbConnection con = new FbConnection(connection))
                {
                    con.Open();

                    using (FbCommand command = new FbCommand(query, con))
                    using (FbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        static public string? GetDiscountByClient(string cliente_id)
        {
            var sql = "SELECT POLITICAS_DSCTOS_ART_CLI.DESCUENTO" +
            "            FROM DIRS_CLIENTES" +
            "           JOIN CLAVES_CLIENTES ON CLAVES_CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
            "            JOIN PRECIOS_CLI_CLI ON PRECIOS_CLI_CLI.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
            "            JOIN POLITICAS_DSCTOS_ART_CLI ON POLITICAS_DSCTOS_ART_CLI.POLITICA_DSCTO_ART_CLI_ID = PRECIOS_CLI_CLI.POLITICA_DSCTO_ART_CLI_ID" +
            "           WHERE DIRS_CLIENTES.CLIENTE_ID =  @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", cliente_id}
            });

            return rows.FirstOrDefault();
        }
        static public string? GetDiscountByArticle(string articulo_id)
        {
            var sql = "SELECT dpl.DESCUENTO, " +
          "       pdp.FECHA_INI_VIGENCIA, " +
          "       pdp.FECHA_FIN_VIGENCIA " +
              "FROM ARTICULOS a " +
              "JOIN DSCTOS_PROMO_LINEAS dpl ON dpl.LINEA_ARTICULO_ID = a.LINEA_ARTICULO_ID " +
              "JOIN POLITICAS_DSCTOS_PROMOCION pdp ON pdp.POLITICA_DSCTO_PROMO_ID = dpl.POLITICA_DSCTO_PROMO_ID " +
              "WHERE a.ARTICULO_ID = @articuloId " +
              "AND CURRENT_DATE BETWEEN pdp.FECHA_INI_VIGENCIA AND pdp.FECHA_FIN_VIGENCIA;";

            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@articuloId", articulo_id}
            });

            return rows.FirstOrDefault();
        }

    }
}

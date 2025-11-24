using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

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
        static public string? GetImpuesto(string articulo_id)
        {
            var sql = @"SELECT IMPUESTOS.PCTJE_IMPUESTO 
                FROM IMPUESTOS
                JOIN IMPUESTOS_ARTICULOS 
                  ON IMPUESTOS_ARTICULOS.IMPUESTO_ID = IMPUESTOS.IMPUESTO_ID
                WHERE IMPUESTOS_ARTICULOS.ARTICULO_ID = @a";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@a", articulo_id}
            });
            return rows.FirstOrDefault();
        }
        static public string? GetExistencia(string articulo_id, string almacenid)
        {
            using (FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection))
            {
                try
                {
                    con.Open();
                    using (FbCommand command = new FbCommand("EXIVAL_ART", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // --- 1. PARÁMETROS DE ENTRADA (5) ---
                        command.Parameters.Add("V_ARTICULO_ID", FbDbType.Integer).Value = articulo_id;
                        command.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = almacenid;
                        command.Parameters.Add("V_FECHA", FbDbType.Date).Value = DateTime.Today;
                        command.Parameters.Add("V_ES_ULTIMO_COSTO", FbDbType.Char).Value = 'S';
                        command.Parameters.Add("V_SUCURSAL_ID", FbDbType.Integer).Value = 0;

                        // --- 2. PARÁMETROS DE SALIDA (4) ---
                        // Se deben declarar todos los outputs que devuelve el SP para mapear la respuesta
                        // aunque solo usemos EXISTENCIA.

                        FbParameter pArticuloId = command.Parameters.Add("ARTICULO_ID", FbDbType.Numeric);
                        pArticuloId.Direction = ParameterDirection.Output;

                        FbParameter pExistencia = command.Parameters.Add("EXISTENCIA", FbDbType.Numeric);
                        pExistencia.Direction = ParameterDirection.Output;

                        FbParameter pValorUnitario = command.Parameters.Add("VALOR_UNITARIO", FbDbType.Numeric);
                        pValorUnitario.Direction = ParameterDirection.Output;

                        FbParameter pValorTotal = command.Parameters.Add("VALOR_TOTAL", FbDbType.Numeric);
                        pValorTotal.Direction = ParameterDirection.Output;

                        // Ejecutar el procedimiento almacenado
                        command.ExecuteNonQuery();

                        // 3. OBTENER EL VALOR USANDO EL OBJETO DECLARADO (¡La clave!)
                        if (pExistencia.Value == DBNull.Value) return "0";

                        // Usamos Convert.ToDecimal para no perder decimales, y luego a Int32 si la existencia es entera.
                        return Convert.ToInt32(pExistencia.Value).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                    return null;
                }
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
        public static DataTable BuscarArticulosByDesc(string parametros)
        {
            string query = $@"
                    SELECT CLAVES_ARTICULOS.CLAVE_ARTICULO, ARTICULOS.NOMBRE, PRECIOS_ARTICULOS.PRECIO  
                    FROM ARTICULOS
                    JOIN CLAVES_ARTICULOS ON CLAVES_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    JOIN PRECIOS_ARTICULOS ON PRECIOS_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    WHERE CLAVES_ARTICULOS.ROL_CLAVE_ART_ID = '17'
                    AND PRECIOS_ARTICULOS.PRECIO_EMPRESA_ID = '42'";
            string[] arrayParametros = parametros.Split(' ');
            // 4. Ciclo: Agregar un filtro por cada palabra
                foreach (string parametro in arrayParametros)
                {
                    query += $@"AND ARTICULOS.NOMBRE LIKE '%{parametro}%'";
                }
                query += " ORDER BY ARTICULOS.NOMBRE ASC ROWS 50";
            // Llamada a tu Helper
            // ✅ CORRECTO. Pasas el diccionario completo (con @p0, @p1, etc.) directamente.
            try
            {
                using (FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection))
                {
                    con.Open();
                    using (FbCommand command = new FbCommand(query, con))
                    {
                        // Si usas el SQL dinámico: @p0, @p1, etc.
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader); // cargar sin mover el cursor
                            return dt;
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

    }
}

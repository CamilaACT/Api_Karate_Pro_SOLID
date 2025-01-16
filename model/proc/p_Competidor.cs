using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.model.proc
{
    public class p_Competidor
    {
        public static Respuesta actualizaCompetidor(competidor_A_competidor competidor)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[7];
                cb.sp = "usp_Web_competidor_A_competidor";//poner el nombre correcto
                vector[0] = "@cmp_id,i," + competidor.cmp_id;
                vector[1] = "@cmp_nombre,v," + competidor.cmp_nombre;
                vector[2] = "@cmp_fech_naci,v," + competidor.cmp_fech_naci;
                vector[3] = "@cmp_peso,i," + competidor.cmp_peso;
                vector[4] = "@cmp_cedula,v," + competidor.cmp_cedula;
                vector[5] = "@ran_id,i," + competidor.ran_id;
                vector[6] = "@clu_id,i," + competidor.clu_id;
                dt = cb.consultar(vector,7, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static Respuesta consultaTodoCompetidor()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_competidor_CT_competidor";//poner el nombre correcto
                dt = cb.consultar(vector, 0, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static Respuesta eliminaCompetidor(int cmp_id)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_competidor_E_competidor";//poner el nombre correcto
                vector[0] = "@cmp_id,i," + cmp_id;
                dt = cb.consultar(vector, 1, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static Respuesta grabaCompetidor(competidor_A_competidor competidor)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[6];
                cb.sp = "usp_Web_competidor_G_competidor";//poner el nombre correcto
                vector[0] = "@cmp_nombre,v," + competidor.cmp_nombre;
                vector[1] = "@cmp_fech_naci,vkk," + competidor.cmp_fech_naci;
                vector[2] = "@cmp_peso,i," + competidor.cmp_peso;
                vector[3] = "@cmp_cedula,v," + competidor.cmp_cedula;
                vector[4] = "@ran_id,i," + competidor.ran_id;
                vector[5] = "@clu_id,i," + competidor.clu_id;
                dt = cb.consultar(vector,6, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static List<Dictionary<string, object>> DataTableToList(DataTable dt)
        {
            var list = new List<Dictionary<string, object>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                list.Add(dict);
            }

            return list;
        }


        public static bool EsCedulaValida(string cedula)
        {
            // Verificar que tenga exactamente 10 dígitos
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 10 || !long.TryParse(cedula, out _))
                return false;

            // Extraer el código de provincia (2 primeros dígitos)
            int codigoProvincia = int.Parse(cedula.Substring(0, 2));
            if (codigoProvincia < 1 || (codigoProvincia > 24 && codigoProvincia != 30))
                return false;

            // Cálculo del dígito verificador
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 }; // Coeficientes para las posiciones 1-9
            int suma = 0;

            for (int i = 0; i < coeficientes.Length; i++)
            {
                int valor = (cedula[i] - '0') * coeficientes[i]; // Multiplicar el dígito por el coeficiente
                suma += valor > 9 ? valor - 9 : valor; // Si el resultado es mayor a 9, restar 9
            }

            int digitoVerificadorCalculado = 10 - (suma % 10);
            if (digitoVerificadorCalculado == 10)
                digitoVerificadorCalculado = 0;

            int digitoVerificadorCedido = cedula[9] - '0'; // Último dígito de la cédula
            return digitoVerificadorCalculado == digitoVerificadorCedido;
        }
    }
}

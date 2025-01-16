using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.model.proc
{
    public class p_Tecnica
    {

        public static Respuesta actualizaTecnica(tecnica_A_tecnica tecnica)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[3];
                cb.sp = "usp_Web_tecnica_A_tecnica";//poner el nombre correcto
                vector[0] = "@tec_id,i," + tecnica.tec_id;
                vector[1] = "@tec_nombre,v," + tecnica.tec_nombre;
                vector[2] = "@tec_puntos,i," + tecnica.tec_puntos;
                dt = cb.consultar(vector, 3, strCon);

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

        public static Respuesta consultaTodoTecnica()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_tecnica_CT_tecnica";//poner el nombre correcto
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

        public static Respuesta eliminaTecnica(int tec_id)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_tecnica_E_tecnica";//poner el nombre correcto
                vector[0] = "@tec_id,i," + tec_id;
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

        public static Respuesta grabaTecnica(tecnica_A_tecnica tecnica)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[2];
                cb.sp = "usp_Web_tecnica_G_tecnica";//poner el nombre correcto
                vector[0] = "@tec_nombre,v," + tecnica.tec_nombre;
                vector[1] = "@tec_puntos,i," + tecnica.tec_puntos;
                dt = cb.consultar(vector, 2, strCon);

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
    }
}

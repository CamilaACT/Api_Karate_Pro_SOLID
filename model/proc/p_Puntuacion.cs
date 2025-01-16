using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.model.proc
{
    public class p_Puntuacion
    {

        public static Respuesta grabaPuntuacion(puntuacion_A_puntuacion puntuacion)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[3];
                cb.sp = "usp_Web_puntuacion_G_puntuacion";//poner el nombre correcto
                vector[0] = "@tec_id,i," + puntuacion.tec_id;
                vector[1] = "@pun_min,i," + puntuacion.pun_min;
                vector[2] = "@riv_id,i," + puntuacion.riv_id;
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

        public static Respuesta eliminaPelea(int pun_id)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_puntuacion_E_puntuacion";//poner el nombre correcto
                vector[0] = "@pun_id,i," + pun_id;
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


        public static Respuesta consultaPuntuacinPorPelId(int pel_id)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_puntuacion_C_pelId";//poner el nombre correcto
                vector[0] = "@pel_id,i," + pel_id;
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

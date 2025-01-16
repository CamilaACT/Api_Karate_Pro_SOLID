using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.model.proc
{
    public class p_Usuario
    {

        public static Respuesta actualizaUsuario(usuario_A_usuario usuario)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[7];
                cb.sp = "usp_Web_usuario_A_usuario";//poner el nombre correcto
                vector[0] = "@us_id,i," + usuario.usu_id;
                vector[1] = "@rol_id,i," + usuario.rol_id;
                vector[2] = "@usu_nombre,v," + usuario.usu_nombre;
                vector[3] = "@usu_cedula,v," + usuario.usu_cedula;
                vector[4] = "@usu_correo,v," + usuario.usu_correo;
                vector[5] = "@rol_descripcion,v," + usuario.rol_descripcion;
                vector[6] = "@clave,v," + usuario.usu_clave;
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
        public static Respuesta consultaTodoUsuario()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_usuario_CT_usuario";//poner el nombre correcto
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

        public static Respuesta eliminaUsuario(int us_id)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_usuario_E_usuario";//poner el nombre correcto
                vector[0] = "@usu_id,i," + us_id;
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

        public static Respuesta grabaUsuario(usuario_A_usuario usuario)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[6];
                cb.sp = "usp_Web_usuario_G_usuario";//poner el nombre correcto
                vector[0] = "@rol_id,i," + usuario.rol_id;
                vector[1] = "@usu_nombre,v," + usuario.usu_nombre;
                vector[2] = "@usu_cedula,v," + usuario.usu_cedula;
                vector[3] = "@usu_correo,v," + usuario.usu_correo;
                vector[4] = "@rol_descripcion,v," + usuario.rol_descripcion;
                vector[5] = "@clave,v," + usuario.usu_clave;
                dt = cb.consultar(vector, 6, strCon);

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

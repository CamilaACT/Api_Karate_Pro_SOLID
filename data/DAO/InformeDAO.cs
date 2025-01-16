using Api_Karate_Pro.util.Conexion;
using System.Data;

namespace Api_Karate_Pro.data.DAO
{
    public class InformeDAO : IInformeDAO
    {
        public DataTable ObtenerDatosClubesPorCompetencia(int comId)
        {
            c_base_datos cb = new c_base_datos();
            DataTable dt;
            string strCon = Conexion.CadenaConexion();
            string[] vector = { "@com_id,i," + comId };

            cb.sp = "usp_Web_informe_clubesPorCompetencia";
            dt = cb.consultar(vector, 1, strCon);

            return dt;
        }

        public DataTable ObtenerDatosCompetidoresPorClub(int comId, int cluId, int tecId)
        {
            c_base_datos cb = new c_base_datos();
            DataTable dt;
            string strCon = Conexion.CadenaConexion();
            string[] vector = {
                "@com_id,i," + comId,
                "@clu_id,i," + cluId,
                "@tec_id,i," + tecId
            };

            cb.sp = "usp_Web_informe_competidoresporClubCompeTecn";
            dt = cb.consultar(vector, 3, strCon);

            return dt;
        }
    }
}

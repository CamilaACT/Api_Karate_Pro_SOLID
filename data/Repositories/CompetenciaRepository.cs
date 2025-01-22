using Api_Karate_Pro.data.DAO;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.data.Repositories
{
    public class CompetenciaRepository : ICompetenciaRepository
    {
        private readonly IInformeDAO _informeDAO;

        public CompetenciaRepository(IInformeDAO informeDAO)
        {
            _informeDAO = informeDAO;
        }

        public Respuesta ObtenerClubesPorCompetencia(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };

            try
            {
                DataTable dt = _informeDAO.ObtenerDatosClubesPorCompetencia(comId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = DataTableToList(dt);
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }

        public Respuesta ObtenerCompetidoresPorClub(int comId, int cluId, int tecId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };

            try
            {
                DataTable dt = _informeDAO.ObtenerDatosCompetidoresPorClub(comId, cluId, tecId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = DataTableToList(dt);
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }

        private List<Dictionary<string, object>> DataTableToList(DataTable dt)
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

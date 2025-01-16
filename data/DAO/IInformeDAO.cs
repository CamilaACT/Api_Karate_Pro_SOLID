using System.Data;

namespace Api_Karate_Pro.data.DAO
{
    public  interface IInformeDAO
    {
        DataTable ObtenerDatosClubesPorCompetencia(int comId);
        DataTable ObtenerDatosCompetidoresPorClub(int comId, int cluId, int tecId);
    }
}

using Api_Karate_Pro.model.Response;

namespace Api_Karate_Pro.data.Repositories
{
    public interface ICompetenciaRepository
    {
        Respuesta ObtenerClubesPorCompetencia(int comId);
        Respuesta ObtenerCompetidoresPorClub(int comId, int cluId, int tecId);
    }
}

using Api_Karate_Pro.data.DAO;
using Api_Karate_Pro.data.Repositories;
using Api_Karate_Pro.model.Response;
using System.Data;

namespace Api_Karate_Pro.Services
{
    public class InformeService
    {
        private readonly ICompetenciaRepository _competenciaRepository;

        public InformeService(ICompetenciaRepository competenciaRepository)
        {
            _competenciaRepository = competenciaRepository;
        }

        public Respuesta ObtenerClubesPorCompetencia(int comId)
        {
            return _competenciaRepository.ObtenerClubesPorCompetencia(comId);
        }

        public Respuesta ObtenerCompetidoresPorClub(int comId, int cluId, int tecId)
        {
            return _competenciaRepository.ObtenerCompetidoresPorClub(comId, cluId, tecId);
        }
    }
}

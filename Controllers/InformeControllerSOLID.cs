using Api_Karate_Pro.model.Response;
using Api_Karate_Pro.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Karate_Pro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformeControllerSOLID : ControllerBase
    {
        private readonly InformeService _informeService;

        public InformeControllerSOLID(InformeService informeService)
        {
            _informeService = informeService;
        }

        [HttpGet("consultaCompetencias")]
        public Respuesta ObtenerClubesPorCompetencia(int comId)
        {
            return _informeService.ObtenerClubesPorCompetencia(comId);
        }
    }
}

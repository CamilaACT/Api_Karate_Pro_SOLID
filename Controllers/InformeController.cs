using Api_Karate_Pro.model.proc;
using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Karate_Pro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class InformeController : ControllerBase
    {
        [HttpPost]
        [Route("clubPorCompetencia")]
        public Respuesta ro_1_3([FromBody] Informes_clubesPorCompetencia competencia)
        {

            Respuesta res = p_Informe.clubPorCompetencia(competencia);
            return res;
        }

        [HttpPost]
        [Route("clubPorCompetenciaLinq")]
        public Respuesta ro_1_8([FromBody] Informes_clubesPorCompetencia competencia)
        {

            Respuesta res = p_Informe.GetInformeClubesPorCompetencia(competencia.com_id);
            return res;
        }


        [HttpPost]
        [Route("clubPorCompetenciaForeach")]
        public Respuesta ro_1_9([FromBody] Informes_clubesPorCompetencia competencia)
        {

            Respuesta res = p_Informe.GetInformeClubesPorCompetenciaConForeach(competencia.com_id);
            return res;
        }




        [HttpPost]
        [Route("competidorPorClubCompeTec")]
        public Respuesta ro_1_4([FromBody] Informes_competidoresporClubCompeTecn competencia)
        {

            Respuesta res = p_Informe.competidoresporClubCompeTecn(competencia);
            return res;
        }

        [HttpPost]
        [Route("competidorPorClubCompeTecLinq")]
        public Respuesta ro_1_6([FromBody] Informes_competidoresporClubCompeTecn competencia)
        {

            Respuesta res = p_Informe.GetInformeCompetidores(competencia);
            return res;
        }

        [HttpPost]
        [Route("competidorPorClubCompeTecForeach")]
        public Respuesta ro_1_7([FromBody] Informes_competidoresporClubCompeTecn competencia)
        {

            Respuesta res = p_Informe.GetInformeCompetidoresConForeach(competencia);
            return res;
        }

        [HttpGet]

        [Route("consultaCompetencias")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Informe.competencias();
            return res;
        }

        [HttpGet]

        [Route("consultaClubes")]
        public Respuesta m_1_2()
        {
            Respuesta res = p_Informe.clubes();
            return res;
        }

        [HttpGet]

        [Route("consultaTecnicas")]
        public Respuesta m_1_3()
        {
            Respuesta res = p_Informe.tecnicas();
            return res;
        }


        [HttpGet]
        [Route("calcularEficiencia")]
        public Respuesta CalcularEficiencia(int comId)
        {
            return p_Informe.CalcularEficienciaPorEdadYRango(comId);
        }

        [HttpGet]
        [Route("topcompetidores")]
        public Respuesta Topcompetidores(int comId)
        {
            return p_Informe.GetInformeCompetidores(comId);
        }


    }
}

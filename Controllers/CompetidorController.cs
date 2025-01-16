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
    [Authorize]
    public class CompetidorController : ControllerBase
    {

        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Competidor.consultaTodoCompetidor();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta m_1_2([FromBody] competidor_A_competidor competidor)
        {
            if (!p_Competidor.EsCedulaValida(competidor.cmp_cedula))
            {
                Respuesta respu = new Respuesta();
                respu.CodigoError = 2;

                return respu;
            }



            Respuesta res = p_Competidor.actualizaCompetidor(competidor);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta m_1_3([FromBody] competidor_A_competidor competidor)
        {
            if (!p_Competidor.EsCedulaValida(competidor.cmp_cedula))
            {
                Respuesta respu = new Respuesta();
                respu.CodigoError = 2;

                return respu;
            }

            Respuesta res = p_Competidor.grabaCompetidor(competidor);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{cmp_id}")]
        public Respuesta m_1_4(int cmp_id)
        {
            Respuesta res = p_Competidor.eliminaCompetidor(cmp_id);
            return res;
        }
    }
}

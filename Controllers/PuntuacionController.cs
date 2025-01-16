using Api_Karate_Pro.model.proc;
using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Karate_Pro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuntuacionController : ControllerBase
    {


        [HttpGet("consultaPuntosPorPelID/{pel_id}")]
        public Respuesta m_1_1(int pel_id)
        {
            Respuesta res = p_Puntuacion.consultaPuntuacinPorPelId(pel_id);
            return res;
        }

        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] puntuacion_A_puntuacion puntuacion)
        {

            Respuesta res = p_Puntuacion.grabaPuntuacion(puntuacion);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{pun_id}")]
        public Respuesta ro_1_4(int pun_id)
        {
            Respuesta res = p_Puntuacion.eliminaPelea(pun_id);
            return res;
        }
    }
}

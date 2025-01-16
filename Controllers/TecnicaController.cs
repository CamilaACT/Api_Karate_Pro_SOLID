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
    public class TecnicaController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta rol_1_1()
        {
            Respuesta res = p_Tecnica.consultaTodoTecnica();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta ro_1_2([FromBody] tecnica_A_tecnica tecnica)
        {

            Respuesta res = p_Tecnica.actualizaTecnica(tecnica);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] tecnica_A_tecnica tecnica)
        {

            Respuesta res = p_Tecnica.grabaTecnica(tecnica);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{tec_id}")]
        public Respuesta ro_1_4(int tec_id)
        {
            Respuesta res = p_Tecnica.eliminaTecnica(tec_id);
            return res;
        }
    }
}

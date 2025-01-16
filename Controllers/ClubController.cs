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
    public class ClubController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Club.consultaTodoClub();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta m_1_2([FromBody] club_A_club club)
        {

            Respuesta res = p_Club.actualizaClub(club);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] club_A_club club)
        {

            Respuesta res = p_Club.grabaClub(club);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{clu_id}")]
        public Respuesta ro_1_4(int clu_id)
        {
            Respuesta res = p_Club.eliminaClub(clu_id);
            return res;
        }
    }
}

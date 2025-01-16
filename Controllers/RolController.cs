using Api_Karate_Pro.Custom;
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
    public class RolController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta rol_1_1()
        {
            Respuesta res = p_Rol.consultaTodoRol();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta ro_1_2([FromBody] rol_A_rol rol)
        {
            
            Respuesta res = p_Rol.actualizaRol(rol);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] rol_A_rol rol)
        {
            
            Respuesta res = p_Rol.grabaRol(rol);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{rol_id}")]
        public Respuesta ro_1_4(int rol_id)
        {
            Respuesta res = p_Rol.eliminaRol(rol_id);
            return res;
        }
    }
}

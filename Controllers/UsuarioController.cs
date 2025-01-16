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
    public class UsuarioController : ControllerBase
    {
        private readonly Utilidades _utilidades;
        public UsuarioController(Utilidades utilidades)
        {
            _utilidades = utilidades;
        }


        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta Login_1_1()
        {
            Respuesta res = p_Usuario.consultaTodoUsuario();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta Login_1_2([FromBody] usuario_A_usuario usuario)
        {
            var contrasenia = _utilidades.encriptaSHA256(usuario.usu_clave);
            usuario.usu_clave = contrasenia;
            Respuesta res = p_Usuario.actualizaUsuario(usuario);
            return res;
        }

        [HttpPost]

        [Route("grabar")]
        public Respuesta Login_1_3([FromBody] usuario_A_usuario usuario)
        {
            var contrasenia = _utilidades.encriptaSHA256(usuario.usu_clave);
            usuario.usu_clave = contrasenia;
            Respuesta res = p_Usuario.grabaUsuario(usuario);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{us_id}")]
        public Respuesta Login_1_4(int us_id)
        {
            Respuesta res = p_Usuario.eliminaUsuario(us_id);
            return res;
        }
    }
}

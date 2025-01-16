using Api_Karate_Pro.model.proc;
using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Karate_Pro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeleaController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Pelea.consultaTodoPelea();
            return res;
        }

        [HttpGet("consultaRivalesID/{pel_id}")]
        public Respuesta m_1_1(int pel_id)
        {
            Respuesta res = p_Pelea.consultaRivalesID(pel_id);
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta ro_1_2([FromBody] pelea_A_pelea pelea)
        {
            // Verifica si el modelo es válido
            //if (!ModelState.IsValid)
            //{
            //    // Devuelve errores de validación

            //    Respuesta respu = new Respuesta();
            //    respu.CodigoError = 2;

            //    return respu;
            //}
            Respuesta res = p_Pelea.actualizaPelea(pelea);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] pelea_A_pelea pelea)
        {

            Respuesta res = new Respuesta();

            if (pelea.riv_color1 == pelea.riv_color2)
            {
                res.CodigoError = 1;
                res.Message = "Los competidores deben tener colores diferentes: uno rojo y otro azul.";
                return res; 
            }
            Respuesta res2 = p_Pelea.grabaPelea(pelea);
            return res2;
        }
        [HttpPost]

        [Route("grabarGanador")]
        public Respuesta ro_1_3([FromBody] pelea_G_ganador pelea)
        {
            // Verifica si el modelo es válido
            //if (!ModelState.IsValid)
            //{
            //    // Devuelve errores de validación

            //    Respuesta respu = new Respuesta();
            //    respu.CodigoError = 2;

            //    return respu;
            //}

            Respuesta res = p_Pelea.grabaGanador(pelea);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{pel_id}")]
        public Respuesta ro_1_4(int pel_id)
        {
            Respuesta res = p_Pelea.eliminaPelea(pel_id);
            return res;
        }
    }
}

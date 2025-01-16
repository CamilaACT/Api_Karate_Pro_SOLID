using System.ComponentModel.DataAnnotations;

namespace Api_Karate_Pro.model.Request
{
    public class pelea_G_ganador
    {
        public int pel_id { get; set; }
    }


    //public class pelea_G_ganador
    //{
    //    [Required(ErrorMessage = "El ID de la pelea es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El ID de la pelea debe ser un número positivo.")]
    //    public int pel_id { get; set; }
    //}
}

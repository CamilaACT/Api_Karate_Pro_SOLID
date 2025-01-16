using System.ComponentModel.DataAnnotations;

namespace Api_Karate_Pro.model.Request
{
    public class pelea_A_pelea
    {
        public string pel_hora { get; set; }
        public int pel_id { get; set; }
        public int com_id { get; set; }
        public int cmp_id_1 { get; set; }
        public int cmp_id_2 { get; set; }
        public int riv_color1 { get; set; }
        public int riv_color2 { get; set; }
        public string tec_puntos { get; set; }
    }

    //public class pelea_A_pelea
    //{
    //    [Required(ErrorMessage = "La hora de la pelea es obligatoria.")]

    //    public string pel_hora { get; set; }

    //    [Required(ErrorMessage = "El ID de la pelea es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El ID de la pelea debe ser un número positivo.")]
    //    public int pel_id { get; set; }

    //    [Required(ErrorMessage = "El ID de la competencia es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El ID de la competencia debe ser un número positivo.")]
    //    public int com_id { get; set; }

    //    [Required(ErrorMessage = "El ID del competidor 1 es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El ID del competidor 1 debe ser un número positivo.")]
    //    public int cmp_id_1 { get; set; }

    //    [Required(ErrorMessage = "El ID del competidor 2 es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El ID del competidor 2 debe ser un número positivo.")]
    //    public int cmp_id_2 { get; set; }

    //    [Required(ErrorMessage = "El color del rival 1 es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El color del rival 1 debe ser un número positivo.")]
    //    public int riv_color1 { get; set; }

    //    [Required(ErrorMessage = "El color del rival 2 es obligatorio.")]
    //    [Range(1, int.MaxValue, ErrorMessage = "El color del rival 2 debe ser un número positivo.")]
    //    public int riv_color2 { get; set; }

    //    [Required(ErrorMessage = "Los puntos técnicos son obligatorios.")]
    //    [StringLength(50, ErrorMessage = "Los puntos técnicos no deben exceder los 50 caracteres.")]
    //    public string tec_puntos { get; set; }
    //}

}

namespace Api_Karate_Pro.model.Request
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int idRol { get; set; }
        public string rolDescripcion { get; set; }
        public string clave { get; set; }
        public int status { get; set; }


    }
}

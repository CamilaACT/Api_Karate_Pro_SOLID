using System.Data.SqlClient;

namespace Api_Karate_Pro.util
{
    public sealed class ConexionSingleton
    {
        private static ConexionSingleton _instancia;
        private static readonly object _bloqueo = new object();
        private SqlConnection _conexion;

        private ConexionSingleton()
        {
            string cadenaConexion = Conexion.Conexion.CadenaConexion(); // Método estático que devuelve la cadena de conexión
            _conexion = new SqlConnection(cadenaConexion);
        }

        public static ConexionSingleton ObtenerInstancia()
        {
            if (_instancia == null)
            {
                lock (_bloqueo) // Bloqueo para asegurar que no se creen múltiples instancias en entornos multihilo
                {
                    if (_instancia == null)
                    {
                        _instancia = new ConexionSingleton();
                    }
                }
            }
            return _instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            if (_conexion.State == System.Data.ConnectionState.Closed || _conexion.State == System.Data.ConnectionState.Broken)
            {
                _conexion.Open();
            }
            return _conexion;
        }
    }
}

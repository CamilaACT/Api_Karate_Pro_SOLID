namespace Api_Karate_Pro.util.Conexion
{
    public class Conexion
    {

        private static string servidor = @"camilacabrera.database.windows.net";
        //private static string servidor = @"host.docker.internal\CAMILASQL";
        private static string base_tip = "KaratePro";
        private static string usuario = "camila";
        private static string password = "Cact2003*";
        //private static string usuario = "sa";
        //private static string password = "sasa";
        private static string clav_priv = "dfaeiriecmvjhe3943dfadahyeu3456";
        public static string CadenaConexion()
        {

            return "Data Source=" + servidor + ";Initial Catalog=" + base_tip + ";User ID=" + usuario + ";Password=" + password;
        }


    }
}

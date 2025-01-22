using Api_Karate_Pro.model.Request;

namespace Api_Karate_Pro.model.Builders
{
    public class CompetidorBuilder
    {
        private readonly competidor_A_competidor _competidor;

        public CompetidorBuilder()
        {
            _competidor = new competidor_A_competidor();
        }

        public CompetidorBuilder ConId(int id)
        {
            _competidor.cmp_id = id;
            return this;
        }

        public CompetidorBuilder ConNombre(string nombre)
        {
            _competidor.cmp_nombre = nombre;
            return this;
        }

        public CompetidorBuilder ConFechaNacimiento(string fechaNacimiento)
        {
            _competidor.cmp_fech_naci = fechaNacimiento;
            return this;
        }

        public CompetidorBuilder ConPeso(double peso)
        {
            _competidor.cmp_peso = peso;
            return this;
        }

        public CompetidorBuilder ConCedula(string cedula)
        {
            _competidor.cmp_cedula = cedula;
            return this;
        }

        public CompetidorBuilder ConRangoId(int rangoId)
        {
            _competidor.ran_id = rangoId;
            return this;
        }

        public CompetidorBuilder ConClubId(int clubId)
        {
            _competidor.clu_id = clubId;
            return this;
        }

        public competidor_A_competidor Construir()
        {
            return _competidor;
        }
    }
}

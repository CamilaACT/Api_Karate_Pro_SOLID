using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using System.Data;
using System.Numerics;

namespace Api_Karate_Pro.model.proc
{
    public class p_Informe
    {


        //COMBO BOX
        public static Respuesta competencias()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_informe_clubesPorCompetencia_competencia";//poner el nombre correcto
                dt = cb.consultar(vector, 0, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }

        public static Respuesta clubes()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_informe_clubesPorCompetencia_club";//poner el nombre correcto
                dt = cb.consultar(vector, 0, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static Respuesta tecnicas()
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[0];
                cb.sp = "usp_Web_informe_clubesPorCompetencia_tecnica";//poner el nombre correcto
                dt = cb.consultar(vector, 0, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }

        //USANDO SP
        public static Respuesta clubPorCompetencia(Informes_clubesPorCompetencia competidor)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_informe_clubesPorCompetencia";//poner el nombre correcto
                vector[0] = "@com_id,i," + competidor.com_id;
                dt = cb.consultar(vector, 1, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static Respuesta competidoresporClubCompeTecn(Informes_competidoresporClubCompeTecn competidor)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[3];
                cb.sp = "usp_Web_informe_competidoresporClubCompeTecn";//poner el nombre correcto
                vector[0] = "@com_id,i," + competidor.com_id;
                vector[1] = "@clu_id,i," + competidor.clu_id;
                vector[2] = "@tec_id,i," + competidor.tec_id;
                dt = cb.consultar(vector, 3, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    var dataAsList = DataTableToList(dt);
                    res.Result = dataAsList;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }
            return res;
        }
        public static List<Dictionary<string, object>> DataTableToList(DataTable dt)
        {
            var list = new List<Dictionary<string, object>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                list.Add(dict);
            }

            return list;
        }


        //public static Respuesta GetClubesPorCompetencia(int comId)
        //{
        //    Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
        //    try
        //    {
        //        // Llama a ObtenerDatosCrudos para obtener los datos brutos desde el SP
        //        DataTable dt = ObtenerDatosCrudosClubes(comId);

        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            // Procesa los datos crudos con LINQ y cálculos
        //            var groupedData = dt.AsEnumerable()
        //                .GroupBy(row => new
        //                {
        //                    ClubId = row.Field<int>("ClubId"),
        //                    ClubNombre = row.Field<string>("ClubNombre")
        //                })
        //                .Select(group => new
        //                {
        //                    Club = group.Key.ClubNombre,
        //                    Competidores = group.Select(row => row.Field<int>("CompetidorId")).Distinct().Count(),
        //                    Medallas = group.Count(row => row.Field<int>("RivalGano") == 1),
        //                    Tecnica = group
        //                        .Where(row => row.Field<int>("RivalGano") == 1)
        //                        .GroupBy(row => row.Field<string>("TecnicaNombre"))
        //                        .OrderByDescending(tecGroup => tecGroup.Count())
        //                        .Select(tecGroup => tecGroup.Key)
        //                        .FirstOrDefault(),
        //                    Eficiencia = (double)group.Count(row => row.Field<int>("RivalGano") == 1) /
        //                                 group.Count() * 100
        //                })
        //                .OrderByDescending(x => x.Eficiencia)
        //                .ToList();

        //            // Actualiza la respuesta
        //            res.CodigoError = -1;
        //            res.Message = "OK";
        //            res.Result = groupedData;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        res.CodigoError = -100;
        //        res.Message = ex.Message;
        //    }

        //    return res;
        //}



        public static Respuesta CalcularEficienciaPorEdadYRango(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                DataTable dt = ObtenerDatosCrudos(comId);
                if (dt.Rows.Count > 0)
                {
                    var groupedData = dt.AsEnumerable()
                        .GroupBy(row => new
                        {
                            Edad = DateTime.Now.Year - row.Field<DateTime>("FechaNacimiento").Year,
                            Rango = row.Field<string>("Rango")
                        })
                        .Select(group => new
                        {
                            Edad = group.Key.Edad,
                            Rango = group.Key.Rango,
                            TotalPeleas = group.Count(),
                            Ganadas = group.Count(row => row.Field<int>("Gano") == 1),
                            Eficiencia = group.Count(row => row.Field<int>("Gano") == 1) / (double)group.Count() * 100
                        })
                        .OrderByDescending(x => x.Eficiencia)
                        .ToList();

                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = groupedData;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = ex.Message;
            }

            return res;
        }

        public static Respuesta GetInformeCompetidores(Informes_competidoresporClubCompeTecn datos)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                // Obtiene datos crudos desde el SP
                DataTable dt = ObtenerDatosCrudosCompetidores(datos.com_id, datos.clu_id, datos.tec_id);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Procesa los datos crudos
                    var groupedData = dt.AsEnumerable()
                        // Filtrar competidores con al menos una pelea ganada
                        .Where(row => dt.AsEnumerable()
                            .Any(innerRow => innerRow.Field<int>("CompetidorId") == row.Field<int>("CompetidorId") &&
                                             innerRow.Field<int>("RivalGano") == 1))
                        .GroupBy(row => new
                        {
                            CompetidorId = row.Field<int>("CompetidorId"),
                            Competidor = row.Field<string>("Competidor"),
                            Club = row.Field<string>("Club")
                        })
                        .Select(group => new
                        {
                            Competidor = group.Key.Competidor,
                            Club = group.Key.Club,
                            TecnicaLider = group
                                .Where(row => row.Field<int>("RivalGano") == 1) // Solo técnicas ganadoras
                                .GroupBy(row => row.Field<string>("Tecnica"))
                                .OrderByDescending(tecGroup => tecGroup.Count())
                                .Select(tecGroup => tecGroup.Key)
                                .FirstOrDefault(), // Técnica más usada
                            Medallas = group.Count(row => row.Field<int>("RivalGano") == 1), // Total de medallas ganadas
                            TotalPeleas = group.Count(), // Total de peleas en las que participó
                            Eficiencia = group.Count(row => row.Field<int>("RivalGano") == 1) /
                                         (double)group.Count() * 100 // (Peleas ganadas / Total peleas) × 100
                        })
                        .OrderByDescending(x => x.Eficiencia)
                        .ToList();

                    // Actualiza la respuesta
                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = groupedData;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }
        public static Respuesta GetInformeCompetidoresConForeach(Informes_competidoresporClubCompeTecn datosus)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                DataTable dt = ObtenerDatosCrudosCompetidores(datosus.com_id, datosus.clu_id, datosus.tec_id);

                if (dt != null && dt.Rows.Count > 0)
                {
              
                    var datos = new List<CompetidorData>();
                    foreach (DataRow row in dt.Rows)
                    {
                        datos.Add(new CompetidorData
                        {
                            CompetidorId = row.Field<int>("CompetidorId"),
                            Competidor = row.Field<string>("Competidor"),
                            Club = row.Field<string>("Club"),
                            Tecnica = row.Field<string>("Tecnica"),
                            RivalGano = row.Field<int>("RivalGano"),
                            PeleaId = row.Field<int>("PeleaId")
                        });
                    }

                    // Filtrar competidores con al menos una pelea ganada
                    var competidoresFiltrados = datos
                        .GroupBy(d => d.CompetidorId)
                        .Where(grupo => grupo.Any(g => g.RivalGano == 1)) 
                        .SelectMany(g => g)
                        .ToList();

                    // Agrupar datos por competidor y club
                    var groupedData = new List<CompetidorResultado>();
                    foreach (var grupo in competidoresFiltrados.GroupBy(d => new { d.CompetidorId, d.Competidor, d.Club }))
                    {
                        var competidor = grupo.Key.Competidor;
                        var club = grupo.Key.Club;

                        // Calcular la técnica líder
                        var tecnicaLider = grupo
                            .Where(d => d.RivalGano == 1) // Solo considerar técnicas ganadoras
                            .GroupBy(d => d.Tecnica)
                            .OrderByDescending(tg => tg.Count())
                            .Select(tg => tg.Key)
                            .FirstOrDefault();

                        // Contar total de peleas y medallas ganadas
                        int totalPeleas = grupo.Count();
                        int medallas = grupo.Count(d => d.RivalGano == 1);

                        // Calcular eficiencia
                        double eficiencia = totalPeleas > 0 ? (double)medallas / totalPeleas * 100 : 0;

                        // Agregar resultado procesado
                        groupedData.Add(new CompetidorResultado
                        {
                            Competidor = competidor,
                            Club = club,
                            TecnicaLider = tecnicaLider,
                            Medallas = medallas,
                            TotalPeleas = totalPeleas,
                            Eficiencia = eficiencia
                        });
                    }

                    // Ordenar resultados por eficiencia descendente
                    groupedData = groupedData.OrderByDescending(r => r.Eficiencia).ToList();


                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = groupedData;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }


        public static Respuesta GetInformeClubesPorCompetencia(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                // Obtiene los datos crudos desde el SP
                DataTable dt = ObtenerDatosCrudosClubesPorCompetencia(comId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    var datos = dt.AsEnumerable();

                    // Agrupar los datos por Club
                    var groupedData = datos
                        .GroupBy(row => new
                        {
                            ClubId = row.Field<int>("ClubId"),
                            ClubNombre = row.Field<string>("ClubNombre")
                        })
                        .Select(group => new
                        {
                            Club = group.Key.ClubNombre,
                            // Competidores: Total de competidores con al menos una pelea en la competencia
                            Competidores = group
                                .Select(row => row.Field<int>("CompetidorId"))
                                .Distinct()
                                .Count(),
                            // Medallas: Competidores que ganaron al menos una pelea en la competencia
                            Medallas = group
                                .Where(row => row.Field<int>("RivalGano") == 1)
                                .Select(row => row.Field<int>("CompetidorId"))
                                .Distinct()
                                .Count(),
                            // Técnica más utilizada en peleas ganadas
                            TecnicaLider = group
                                .Where(row => row.Field<int>("RivalGano") == 1)
                                .GroupBy(row => row.Field<string>("Tecnica"))
                                .OrderByDescending(tecGroup => tecGroup.Count())
                                .Select(tecGroup => tecGroup.Key)
                                .FirstOrDefault(),
                            // Eficiencia: Medallas ganadas por el club / Total general de medallas
                            Eficiencia = datos
                                .Where(row => row.Field<int>("RivalGano") == 1)
                                .Count() > 0
                                ? (double)group
                                    .Where(row => row.Field<int>("RivalGano") == 1)
                                    .Count() / datos
                                    .Where(row => row.Field<int>("RivalGano") == 1)
                                    .Count() * 100
                                : 0
                        })
                        .OrderByDescending(x => x.Eficiencia)
                        .ToList();

                    // Actualiza la respuesta
                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = groupedData;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }
        public static Respuesta GetInformeClubesPorCompetenciaConForeach(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                DataTable dt = ObtenerDatosCrudosClubesPorCompetencia(comId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    var datos = dt.AsEnumerable()
                        .Select(row => new
                        {
                            ClubId = row.Field<int>("ClubId"),
                            ClubNombre = row.Field<string>("ClubNombre"),
                            CompetidorId = row.Field<int>("CompetidorId"),
                            RivalGano = row.Field<int>("RivalGano"),
                            Tecnica = row.Field<string>("Tecnica")
                        }).ToList();

                    var groupedData = new List<dynamic>();

                    foreach (var grupo in datos.GroupBy(d => new { d.ClubId, d.ClubNombre }))
                    {
                        var clubId = grupo.Key.ClubId;
                        var clubNombre = grupo.Key.ClubNombre;

                        // Competidores con al menos una pelea
                        int competidores = grupo
                            .Select(g => g.CompetidorId)
                            .Distinct()
                            .Count();

                        // Medallas: Competidores que han ganado al menos una pelea
                        int medallas = grupo
                            .Where(g => g.RivalGano == 1)
                            .Select(g => g.CompetidorId)
                            .Distinct()
                            .Count();

                        // Técnica líder
                        string tecnicaLider = grupo
                            .Where(g => g.RivalGano == 1)
                            .GroupBy(g => g.Tecnica)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();

                        // Eficiencia
                        double eficiencia = datos
                            .Count(g => g.RivalGano == 1) > 0
                            ? (double)grupo
                                .Where(g => g.RivalGano == 1)
                                .Count() / datos
                                .Count(g => g.RivalGano == 1) * 100
                            : 0;

                        groupedData.Add(new
                        {
                            Club = clubNombre,
                            Competidores = competidores,
                            Medallas = medallas,
                            TecnicaLider = tecnicaLider,
                            Eficiencia = eficiencia
                        });
                    }

                    groupedData = groupedData.OrderByDescending(r => r.Eficiencia).ToList();

                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = groupedData;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = $"Error inesperado: {ex.Message}";
            }

            return res;
        }


        public static DataTable ObtenerDatosCrudos (int comid)
        {

            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {

                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_datos_crudos";//poner el nombre correcto
                vector[0] = "@com_id,i," + comid;
                dt = cb.consultar(vector, 1, strCon);


                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;

                    return dt;

                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                    return dt;
                }

            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
                return null;
            }
         

        }

        public static DataTable ObtenerDatosCrudosClubesPorCompetencia(int comid)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_datos_crudos_clubes"; // Nombre del SP
                vector[0] = "@com_id,i," + comid;
                dt = cb.consultar(vector, 1, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    return dt;
                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                    return dt;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
                return null;
            }
        }

        public static DataTable ObtenerDatosCrudosCompetidores(int comId, int cluId, int tecId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[3];
                cb.sp = "usp_Web_datos_crudos_competidores"; // Nombre del SP
                vector[0] = "@com_id,i," + comId;
                vector[1] = "@clu_id,i," + cluId;
                vector[2] = "@tec_id,i," + tecId;
                dt = cb.consultar(vector, 3, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    return dt;
                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                    return dt;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
                return null;
            }
        }

        public static Respuesta GetInformeCompetidores(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                DataTable dt = ObtenerDatosCrudosCompetidores(comId);

                if (dt != null && dt.Rows.Count > 0)
                {

                    var datos = dt.AsEnumerable()
                     .Select(row => new
                     {
                         CompetidorId = row.Field<int>("CompetidorId"), // int
                         CompetidorNombre = row.Field<string>("CompetidorNombre"), // string
                         RivalGano = row.Field<int>("RivalGano"), // int
                         TiempoPuntuacion = row.Field<int?>("TiempoPuntuacion") ?? 0, // int nullable convertido a int
                         TecnicaId = row.Field<int?>("TecnicaId"), // Nullable int
                         Tecnica = row.Field<string>("Tecnica"), // string
                         Puntos = row.Field<int?>("Puntos") ?? 0 // int nullable convertido a int
                     }).ToList();


                    var resultados = new List<dynamic>();

                    foreach (var grupo in datos.GroupBy(d => new { d.CompetidorId, d.CompetidorNombre }))
                    {
                        var competidorId = grupo.Key.CompetidorId;
                        var competidorNombre = grupo.Key.CompetidorNombre;

                        // Promedio de tiempo de puntuación
                        double promedioTiempo = grupo.Average(g => g.TiempoPuntuacion);

                        // Promedio de puntos
                        double promedioPuntos = grupo.Average(g => g.Puntos);


                        // Técnica más empleada
                        string tecnicaMasEmpleada = grupo
                            .GroupBy(g => g.Tecnica)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();

                        resultados.Add(new
                        {
                            CompetidorId = competidorId,
                            CompetidorNombre = competidorNombre,
                            PromedioTiempo = promedioTiempo,
                            PromedioPuntos = promedioPuntos,
                            TecnicaMasEmpleada = tecnicaMasEmpleada
                        });
                    }

                    res.CodigoError = -1;
                    res.Message = "OK";
                    res.Result = resultados.OrderBy(r => r.PromedioTiempo).ToList();
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
            }

            return res;
        }


        public static DataTable ObtenerDatosCrudosCompetidores(int comId)
        {
            Respuesta res = new Respuesta() { CodigoError = 0, Message = "Sin Resultados", Result = null };
            try
            {
                data.DAO.c_base_datos cb = new data.DAO.c_base_datos();
                System.Data.DataTable dt;
                string strCon = util.Conexion.Conexion.CadenaConexion();
                string[] vector = new string[1];
                cb.sp = "usp_Web_datos_crudos_top_tiempo"; // Nombre del SP
                vector[0] = "@com_id,i," + comId;
                dt = cb.consultar(vector, 1, strCon);

                res.CodigoError = cb.valo_erro;
                if (res.CodigoError == -1)
                {
                    res.Message = "OK";
                    res.Message = cb.valo_resp;
                    return dt;
                }
                else
                {
                    res.Message = "Que pena me da tu caso";
                    res.Message = cb.valo_resp;
                    return dt;
                }
            }
            catch (Exception ex)
            {
                res.CodigoError = -100;
                res.Message = "Error inesperado";
                res.Message = ex.Message;
                return null;
            }
        }




    }



    public class CompetidorData
    {
        public int CompetidorId { get; set; }
        public string Competidor { get; set; }
        public string Club { get; set; }
        public string Tecnica { get; set; }
        public int RivalGano { get; set; }
        public int PeleaId { get; set; }
    }

    public class CompetidorResultado
    {
        public string Competidor { get; set; }
        public string Club { get; set; }
        public string TecnicaLider { get; set; }
        public int Medallas { get; set; }
        public int TotalPeleas { get; set; }
        public double Eficiencia { get; set; }
    }










}

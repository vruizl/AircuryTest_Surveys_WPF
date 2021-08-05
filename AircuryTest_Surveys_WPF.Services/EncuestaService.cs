using AircuryTest_Surveys_WPF.Business;
using AircuryTest_Surveys_WPF.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Services
{
    //Comunicacinoes con el WS/API... 
    public class EncuestaService :IEncuestaService
    {
        #region Crear datos (MOCK)
        static List<Encuesta> Encuestas = new List<Encuesta>()
        {
            //Lo utilizamos así porque no tenemos bdd/api/ws que nos proporcione los datos
            new Encuesta()
            {
                IdEncuesta = 1,
                TituloEncuesta = "Primera encuesta",
                DescEncuesta = "Encuesta número 1 para preguntar cosas"
            },

             new Encuesta()
            {
                IdEncuesta = 2,
                TituloEncuesta = "Segunda encuesta",
                DescEncuesta = "Encuesta número 2 para preguntar cosas"
            },

              new Encuesta()
            {
                IdEncuesta = 3,
                TituloEncuesta = "Tercera encuesta",
                DescEncuesta = "Encuesta número 3 para preguntar cosas"
            }

        };

        static Encuesta DetalleEncuesta = new Encuesta()
        {
            Preguntas = new ObservableCollection<Pregunta>()
            {
                new Pregunta()
                {
                    IdPregunta = 1,
                    DescPregunta = "Desc pregunta uno",
                    Opciones = new ObservableCollection<Opcion>()
                    {
                        new Opcion
                        {
                            IdOpcion = 1,
                            TextoOpcion = "Opción 1",
                            Seleccionada = false
                        },

                         new Opcion
                        {
                            IdOpcion = 2,
                            TextoOpcion = "Opción 2",
                            Seleccionada = false
                        },
                          new Opcion
                        {
                            IdOpcion = 3,
                            TextoOpcion = "Opción 3",
                            Seleccionada = false
                        }

                    }
                },

                new Pregunta()
                {
                    IdPregunta = 2,
                    DescPregunta = "Desc pregunta dos",
                    Opciones = new ObservableCollection<Opcion>()
                    {
                        new Opcion
                        {
                            IdOpcion = 1,
                            TextoOpcion = "Opción 1",
                            Seleccionada = false
                        },

                         new Opcion
                        {
                            IdOpcion = 2,
                            TextoOpcion = "Opción 2",
                            Seleccionada = false
                        },
                          new Opcion
                        {
                            IdOpcion = 3,
                            TextoOpcion = "Opción 3",
                            Seleccionada = false
                        }

                    }
                },

                new Pregunta()
                {
                    IdPregunta = 3,
                    DescPregunta = "Desc pregunta tres",
                    Opciones = new ObservableCollection<Opcion>()
                    {
                        new Opcion
                        {
                            IdOpcion = 1,
                            TextoOpcion = "Opción 1",
                            Seleccionada = false
                        },

                         new Opcion
                        {
                            IdOpcion = 2,
                            TextoOpcion = "Opción 2",
                            Seleccionada = false
                        },
                          new Opcion
                        {
                            IdOpcion = 3,
                            TextoOpcion = "Opción 3",
                            Seleccionada = false
                        }

                    }
                }
            }
        };
        #endregion

        /// <summary>
        /// Procedimiento que nos permite obtener el listado de encuestas que puede rellenar el usuario
        /// En principio sin el detalle, solo los títulos y descripciones. Iremos a por el resto de datos
        /// una vez el usuario seleccione la encuesta que quiere rellenar.
        /// </summary>
        /// <returns></returns>
        public List<Encuesta> GetEncuestasSinDetalle()
        {
            return Encuestas;
        }

        /// <summary>
        /// En este punto el usuario ya ha seleccionado una encuesta para rellenar así que vamos a buscar
        /// sus preguntas / opciones de respuesta
        /// </summary>
        /// <param name="idEncuesta"></param>
        /// <returns></returns>
        public Encuesta GetDatosEncuesta(int idEncuesta)
        {
            DetalleEncuesta.IdEncuesta = idEncuesta;
            DetalleEncuesta.TituloEncuesta = Encuestas.Where(e => e.IdEncuesta == idEncuesta).Select(e => e.TituloEncuesta).ToList()[0];
            DetalleEncuesta.DescEncuesta = Encuestas.Where(e => e.IdEncuesta == idEncuesta).Select(e => e.DescEncuesta).ToList()[0];
            return DetalleEncuesta;
        }
    }
}

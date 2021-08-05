using AircuryTest_Surveys_WPF.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Services.Interfaces
{
    //Interfaz que se implementará en la clase de comunicación con el WS/API
    public interface IEncuestaService
    {
         Encuesta GetDatosEncuesta(int idEncuesta);

         List<Encuesta> GetEncuestasSinDetalle();
     
    }
}

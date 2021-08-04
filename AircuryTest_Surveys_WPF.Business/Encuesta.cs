using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Business
{
    public class Encuesta : BusinessBase
    {
        private ObservableCollection<Pregunta> _preguntas;
       

        #region Propiedades
        public int IdEncuesta { get; set; }

        private string _tituloEncuesta;
        public string TituloEncuesta {
            get { return _tituloEncuesta; }
            set { SetProperty(ref _tituloEncuesta, value); }
        }
        public string DescEncuesta { get; set; }

        public bool Seleccionada { get; set; }

        public ObservableCollection<Pregunta> Preguntas
        {
            get
            {
                return _preguntas;
            }
            set
            {
                SetProperty(ref _preguntas, value);
            }
        }
        
        #endregion
    }
}

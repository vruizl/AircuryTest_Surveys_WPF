using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Business
{
    public class Pregunta:BusinessBase
    {
       

        private ObservableCollection<Opcion> _opciones;
        private int _idPregunta;

        #region Propiedades
        public int IdPregunta
        {
            get { return _idPregunta; }
            set
            {
                SetProperty(ref _idPregunta, value);
            }
        }
        public string DescPregunta { get; set; }
        public ObservableCollection<Opcion> Opciones
        {
            get
            {
                return _opciones;
            }
            set
            {
                SetProperty(ref _opciones, value);
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Business
{
    public class Opcion :BusinessBase
    {
        #region Propiedades
        public int IdOpcion { get; set; }
        public string TextoOpcion { get; set; }

        public bool Seleccionada { get; set; }
        #endregion

    }
}

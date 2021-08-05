using AircuryTest_Surveys_WPF.Services.Interfaces;
using AircuryTest_Surveys_WPF.Business;
using AircuryTest_Surveys_WPF.Core;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Regions;

namespace AircuryTest_Surveys_WPF.Modules.ListadoEncuestas.ViewModels
{
    public class ListaEncuestasViewModel : BindableBase
    {

        private ObservableCollection<Encuesta> _encuestas;
        private readonly IEncuestaService _encuestaService;
        private readonly IRegionManager _regionManager;

      
        public ObservableCollection<Encuesta> ListaEncuestas
        {
            get { return _encuestas; }
            set { SetProperty(ref _encuestas, value); }
        }
       
        public DelegateCommand LanzaEncuestaCommand { get; set; }

        public ListaEncuestasViewModel(IEncuestaService encuestaService,IRegionManager regionManager)
        { 
            _encuestaService = encuestaService;
            _regionManager = regionManager;

            ListaEncuestas = new ObservableCollection<Encuesta>(_encuestaService.GetEncuestasSinDetalle());
            
            LanzaEncuestaCommand = new DelegateCommand(Click);
        }

        private void Click()
        {
            ObservableCollection<Encuesta> le = ListaEncuestas;
            int id = le.Where(e => e.Seleccionada == true).Select(e => e.IdEncuesta).ToList()[0];
            _regionManager.RequestNavigate(RegionNames.ListaEncuestasRegion, "DatosEncuestaView?id="+id);
        }
    }
}

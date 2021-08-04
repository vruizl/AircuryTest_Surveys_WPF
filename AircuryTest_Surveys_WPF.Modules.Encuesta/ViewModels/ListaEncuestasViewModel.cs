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

        private DelegateCommand<string> _navigateCommand;
        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand =>
               _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));
        public ObservableCollection<Encuesta> ListaEncuestas
        {
            get { return _encuestas; }
            set { SetProperty(ref _encuestas, value); }
        }
       
        public DelegateCommand LanzaEncuestaCommand { get; set; }

        public ListaEncuestasViewModel(IEncuestaService usuarioDonanteService,IRegionManager regionManager)
        { 
            _encuestaService = usuarioDonanteService;
            ListaEncuestas = new ObservableCollection<Encuesta>(usuarioDonanteService.GetEncuestasSinDetalle());
            _regionManager = regionManager;
            LanzaEncuestaCommand = new DelegateCommand(Click);
        }

        void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException();

            _regionManager.RequestNavigate(RegionNames.ListaEncuestasRegion, "DatosEncuestaView");
        }

        private void Click()
        {
            ObservableCollection<Encuesta> le = ListaEncuestas;
            int id = le.Where(e => e.Seleccionada == true).Select(e => e.IdEncuesta).ToList()[0];
            _regionManager.RequestNavigate(RegionNames.ListaEncuestasRegion, "DatosEncuestaView?id="+id);
          

        }
    }
}

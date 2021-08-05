using AircuryTest_Surveys_WPF.Services.Interfaces;
using AircuryTest_Surveys_WPF.Business;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Regions;
using AircuryTest_Surveys_WPF.Core;

namespace AircuryTest_Surveys_WPF.Modules.DatosEncuesta.ViewModels
{
    public class DatosEncuestaViewModel : BindableBase,INavigationAware
    {
        private Encuesta _encuesta;
        private readonly IEncuestaService _encuestaService;
        private int idEncuestaSeleccionada = -1;
        private readonly IRegionManager _regionManager;


        private string _text = string.Empty;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public Encuesta DatosEncuesta
        {
            get { return _encuesta; }
            set { SetProperty(ref _encuesta, value); }
        }

        public DelegateCommand EnviarEncuestaCommand { get; set; }
        public DelegateCommand VolverAtrasCommand { get; set; }

        public DatosEncuestaViewModel(IEncuestaService usuarioDonanteService, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _encuestaService = usuarioDonanteService;

            EnviarEncuestaCommand = new DelegateCommand(Click_Enviar);
            VolverAtrasCommand = new DelegateCommand(Click_Volver);    
        }

       
        private void Click_Enviar()
        {
            //En el caso de estar implementado y de ser necesario se enviarían los resultados de la encuesta que se ha realizado.
            Text = "La encuesta se ha enviado con éxito";
        }

        private void Click_Volver()
        {
            Text = string.Empty;
            _regionManager.RequestNavigate(RegionNames.ListaEncuestasRegion, "ListaEncuestasView");

        }
        #region Implementación INavigationAware
        public void OnNavigatedTo(NavigationContext navigationContext)
            {
            idEncuestaSeleccionada = Convert.ToInt32(navigationContext.Parameters.GetValue<string>("id"));
           
            DatosEncuesta = _encuestaService.GetDatosEncuesta(idEncuestaSeleccionada);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
           
        }
        #endregion
    }
}

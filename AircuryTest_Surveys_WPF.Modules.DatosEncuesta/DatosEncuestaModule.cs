using AircuryTest_Surveys_WPF.Core;
using AircuryTest_Surveys_WPF.Modules.DatosEncuesta.ViewModels;
using AircuryTest_Surveys_WPF.Modules.DatosEncuesta.Views;
using AircuryTest_Surveys_WPF.Services;
using AircuryTest_Surveys_WPF.Services.Interfaces;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircuryTest_Surveys_WPF.Modules.DatosEncuesta
{
    public class DatosEncuestaModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public DatosEncuestaModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerprovider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ListaEncuestasRegion, typeof(DatosEncuestaView));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IEncuestaService, EncuestaService>();
            containerRegistry.RegisterForNavigation<DatosEncuestaView, DatosEncuestaViewModel>();
        }
    
    }
}

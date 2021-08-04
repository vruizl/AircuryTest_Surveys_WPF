using AircuryTest_Surveys_WPF.Core;
using AircuryTest_Surveys_WPF.Modules.ListadoEncuestas.ViewModels;
using AircuryTest_Surveys_WPF.Modules.ListadoEncuestas.Views;
using AircuryTest_Surveys_WPF.Services;
using AircuryTest_Surveys_WPF.Services.Interfaces;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;


namespace AircuryTest_Surveys_WPF.Modules.ListadoEncuestas
{
    public class ListaEncuestasModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public ListaEncuestasModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerprovider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ListaEncuestasRegion, typeof(ListaEncuestasView));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IEncuestaService, EncuestaService>();
            containerRegistry.RegisterForNavigation<ListaEncuestasView, ListaEncuestasViewModel>();
        }

    }
}

using AircuryTest_Surveys_WPF.Views;
using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using AircuryTest_Surveys_WPF.Modules.ListadoEncuestas;
using System.ComponentModel;
using AircuryTest_Surveys_WPF.Modules.DatosEncuesta;

namespace AircuryTest_Surveys_WPF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override Window CreateShell()
        {
            var w = Container.Resolve<ShellWindow>();
            return w;
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ListaEncuestasModule>();
            moduleCatalog.AddModule<DatosEncuestaModule>();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AircuryTest_Surveys_WPF.Business;
using AircuryTest_Surveys_WPF.Services;
using System.Text;
using AircuryTest_Surveys_WPF.Modules.ListadoEncuestas.ViewModels;
using Prism;
using Prism.Regions;

namespace AircuryTest_Surveys_WPF.Testing.ViewModels
{
    [TestClass]
    public class ListaEncuestasViewModelTest
    {
        [TestMethod]
        public void TestListaEncuestasViewModelConstructorInitializesMembers()
        {
            EncuestaService _encuestaService = new EncuestaService();
            RegionManager _regionManager = new RegionManager() ;
            // Actions
            var uvm = new ListaEncuestasViewModel(_encuestaService, _regionManager);

            // Assertions
            Assert.IsNotNull(uvm);

        }
        [TestMethod]
        public void TestGetListaEncuestas()
        {

            EncuestaService _encuestaService = new EncuestaService();

            List<Encuesta> le =  _encuestaService.GetEncuestasSinDetalle();
            //Al ser datos Mockeados sabemos que se deben devolver 3 encuestas.
            Assert.AreEqual(3, le.Count);

        }

        [TestMethod]
        public void TestGetDatosEncuesta()
        {
            EncuestaService _encuestaService = new EncuestaService();
            int idEncuesta = 1;
            Encuesta e = _encuestaService.GetDatosEncuesta(idEncuesta);
           
            Assert.AreEqual("Primera encuesta", e.TituloEncuesta);

        }
    }
}

using ElectricityAPI.Controllers;
using ElectricityAPI.Data;
using ElectricityAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class ElectriccityUT
    {
        private readonly IElectricityRepository _electricityRepository;
        private readonly Connections _conn;
        private readonly ILogger<ElectricityController> _logger;

        public ElectriccityUT(Connections conn, ILogger<ElectricityController> logger)
        {
            _conn = conn;
            _logger = logger;
            _electricityRepository = new ElectricityRepository(_conn);
        }

        [TestMethod]
        public void ElectricityController_Getdata_ReturnOk()
        {

            // Arrage
            var electricData = _electricityRepository.GetElectricityData();
            var controller = new ElectricityController(_electricityRepository, _logger);


            //Act
            Assert.IsNotNull(controller);
            var result = controller.GetElectricities();


            //Assert

            Assert.AreEqual(result, electricData, "Not Equal Data");
        }
    }
}

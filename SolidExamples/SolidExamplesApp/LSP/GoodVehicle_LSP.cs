using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.LSP
{
       public interface IVehicle
        {
            string GetVehicleDetails(int id);
        }

        public interface IPrice
        {
            int CalculateRent(int id);
        }

        public class GoodCar : IVehicle, IPrice
        {
            public int CalculateRent(int employeeId)
            {
                return 25000;
            }

            public string GetVehicleDetails(int employeeId)
            {
                return "This is a car";
            }
        }

        public class GoodBus : IVehicle
        {
            public string GetVehicleDetails(int employeeId)
            {
                return "This is a bus";
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.LSP
{
    public class GoodVehicle_LSP
    {
        public interface IVehicle
        {
            string GetVehicleDetails(int id);
        }

        public interface IPrice
        {
            int CalculatePrice(int id);
        }

        public class Car : IVehicle, IPrice
        {
            public int CalculatePrice(int employeeId)
            {
                return 25000;
            }

            public string GetVehicleDetails(int employeeId)
            {
                return "This is a car";
            }
        }

        public class Bus : IVehicle
        {
            public string GetVehicleDetails(int employeeId)
            {
                return "This is a bus";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.LSP
{
    public interface IVehicle
    {
        int ID { get; }
        string GetVehicleDetails(int id);
    }

    public interface IRent
    {
       public int CalculateRent(int id);
    }

    public class GoodCar : IVehicle, IRent
    {
        public int ID { get; }
        public int CalculateRent(int id)
        {
            return 25000;
        }

        public string GetVehicleDetails(int id)
        {
            return "This is a car";
        }
    }

    public class GoodBus : IVehicle
    {
        public int ID { get; }
        public string GetVehicleDetails(int id)
        {
            return "This is a bus";
        }
    }
}

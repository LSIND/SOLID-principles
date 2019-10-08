using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.ISP
{
    public interface IVehicleAdd
    {
        bool AddNewVehicle(); // требование добавлять только автобусы
    }

    public interface IVehicleDetails
    {
        string ShowDetails(int id);

    }

    public class CarGood : IVehicleAdd, IVehicleDetails
    {
        public string ShowDetails(int id)
        {
            return "This is a car";
        }
        public bool AddNewVehicle()
        {
            return true;
        }
    }

    public class BusGood : IVehicleDetails
    {
        public string ShowDetails(int id)
        {
            return "This is a bus";
        }
    }
}

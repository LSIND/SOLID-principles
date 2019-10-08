using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.ISP
{
    public interface IVehicle
    {
        string ShowDetails(int id);
        bool AddNewVehicle(); // add only cars

    }


    public class Car : IVehicle
    {
        public string ShowDetails(int id)
        {
            return "This is a car";
        }
        public bool AddNewVehicle()
        {
            //ок
            return true;
        }
    }

    public class Bus : IVehicle
    {
        public bool AddNewVehicle()
        {
            // we cannot add buses
            return true;
        }
        public string ShowDetails(int id)
        {
            return "This is a bus";
        }
    }
}

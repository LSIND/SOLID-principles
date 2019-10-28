using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.LSP
{
    public abstract class BadVehicle_LSP
    {
        public virtual int CalculatePrice(int id)
        {
            ///
            return 10000;
        }

        public virtual string GetVehicleDetails(int id)
        {
            return "Base Vehicle";
        }
    }

    public class Car : BadVehicle_LSP
    {
        public override int CalculatePrice(int id)
        {
            return 25000;
        }

        public override string GetVehicleDetails(int id)
        {
            return "This is a car";
        }
    }

    public class Bus : BadVehicle_LSP
    {
        // no info
        public override int CalculatePrice(int id)
        {
            throw new NotImplementedException();
        }


        public override string GetVehicleDetails(int id)
        {
            return "This is a bus";

        }
    }
}

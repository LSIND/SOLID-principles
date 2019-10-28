using SolidExamplesApp.LSP;
using System;
using System.Collections.Generic;

namespace SolidExamplesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S.O.L.I.D. Principles");



            Console.WriteLine("Bad example without LSP: ");
            List<BadVehicle_LSP> list = new List<BadVehicle_LSP>();

            list.Add(new Car());
            list.Add(new Bus());

            foreach (BadVehicle_LSP veh in list)
            {
                veh.GetVehicleDetails(66); //
            }
        }
    }
}

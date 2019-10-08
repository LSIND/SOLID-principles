using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.SRP
{
    // SRP = Single responsibility principle 
    // bad impl
    public class BadCarSRP
    {
        public int Model { get; set; }

        int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2010 & year <= 2019)
                    year = value;
            }
        }
        public void PrintData(BadCarSRP car)
        {
            // Print Info about car
        }
    }
}

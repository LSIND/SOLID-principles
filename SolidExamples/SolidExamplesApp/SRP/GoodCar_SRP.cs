using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.SRP
{
    // SRP = Single responsibility principle 
    // good impl
    public class GoodCarSRP
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
    }

    public class Printer
    {
        public void PrintData(GoodCarSRP car)
        {
        }
    }
}

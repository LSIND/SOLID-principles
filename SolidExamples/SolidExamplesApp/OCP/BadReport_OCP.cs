using System;
using System.Collections.Generic;
using System.Text;
using SolidExamplesApp.SRP;

namespace SolidExamplesApp.OCP
{
   public class BadReport_OCP
    {

            public string TypeReport { get; set; }


            public void PrintData(GoodCarSRP car)
            {
                if (TypeReport == "Doc")
                {
                    // Генерация отчета в  doc
                }

                if (TypeReport == "PDF")
                {
                    // Генерация отчета в  PDF
                }
            }
        
    }
}

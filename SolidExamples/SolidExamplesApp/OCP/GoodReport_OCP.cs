using System;
using System.Collections.Generic;
using System.Text;
using SolidExamplesApp.SRP;

namespace SolidExamplesApp.OCP
{
    public class GoodReport_OCP
    {
        public virtual void PrintData(GoodCarSRP car)
        {
            //default
        }
    }

    public class PrintInDoc : GoodReport_OCP
    {
        public override void PrintData(GoodCarSRP car)
        {
            // report in doc
        }
    }

    public class PrintInPdf : GoodReport_OCP
    {
        public override void PrintData(GoodCarSRP car)
        {
            // report in PDF
        }
    }
}

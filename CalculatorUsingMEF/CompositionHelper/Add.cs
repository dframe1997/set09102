using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

using Contract;

namespace CompositionHelper
{
    [Export(typeof(ICalculator))]
    [ExportMetadata("CalculatorMetaData", "Add")]
    public class Add : ICalculator
    {
        public double GetResult(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}

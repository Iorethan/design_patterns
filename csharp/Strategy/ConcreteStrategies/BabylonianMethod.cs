using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.ConcreteStrategies
{
    public class BabylonianMethod : RootCalculatingStrategy
    {
        public override double CalculateRoot(double number)
        {
            double lastEstimate;
            double currentEstimate = 1;
            do
            {
                lastEstimate = currentEstimate;
                currentEstimate = (currentEstimate + number / currentEstimate) / 2;
            } while (Math.Abs(currentEstimate - lastEstimate) > 0.01);
            return currentEstimate;
        }
    }
}

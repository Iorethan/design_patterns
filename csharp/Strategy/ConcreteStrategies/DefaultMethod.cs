using System;

namespace DesignPatterns.Strategy.ConcreteStrategies
{
    public class DefaultMethod : RootCalculatingStrategy
    {
        public override double CalculateRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
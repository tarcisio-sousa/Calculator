using Calculator.Contracts;

namespace Calculator.Models
{
    public class Sum(float value1, float value2) : IOperation
    {
        private readonly float value1 = value1;
        private readonly float value2 = value2;

        public float Calculate()
        {
            return value1 + value2;
        }
    }
}
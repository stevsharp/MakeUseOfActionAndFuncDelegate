using MakeUseOfActionDelegate;

namespace MakeUseOfActionAndFuncDelegate
{
    public class CalculatorFactory
    {
        private readonly Calculator _calculator;

        public CalculatorFactory(Calculator calculator)
        {
            _calculator = calculator;
        }

        public int Calculate(Operation operation)
        {
            return operation switch
            {
                Operation.Subtract => _calculator.Subtract(),
                Operation.Sum => _calculator.Subtract(),
                _ => -1,
            };
        }
    }
}
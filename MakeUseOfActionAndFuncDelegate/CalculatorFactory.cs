using MakeUseOfActionDelegate;

namespace MakeUseOfActionAndFuncDelegate
{
    public class CalculatorFactory
    {
        private readonly Calculator _calculator;

        private readonly CalculatorService _calculatorService;

        public CalculatorFactory(Calculator calculator , CalculatorService calculatorService)
        {
            _calculator = calculator;

            _calculatorService = calculatorService;
        }

        public int Calculate(Operation operation)
        {
            _calculatorService.PrepareFunction(_calculator.Sum, _calculator.Subtract);

            return _calculatorService
                    .FuncExecute
                    .ContainsKey(operation) ?
                        _calculatorService.FuncExecute[operation]() :
                        -1;

            //return operation switch
            //{
            //    Operation.Subtract => 
            //        _calculator.Subtract(),
            //    Operation.Sum => 
            //        _calculator.Subtract(),
            //        _ => 
            //            -1,
            //};
        }
    }
}
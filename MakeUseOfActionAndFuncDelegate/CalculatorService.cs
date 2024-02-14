using MakeUseOfActionAndFuncDelegate;


namespace MakeUseOfActionDelegate
{
    public class CalculatorService
    {
        protected CalculatorFactory _calculatorFactory = new(new Calculator(0, 0));

        protected Dictionary<Operation, Func<int>> FuncExecute;

        protected Func<int> Sum;

        protected Func<int> Substract;

        public void PrepareFunction(Func<int> sum, Func<int> subtract)
        {
            FuncExecute = new Dictionary<Operation, Func<int>>(0);

            Sum = sum;

            Substract = subtract;

            FuncExecute.Add(Operation.Sum, Sum);

            FuncExecute.Add(Operation.Subtract, Substract);
        }
    }
}

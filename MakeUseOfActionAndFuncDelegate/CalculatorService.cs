using MakeUseOfActionAndFuncDelegate;


namespace MakeUseOfActionDelegate
{
    public class CalculatorService
    {
        public Dictionary<Operation, Func<int>> FuncExecute;

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

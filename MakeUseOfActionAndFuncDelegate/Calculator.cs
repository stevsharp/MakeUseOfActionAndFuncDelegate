namespace MakeUseOfActionDelegate
{
    public class Calculator
    {
        readonly int _fistNumber;

        readonly int _secondNumber;

        public Calculator(int fistNumber, int secondNumber)
        {
            _fistNumber = fistNumber;

            _secondNumber = secondNumber;
        }

        public int Sum()
        {
            return _fistNumber + _secondNumber;
        }

        public int Subtract()
        {
            return _fistNumber - _secondNumber;
        }
    }
}

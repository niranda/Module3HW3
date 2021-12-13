namespace ShopApp.Main
{
    public delegate bool Res(double number);
    public delegate double Pow(double firstNumber, double secondNumber);
    public class Class2
    {
        private double _result;
        public Res Calc(Pow powDelegate, double firstNumber, double secondNumber)
        {
            _result = powDelegate.Invoke(firstNumber, secondNumber);
            Res resOperation = Result;
            return resOperation;
        }

        public bool Result(double number)
        {
            return _result % number == 0;
        }
    }
}

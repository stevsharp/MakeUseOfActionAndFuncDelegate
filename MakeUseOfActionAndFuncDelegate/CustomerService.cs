namespace MakeUseOfActionAndFuncDelegate
{
    internal class CustomerService
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>()
        {
            new Customer("George", "Papas", "Greee", 0, 1000),
            new Customer("Luigi", "Bianchi", "Italy", 0, 25000),
            new Customer("Michael", "Williams", "USA", 0, 100000),
            new Customer("Amélie", "Rousseau", "France", 0, 5000)
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="applyDiscount"></param>
        /// <param name="discountApplied"></param>
        /// <param name="discountDelegate"></param>
        public void GiveDiscount(
            Action<string> applyDiscount, 
            Action<string> discountApplied,
            Action<Customer> discountDelegate)
        {
            applyDiscount("applying discount.");

            discountApplied("discount Applied.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applyDiscount"></param>
        /// <param name="discountApplied"></param>
        /// <param name="calculateDiscountedTotal"></param>
        public void GiveDiscountWithFunc(
        Action<string> applyDiscount,
        Action<string> discountApplied,
        Func<List<Customer>, decimal> calculateDiscountedTotal)
        {
            applyDiscount("applying discount.");

            decimal total = calculateDiscountedTotal(this.CustomerList);

            discountApplied("discount Applied.");
        }


    }
}

namespace MakeUseOfActionAndFuncDelegate
{
    internal class CustomerService
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>()
        {
            new Customer("George", "Papas", "Greee", 0),
            new Customer("Luigi", "Bianchi", "Italy", 0),
            new Customer("Michael", "Williams", "USA", 0),
            new Customer("Amélie", "Rousseau", "France", 0)
        };
        
        public void GiveDiscount(
            Action<string> applyDiscount, 
            Action<string> discountApplied,
            Action<Customer> discountDelegate)
        {
            applyDiscount("applying discount.");

            //foreach (var customer in CustomerList)
            //{
            //    if (customer.Country.Equals("Greee"))
            //    {
            //        customer.ApllyDiscount(10);
            //    }

            //    if (customer.Country.Equals("Italy"))
            //    {
            //        customer.ApllyDiscount(5);
            //    }

            //    if (customer.Country.Equals("USA"))
            //    {
            //        customer.ApllyDiscount(3);
            //    }

            //    if (customer.Country.Equals("France"))
            //    {
            //        customer.ApllyDiscount(2);
            //    }

            //}

            discountApplied("discount Applied.");
        }


    }
}

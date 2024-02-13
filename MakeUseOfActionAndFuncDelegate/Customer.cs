namespace MakeUseOfActionAndFuncDelegate
{
    public record class Customer
    {
        public string Country { get; }
        public string LastName { get; }
        public string Name { get; }
        public decimal Discount { get; protected set; }
        public decimal Sales { get; }
        public void ApplyDiscount(decimal discount) => this.Discount = discount;

        public Customer(string name, string lastName, string country, decimal discount , decimal sales)
        {
            this.Discount = discount;

            this.Name = name;

            this.LastName = lastName;

            this.Country = country;

            this.Sales = sales;
        }
    }
}

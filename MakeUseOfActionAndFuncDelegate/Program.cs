
using MakeUseOfActionAndFuncDelegate;

try
{
    CustomerService customerService = new();

    // Use Action Del
    customerService.GiveDiscount((message) =>
    {
        Console.WriteLine(message);
    },
    (message) =>
    {
        Console.WriteLine(message);
    }
    ,((customer) =>
     {
         switch (customer.Country)
         {
             case "Greece":
                 customer.ApplyDiscount(10);
                 break;
             case "Italy":
                 customer.ApplyDiscount(5);
                 break;
             case "USA":
                 customer.ApplyDiscount(3);
                 break;
             case "France":
                 customer.ApplyDiscount(2);
                 break;
         }
     }));

    // Use Func
    customerService.GiveDiscountWithFunc((message) =>
    {
        Console.WriteLine(message);
    },
    (message) =>
    {
        Console.WriteLine(message);
    },
     (Customers) => {

         foreach (var customer in Customers)
         {
             if (customer.Sales is > 1000)
             {
                 return 10;
             }

             if (customer.Sales is > 2000)
             {
                 return 10;
             }
         }

         return 0;
        
     }
    );

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadLine();
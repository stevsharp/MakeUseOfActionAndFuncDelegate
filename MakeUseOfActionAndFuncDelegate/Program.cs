
using MakeUseOfActionAndFuncDelegate;

try
{
    CustomerService customerService = new();

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
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadLine();
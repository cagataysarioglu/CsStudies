using System;

namespace OOPOne
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customerOne = new IndividualCustomer();
            customerOne.Id = 1;
            customerOne.TRId = "8877993311";
            customerOne.CustomerNo = "34567";
            customerOne.Name = "Çağatay";
            customerOne.Surname = "Sarıoğlu";

            CorporateCustomer customerTwo = new CorporateCustomer();
            customerTwo.Id = 2;
            customerTwo.CustomerNo = "987345";
            customerTwo.TaxNo = "738495";
            customerTwo.FirmName = "hçsYazılım";

            Customer customerThree = new IndividualCustomer();
            Customer customerFour = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customerOne);
            customerManager.Add(customerThree);
        }
    }
}

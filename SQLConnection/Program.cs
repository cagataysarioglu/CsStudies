using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string queryString = "SELECT Products.ProductName AS ProductName, SUM([Order Details].UnitPrice * [Order Details].Quantity) AS TotalGain" +
                                 "FROM Products" +
                                 "INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID" +
                                 "INNER JOIN Orders ON Orders.OrderID = [Order Details].OrderID" +
                                 "GROUP BY Products.ProductName" +
                                 "ORDER BY ProductName, TotalGain";
            Connector connector = new Connector();
            connector.Perform(queryString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthiwndSorgularLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities context = new NorthwindEntities();
            var ordD = context.Order_Details.ToList();

            var query = (from o in ordD
                         join p in context.Products.ToList() on o.ProductID equals p.ProductID
                         group (o, p) by o.ProductID into g
                         select new
                         {
                             ProductID = g.Key,
                             ProductPrice = g.Where(x => x.o.ProductID == g.Key).FirstOrDefault().o.UnitPrice,
                             ProductOrtalamaFiyat = g.Where(x => x.o.ProductID == g.Key).Average(x => x.o.UnitPrice),
                         }).OrderByDescending(x => x.ProductID);

            var query2 = from b in query
                         select new
                         {
                             ProductID = b.ProductID,
                             Message = b.ProductPrice < b.ProductOrtalamaFiyat ? "Ortalamanın Altında" : "Ortalamanın Üstünde",
                             ProductAvarage = b.ProductOrtalamaFiyat,
                             ProductPrice = b.ProductPrice
                         };
            foreach (var item in query2)
            {
                Console.WriteLine("ProductId:" + item.ProductID + " Price: " + item.ProductPrice + " Avarage:" + item.ProductAvarage + " Message:" + item.Message);
            }

            var ordersByCustomerRegion = (from o in context.Orders.ToList()
                                          join c in context.Customers.ToList() on o.CustomerID equals c.CustomerID
                                          join od in context.Order_Details.ToList() on o.OrderID equals od.OrderID
                                          group new { c, o, od } by new { c.Region } into gr
                                          select new
                                          {
                                              Region = gr.Key,
                                              TotalPrice = gr.Sum(x => x.od.Quantity * x.od.UnitPrice)
                                          }).ToList().OrderByDescending(x => x.TotalPrice);
        }
    }
}

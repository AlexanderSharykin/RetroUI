using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DemoApp
{
    public class DemoData
    {
        public static string[] Months =
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December",
        };

        private static Random Rnd = new Random();
        private static string Abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private List<Order> _orders;
        private string _selectedMonth;

        public DemoData()
        {
            OrdersView = new ListCollectionView(Orders);
            SelectedMonth = Months[0];
            var cv = new ListCollectionView(Orders);
            cv.GroupDescriptions.Add(new PropertyGroupDescription("Month"));
            YearOrders = cv;            
        }

        public string SelectedMonth
        {
            get { return _selectedMonth; }
            set
            {
                _selectedMonth = value;
                string month = _selectedMonth;
                OrdersView.Filter = o => ((Order) o).Month == month;
            }
        }

        public List<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    // generate 4 order per month with random Products
                    _orders = Enumerable.Range(1, 4)
                        .SelectMany(i => Months)
                        .Select(m => new Order
                                     {
                                         Month = m,
                                         Products = Enumerable.Range(1, Rnd.Next(3) + 1)
                                             .Select(i => new Product
                                                          {
                                                              Price = Rnd.Next(100) + 1,
                                                              Quantity = Rnd.Next(10) + 1,
                                                              Code = Abc[Rnd.Next(Abc.Length)].ToString() + Rnd.Next(10),
                                                          })
                                             .ToList()
                                     })
                        .ToList();
                    foreach (var o in _orders)
                    {
                        foreach (var p in o.Products)                        
                            p.Total = p.Price * p.Quantity;
                        
                        o.Total = o.Products.Sum(p => p.Total);
                    }
                }
                return _orders;
            }            
        }

        public ICollectionView OrdersView { get; private set; }

        public ICollectionView YearOrders { get; private set; } 
    }

    public class Order
    {
        public string Month { get; set; }

        public List<Product> Products { get; set; }

        public int Total { get; set; }

        public override string ToString()
        {
            return String.Format("{0} product(s); ${1}", Products.Count, Total);
        }
    }

    public class Product
    {
        public string Code { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int Total { get; set; }        
    }
}

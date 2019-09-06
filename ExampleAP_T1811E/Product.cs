using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAP_T1811E
{
  public abstract class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Producer { get; set; }

        public Product(string id, string name, double price, string producer)
        {
            Id = id;
            Name = name;
            Price = price;
            Producer = producer;
        }

        public abstract double ComputeTax();
    }

}

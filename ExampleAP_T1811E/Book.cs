using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAP_T1811E
{
    class Book : Product
    {
       public Book(string id, string name, double price, string producer) : base(id, name, price, producer)
        {
          
        }
        
        public override double ComputeTax()
        {
            return (Price * 0.08);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAP_T1811E
{
    class MobilePhone : Product
    {
       public MobilePhone(string id, string name, double price, string producer) : base(id, name, price, producer)
        {
        }
       

        public override double ComputeTax()
        {
            return (Price * 0.1);
        }
    }
}

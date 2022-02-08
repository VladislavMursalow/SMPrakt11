using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt11
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string[] decriptions) : base(decriptions) { }

        public override string GetData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bicycle: (");

            foreach (string s in _descriptions)
            {
                sb.Append(s + " ");
            }
            sb.Append(") ");

            return sb.ToString() + _mileage + "km";
        }
    }
}

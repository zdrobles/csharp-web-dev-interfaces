using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double difference = x.Cost - y.Cost;
            return difference > 0 ? 1 : difference < 0 ? -1 : 0;
        }
    }
}

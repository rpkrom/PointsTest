using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsTest
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RewardPoints
        {
            get
            {
                return this.ComparisonPoints;
            }

        }

        public int ComparisonPoints { get; set; }

        public Transactions Transactions { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class Car
    {
        private int? speed;
        private Nullable<decimal> price;
        private int numberOfDoors;


        public int? Year { get; set; }

        public decimal? Price
        {
            get { return price; }
            set { price = value; }
        }

        public int? Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string CarType { get; set; }

        public int NumberOfDooers
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if (value < 10)
                {
                    numberOfDoors = value;
                }
            }
        }


    }
}

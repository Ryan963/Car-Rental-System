using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _291_Project
{
    public class Customer
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lname { get; set; }
        public string membership { get; set; }
        public string cell_number { get; set; }

        public string FullInfo
        {
            get
            {
                
                return $"{ fName } { lname } {ID} ({ membership })";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Purpose: Model the Car Table from SQL DataBase, Callable format that excludes
 *  non essential columns.
 *  Parameters: None
 *  Returns: None
 *  (2021-06-13)
 * 
 */

namespace _291_Project
{
    /* Data Model class for Car Table in SQL */
    public class Car
    {
        public string Vin { get; set; }
        public string make { get; set; }
        public string Model { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public string license_plate { get; set; }
        public int Availability { get; set; }
        public int branchID { get; set; }
        public string carClass { get; set; }
    
        public string FullInfo
        {
            /* TODO - Fix else statement for cleaner format */
            get
            {
                if (Availability == 1)
                {
                    return $"{ make } { Model } {year} is available";
                }
                else
                {
                    return "";
                }


            }
        }
    }
}
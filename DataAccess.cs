using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

/*  Purpose: Access database and run stored procedures in methods for various forms.
 *  
 *  Parameters: Uses Dapper Nuget for connection string
 *  Returns: None
 *  (2021-06-07)
 * 
 */



namespace _291_Project
{
    public class DataAccess
    {   
        public List<Customer> GoldMembers()
        {
            /* List containing each Customer */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WadesDB")))
            {           
                var output = connection.Query<Customer>("dbo.Customer_GoldMembership").ToList();
                return output;
            }
        }

        public List<Car> Availability(string bname) //, int availability)
        {
            /* List containing each car 
             TODO - add in an availability parameter, linked with a combobox(yes/no) */
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WadesDB")))
            {
                var output = connection.Query<Car>("dbo.FindCars_Availability_ByBranch @Name", new { Name = bname }).ToList(); //, Availability = availability}).ToList();
                return output;
            }        
        }

        public List<string> GetBranches()
        {
            /* List of each branch name 
             TODO- switch back to List<Branch> to use Branch Datamodel class*/
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WadesDB")))
            {
                var output = connection.Query<string>("dbo.GetBranchNames").ToList();
                return output;
                
            }
        }
    }
}

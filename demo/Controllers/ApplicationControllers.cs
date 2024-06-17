using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace demo.Controllers
{
    internal class ApplicationControllers
    {
        Connection connection = new Connection();
        private int k;

        
      
        public ApplicationTable CreateNewApplication(string equipment, string description)
        {
            try
            {    ApplicationTable appl= new ApplicationTable
            {
                   id_application = k+1,
                   problem_description = description

                };
                connection.auth.ApplicationTable.Add(appl);
                connection.auth.SaveChanges();
                return  appl;
            }
            catch (Exception ex)
            { throw new Exception($"{ex.Message}"); }
        }
    }
}

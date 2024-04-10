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

        
      
        public Заявки CreateNewApplication(string equipment, string description)
        {
            try
            {    Заявки appl= new Заявки
                {
                   id_заявки = k+1,
                   Описание_проблемы = description

                };
                connection.auth.Заявки.Add(appl);
                connection.auth.SaveChanges();
                return  appl;
            }
            catch (Exception ex)
            { throw new Exception($"{ex.Message}"); }
        }
    }
}

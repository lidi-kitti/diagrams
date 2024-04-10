using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Connection
    {
        public DemoEntities auth = new DemoEntities();
        public scriptDataSet scriptDataSet = new scriptDataSet();
        int k = 5;
    }
}

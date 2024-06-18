using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Connection
    {
        public Demo_examEntities auth = new Demo_examEntities();
        public Demo_examDataSet demo_exam = new Demo_examDataSet();
        int k = 5;
    }
}

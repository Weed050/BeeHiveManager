using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManager
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day1
{
    class Fish : Animal
    {
        private int fins;

        private bool scales;
        private bool teeth;
        private string waterType;

        public Fish(int fins, bool scales, bool teeth, string waterType)
        {
            this.fins = fins;
            this.scales = scales;
            this.teeth = teeth;
            this.waterType = waterType;
        }

    }
}

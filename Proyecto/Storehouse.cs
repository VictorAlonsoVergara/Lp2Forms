using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDisecForms
{
    class Storehouse : AlmacenDisecWS.storehouse
    {
        public Storehouse()
        { 
            this.city = new City();
        }

        public override string ToString()
        {
            return this.storehouse_name;
        }
    }
}

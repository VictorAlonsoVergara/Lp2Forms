using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDisecForms
{
   class City : AlmacenDisecWS.city

    {
    public City()
        {
          
        }
        City(int id, String name)
        {
            this.id_city = id;
            this.name_city = name;

        }        
        public override string ToString()
        {
            return this.name_city;
        }
    } 
}

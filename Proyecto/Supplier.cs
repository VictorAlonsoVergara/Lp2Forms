using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDisecForms
{
    class Supplier : AlmacenDisecWS.supplier
    {
       


        public Supplier()
        {
      
            this.city = new City();
        }

      

        public override string ToString()
        {
            return this.supplier_name;
        }
    }
  
}

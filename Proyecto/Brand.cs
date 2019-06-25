using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDisecForms
{
    class Brand:AlmacenDisecWS.brand
    {
        public Brand()
        {
            
        }
        Brand(int id, String name)
        {
            this.brand_id = id;
            this.brand_name = name;

        }
        public override string ToString()
        {
            return this.brand_name;
        }
    }
}

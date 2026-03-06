using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Api.Models
{
    public class Products
    {
        public string ID{ get; set; }
        public string Name{ get; set; }
        public string Price{ get; set; }

        public int Quantity{ get; set; }

        public string category{get; set;}
        
        public string Img{ get; set; }

    }
}
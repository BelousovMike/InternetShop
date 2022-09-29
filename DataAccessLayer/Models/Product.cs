using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Code { get; set; }

        public int CompanyId { get; set; }


    }
}

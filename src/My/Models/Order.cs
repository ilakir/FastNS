using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderName { get; set; }
        public List<User> User { get; set; }
        public List<Product> Products { get; set; }
    }
}

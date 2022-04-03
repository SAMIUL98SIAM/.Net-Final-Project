using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int Customer_Id { get; set; }

        public virtual CustomerModel Customer { get; set; }
    }
}

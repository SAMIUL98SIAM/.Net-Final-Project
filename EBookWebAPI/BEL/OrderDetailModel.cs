using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public int Unitprice { get; set; }
        public int Product_Id { get; set; }
        public int Order_Id { get; set; }

        public virtual OrderModel Order { get; set; }
        public virtual ProductBookModel ProductBook { get; set; }
    }
}

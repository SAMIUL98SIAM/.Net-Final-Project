using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        public static void ApproveOrder(int id)
        {
            OrderRepo.ApproveOrder(id);
            
        }
        public static void CancelOrder(int id)
        {
            OrderRepo.CancelOrder(id);
        }
    }
}

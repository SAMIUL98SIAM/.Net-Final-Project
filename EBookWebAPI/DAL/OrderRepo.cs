using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static EbookEntities db;
        static OrderRepo()
        {
            db = new EbookEntities();
        }
        public static void ApproveOrder(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Proccess = "Approved";
            db.SaveChanges();
        }
        public static void CancelOrder(int id)
        {
            var book = (from o in db.OrderDetails
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Proccess = "Cancel Order";
            db.SaveChanges();
        }
    }
}

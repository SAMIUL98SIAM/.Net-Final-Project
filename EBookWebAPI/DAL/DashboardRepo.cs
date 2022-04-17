using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DashboardRepo
    {
        static EbookEntities db;
        static DashboardRepo()
        {
            db = new EbookEntities();
        }
        public static List<OrderDetail> CustomerOrders()
        {
            return db.OrderDetails.ToList();
        }
      
        public static void Activate(int id)
        {
            var book = (from o in db.ProductBooks
                         where o.Id == id
                         select o).FirstOrDefault();

            book.Status = 1;
            db.SaveChanges();
        }
        public static void Unactivate(int id)
        {
            var book = (from o in db.ProductBooks
                        where o.Id == id
                        select o).FirstOrDefault();

            book.Status = 0;
            db.SaveChanges();
        }
    }
}

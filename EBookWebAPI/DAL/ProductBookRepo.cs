using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductBookRepo : IRepo<ProductBook, int>
    {
        EbookEntities db;
        public ProductBookRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(ProductBook pb)
        {
            db.ProductBooks.Add(pb);
            db.SaveChanges();
        }

        public void Delete(ProductBook pb)
        {
            var _pb = db.ProductBooks.FirstOrDefault(p => p.Id == pb.Id);
            db.ProductBooks.Remove(_pb);
            db.SaveChanges();
        }

        public void Edit(ProductBook pb)
        {
            var _pb = db.Sellers.FirstOrDefault(p => p.Id == pb.Id);
            db.Entry(_pb).CurrentValues.SetValues(pb);
            db.SaveChanges();
        }

        public List<ProductBook> Get()
        {
            return db.ProductBooks.ToList();
        }

        public ProductBook Get(int id)
        {
            return db.ProductBooks.FirstOrDefault(p => p.Id == id);
        }
    }
}

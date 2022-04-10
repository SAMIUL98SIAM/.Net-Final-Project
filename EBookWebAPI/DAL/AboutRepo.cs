using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AboutRepo : IRepo<About>
    {
        EbookEntities db;
        public AboutRepo(EbookEntities db)
        {
            this.db = db;
        }
        public void Add(About about)
        {
            db.Abouts.Add(about);
            db.SaveChanges();
        }

        public void Delete(About about)
        {
            var _about = db.Abouts.FirstOrDefault(a => a.Id == about.Id);
            db.Abouts.Remove(_about);
            db.SaveChanges();
        }

        public void Edit(About about)
        {
            var _about = db.Abouts.FirstOrDefault(a => a.Id == about.Id);
            db.Entry(_about).CurrentValues.SetValues(about);
            db.SaveChanges();
        }

        public List<About> Get()
        {
            return db.Abouts.ToList();
        }
    }
}

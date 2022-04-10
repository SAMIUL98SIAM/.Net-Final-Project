using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AboutService
    {
        public static List<AboutModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<About, AboutModel>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AboutModel>>(DataAccessFactory.AboutDataAccess().Get());
            return data;
        }
        public static void Add(AboutModel about)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<AboutModel, About>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<About>(about);
            DataAccessFactory.AboutDataAccess().Add(data);

        }

        public static void Edit(AboutModel about)
        {
            var config = new MapperConfiguration
               (
                   c =>
                   {
                       c.CreateMap<AboutModel, About>();
                   }
               );
            var mapper = new Mapper(config);
            var data = mapper.Map<About>(about);
            DataAccessFactory.AboutDataAccess().Edit(data);

        }
        public static void Delete(AboutModel about)
        {
            var config = new MapperConfiguration
              (
                  c =>
                  {
                      c.CreateMap<AboutModel, About>();
                  }
              );
            var mapper = new Mapper(config);
            var data = mapper.Map<About>(about);
            DataAccessFactory.AboutDataAccess().Delete(data);
        }
    }
}

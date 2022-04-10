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
    public class HomeService
    {
        public static void Contact(ContactModel contact)
        {
            var config = new MapperConfiguration
           (
               c =>
               {
                   c.CreateMap<ContactModel, Contact>();
               }
           );
            var mapper = new Mapper(config);
            var data = mapper.Map<Contact>(contact);
            HomeRepo.Contact(data);

        }
    }
}

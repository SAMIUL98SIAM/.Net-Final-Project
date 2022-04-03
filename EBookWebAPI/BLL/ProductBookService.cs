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
    public class ProductBookService
    {
        public static List<ProductBookModel> Get()
        {
            var config = new MapperConfiguration
            (
                c =>
                {
                    c.CreateMap<ProductBook, ProductBookModel>();
                    c.CreateMap<Admin, AdminModel>();
                    c.CreateMap<Seller, SellerModel>();  
                }
            );
            var mapper = new Mapper(config);
            var pba = DataAccessFactory.ProduckBookDataAccess();
            var data = mapper.Map<List<ProductBookModel>>(pba.Get());
            return data;
        }
    }
}

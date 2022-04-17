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
    public class DashboardService
    {
        public static List<OrderDetailModel> CustomerOrders()
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<OrderDetail, OrderDetailModel>();
                    cfg.CreateMap<Order, OrderModel>();
                    
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderDetailModel>>(DashboardRepo.CustomerOrders());
            return data;
        }


        public static void Activate(int id)
        {
            DashboardRepo.Activate(id);
            //DataAccessFactory.OrderDataAcess().ApproveCancel(id);
        }
        public static void Unctivate(int id)
        {
            DashboardRepo.Unactivate(id);
        }

    }
}

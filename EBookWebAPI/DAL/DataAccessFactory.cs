﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static EbookEntities db;
        static DataAccessFactory()
        {
            db = new EbookEntities();
        }
        public static IRepo<Customer,int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
        public static IRepo<Seller,int> SellerDataAccess()
        {
            return new SellerRepo(db);
        }
        public static IRepo<ProductBook, int> ProduckBookDataAccess()
        {
            return new ProductBookRepo(db);
        }
    }
}

using SalesWebMrv.Data;
using SalesWebMrv.Services;
using SalesWebMrv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMrv.Services
{
    public class SellerService
    {
        private readonly SalesWebMrvContext _context;

        public SellerService(SalesWebMrvContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            //obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

using EasyCashIdentityProject.EntityLayer.Concrete;
using EasyCashIdentityProjectDataAccessLayer.Abstract;
using EasyCashIdentityProjectDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectDataAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess> , 
        ICustomerAccountProcessDal
    {
    }
}

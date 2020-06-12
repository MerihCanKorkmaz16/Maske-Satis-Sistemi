using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Abstract
{
    public interface IUserService
    {
        void UserAdd(Users user);
        Users LoginCheckUser(string tcno,string sifre);
        Users GetUser(string tcno);
        Users UpdateUser(Users user);
    }
}

using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.ServiceAdapter;
using MaskeSatisProject.DataAccess.Abstract;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;
        private IKpsService _kpsService;
        public UserManager(IUserDal userDal,IKpsService kpsService)
        {
            _userDal = userDal;
            _kpsService = kpsService;
        }

        public List<Users> GetAllUser()
        {
            return _userDal.GetAllUser();
        }

        public Users GetUser(string tcno)
        {
           return _userDal.GetUser(x => x.TcNo == tcno);
        }

        public Users LoginCheckUser(string tcno, string sifre)
        {
            var checkuser = _userDal.GetUser(x=>x.TcNo == tcno && x.Sifre == sifre);
            return checkuser;
        }

        public Users UpdateUser(Users user)
        {
            return _userDal.Update(user);
        }

        public void UserAdd(Users user)
        {
            CheckUserKpsService(user);
            _userDal.Add(user);
        }

        private void CheckUserKpsService(Users user)
        {
            if (_kpsService.ValidateUser(user) == false )
            {
                throw new Exception("Kullanıcı doğrulaması başarısız");
            }
        }

    }
}

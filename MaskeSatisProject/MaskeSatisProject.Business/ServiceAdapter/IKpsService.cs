using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.ServiceAdapter
{
    public interface IKpsService
    {
        bool ValidateUser(Users user);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeSatisProject.Entities.Concrete;

namespace MaskeSatisProject.Business.ServiceAdapter
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Users user)
        {
            KpsServiceReferans.KPSPublicSoapClient client = new KpsServiceReferans.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(user.TcNo), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DayOfBirth.Year);
        }
    }
}

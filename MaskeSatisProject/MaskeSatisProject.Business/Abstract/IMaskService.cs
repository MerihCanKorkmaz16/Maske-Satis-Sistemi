using MaskeSatisProject.Entities.ComplexType;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Abstract
{
    public interface IMaskService
    {
        List<MaskDetails> GetMaskDetails(int userId);
        void BuyMask(MaskTable maskTable);
    }
}

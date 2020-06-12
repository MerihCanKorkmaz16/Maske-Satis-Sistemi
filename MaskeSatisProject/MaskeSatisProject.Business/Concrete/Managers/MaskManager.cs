using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.DataAccess.Abstract;
using MaskeSatisProject.Entities.ComplexType;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Business.Concrete.Managers
{
    public class MaskManager : IMaskService
    {
        private IMaskDal _maskDal;
        public MaskManager(IMaskDal maskDal)
        {
            _maskDal = maskDal;
        }

        public void BuyMask(MaskTable maskTable)
        {
            _maskDal.Add(maskTable);
        }

        public List<MaskDetails> GetMaskDetails(int userId)
        {
           return  _maskDal.GetMaskDetail(userId);
        }
    }
}

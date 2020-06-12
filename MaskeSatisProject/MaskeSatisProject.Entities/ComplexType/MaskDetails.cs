using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.Entities.ComplexType
{
    public class MaskDetails
    {
        //nhibernate çalışacağımı düşündüğüm için virtual yazdım
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime OperationDate { get; set; }
    }
}

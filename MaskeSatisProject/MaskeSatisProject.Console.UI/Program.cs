using MaskeSatisProject.Business.Abstract;
using MaskeSatisProject.Business.Dependency_Resolvers.Ninject;
using MaskeSatisProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeSatisProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var userservice = InstanceFactory.GetInstance<IUserService>();
            userservice.UserAdd(
                new User
                {
                    FirstName="Merih Can",
                    LastName = "Korkmaz",
                    DayOfBirth = new DateTime(1997,3,29),
                    TcNo ="23566525060",
                    Sifre ="123",
                    Email ="merihcankorkmaz16@gmail.com"

                });
            Console.WriteLine("Eklendi");
            Console.ReadLine();

        }
    }
}

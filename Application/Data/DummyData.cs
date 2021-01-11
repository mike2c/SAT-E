using Core.Entity;
using Core.Security;
using Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Data
{
    public class DummyData
    {
        public void Initialize(SATContext context, IEncryptor encryptor)
        {

            if (!context.Users.Any())
            {
                context.Users.Add(
                new User()
                {
                    Username = "mcastilloc",
                    Password = encryptor.encrypt("123"),
                    Email = "macastilloc@enacal.com.pri",
                    //Rol = new List<Rol>()
                    //{
                    //    new Rol()
                    //    {
                    //        RolId = RolId.SOPORTE_SISTEMAS,
                    //        RolName = "Soporte de sistemas"
                    //    },
                    //    new Rol()
                    //    {
                    //        RolId = RolId.COMUNICACION_REDES,
                    //        RolName = "Redes y comunicaciones"
                    //    }
                    //},
                    Rol = new Rol()
                    {
                        RolId = RolId.SOPORTE_SISTEMAS,
                        RolName = "Soporte de sistemas"
                    },
                    IsActive = true
                });
            }

            context.SaveChanges();
        }
    }
}

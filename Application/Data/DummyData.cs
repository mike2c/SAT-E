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

            if (context.Users.Any())
                return;

            context.Users.Add (
                new User()
                {
                    Username = "mcastilloc",
                    Password = encryptor.encrypt("123"),
                    Email = "macastilloc@enacal.com.pri",
                    Roles = new List<Rol>()
                    {
                        new Rol()
                        {
                            RolId = RolId.Soporte,
                            RolName = "Soporte de sistemas"
                        },
                        new Rol()
                        {
                            RolId = RolId.Redes,
                            RolName = "Redes y comunicaciones"
                        }
                    },
                    IsActive = true                        
                }
            );

            context.SaveChanges();
        }
    }
}

using Core.Entity;
using Core.Security;
using Data.Data;
using System.Collections.Generic;
using System.Linq;

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
                    Rol = new Rol()
                    {
                        RolId = RolId.SOPORTE_SISTEMAS,
                        RolName = "Soporte de sistemas"
                    },
                    IsActive = true
                });
            }

            if (!context.Provinces.Any())
            {
                Province managua = new Province() { ProvinceName = "Managua" };
                Province nuevaSegovia = new Province() { ProvinceName = "NuevaSegovia" };
                Province esteli = new Province() { ProvinceName = "Esteli" };
                Province matagalpa = new Province() { ProvinceName = "Matagalpa" };
                Province leon = new Province() { ProvinceName = "Leon" };

                Municipality tipitapa = new Municipality() { MunicipalityName = "Tipitapa" };
                Municipality managuaCabecera = new Municipality() { MunicipalityName = "Managua" };

                List<Municipality> municipalities = new List<Municipality>() { tipitapa, managuaCabecera };

                managua.Municipalities = municipalities;

                Municipality ocotal = new Municipality() { MunicipalityName = "Ocotal" };
                Municipality jalapa = new Municipality() { MunicipalityName = "Jalapa" };

                nuevaSegovia.Municipalities = new List<Municipality>() { ocotal, jalapa };

                Municipality cabeceraEsteli = new Municipality() { MunicipalityName = "Esteli" };
                Municipality condega = new Municipality() { MunicipalityName = "Condega" };

                esteli.Municipalities = new List<Municipality>() { cabeceraEsteli, condega };

                Municipality leonCabecera = new Municipality() { MunicipalityName = "Leon" };
                Municipality larreynaga = new Municipality() { MunicipalityName = "Larreynaga" };

                leon.Municipalities = new List<Municipality>() { leonCabecera, larreynaga };

                Branch asososca = new Branch() { BranchName = "Asososca", Municipality = managuaCabecera };
                Branch altamira = new Branch() { BranchName = "Altamira", Municipality = managuaCabecera };
                Branch sucursalOcotal = new Branch() { BranchName = "Ocotal", Municipality = ocotal };
                Branch sucursalEsteli = new Branch() { BranchName = "Esteli", Municipality = cabeceraEsteli };
                Branch sucursalLeon = new Branch() { BranchName = "Leon", Municipality = leonCabecera };

                context.Provinces.Add(managua);
                context.Provinces.Add(nuevaSegovia);
                context.Provinces.Add(esteli);
                context.Provinces.Add(matagalpa);
                context.Provinces.Add(leon);

                context.Branches.Add(asososca);
                context.Branches.Add(altamira);
                context.Branches.Add(sucursalOcotal);
                context.Branches.Add(sucursalEsteli);
                context.Branches.Add(sucursalLeon);
            }

            if (!context.Source.Any())
            {
                context.Source.Add(new Source() { SourceName = "(AV) AquaVisum", TaskType = TaskType.AsistenciaTecnica, IsActive = true });
                context.Source.Add(new Source() { SourceName = "(SCI) Sistema de Inventario", TaskType = TaskType.AsistenciaTecnica, IsActive = true });
            }

            context.SaveChanges();
        }
    }
}

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
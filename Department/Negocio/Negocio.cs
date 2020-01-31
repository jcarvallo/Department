using Department.Datos;
using Department.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department.Negocio
{
    public class Negocio:INegocio
    {
        private readonly IDato _dato;

        public Negocio(IDato dato)
        {
            _dato = dato;
        }

        public string CreateDepartment(DepartmentModel data)
        {
            return _dato.CreateDepartment(data);
        }

        public string DeleteDepartment(int id)
        {
            return _dato.DeleteDepartment(id);
        }

        public IList<DepartmentModel> GetAll()
        {
            return _dato.GetAll();
        }

        public string UpdateDepartment(DepartmentModel data, int id)
        {
            return _dato.UpdateDepartment(data,id);
        }
    }
}

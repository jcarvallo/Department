using Department.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department.Negocio
{
    public interface INegocio
    {
        IList<DepartmentModel> GetAll();
        string CreateDepartment(DepartmentModel data);
        string UpdateDepartment(DepartmentModel data, int id);
        string DeleteDepartment(int id);
    }
}

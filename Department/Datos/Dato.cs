using Department.Dapper;
using Department.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Department.Datos
{
    public class Dato: IDato
    {
        private IConnectionDB _connect;

        public Dato(IConnectionDB connect)
        {
            _connect = connect;
        }
        public string CreateDepartment(DepartmentModel data)
        {
           
            try
            {
                var conn = _connect.ConexionABase();
                conn.Query<DepartmentModel>($"Insert into [dbo].[Departments] VALUES ('{data.Name}','{data.Description}')");
                return "OK";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string DeleteDepartment(int id)
        {
            try
            {
                var conn = _connect.ConexionABase();
                conn.Query<DepartmentModel>($"DELETE FROM [dbo].[Departments] WHERE id='{id}'");
                return "OK";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<DepartmentModel> GetAll()
        { 
            var conn = _connect.ConexionABase();
            var resul = conn.Query<DepartmentModel>(@"Select * from [dbo].[Departments]").ToList();
            return resul;
;

        }

        public string UpdateDepartment(DepartmentModel data, int id)
        {
            try
            {
                var conn = _connect.ConexionABase();
                conn.Query<DepartmentModel>($"UPDATE [dbo].[Departments] SET Name='{data.Name}', Description='{data.Description}' WHERE id='{id}'");
                return "OK";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

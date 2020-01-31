using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Department.Modelo;
using Department.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Department.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
      

        private readonly ILogger<DepartmentController> _logger;
        private readonly INegocio _negocio;

        public DepartmentController(ILogger<DepartmentController> logger, INegocio negocio)
        {
            _logger = logger;
            _negocio = negocio;
        }

    
        [HttpPost]
        public string CreateDepartment(DepartmentModel data)
        {
            return _negocio.CreateDepartment(data);
        }
        [HttpDelete]
        public string DeleteDepartment(int id)
        {
            return _negocio.DeleteDepartment(id);
        }
        [HttpGet]
        public IList<DepartmentModel> GetAll()
        {
            return _negocio.GetAll();
        }
        [HttpPut]
        public string UpdateDepartment(DepartmentModel data, int id)
        {
            return _negocio.UpdateDepartment(data, id);
        }
    }
}

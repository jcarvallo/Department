using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Department.Dapper
{
    public interface IConnectionDB
    {
        IDbConnection ConexionABase();
    }
}

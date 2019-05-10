using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DwDxx.IDAL
{
    public partial interface IDBSession
    {
        DbContext Db { get; }
        bool SaveChanges();
        int ExecuteSql(string sql, params IDbDataParameter[] pars);
        //List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars);
    }
}

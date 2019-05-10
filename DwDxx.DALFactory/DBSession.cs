using DwDxx.DAL;
using DwDxx.IDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DwDxx.DALFactory
{
    public partial class DBSession : IDBSession
    {
        public DbContext Db
        {
            get { return DBContextFactory.CreateDbContext(); }
        }

        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }

        public int ExecuteSql(string sql, params IDbDataParameter[] pars)
        {
            return Db.Database.ExecuteSqlCommand(sql, pars);
        }

        //public List<T> ExecuteQuery<T>(string sql, params IDbDataParameter[] pars)
        //{
        //	return Db.Database.SqlQuery<T>(sql, pars).ToList();
        //}
    }
}

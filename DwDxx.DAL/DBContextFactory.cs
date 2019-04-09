using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DwDxx.Model;

namespace DwDxx.DAL
{
    /// <summary>
    /// 负责创建EF操作数据的上下文实例对象，并保证其在线程内唯一
    /// </summary>
    public class DBContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if(dbContext == null)
            {
                dbContext = new DwdxxContext();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }
    }
}

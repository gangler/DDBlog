using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DwDxx.DALFactory
{
    /// <summary>
    /// 通过反射的形式创建类的实例
    /// </summary>
    public partial class AbstractFactory
    {
        private static readonly string AssemblyPath = "DwDxx.DAL";
        private static readonly string NameSpace = "DwDxx.DAL";

        private static object CreateInstance(string className)
        {
            var assembly = Assembly.Load(AssemblyPath);
            return assembly.CreateInstance(className);
        }
    }
}

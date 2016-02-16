using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo_13.Models
{
    public class _13_2MVC中的依赖解析
    {
    }
    /// <summary>
    /// mvc与容器交互的主要方式就是通过 为mvc应用程序创建一个接口：IDependency Resolver  
    /// </summary>
    public interface IDependencyResolver
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}
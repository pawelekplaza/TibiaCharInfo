using System.Collections.Generic;
using System.Linq;

namespace TibiaCharInfo.Services
{
    public class ServicesContainer
    {
        private readonly IList<object> registeredObjects = new List<object>();

        public void Register<Interface, TConcrete>()    where TConcrete : new()
                                                        where Interface : class
        {
            if (registeredObjects.Any(v => v.GetType().GetInterfaces().Any(x => x.FullName == (typeof(Interface).FullName))))
                return;
            registeredObjects.Add(new TConcrete());
        }

        public T GetService<T>() where T : class
        {
            return registeredObjects.FirstOrDefault(v => (v as T) != null) as T;
        }
    }
}

using ASP_Homework_Product.Models;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ASP_Homework_Product
{
    public interface IRolesRepository
    {
        List<Role> GetAll();
        Role TryGetByName(string Name);
        void Add(Role role);
        void Remove(string name);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecipeData
{
    public interface IRepository<T>
    {
        T FindById(int id);
    }
}

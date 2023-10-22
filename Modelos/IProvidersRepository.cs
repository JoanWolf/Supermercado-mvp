using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Modelos
{
    internal interface IProvidersRepository
    {
        void Add(ProvidersModel categoryModel);
        void Edit(ProvidersModel categoryModel);
        void Delete(int id);
        IEnumerable<ProvidersModel> GetAll();
        IEnumerable<ProvidersModel> GetByValue(String value);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID, RET>
    {
        RET Create(CLASS obj);
        void Delete(ID id);
        CLASS Get(ID id);
        List<CLASS> Get();
        RET Update(CLASS obj);

    }
}

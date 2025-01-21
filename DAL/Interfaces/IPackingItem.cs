using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPackingItem
    {
        bool CreateMuliple(List<PackingItem> obj);
        List<PackingItem> GetByTripId(int id);


    }
}

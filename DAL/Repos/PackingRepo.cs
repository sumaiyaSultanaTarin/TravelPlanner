using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PackingRepo : Repo, IRepo<PackingItem, int, bool>, IPackingItem
    {
        public bool Create(PackingItem obj)
        {
            db.PackingItems.Add(obj);
            return db.SaveChanges() > 0;

        }

        public void Delete(int id)
        {
            var exobj = Get(id);
            if (exobj != null)
            {
                db.PackingItems.Remove(exobj);
                db.SaveChanges();
            }
        }

        public PackingItem Get(int id)
        {
            return db.PackingItems.Find(id);
        }

        public List<PackingItem> Get()
        {
            return db.PackingItems.ToList();
        }
        
        public  List<PackingItem> GetByTripId(int id)
        {
            return db.PackingItems.Where(x => x.TripId == id).ToList();
        }
        public bool Update(PackingItem obj)
        {
            var exobj = Get(obj.PackingItemId);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            else
            {
                return false;
            }
        }

        public bool CreateMuliple(List<PackingItem> obj)
        {
            db.PackingItems.AddRange(obj);
            return db.SaveChanges() > 0;
        }
    }
}

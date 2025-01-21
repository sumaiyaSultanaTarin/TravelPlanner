using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TripRepo : Repo, IRepo<Trip, int, bool>
    {
        public bool Create(Trip obj)
        {
            db.Trips.Add(obj);
            return db.SaveChanges() > 0;
        }

        public void Delete(int id)
        {
            var exobj = Get(id);
            if (exobj != null)
            {
                db.Trips.Remove(exobj);
                db.SaveChanges();
            }

           
        }

        public Trip Get(int id)
        {
            return db.Trips.Find(id);
        }

        public List<Trip> Get()
        {
            return db.Trips.ToList();
        }

        public bool Update(Trip obj)
        {
            var exobj = Get(obj.TripId);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            else {
                return false;
            }
        }
    }
}

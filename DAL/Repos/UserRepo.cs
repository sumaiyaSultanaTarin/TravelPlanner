using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, User>, IAuth
    {
        public User Authenticate(string username, string password)
        {
            return db.Users.Where(x => x.Username.Equals(username) && x.Password.Equals(password)).SingleOrDefault();

        }

        public User Create(User obj)
        {

            db.Users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public void Delete(string id)
        {
            var ex = Get(id);
            db.Users.Remove(ex);
            db.SaveChanges();
        }

        public User Get(string id)
        {
            return db.Users.FirstOrDefault(u => u.Username.Equals(id));
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Update(User obj)
        {
            var ex = Get(obj.Username);
            db.Entry(ex).CurrentValues.SetValues(ex);
            db.SaveChanges();
            return ex;

        }
    }
}

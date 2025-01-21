using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Trip, int, bool> TripData()
        {
            return new TripRepo();
        }
     
        public static IBudget BudgetData()
        {
            return new TripRepo();
        }

        public static IPackingItem PackingItemData()
        {
            return new PackingRepo();
        }
        public static IAuth Auth()
        {
            return new UserRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
    }
}

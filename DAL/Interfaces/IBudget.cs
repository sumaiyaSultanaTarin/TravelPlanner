using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBudget
    {
        bool UpdateBudget(int id, double budget);
        bool UpdateExpense(int id, double actualExpense);
    }
}

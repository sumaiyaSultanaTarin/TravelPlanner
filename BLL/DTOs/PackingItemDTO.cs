using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PackingItemDTO
    {
        public int PackingItemId { get; set; }
        public string ItemName { get; set; }
        public bool IsPacked { get; set; }
        public int TripId { get; set; }
    }
}

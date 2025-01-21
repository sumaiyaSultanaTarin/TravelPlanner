using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class PackingItem
    {
        public int PackingItemId { get; set; }
        public string ItemName { get; set; }
        public bool IsPacked { get; set; }
        public int TripId { get; set; }
        [ForeignKey("TripId")]
        public virtual Trip Trip { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Palliative.Models
{
    public class EventModel
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public string event_type { get; set; }
        public string event_data { get; set; }
        public DateTime created { get; set; }
        public bool current { get; set; }
    }

    public class EventModelDbContext:DbContext
    {
        public DbSet<EventModel> Events { get; set; }
    }
 }
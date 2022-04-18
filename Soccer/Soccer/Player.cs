using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Soccer
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

    }
    public class SoccerContext : DbContext
    {
        public SoccerContext()
            : base("DefaultConnection")
        { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public virtual ICollection<Player> Players { get; set; } 
    }
}

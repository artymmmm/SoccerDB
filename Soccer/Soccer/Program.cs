using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Soccer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoccerContext db = new SoccerContext())
            {
                var p = db.Players.ToList();
                foreach (var player in p)
                {
                    Console.WriteLine("{0} - {1}", player.Name, player.Team.Name);
                }
            }
                }
            }
        }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    class Program
    {
        static void Main(string[] args)
        {
            GossipTeam gp = new GossipTeam();
            gp.CreateStory();
            HealthTeam ht = new HealthTeam();
            ht.CreateStory();
            PoliticsTeam pt = new PoliticsTeam();
            pt.CreateStory();
            Story[] story = new Story[3]
            {
                gp.GetStory(),
                ht.GetStory(),
                pt.GetStory()
            };


            NewsPaper np = new NewsPaper(story, 34);

            GossipTeam gps = new GossipTeam();
            gp.CreateStory();
            HealthTeam hts = new HealthTeam();
            ht.CreateStory();
            PoliticsTeam pts = new PoliticsTeam();
            pt.CreateStory();
            Story[] storyy = new Story[3]
            {
                gps.GetStory(),
                hts.GetStory(),
                pts.GetStory()
            };
            NewsPaper nps = new NewsPaper(storyy, 30);
            Seller s = new Seller();
            s.SellNewsPaper(np);
            s.SellNewsPaper(nps);
        }
    }
}

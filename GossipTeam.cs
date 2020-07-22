using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    internal class GossipTeam : NewsTeam
    {

        internal override void CreateStory()
        {
            story = new Story("did the reachest man die?", "the reachest man died yesterday");
        }

        public override string ToString()
        {
            return story.ToString();
        }

    }
}

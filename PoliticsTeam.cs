using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
   internal class PoliticsTeam : NewsTeam
    {
        internal override void AddStyle()
        {
            story.SetVisualStyle("man reading in the backround");
        }

        internal override void CreateStory()
        {
            story = new Story("can we stop the corona virus from spreading?", "we can do it by wearing masks");
        }
        public override string ToString()
        {
            return story.ToString();
        }
    }
}

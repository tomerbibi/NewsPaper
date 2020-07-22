using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    internal class HealthTeam : NewsTeam
    {
        internal override void AddStyle()
        {
            story.SetVisualStyle("nature backround");
        }

        internal override void CreateStory()
        {
            story = new Story("can lemons cure cancer?", "lemons cant cure cancer");
        }
        public override string ToString()
        {
            return story.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    abstract internal class NewsTeam
    {
        protected Story story;
        abstract internal void CreateStory();
        internal Story GetStory()
        {
            return story;
        }
        virtual internal void AddStyle()
        {
            story.SetVisualStyle("default style");
        }


    }
}

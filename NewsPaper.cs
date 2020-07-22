using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    public class NewsPaper
    {
        private Story[] story = new Story[3];
        private float _price;


        public NewsPaper(Story[] s, int price)
        {
            if (price > 0)
            {
                story = s;
                _price = price;
            }
            else
            {
                Console.WriteLine("you must change the price to zero or more");
            }
            if (s.Length != 3)
            {
                Console.WriteLine("error");
            }
        }
        public Story[] GetStories()
        {
            return story;
        }
        public void SetStories(Story[] s)
        {
            story = s;
        }
        public void SetPrice(float price)
        {
            if (price >= 0)
            {
                _price = price;
            }
        }
        public float GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return story[0].ToString() + story[1].ToString() + story[2].ToString();
        }
    }
}

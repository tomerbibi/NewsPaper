using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newspaper
{
    public class Story
    {
        private string _title;
        private string _body;
        private string _visualStyle;
        public Story (string title, string body)
        {
            _title = title;
            _body = body;
        }
        public string GetTitel()
        {
            return _title;
        }
        public void SetTitel(string newTitle)
        {
            _title = newTitle;
        }
        public string GetBody()
        {
            return _body;
        }
        public void Setbody(string newBody)
        {
            _body = newBody;
        }
        public string GetVisualStyle()
        {
            return _visualStyle;
        }
        public void SetVisualStyle(string newVisualStyle)
        {
            _visualStyle = newVisualStyle;
        }

        public override string ToString()
        {
            return $"title: {_title}, body: {_body}, visual style: {_visualStyle}";
        }
    }
}

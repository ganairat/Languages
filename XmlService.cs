using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Languages
{
    public class XmlService
    {
        public void SetWords(List<Word> words)
        {
            XDocument xdoc = XDocument.Load(@"..\..\ViewerMessages.xml");
            XElement root = xdoc.Element("messages");

            foreach (XElement xe in root.Elements("message").ToList())
            {
                var variants = xe.Elements("variant").ToList();
                var ww = words.Find(w => w.English == variants[0].Value);
                variants[1].Value = ww.Russian;
            }
            xdoc.Save(@"..\..\ViewerMessagesFull.xml");
        }
    }
}

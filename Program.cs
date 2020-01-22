using System.Collections.Generic;

namespace Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            ExelService exelService = new ExelService();
            List<Word> words = exelService.getWords();

            XmlService xmlService = new XmlService();
            xmlService.SetWords(words);
           
        }
    }
}

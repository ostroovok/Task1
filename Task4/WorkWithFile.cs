using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4   
{
    public class WorkWithFile
    {
        public string TextFromFile { get; set; }

        public WorkWithFile(string textFromFile)
        {
            TextFromFile = textFromFile;
        }

        public DictHashTable FindWordsOfN()
        {
            string[] words = TextFromFile.Split(new string[] { "\r\n", " " }, StringSplitOptions.None);
            DictHashTable dict = new DictHashTable();
            dict.Add(words[0].ToLower(), 1);
            for (int i = 1; i < words.Length; i++)
            {
                bool check = Find(words[i], dict);
                if (!check)
                    dict.Add(words[i], 1);
            }
            return dict;
        }
        private bool Find(string word, DictHashTable dict)
        {
            var temp = dict.GetElement(word.ToLower());
            if (temp != null)
            {
                temp.Value += 1;
                return true;
            }
            return false;
        }
    }
}

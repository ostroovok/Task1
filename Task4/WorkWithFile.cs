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

        public DictHashTable FindWordsOfNLen()
        {
            string[] words = TextFromFile.Split(' ');
            DictHashTable dict = new DictHashTable();
            dict.Add(0, words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                
            }
            return null;
        }
        private bool Find(string word, DictHashTable dict)
        {
            for (int i = 0; i < dict.Size; i++)
            {
                if(word == )
            }
            return true;
        }
    }
}

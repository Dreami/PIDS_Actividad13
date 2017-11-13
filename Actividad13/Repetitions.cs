using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad13
{
    class Repetitions
    {
        private string word;
        private int overall_repetitions;
        private HashSet<string> repeatsPerFile = new HashSet<string>();
        private Dictionary<string, int> dictionary_files = new Dictionary<string, int>();

        public Repetitions(string w, string fileName)
        {
            word = w;
            overall_repetitions = 1;
            repeatsPerFile.Add(fileName);
            dictionary_files.Add(fileName, 1);
        }

        public void addWord(string fileName)
        {
            overall_repetitions++;
            repeatsPerFile.Add(fileName);
            if(dictionary_files.ContainsKey(fileName))
            {
                dictionary_files[fileName] = dictionary_files[fileName] + 1;
            } else
            {
                dictionary_files.Add(fileName, 1);
            }
        }

        public int getRepetitions()
        {
            return this.overall_repetitions;
        }

        public int getRepeatsCount()
        {
            return this.repeatsPerFile.Count();
        }

        public HashSet<string> getFilesFoundIn()
        {
            return this.repeatsPerFile;
        }

        public Dictionary<string, int> getDictionaryFiles()
        {
            return this.dictionary_files;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events
{
    class WordAddedEventArgs : EventArgs
    {
        private List<string> _Items;
        private string _Word;

        public List<string> Items { get => _Items; set => _Items = value; }
        public string Word { get => _Word; set => _Word = value; }
        public DateTime AddedDateTime { get; set; } = DateTime.Now;

        public WordAddedEventArgs(List<string> items, string word)
        {
            Items = items;
            Word = word;
        }
    }
    internal class Words
    {
        public delegate void WordRemoved();
        public delegate void WordAdded(WordAddedEventArgs args);
        public event WordRemoved OnWordRemoved;
        public event WordAdded OnWordAdded;
        
        
        private List<string> _Items = new List<string> { "CSharp", "Java", "Python", "Go" };
        
        public void Add(string word)
        {
            _Items.Add(word);
            if (OnWordAdded != null)
            {
                OnWordAdded.Invoke(new WordAddedEventArgs(_Items, word));
            }
        }

        public void Remove(string item)
        {
            _Items.Remove(item);
            if (OnWordRemoved != null)
            {
                OnWordRemoved.Invoke();
            }
        }

        public void ListAll()
        {
            int ndx = 1;
            foreach (var item in _Items)
            {
                Console.WriteLine($"{ndx++} {item}");
            }
        }
    }
}

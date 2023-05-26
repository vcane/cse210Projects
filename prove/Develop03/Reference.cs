using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Develop03
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _lastVerse;
        private int _numberOfVerses;

        public Reference(string book, string chapter, string verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _numberOfVerses = 1;
        }

        public Reference(string book, string chapter, string verse, string lastVerse)
            :this(book,chapter,verse)
        {
            _lastVerse = lastVerse;
            _numberOfVerses = 2;
        }

        public void LoadReference()
        {
        
        }

        public string RenderReference()
        {
            if (_numberOfVerses == 1)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
            }
        }
    }
}
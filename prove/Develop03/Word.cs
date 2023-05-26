using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Develop03
{
    public class Word
    {
        private string _word;
        private bool _visible;

        public Word(string word)
        {
            _word = word;
            _visible = true;
        }

        
        public override string ToString()
        {
            return base.ToString();            
        }
                

        public void HideWord()
        {
           _visible = false;
        }

        public string GetRenderedText()
        {
            //return word if visible 
            //__ if not visible
            if (_visible == true)
            {
                return $"{_word}";
            }
            else
            {
                string underscore = new string('_', _word.Length);
                return underscore;
            }
        }
    }
}
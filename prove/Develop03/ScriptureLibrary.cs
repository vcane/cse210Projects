using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Develop03
{
  public class ScriptureLibrary
  {
        private List<List<string>> _scriptureLibrary; 
        private string _loadedScriptures;
        

        public ScriptureLibrary()
        {

            List<List<string>> scriptureLibrary = new List<List<string>>();
            // create inner lists of strings to add to library
            List<string> scripture1 = new List<string>() 
            {
                "Proverbs;3;5;6",
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                "In all thy ways acknowledge him, and he shall direct thy paths."
            };
            List<string> scripture2 = new List<string>()
            {
                "John;3;16",
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            };

            scriptureLibrary.Add(scripture1);
            scriptureLibrary.Add(scripture2);
            _scriptureLibrary = scriptureLibrary;
        }

        public List<string> RenderRandomScripture()
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(_scriptureLibrary.Count);
            //List<List<string>> randomScriptureVerses = new List<List<string>>();
            //randomScriptureVerses = _scriptureLibrary;
            List<string> randoVerse = new List<string>();
            
            randoVerse = _scriptureLibrary[index];
            /*
            for (int i = 0; i < randoVerse.Count; i++)
            {
                Console.WriteLine(randoVerse[i]);
            }*/

            
            //Console.WriteLine(numberOfVerses);
            return randoVerse;
            // render a random scripture from the _scriptureLibrary
            // return the list
        }

        public int NumberOfVerses()
        {
            List<string> randoVerse = RenderRandomScripture();
            return (randoVerse.Count) - 1;
        }

        /*private int GenerateRandomIndexNumber()
        {
          //throw new System.NotImplementedException();
        }
        */

        // public string GetRandomScripture()
        // {
        //   Random randomScriptureIndex = new Random();
        //   randomScriptureIndex.Next();

        //         //throw new System.NotImplementedException();
        // }
    }
}
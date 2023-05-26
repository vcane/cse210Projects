using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Develop03
{
  public class Scripture
  {
    private Reference _reference;
    private List<Word> _scriptureText;
    private Random random = new Random();

    public Scripture(List<Word> scriptureText, Reference reference)
    {
      _reference = reference;
      _scriptureText = scriptureText;
      // initialize _reference
      // initialize _scriptureText
    }

    /*public string RenderScripture()
    {
        for(int i = 0; i < _scriptureText.Count; i++)
            {   
                int randomIndex = random.Next(0, _scriptureText.Count);

            }
            
            
            //hide number of words randomly
            //create a string that represents a scripture
            //render reference
            //call scriptureText with join method
            //return that string
    }

    
    
    public string RenderText()
    {
        throw new System.NotImplementedException();
    }

    public void HideWords()
    {
        throw new System.NotImplementedException();
    }
    
    public bool IsCompletelyHidden()
    {
        
    }
/*
    public string GetRandomScripture()
    {
        throw new System.NotImplementedException();
    }
    */
    
  }
}
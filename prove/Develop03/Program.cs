using System;
using Develop03;

class Program
{

    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        List<string> scripture = library.RenderRandomScripture();
        foreach (string s in scripture)
        {
            Console.WriteLine(s);
        }
        int numberOfVerses = library.NumberOfVerses();
        string scriptureReference = scripture[0];
        string[] splitReference = scriptureReference.Split(";");
        
        //Console.WriteLine(numberOfVerses);
        if (numberOfVerses == 1 ) 
        {
            string book = splitReference[0];
            string chapter = splitReference[1];
            string verse = splitReference[2];
            Reference reference = new Reference(book, chapter, verse) { };
        }
        else 
        {
            string book = splitReference[0];
            string chapter = splitReference[1];
            string verse = splitReference[2];
            string lastVerse = splitReference[3];
            Reference reference = new Reference(book, chapter, verse, lastVerse) { };
        }

        Console.WriteLine(reference.RenderRefernce());







        //ScriptureLibrary library = new ScriptureLibrary();
        //List<string> scripture = library.RenderRandomScripture();
        //Scripture scripture = new Scripture();
        //create word list to pass to scripture constructor
        //iterate until
        /*
        FileHelper fileHelper = new FileHelper();
        string[] file = fileHelper.LoadFile();
        Console.WriteLine("Displaying file...");
        foreach (string s in file)
        {
            Console.WriteLine(s);
        }
        */
    }
}
using System;

public class PromptHandler
{
  // attributes
  public List<string> _prompts = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What service did someone provide for me today?",
    "What service did I provide for someone today?",
    "What problem(s) did I have today? How did I solve the problem(s) or how do I plan to solve it?",
    "What did I read about in the scriptures today?",
    "What was the weather like today?"
  };

  public string GetRandomPrompt()
  {
    Random randomNum = new Random();
    int promptIndex = randomNum.Next(0, 10);
    return _prompts[promptIndex];
  }
}
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("||Welcome to Quiz, it shall start now||");
    Console.WriteLine ("Question 1: What are an intergers capablilites?");
    Console.WriteLine ("1: Being Positive");
    Console.WriteLine ("2: Being Negative");
    Console.WriteLine ("3: Being Zero");
    Console.WriteLine ("4: All Above");
    int opt = Convert.ToInt32(Console.ReadLine()); 
    if (opt == 4)
        {
            Console.WriteLine("Correct");
    }
      else
                Console.WriteLine("Incorrect");

    Console.WriteLine ("Question 2: What is a %%?");
    Console.WriteLine ("1: If both are true is true but if one is false its false");
    Console.WriteLine ("2: If Both are true its false but if one is false its frue");
    Console.WriteLine ("3: If one of them are true its true bit if both are true its also true");
    Console.WriteLine ("4: It will always be correct no matter what ");
    int opt1 = Convert.ToInt32(Console.ReadLine()); 
    if (opt1 == 1)
        {
            Console.WriteLine("Correct");
    }
      else
                Console.WriteLine("Incorrect");

        Console.WriteLine ("Question 3: What is the command Int i = 0;  apart of?");
    Console.WriteLine ("1: Operations");
    Console.WriteLine ("2: Looping");
    Console.WriteLine ("3: else if");
    Console.WriteLine ("4: Decimals");
    int opt2 = Convert.ToInt32(Console.ReadLine()); 
    if (opt2 == 2)
        {
            Console.WriteLine("Correct");
    }
      else
                Console.WriteLine("Incorrect");

 Console.WriteLine ("Question 4: What are Decimals primarly represented as in coding?");
    Console.WriteLine ("1: F1-12 Commands");
    Console.WriteLine ("2: Else if, Do While, int ETC...");
    Console.WriteLine ("3: Numbers");
    Console.WriteLine ("4: All Characters on a keyboard");
    int opt3 = Convert.ToInt32(Console.ReadLine()); 
    if (opt3 == 3)
        {
            Console.WriteLine("Correct");
    }
      else
                Console.WriteLine("Incorrect");


     Console.WriteLine ("Question 5: What is C-Sharp");
    Console.WriteLine ("1: A Programming Language ");
    Console.WriteLine ("2: A Code Command ");
    Console.WriteLine ("3: One of the three operators");
    Console.WriteLine ("4: A Special Character");
    int opt4 = Convert.ToInt32(Console.ReadLine()); 
    if (opt4 == 1)
        {
            Console.WriteLine("Correct");
    }
      else
                Console.WriteLine("Incorrect");

    Console.WriteLine ("CONGRAUTLAIONS YOU HAVE COMPLETED THE QUIZZ!");
  }
}
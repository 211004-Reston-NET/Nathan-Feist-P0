using System;
using CollectionFunction;
using HouseFunction;

// this is a comment

/*
All of this will be a comment

We use PascelCase for the most part it means naming artifacts as EverythingWillBeCapitalized
camelCase means naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning
*/

namespace HelloWorld
{
    class Program
    {
        /*
        - the main method is the first method that will run
        - static means that you don't heve to istantiate the program class to use that method
        - void, the method will not give anything back
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this is if you don't make the method static you have to instantiate it
              //  Program test = new Program(); //This will instantiate the obj
               // text.Example();
               Program.Example();
/*
1. Be able to read what the user will write in the terminal
2. Be able to attached that value to a variable
3. Write some statement that uses that variable back to the terminal
Hint: look into the Console class
4. Push this console application into a new remote repo in the organization title firstname-lastname-C#Hello (you can't use # in a name on GitHub though.)
*/
               House Nathan = new House(); 
               Nathan.MiceName = "Jerry";
                Console.WriteLine(Nathan.MiceName);
                Console.WriteLine(Nathan.Owner);

                Console.WriteLine("Enter your name:");
                string yourName = Console.ReadLine();
                Console.WriteLine("Your name is: " + yourName);

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();
                Console.WriteLine("So your full name is:" + yourName + (" ") + lastName);

            Collection collectionObj = new Collection();
            collectionObj.CollectionMain();
        }


        public static int Example()
    {   
return 10;
    }   
 }
}

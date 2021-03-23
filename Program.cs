using System;
using System.Collections.Generic;

namespace MADAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<Talkable> zoo = new List<Talkable>();

            //I'm keeping these on purpose...
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            //Because I want a list to browse.

            Talkable myTacoBowl = customTalkable();
            zoo.Add(myTacoBowl);

            for(int i = 0; i < zoo.Count; i++){
                printOut(zoo[i]);
            }

        }

        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.Name + " says=" + p.talk());

        }

        public static Talkable customTalkable()
        {
            string[] TalkableTypes = {"Teacher", "Dog", "Cat"};
            //string UserInput;
            int choice = 99;
            int n = 0;
            
            do{
                Console.WriteLine("What kind of animal do you want to make?");
                foreach(string type in TalkableTypes)
                {
                    Console.WriteLine(n + ": " + type);
                    n++;
                }
                choice = Int32.Parse(Console.ReadLine());
            }while(choice >= n);

            Console.WriteLine("What should the name be?");
            string Name = Console.ReadLine();

            switch (choice)
            {
                case 0:
                    int Age;
                    do{
                        Console.WriteLine("How old is the Teacher?");
                    }while(!Int32.TryParse(Console.ReadLine(), out Age));
                    Teacher newTeacher = new Teacher(Age, Name);
                    return newTeacher;
                case 1:
                    bool IsFriendly;
                    string response = "";
                    do{
                        Console.WriteLine("Is the dog freindly? Y/N");
                        response = Console.ReadLine().ToUpper();
                        Console.WriteLine("response: " + response);
                    }while(response != "Y" && response != "N");
                    if(response == "Y") IsFriendly = true;
                    else IsFriendly = false;
                    Dog newDog = new Dog(IsFriendly, Name);
                    return newDog;
                case 2:
                    int MiceKilled;
                    do{
                        Console.WriteLine("How many mice has the cat killed?");
                    }while(!Int32.TryParse(Console.ReadLine(), out MiceKilled));
                    Cat newCat = new Cat(MiceKilled, Name);
                    return newCat;
                default:
                    Dog nullDog = new Dog(false, "Null");
                    return nullDog;
            }

        }
    }
}

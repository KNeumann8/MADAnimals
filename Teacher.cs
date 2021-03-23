namespace MADAnimals
{

    class Teacher : Person, Talkable
    {

        public int Age {get;set;}

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public string talk()
        {
            return "Don't forget to do the assigned reading!";
        }

    }

}
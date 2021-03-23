namespace MADAnimals
{

    class Cat : Pet, Talkable
    {
        public int MiceKilled {get;set;}

        public Cat(int miceKilled, string name) : base(name)
        {
            MiceKilled = miceKilled;
        }

        public void addMouse()
        {
            MiceKilled++;
        }

        public string talk()
        {
            return "Meow";
        }

        override
        public string ToString()
        {
            return "Cat: " + "Name=" + Name + " MiceKilled=" + MiceKilled;
        }
    }

}
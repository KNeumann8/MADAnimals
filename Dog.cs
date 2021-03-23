namespace MADAnimals
{

    class Dog : Pet, Talkable
    {
        public bool IsFriendly {get;set;}

        public Dog(bool isFriendly, string name) : base(name)
        {
            IsFriendly = isFriendly;
        }

        public string talk()
        {
            return "Bark";
        }

        override
        public string ToString()
        {
            return "Dog: " + "Name=" + Name + " IsFriendly=" + IsFriendly;
        }
    }

}
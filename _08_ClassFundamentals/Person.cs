using static System.Console;

namespace _08_ClassFundamentals
{
    public class Person
    {
        // Fields
        private string Name;
        private int Age;
        private float Height;
        private byte Weight;


        // Constructor
        public Person(string Name, int Age, float Height, byte Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;
        }


        // Methods with different access modifiers

        // public: can be accessed from anywhere
        public void Walk()
        {
            WriteLine($"{Name} is walking.");
        }

        // protected: can be accessed within the class and by derived class instances
        protected void Talk()
        {
            WriteLine($"{Name} is talking. His height is {Height} cm.");
        }

        // private: can only be accessed within the class
        private void Sleep()
        {
            WriteLine($"{Name} is sleeping.");
        }

        // internal: can be accessed within the same assembly
        void Eat()
        {
            WriteLine($"{Name} is eating. Having weight of {Weight} kg.");
        }



        public void DoAllActions() 
        {
            Talk();
            Eat();
            Sleep();
        }
    }
}
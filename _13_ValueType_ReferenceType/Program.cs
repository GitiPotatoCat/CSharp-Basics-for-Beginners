using System;

namespace _13_ValueType_ReferenceType 
{
    public class Program 
    {
        static void Main() 
        {
            Console.WriteLine("---Value Type---");
            ValueTypoExample();
            Console.WriteLine("---Reference Type---");
            ReferenceTypoExample();
        }


        protected static void ValueTypoExample() 
        {
            int a = 10;
            int b = a;      // Copies the value of 'a' into 'b'

            b = 20;     // This change will not affect variable 'a'

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }


        /*
            In C#, reference typos are:
                1. class
                2. interface
                3. delegate
                4. object
                5. string
                6. array
        */
        protected static void ReferenceTypoExample() 
        {
            // ========== Class Example =========
            Person p1 = new Person();
            p1.Name = "Jyotiraditya";

            Person p2 = new Person();
            p2.Name = "Subham";

            Console.WriteLine("Before Reference type");
            Console.WriteLine("p1: {0}\np2: {1}", p1.Name, p2.Name);

            /*
                Due to reference type, if it any changes in p2, will affect p1
            */
            p2 = p1;

            p2.Name = "Soumyadip";

            Console.WriteLine("After Reference type");
            Console.WriteLine("p1: {0}\np2: {1}", p1.Name, p2.Name);


            // ========== Interface Example ==========
            ILanguage lang1 = new CSharp();
            ILanguage lang2 = new TScript();

            Console.WriteLine("\nInterface Example:");
            lang1.Programming();
            lang2.Programming();


            lang2 = lang1;

            lang2.LanguageName = "C# 14";

            Console.WriteLine("\nAfter modifying lang2.LanguageName: ");
            lang1.Programming();    // Output: It is C# 14 programming language
            lang2.Programming();    // Output: It is C# 14 programming language
        }
    }


    class Person 
    {
        public string? Name;
    }

    interface ILanguage
    {
        string? LanguageName { get; set; }
        void Programming();
    }

    class CSharp : ILanguage {
        public string? LanguageName { get; set; } = "C#";

        public void Programming() {
            Console.WriteLine("It is {0} programming language", LanguageName);
        }
    }

    class TScript : ILanguage {
        public string? LanguageName { get; set; } = "TypeScript";

        public void Programming() {
            Console.WriteLine("It is {0} programming language", LanguageName);
        }
    }
}
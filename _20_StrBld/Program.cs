using System;
using System.Text;  // StringBuilder class is found in the System.Text namespace.


namespace _20_StrBld 
{
    class Program 
    {
        static void Main() 
        {
            StringBuilder sb = new StringBuilder("Namaste, Devs are back!");
            sb.Append(" Yeh toh badiya din hain!");
            Console.WriteLine(sb);

            int MyInt = 25;
            StringBuilder sb1 = new StringBuilder("Total price is: ");
            sb1.AppendFormat("{0:C} ", MyInt);
            Console.WriteLine(sb1);


            // Insert method
            StringBuilder sbInsert = new StringBuilder("ABCDEFGH");
            sbInsert.Insert(6, "12345678 ");
            Console.WriteLine(sbInsert);

            // Remove method
            StringBuilder sbRemove = new StringBuilder("Halo Ulagam");
            sbRemove.Remove(4,7);   // 4 -> Index position; 7 -> Total characters count from last index;
            // Also can achieve this using `sbRemove.Remove(4, sbRemove.Length - 4);` that means remove from index 4 to end
            Console.WriteLine(sbRemove);

            // Replace method
            StringBuilder sbReplace = new StringBuilder("Vanakkam Ulagam!");
            sbReplace.Replace('!', '.');
            Console.WriteLine(sbReplace);



            // Converting a StringBuilder Object to a String
            StringBuilder sbObj = new StringBuilder();
            bool flag = true;
            string[] spellings = { "recieve", "receeve", "receive" };
            sbObj.AppendFormat("Which of the following spellings is {0}: ", flag);
            sbObj.AppendLine();
            
            for (int i = 0; i <= spellings.GetUpperBound(0); i++) {
                sbObj.AppendFormat("\t {0}. {1}", i, spellings[i]);
                sbObj.AppendLine();
            }
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
        }
    }
}
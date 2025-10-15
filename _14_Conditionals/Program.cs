using static System.Console;

namespace _14_Conditionals 
{
    class Program 
    {
        static void Main() 
        {
            var season = Season.Autumn;

            switch(season) {
                case Season.Autumn:
                    WriteLine("It is autumn.");
                    break;

                case Season.Summer:
                    WriteLine("It is summer.");
                    break;

                default:
                    WriteLine("default case");
                    break;
            }
        }
    }
}
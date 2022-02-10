using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tanner";
            int age = 28;
            char lastInitial = 'S';
            bool engaged = true;
            double monthAndDayBorn = 11.23;
            decimal randomDecimal = 1234.567m;
            Console.WriteLine($"My  name is {name}, I am {age} years old " +
                $"my last name's first initial is {lastInitial} Am I engaged? " +
                $"(True for yes False for no) {engaged}. What day and month was I born? " +
                $" {monthAndDayBorn} a random decimal I made up is {randomDecimal}.");

        }
    }
}

namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)

        {
            Add(2, 4);
            Multiply(10, 2);
            dayAttheBeach();
        }

        public static void dayAttheBeach()
        {



            //Exercise 1 _______


            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();


            Console.WriteLine($"Hi, {userName}, What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} I like that color too!, What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Cute! What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Cool! {userName}! Here are your answers");

            Console.WriteLine("________________________");


            Console.WriteLine("Name: {userName}");
            Console.WriteLine($"Favorite color): {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine($"Today,{userName} was at the beach, but the ocean was {color}. While {userName} was swimming, they saw a {animal} swimming too! The {animal} asked {userName} if the'd like to swim together listening to {band}. {userName} said, sure! And off the swam together.");


            //Exercise 2 ______

        }

        public static int Add(int num1, int num2)

        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }


        public static int Multiply(int num1, int num2)
        {


            int result = num1 * num2;
            Console.WriteLine(result);
            return result;

        }

    }

}




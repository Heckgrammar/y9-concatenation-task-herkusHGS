namespace Y9ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter surname: ");
            string Surname = Console.ReadLine();
            Console.Write("Enter age: ");
            string age1 = Console.ReadLine();
            int age = Convert.ToInt32(age1);
            Console.WriteLine("Hello, " + FirstName + " " + Surname + ", you are " + age + " years old");
            // add two more variables for the users last name and their age
            // take these inputs into the program
            // use the test data Bob, Smith, 14
            // ammend this code to output in one command
            // Hello Bob Smith you are 14 years old
            // save and commit your program
            // add evidence of the test input and your own input running the program
        }
    }
}

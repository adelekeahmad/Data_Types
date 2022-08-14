// See https://aka.ms/new-console-template for more information

//Data types
namespace Data_Types;
class Program
{
    static void Main(String[] args)
    { 
    Console.WriteLine("Now we are going through data types");
        string schoolName = "G-Land Computing Academy";
        //only takes up a single character
        char grade = 'A';
        char currency = '$';
        //whole numbers, you don't need any quotation marks here
        int age = 20;
        //for decimal numbers, we have 3 diferent types of data types that represent them
        float weight = 30.0f;
        double height = 20.68;
        decimal price = 20;
        bool isBoy = true;
        Console.WriteLine("I'm a student of " + schoolName.ToUpper());
        Console.WriteLine("Doctor told me that I weight " + weight + "kg");
        Console.WriteLine("and that my height is " + height + "cm");  
        Console.WriteLine("So, he prescribed a drug that is worth " + currency + price);
        int length = schoolName.Length;
        Console.WriteLine("the length of the school name is " + length);
        Console.WriteLine("As such, the school name is expected to return a " + schoolName.Contains("Computing") + " value");
        Console.WriteLine("now we want to print out the first letter of the school name which is letter " + schoolName[0]);
        Console.WriteLine("Now I want to print out a character from my school name at index number 7 which is " + schoolName.Substring(7, 9));
        Console.WriteLine("now let's talk abouth math method = " + Math.Sqrt(144));
        Console.ReadLine();
    }

}


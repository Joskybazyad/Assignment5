using System;

class Program
{
      enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }
    static void Main()
    {
        #region Q1:Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
        //1-When a parameter is passed by value a copy of the actual data is made
        //Changes made to the parameter inside the method do not affect the original data outside the method.
        //2-When a parameter is passed by reference a reference to the actual data is passed
        //This means that changes made to the parameter inside the method will affect the original data outside the method
        //static void PassByValue(int num)
        //{
        //    num += 10;
        //    Console.WriteLine("Inside PassByValue: " + num);
        //}

        //static void PassByReference(ref int num)
        //{
        //    num += 10;
        //    Console.WriteLine("Inside PassByReference: " + num);
        //}
        //    int value = 20;

        //    Console.WriteLine("Before PassByValue: " + value);
        //    PassByValue(value);
        //    Console.WriteLine("After PassByValue: " + value);

        //    Console.WriteLine("\nBefore PassByReference: " + value);
        //    PassByReference(ref value);
        //    Console.WriteLine("After PassByReference: " + value);
        #endregion
        #region Q2:Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());
        //    int result = SumOfDigits(number);
        //    Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
        #endregion
        #region Q3:Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //bool result = IsPrime(number);
        //Console.WriteLine($"Is the number {number} prime? {result}");
        #endregion
        #region Q4:Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //static void MinMaxArray(int[] array, out int min, out int max)
        //{
        //    min = array[0];
        //    max = array[0];
        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        //int[] numbers = { 5, 8, 1, 3, 10, 2 };
        //MinMaxArray(numbers, out int min, out int max);
        //Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        #endregion
        #region Q5:Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //int result = Factorial(number);
        //Console.WriteLine($"The factorial of {number} is: {result}");
        #endregion
        #region Q6:Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //static void Calculate(int a, int b, out int sum, out int diff)
        //{
        //    sum = a + b;
        //    diff = a - b;
        //}
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());
        //Calculate(num1, num2, out int sum, out int diff);
        //Console.WriteLine($"Sum: {sum}, Difference: {diff}");
        #endregion
        #region Q7:Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        //static string ChangeChar(string str, int position, char newChar)
        //{
        //    char[] charArray = str.ToCharArray();
        //    charArray[position] = newChar;
        //    return new string(charArray);
        //}
        //Console.Write("Enter a string: ");
        //string input = Console.ReadLine();
        //Console.Write("Enter position to modify (0-based): ");
        //int position = int.Parse(Console.ReadLine());
        //Console.Write("Enter new character: ");
        //char newChar = Console.ReadKey().KeyChar;
        //Console.WriteLine();
        //string result = ChangeChar(input, position, newChar);
        //Console.WriteLine($"Modified string: {result}");
        #endregion
        #region Q8:Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
        //foreach (var day in Enum.GetValues(typeof(WeekDays)))
        //{
        //    Console.WriteLine(day);
        //}
        #endregion
        #region Q9:Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

        //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        //string input = Console.ReadLine();

        //if (Enum.TryParse(input, true, out Season season))
        //{
        //    switch (season)
        //    {
        //        case Season.Spring:
        //            Console.WriteLine("March to May");
        //            break;
        //        case Season.Summer:
        //            Console.WriteLine("June to August");
        //            break;
        //        case Season.Autumn:
        //            Console.WriteLine("September to November");
        //            break;
        //        case Season.Winter:
        //            Console.WriteLine("December to February");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid input.");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input.");
        //}
        #endregion
        #region Q10:Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        //Permissions userPermissions = Permissions.Read | Permissions.Write;
        //Console.WriteLine("Current Permissions: " + userPermissions);
        //Console.WriteLine("Does user have Write permission? " + userPermissions.HasFlag(Permissions.Write));
        //userPermissions |= Permissions.Execute;
        //Console.WriteLine("Updated Permissions: " + userPermissions);
        //userPermissions &= ~Permissions.Write;
        //Console.WriteLine("Updated Permissions: " + userPermissions);
        #endregion
        #region Q11:Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //Console.WriteLine("Enter a color:");
        //string input = Console.ReadLine();

        //if (Enum.TryParse(input, true, out Colors color))
        //{
        //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
        //    {
        //        Console.WriteLine($"{color} is a primary color.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{color} is not a primary color.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid color.");
        //}

        #endregion
    }
}
using System.Reflection;

namespace Demo
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
    };

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    public enum Permissions
    {
        None = 0,
        Read = 1,    
        Write = 2,   
        Delete = 4,  
        Execute = 8  
    }


    internal class Program
    {

        private static void Swap(int a , int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static int Sum(string a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] - '0';
            }
            return sum;
        }

        private static bool IsPrime(int a)
        {
            if (a <= 1)
                return false;

            for(int i = 2; i < Math.Sqrt(a); i++)

                if( a % i == 0 )
                    return false;

            return true;
        }

        private static void MinMaxArray( int[] arr , out int min , out int max )
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
        }

        private static long factorial(int fact)
        {

            if( fact == 0 )
                return 1;

            if (fact < 0)
                return -1;

            long result = 1;
            int count = 0;
            for (int i = 1; i <= fact; i++)
            {
                result *= fact - count ;
                count++;
            }
            return result;
        }

        private static (float, float) SumAndDiff(float num1, float num2, float num3, float num4)
        {
            float sum = num1 + num2 + num3 + num4;
            float sub = (num1 + num2) - (num3 + num4);
            return (sum, sub);
        }

        private static string ChangeChar( string str, int idx, char letter)
        {
            char[] chars = str.ToCharArray();
            chars[idx] = letter;
            str = new string(chars);
            //str = string.Concat(chars);
            return str;
        }

        private static void ReferenceTypeByValue(int[] a)
        {
            a[0] = 2;
            a = new int[] { 3, 2, 1 };
        }

        private static void ReferenceTypeByReference(ref int[] a)
        {
            a[0] = 2;
            a = new int[] { 3, 2, 1 };
        }

        ////
        static Permissions AddPermission(Permissions currentPermissions, Permissions permissionToAdd)
        {
            return currentPermissions | permissionToAdd;
        }

        static Permissions RemovePermission(Permissions currentPermissions, Permissions permissionToRemove)
        {
            return currentPermissions & ~permissionToRemove;
        }

        static bool CheckPermission(Permissions currentPermissions, Permissions permissionToCheck)
        {
            return (currentPermissions & permissionToCheck) == permissionToCheck;
        }

        static void Main(string[] args)
        {
            #region Part One

            #region 1.	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //int firstNum = 11;
            //int secondNum = 22;

            #region Call by value
            //Swap(firstNum, secondNum);
            //Console.WriteLine($"First Number : {firstNum} , Second Number : {secondNum}"); //First Number : 11 , Second Number : 22

            #endregion

            #region Call by reference
            //Swap(ref firstNum, ref secondNum);
            //Console.WriteLine($"First Number : {firstNum} , Second Number : {secondNum}"); //First Number : 22 , Second Number : 11

            #endregion

            /*
              Call by Value: 
              the copy of the variable is passed to the called function
              then copied into the parameter of the function
              but not allow to change the actual variables
              because the memory location of parameters and arguments are different
             */

            /*
             Call by Reference:
             variable’s address is passed to the called function
             allow to change the actual variables
             parameters and arguments  point to the same memory address  
             */
            #endregion

            #region 2.	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //string number = Console.ReadLine();
            //int result = Sum(number);
            //Console.WriteLine(result);

            #endregion

            #region 3.	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //int.TryParse(Console.ReadLine(), out int num);
            //bool checkIsPrime = IsPrime(num);
            //Console.WriteLine(checkIsPrime);

            #endregion

            #region 4.	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int [] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //MinMaxArray(arr, out int min , out int max );
            //Console.WriteLine($"Min: {min}, Max: {max}");

            #endregion

            #region 5.	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int.TryParse(Console.ReadLine(), out int fact );
            //long result = factorial(fact);
            //Console.WriteLine(result);
            #endregion

            #region 6.	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3 };

            //ReferenceTypeByValue(arr1);
            ////after - passing by value
            //Console.WriteLine(string.Join(" ", arr1));

            //ReferenceTypeByReference(ref arr2);
            ////after - passing by Reference
            //Console.WriteLine(string.Join(" ", arr2));

            /*
             passing by value:
             -a copy of the reference is passed,
             -changing array element will change original array cause 
             the reference types points to the same memory addresss
             but:
             -reassigning array to a new array does not change original one
             */

            /*
             passing by reference:
             -allows acual reference to be passed,
             -changing array element will change original array cause 
             -reassigning array to a new array does not change original one
             */

            #endregion

            #region 7.	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //float.TryParse(Console.ReadLine(), out float num1);
            //float.TryParse(Console.ReadLine(), out float num2);
            //float.TryParse(Console.ReadLine(), out float num3);
            //float.TryParse(Console.ReadLine(), out float num4);

            //(float sum , float diff) = SumAndDiff(num1, num2, num3, num4);
            //Console.WriteLine( $"sum: {sum} , difference: {diff}" );

            #endregion

            #region 8.	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter String: ");
            //string word = Console.ReadLine();
            //Console.Write("index: ");
            //int.TryParse(Console.ReadLine(), out int idx);
            //Console.Write("New Letter: ");
            //char.TryParse(Console.ReadLine(), out char letter);

            //string result = ChangeChar(word, idx, letter);
            //Console.WriteLine(result);
            #endregion


            #endregion

            #region Part Two

            #region 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays i in Enum.GetValues(typeof(WeekDays)))
            //    Console.WriteLine(i);
            #endregion

            #region 2-	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Enum.TryParse(Console.ReadLine(), out Season season);

            //string range = season switch
            //{
            //    Season.Spring => "Mar to May",
            //    Season.Summer => "Jun to Aug",
            //    Season.Autumn => "Sep to Nov",
            //    Season.Winter => "Dec to Feb",
            //    _ => "Invalid"
            //};

            //Console.WriteLine(range);
            #endregion

            #region 4-     Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            Permissions empPermission = Permissions.None;

            empPermission = AddPermission(empPermission, Permissions.Read);
            empPermission = AddPermission(empPermission, Permissions.Write);
            Console.WriteLine(CheckPermission(empPermission, Permissions.Read));
            Console.WriteLine(CheckPermission(empPermission, Permissions.Execute));
            empPermission = RemovePermission(empPermission, Permissions.Read);
            Console.WriteLine($"Read Permission? {CheckPermission(empPermission, Permissions.Read)}");
            Console.WriteLine($"existed Permissions: {empPermission}");
            #endregion

            #region 5- Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //if ( Enum.TryParse(Console.ReadLine(), true, out Colors c) )
            //{
            //    Console.WriteLine($"{c} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"not a primary color");
            //}
            #endregion

            #endregion

        }
    }
}

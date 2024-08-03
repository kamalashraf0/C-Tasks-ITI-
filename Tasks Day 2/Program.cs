namespace Tasks_Day_2
{
    class Program
    {

        static void Main()
        {
            #region Task #1
            ///1- array of 10 intergers and get min and max value   |5|4|2|-1|-33|55|66|77|88|100|


            //int[] arr = new int[3];

            //Console.WriteLine("Enter the Elements");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.Write($"Array : ");


            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + "\t");


            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine($"\n\nMax Value = {max} Min Value = {min}");


            #endregion

            #region Task #2
            ///2- array of 10 integers and sort it ascending without any built in function



            //int[] arr = new int[4];

            //Console.WriteLine("Enter the Elements");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i; j < arr.Length; j++)
            //    {

            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}


            //Console.WriteLine();
            //Console.Write("AscArray: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}  ");
            //}

            #endregion

            #region Task #3
            ///3- array of 10 integers and search number and get index



            //int[] arr = new int[3];

            //Console.WriteLine("Enter the Elements");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter the element to search for: ");
            //int target = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == target)
            //    {
            //        Console.WriteLine($"Element {target} found at index {i}.");
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine($"Element {target} not found in the array.");
            //}

            #endregion

            #region Task #4 

            //int[,] twodarr = new int[3, 4];

            //for (int i = 0; i < twodarr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twodarr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter the Elemets of {i},{j}");
            //        twodarr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////for (int i = 0; i < twodarr.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < twodarr.GetLength(1); j++)
            ////    {
            //           Console.Write($"{arr[i, j]} \t");
            ////    }
            ////    Console.WriteLine();
            ////}

            //foreach (var item in twodarr)
            //{
            //    Console.Write($"{item} \t");
            //}

            #endregion

            #region Task #5 

            //Console.WriteLine("plz enter your year from 1980->2023");
            //int year = int.Parse(Console.ReadLine());
            //while (year < 1980 || year > 2023)
            //{
            //    Console.WriteLine("plz enter your year from 1980->2023");
            //    year = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("plz enter your month");
            //int month = int.Parse(Console.ReadLine());
            //while (month < 1 || month > 12)
            //{
            //    Console.WriteLine("plz enter your month from 1 to 12");
            //    month = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("plz enter your day");
            //int day = int.Parse(Console.ReadLine());



            //while (day < 1 || day > 31)
            //{
            //    Console.WriteLine("plz enter your day from 1 to 31 ");
            //    day = int.Parse(Console.ReadLine());
            //}

            //while ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
            //{
            //    Console.WriteLine($"Month {month} only has 30 days.");
            //    day = int.Parse(Console.ReadLine());
            //}
            //bool leapYear = DateTime.IsLeapYear(year);

            //while (month == 2 && ((leapYear && day > 29) || (!leapYear && day > 28)))
            //{
            //    if (leapYear && day > 29)
            //    {
            //        Console.WriteLine("February in a leap year only has 29 days. Please enter a valid day:");
            //    }
            //    else if (!leapYear && day > 28)
            //    {
            //        Console.WriteLine("February only has 28 days. Please enter a valid day:");
            //    }

            //    day = int.Parse(Console.ReadLine());
            //}

            //int currentday = DateTime.Now.Day;
            //int currentmonth = DateTime.Now.Month;
            //int currentyear = DateTime.Now.Year;

            //int myyear = currentyear - year;
            //int myymonth = currentmonth - month;
            //int myyday = currentday - day;

            //if (myyday < 0)
            //{
            //    myymonth--;
            //    myyday += DateTime.DaysInMonth(currentyear, currentmonth - 1);
            //}

            //if (myymonth < 0)
            //{
            //    myyear--;
            //    myymonth += 12;
            //}

            //Console.WriteLine($"you're {myyear} year  {myymonth} months and {myyday} days");


            #endregion

            #region Task #6 

            //int first;
            //int second;
            //char ch;
            //int result = 0;
            //do
            //{

            //    Console.Write("Enter first Number : ");
            //    first = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Second Number: ");
            //    second = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Operator : ");
            //    char op = char.Parse(Console.ReadLine());

            //    switch (op)
            //    {
            //        case '+':
            //            result = first + second;
            //            break;
            //        case '-':
            //            result = first - second;
            //            break;
            //        case '/':
            //            result = first / second;
            //            break;
            //        case '*':
            //            result = first * second;
            //            break;

            //        default:
            //            Console.WriteLine("invalid op");
            //            break;
            //    }

            //    Console.WriteLine($"{first} {op} {second} = {result}");

            //    Console.WriteLine("Continue y or n");
            //    ch = char.Parse(Console.ReadLine());
            //} while (ch == 'y');
            //Console.WriteLine("Thank you");

            #endregion

            #region Bouns

            //Employees[] employees = new Employees[10];
            ////new is MANDATORY
            /////new +array=allocation + initialization
            //int index;
            //char flag;

            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Choose index 0->9");
            //        index = int.Parse(Console.ReadLine());


            //    } while (index < 0 || index > 9 || employees[index].SSN != 0);


            //    Console.WriteLine("Enter SSN:");
            //    int ssn = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < employees.Length; i++)
            //    {
            //        while (employees[i].SSN != 0 && employees[i].SSN == ssn)
            //        {
            //            Console.WriteLine("SSN already exists. Enter a unique SSN.");
            //            ssn = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    employees[index].SSN = ssn;
            //    Console.WriteLine("Enter name");
            //    employees[index].Name = Console.ReadLine();
            //    Console.WriteLine("Enter age");
            //    employees[index].Age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter salary");
            //    employees[index].Salary = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("Continue y or n");
            //    flag = char.Parse(Console.ReadLine());
            //} while (flag == 'y');

            ////print entered employees
            //Console.WriteLine("Entered Employees");
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    if (employees[i].SSN != 0)
            //    {


            //        Console.WriteLine($"{employees[i].SSN}  {employees[i].Name}  {employees[i].Age}  {employees[i].Salary}");
            //    }
            //}
            #endregion

            Console.ReadKey();
        }

        struct Employees
        {
            public int SSN;
            public string Name;
            public int Age;
            public decimal Salary;
        }
    }
}

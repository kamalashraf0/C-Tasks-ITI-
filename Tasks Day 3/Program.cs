namespace Tasks_Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Complex 
            while (true)
            {
                Complex c1 = new Complex();
                Complex c2 = new Complex();

                while (true)
                {
                    Console.Write("Enter real : ");
                    c1.SetReal(int.Parse(Console.ReadLine()));
                    Console.Write("Enter img : ");
                    c1.SetImg(int.Parse(Console.ReadLine()));
                    Console.WriteLine(c1.Print());
                }
                c1.Add(c2);
                Console.Write($" => {c1.Print()} \n ");
            }
            #endregion


            #region Array of 3 Employees

            //Employee[] emp = new Employee[3];

            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine($"Employee #{i + 1}");
            //    emp[i] = new Employee();   
            //    Console.Write("Enter Your ID : ");
            //    emp[i].SetID(int.Parse(Console.ReadLine()));
            //    Console.Write("Enter Your Name : ");
            //    emp[i].SetName(Console.ReadLine());
            //    Console.Write("Enter Your Age : ");
            //    emp[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.Write("Enter Your Salary : ");
            //    emp[i].SetSalary(decimal.Parse(Console.ReadLine()));




            //}

            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine(emp[i].Print());
            //}



            #endregion


            //Console.ReadKey();
        }
    }
}

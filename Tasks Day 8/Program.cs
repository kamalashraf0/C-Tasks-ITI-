namespace Tasks_Day_8
{
    public partial class Program
    {

        static void Main(string[] args)
        {

            Employee[] employee = new Employee[1];
            //{
            //    new Employee  {ID = int.Parse(Console.ReadLine()), SecurityLevel = SecurityLevel.guest ,Salary = 12000 ,Gender = Gender.female , HireDate = new HireDate(1,5,2023)} ,
            //    new Employee  {ID = 2, SecurityLevel = SecurityLevel.DBA ,Salary = 15000 ,Gender = Gender.male, HireDate = new HireDate(12,10,2022)} ,
            //    new Employee  {ID = 3, SecurityLevel = SecurityLevel.Secertary ,Salary = 30000 ,Gender = Gender.female , HireDate = new HireDate(1,5,2022)} ,



            //};

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("Enter The Employee info: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("SecurityLevel (DBA, Guest, Secretary, Developer): ");
                SecurityLevel securityLevel;
                while (!Enum.TryParse(Console.ReadLine(), true, out securityLevel) || !Enum.IsDefined(typeof(SecurityLevel), securityLevel))
                {
                    Console.WriteLine("Invalid SecurityLevel. Please enter DBA, Guest, Secretary, or Developer: ");
                }

                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Gender (Male, Female): ");
                Gender gender;
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) || !Enum.IsDefined(typeof(Gender), gender))
                {
                    Console.WriteLine("Invalid Gender. Please enter Male or Female: ");
                }

                Console.WriteLine("Hire date:");
                Console.WriteLine("\tDay: ");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("\tMonth: ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("\tYear: ");
                int year = int.Parse(Console.ReadLine());

                HireDate hireDate = new HireDate(day, month, year);

                employee[i] = new Employee(id, securityLevel, salary, hireDate, gender);
            }

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i]);
            }
            Console.ReadKey();
        }


    }


}

namespace Tasks_Day_8
{

    public struct Employee
    {
        public int ID { get; set; }

        public SecurityLevel SecurityLevel { get; set; }

        public decimal Salary { get; set; }

        public HireDate HireDate { get; set; }

        public Gender Gender { get; set; }


        public Employee(int id, SecurityLevel securityLevel, decimal salary, HireDate hireDate, Gender gender)
        {
            ID = id;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{ID} : {SecurityLevel} : {Salary:C} :  {HireDate} : {Gender}";
        }

    }

    public enum SecurityLevel
    {
        guest,
        Developer,
        Secertary,
        DBA
    }

    public enum Gender
    {
        male,
        female
    }
}



